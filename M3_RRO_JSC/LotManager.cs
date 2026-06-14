using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using static M3_RRO_JSC.DBManager;
using System.Diagnostics.Eventing.Reader;
using Mysqlx.Crud;

namespace M3_RRO_JSC
{
    internal class LotManager
    {
        private const string EtatEnAttente = "En attente";
        private const string EtatEnCours = "En cours";
        private const string EtatTermine = "Terminé";
        private const string EtatErreur = "Erreur";

        private const int ValeurInactive = 0;
        private const long IdInvalide = -1;


        /// <summary>
        /// Récupère tous les lots enregistrés dans la base de données avec leur recette associée et leur état.
        /// </summary>
        /// <returns></returns>
        public static List<Lot> GetAllLots()
        {
            List<Lot> lots = new List<Lot>();

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {

                    cmd.CommandText = "SELECT l.Id_Lot, l.LOT_Nom, l.LOT_Quantite, l.LOT_DateHeureCreation," +
                                       "r.REC_Nom, e.ETA_Libelle " +
                                       "FROM lot l " +
                                       "INNER JOIN recette r ON l.Id_Recette = r.Id_Recette " +
                                       "INNER JOIN etat e ON l.Id_Etat = e.Id_Etat " +
                                       "ORDER BY l.LOT_DateHeureCreation DESC;";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot lot = new Lot();

                            lot.IdLot = reader.GetInt32("Id_Lot");
                            lot.NomLot = reader.GetString("LOT_Nom");
                            lot.QuantitePieces = reader.GetInt32("LOT_Quantite");
                            lot.DateCreation = reader.GetDateTime("LOT_DateHeureCreation");
                            lot.Etat = reader.GetString("ETA_Libelle");

                            lot.RecetteAssociee = new Recette();
                            lot.RecetteAssociee.NomRecette = reader.GetString("REC_Nom");

                            lots.Add(lot);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur chargement lots ; " + ex.Message);
            }
            return lots;
        }


        /// <summary>
        /// Crée un nouveau lot dans la base de données avec l'état initial "En attente".
        /// </summary>
        /// <param name="lot">Lot à enregistrer dans la base de données</param>
        /// <returns>Identifiant du lot créé, ou -1 si la création a échoué</returns>
        public static long CreateLot ( Lot lot)
        {
            long idLot = IdInvalide;

            try
            {
                if (lot.RecetteAssociee != null)
                {


                    using (MySqlCommand cmd = GetConnection().CreateCommand())
                    {
                        cmd.CommandText = "INSERT INTO lot " +
                                          "(LOT_Nom, LOT_Quantite, LOT_DateHeureCreation, Id_Etat, Id_Recette) " +
                                          "VALUES (@nomLot, @quantite, @dateCreation, " +
                                          "(SELECT Id_Etat FROM etat WHERE ETA_Libelle = @etat), @idRecette);";

                        cmd.Parameters.AddWithValue("@nomLot", lot.NomLot);
                        cmd.Parameters.AddWithValue("@quantite", lot.QuantitePieces);
                        cmd.Parameters.AddWithValue("@dateCreation", DateTime.Now);
                        cmd.Parameters.AddWithValue("@etat", EtatEnAttente);
                        cmd.Parameters.AddWithValue("@idRecette", lot.RecetteAssociee.IdRecette);

                        cmd.ExecuteNonQuery();

                        idLot = cmd.LastInsertedId;
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une recette pour le lot.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur création lot : " + ex.Message);
            }
            return idLot;
        }


        /// <summary>
        /// Met à jour les informations d'un lot existant dans la base de données.
        /// </summary>
        /// <param name="lot">Lot contenant les nouvelles informations à enregistrer.</param>
        public static void UpdateLot ( Lot lot)
        {
            try
            {
                if ( lot.RecetteAssociee != null)
                {
                    using (MySqlCommand cmd = GetConnection().CreateCommand())
                    {
                        cmd.CommandText = "UPDATE lot SET " +
                                          "LOT_Nom = @nomLot, " +
                                          "LOT_Quantite = @quantite, " +
                                          "Id_Recette = @idRecette " +
                                          "WHERE Id_Lot = @idLot;";

                        cmd.Parameters.AddWithValue("@nomLot", lot.NomLot);
                        cmd.Parameters.AddWithValue("@quantite", lot.QuantitePieces);
                        cmd.Parameters.AddWithValue("@idRecette", lot.RecetteAssociee.IdRecette);
                        cmd.Parameters.AddWithValue("@idLot", lot.IdLot);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Veuillez sélectionner une recette pour ce lot.");
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erreur modification lot : " + ex.Message);
            }

        }


        /// <summary>
        /// Supprime un lot de la base de données si celui-ci est encore en attente.
        /// </summary>
        /// <param name="idLot">Identifiant du lot à supprimer.</param>
        public static void DeleteLot ( int idLot)
        {
            try
            {
                if (!LotBloque(idLot))
                {
                    using (MySqlCommand cmd = GetConnection().CreateCommand())
                    {
                        cmd.CommandText = "Delete FROM lot WHERE Id_Lot = @idLot;";

                        cmd.Parameters.AddWithValue("@idLot", idLot);

                        cmd.ExecuteNonQuery();

                    }
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer ce lot car il n'est plus en attente.");
                }

            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erreur suppression lot : " + ex.Message);
            }
        }


        /// <summary>
        /// Vérifie si un lot est bloqué, c'est-à-dire s'il n'est plus à l'état "En attente".
        /// </summary>
        /// <param name="idLot">Identifiant du lot à vérifier.</param>
        /// <returns>True si le lot est bloqué, sinon false.</returns>
        public static bool LotBloque( int idLot)
        {
            bool lotBloque = true;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) " +
                                       "FROM lot l " +
                                       "INNER JOIN etat e ON l.Id_Etat = e.Id_Etat " +
                                       "WHERE l.Id_Lot = @idLot " +
                                       "AND e.ETA_Libelle <> @etatAutorise;";

                    cmd.Parameters.AddWithValue("@idLot", idLot);
                    cmd.Parameters.AddWithValue("@etatAutorise", EtatEnAttente);

                    int nombreLotsBloquants = Convert.ToInt32(cmd.ExecuteScalar());

                    lotBloque = nombreLotsBloquants > ValeurInactive;
                                         
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur vérification état du lot : " + ex.Message);
                lotBloque = true;
            }
            return lotBloque;
        }



        /// <summary>
        /// Récupère les dix derniers lots créés dans la base de donnée, cette methode est utilisé pour afficher les lots dans le datagrid 
        /// de la page d'acceuil, elle sert uniquement a cela.
        /// </summary>
        /// <returns>Liste des dix derniers lots créés.</returns>
        public static List<Lot> GetDixDerniersLots()
        {
            List<Lot> lots = new List<Lot>();

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT l.Id_Lot, l.LOT_Nom, l.LOT_Quantite, l.LOT_DateHeureCreation, " +
                                      "r.REC_Nom, e.ETA_Libelle " +
                                      "FROM lot l " +
                                      "INNER JOIN recette r ON l.Id_Recette = r.Id_Recette " +
                                      "INNER JOIN etat e ON l.Id_Etat = e.Id_Etat " +
                                      "ORDER BY l.LOT_DateHeureCreation DESC " +
                                      "LIMIT 10;";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Lot lot = new Lot();

                            lot.IdLot = reader.GetInt32("Id_Lot");
                            lot.NomLot = reader.GetString("LOT_Nom");
                            lot.QuantitePieces = reader.GetInt32("LOT_Quantite");
                            lot.DateCreation = reader.GetDateTime("LOT_DateHeureCreation");
                            lot.Etat = reader.GetString("ETA_Libelle");

                            lot.RecetteAssociee = new Recette();
                            lot.RecetteAssociee.NomRecette = reader.GetString("REC_Nom");

                            lots.Add(lot);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur chargement des dix derniers lots : " + ex.Message);
            }

            return lots;
        }

    }
}
