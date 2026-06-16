// Fichier: RecetteManager.cs
// Description: Fournit les opérations CRUD et utilitaires liées aux recettes
// et opérations (création, lecture, modification, suppression, conversions
// de valeurs pour la base de données).
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static M3_RRO_JSC.DBManager;

namespace M3_RRO_JSC
{
    internal class RecetteManager
    {
        private const long IdInvalide = -1;
        private const int ValeurInactive = 0;
        private const int PremierNumeroOperation = 1;

        private const string Position12h = "12h";
        private const string Position3h = "3h";
        private const string Position6h = "6h";
        private const string Position9h = "9h";
        private const string TexteVide = "";


        /// <summary>
        /// Convertit le sens moteur saisi sous forme de texte en valeur booléenne.
        /// Le sens horaire correspond à true, les autres valeurs correspondent à false.
        /// </summary>
        /// <param name="sensTexte"> Sens moteur sous forme de texte </param>
        /// <returns> True si le sens est horaire, sinon false</returns>
        public static  bool ConvertirSensMoteur(string sensTexte)
        {
            bool sensMoteur = false;

            if (!string.IsNullOrWhiteSpace(sensTexte))
            {
                if(System.Enum.TryParse(sensTexte, out SensMoteur sens))
                {
                    sensMoteur = sens == SensMoteur.Horaire;
                }
            }
            return sensMoteur;
        }


        /// <summary>
        /// Convertit le sens moteur enregistré en base de données en texte affichable.
        /// La valeur true correspond au sens horaire, la valeur false au sens anti-horaire.
        /// </summary>
        /// <param name="sensValeur">Valeur booléenne du sens moteur enregistré en base </param>
        /// <returns>Le sens moteur sous forme de texte </returns>
        public static string ConvertirSensMoteurEnTexte(bool sensValeur)
        {
            string sensTexte = SensMoteur.AntiHoraire. ToString();

            if (sensValeur)
            {
                sensTexte = SensMoteur.Horaire.ToString();
            }

            return sensTexte;
            
        }


        /// <summary>
        /// Convertit le temps d'attente saisi sous forme de texte en nombre entier.
        /// Si le texte est vide ou invalide, une valeur inactive est retournée.
        /// </summary>
        /// <param name="tempsTexte">Temps d'attente sous forme de texte.</param>
        /// <returns></returns>
        public static int ConvertirTempsAttente(string tempsTexte)
        {
            int tempsAttente = ValeurInactive;

            if(!string.IsNullOrWhiteSpace(tempsTexte))
            {
                if (int.TryParse(tempsTexte, out int temps))
                {
                    tempsAttente = temps;
                }
               
            }
            return tempsAttente;
        }

        /// <summary>
        /// Convertit la position moteur saisie sous forme de texte en valeur numérique.
        /// Cette valeur numérique correspond à l'énumération PosMoteur utilisée dans la base de données.
        /// </summary>
        /// <param name="positionTexte">Position moteur sous forme numérique.</param>
        /// <returns>La position du moteur sous forme numérique </returns>
        public static int ConvertirPositionMoteur(string positionTexte)
        {
            int positionValeur = ValeurInactive;

            if (!string.IsNullOrWhiteSpace(positionTexte))
            {

                switch (positionTexte)
                {
                    case Position12h:
                        positionValeur = (int)PosMoteur.Midi;
                        break;

                    case Position3h:
                        positionValeur = (int)PosMoteur.TroisHeures;
                        break;

                    case Position6h:
                        positionValeur = (int)PosMoteur.SixHeures;
                        break;

                    case Position9h:
                        positionValeur = (int)PosMoteur.NeufHeures;
                        break;

                    default:
                        if (System.Enum.TryParse(positionTexte, out PosMoteur position))
                        {
                            positionValeur = (int)position;
                        }

                        break;
                }
            }
            return positionValeur;
        }


        /// <summary>
        /// Convertit la position moteur enregistrée en base de données en texte affichable.
        /// </summary>
        /// <param name="positionValeur"> Valeur numérique de la positon moteur enregistré en base </param>
        /// <returns>La position moteur sous forme de texte.</returns>
        public static string ConvertirPositionMoteurEnTexte( int positionValeur)
        {
            string positionTexte = TexteVide;

            switch ((PosMoteur)positionValeur)
            { 

                case PosMoteur.Midi:
                positionTexte = Position12h;
                    break;

                case PosMoteur.TroisHeures:
                positionTexte = Position3h;
                    break;

                case PosMoteur.SixHeures:
                positionTexte = Position6h;
                    break;

                case PosMoteur.NeufHeures:
                positionTexte = Position9h;
                    break;
            }
            return positionTexte;

        }





        /// <summary>
        /// <summary>
        /// Crée une nouvelle recette dans la table "recette" de la base de données.
        /// </summary>
        /// <param name="nomRecette">Nom de la recette à enregistrer.</param>
        /// <returns>Identifiant de la recette créée, ou -1 en cas d'échec.</returns>
        public static long CreateRecette(string nomRecette)
        {
            long idRecette = IdInvalide;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = " INSERT INTO recette (REC_Nom, REC_DateHeureCreation) VALUES (@nomRecette, @dateCreation);";

                    cmd.Parameters.AddWithValue("@nomRecette", nomRecette);
                    cmd.Parameters.AddWithValue("@dateCreation", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    idRecette = cmd.LastInsertedId;
                }
            } 

            catch(MySqlException ex)
            {
                MessageBox.Show("Erreur ajout recette : " + ex.Message);
            }

            return idRecette;
        }


        /// <summary>
        /// Crée une nouvelle ligne opération dans la table `operation` de la base de
        /// données. Convertit les valeurs lisibles en types attendus par la base.
        /// </summary>
        /// <param name="operation">Objet OperationRecette contenant les données à insérer.</param>
        /// <returns>Identifiant de l'opération créée, ou -1 en cas d'erreur.</returns>
        public static long CreateOperation(OperationRecette operation)
        {
            long idOperation = IdInvalide;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "INSERT INTO operation " +
                                      "(OPE_Nom, OPE_PositionMoteur, OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur) " +
                                      "VALUES (@nomOperation, @positionMoteur, @tempsAttente, @cycleVerin, @quittance, @sensMoteur);";

                    cmd.Parameters.AddWithValue("@nomOperation", operation.NomOperation);
                    cmd.Parameters.AddWithValue("@positionMoteur", ConvertirPositionMoteur(operation.Position));
                    cmd.Parameters.AddWithValue("@tempsAttente", ConvertirTempsAttente(operation.TempsAttente));
                    cmd.Parameters.AddWithValue("@cycleVerin", operation.CycleVerin);
                    cmd.Parameters.AddWithValue("@quittance", operation.Quittance);
                    cmd.Parameters.AddWithValue("@sensMoteur", ConvertirSensMoteur(operation.Sens));

                    cmd.ExecuteNonQuery();
                    idOperation = cmd.LastInsertedId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur CreateOperation :\n\n" + ex.ToString());
            }

            return idOperation;
        }
       

        /// <summary>
        /// Crée un lien entre une recette et une opération dans la table `contenir`.
        /// Cette table conserve l'ordre des opérations au sein d'une recette via CON_NoOperation.
        /// </summary>
        /// <param name="idRecette">Identifiant de la recette.</param>
        /// <param name="idOperation">Identifiant de l'opération.</param>
        /// <param name="numeroOperation">Position de l'opération dans la recette (1-based).</param>
        public static void AjouterOperationRecette( long idRecette, long idOperation, int numeroOperation)
        {
            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO contenir " +
                                      "(Id_Operation_est_contenu_dans, Id_Recette, CON_NoOperation) " +
                                      "VALUES (@idOperation, @idRecette, @numeroOperation);";

                    cmd.Parameters.AddWithValue("@idOperation", idOperation);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.Parameters.AddWithValue("@numeroOperation", numeroOperation);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur ajout lien recette-operation: " + ex.Message);
            }
                
           
        }



        /// <summary>
        /// Récupère toutes les recettes enregistrées dans la table `recette`.
        /// Chaque recette récupérée verra sa liste d'opérations chargée ensuite via GetOperationsByRecetteId.
        /// </summary>
        /// <returns>Liste de recettes (vide en cas d'erreur).</returns>
        public static List<Recette>GetAllRecette()

        {
            // Création d'une liste vide qui va contenir les recettes récuprées
            List<Recette> recettes = new List<Recette>();

            try
            {   
                // Création d'une comamnde SQL, connexion ouverte
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    // Requête SQL qui récupère toutes les recettes de la table recette
                    cmd.CommandText = "SELECT Id_Recette, Rec_Nom, REC_DateHeureCreation FROM recette;";

                    // Permet de lire plusieurs lignes retournées par la requête SELECT
                    using(MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        // Tant qu'il y a une ligne à lire dans le résultat 
                        while(reader.Read())
                        {
                            // Creation d'un objet recette à partir des données de la ligne actuelle 
                            Recette recette = new Recette();

                            recette.IdRecette = reader.GetInt32("Id_Recette");
                            recette.NomRecette = reader.GetString("Rec_Nom");
                            recette.DateCreation = reader.GetDateTime("Rec_DateHeureCreation");

                            // Ajout de la recette dans la liste 
                            recettes.Add(recette);

                        }
                    }

                }
                // Pour cahque recette récupère, on charge les opérations qui ui sont associées grâce a son identifiant IdRecette.
                foreach(Recette recette in recettes)
                {
                    recette.Operations = GetOperationsByRecetteId(recette.IdRecette);
                }

            }catch (MySqlException ex)
            {
                MessageBox.Show("Erreur chargement recettes : " + ex.Message);
            }

            // retourne la liste des recettes récupérées
            return recettes;
        }


        /// <summary>
        /// Récupère toutes les opérations associées à une recette données, les opérations sont retrouvées grâce à la table "Contenir".
        /// </summary>
        /// <param name="idRecette"> Identifiant de la recette dont on veur récupèrer les opérations </param>
        /// <returns> La liste des opérations liées à la recette,une  liste vide si aucune opération n'est trouvée ou si une erreur survient.</returns>
        public static List<OperationRecette> GetOperationsByRecetteId ( int idRecette)
        {
            List<OperationRecette> operations = new List<OperationRecette>();

            try
            {

                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT o.Id_Operation, o.OPE_Nom, o.OPE_PositionMoteur, o.OPE_TempsAttente, o.OPE_CycleVerin, o.OPE_Quittance, o.OPE_SensMoteur " +
                                      "FROM operation o " +
                                      "INNER JOIN contenir c ON o.Id_Operation = c.Id_Operation_est_contenu_dans " +
                                      "WHERE c.Id_Recette = @idRecette " +
                                      "ORDER BY c.CON_NoOperation;";

                    cmd.Parameters.AddWithValue("@idRecette", idRecette);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OperationRecette operation = new OperationRecette();

                            operation.IdOperation = reader.GetInt32("Id_Operation");
                            operation.NomOperation = reader.GetString("OPE_Nom");
                            operation.Position = ConvertirPositionMoteurEnTexte(reader.GetInt32("OPE_PositionMoteur"));
                            operation.TempsAttente = reader.GetInt32("OPE_TempsAttente").ToString();
                            operation.CycleVerin = reader.GetBoolean("OPE_CycleVerin");
                            operation.Quittance = reader.GetBoolean("OPE_Quittance");
                            operation.Sens = ConvertirSensMoteurEnTexte(reader.GetBoolean("OPE_SensMoteur"));

                            operations.Add(operation);

                        }
                    }
                }

            }catch(MySqlException ex)
            {
                MessageBox.Show("Erreur chargement operation : " + ex.Message);

            }

            return operations;
        }


        /// <summary>
        /// Supprime une recette de la base de donnée avec ses liens dans la table "Contenir", mais ne supprime pas les opréations.
        /// </summary>
        /// <param name="idRecette"> Identifiant de la recette a supprimer. </param>
        public static void DeleteRecette( int idRecette)
        {
            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM contenir WHERE Id_Recette = @idRecette;";
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery(); 
                }

                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM recette WHERE Id_Recette = @idRecette;";
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.ExecuteNonQuery();
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show("Erreur suppresion recette : " + ex.Message);
            }
        }

        /// <summary>
        /// Vérifie si une recette est utilisée par un lot qui n'est plus modifiable. Une recette ne doit plus être modifiée si elle est associée à un lot 
        /// déjà envoyé en production, terminé ou en erreur.
        /// </summary>
        /// <param name="idRecette"> Identifaint de la recette à vérifier.</param>
        /// <returns> true si la recette est bloquée,false si la recette peut encore être modifier ou supprimée.</returns> 
        public static bool RecetteEstBloquee(int idRecette)
        {
            bool recetteBloquee = false;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) " +
                                       "FROM lot l " +
                                       "INNER JOIN etat e ON l.Id_Etat = e.Id_Etat " +
                                       "WHERE l.Id_Recette = @idRecette " +
                                       "AND e.ETA_Libelle <> @etatAutorise;";
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.Parameters.AddWithValue("@etatAutorise", "En attente");

                    //// ExecuteScalar récupère le résultat du COUNT(*), donc le nombre de lots bloquants trouvés
                    int nombreLotsBloquant = Convert.ToInt32(cmd.ExecuteScalar());

                    // Si au moins un lot bloquant existe, la recette ne peut plus être modifiée
                    recetteBloquee = nombreLotsBloquant > 0;
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Erreur vérification modification recette: " + ex.Message);

                //// Par sécurité, si on n'arrive pas à vérifier, on bloque l'action.
                recetteBloquee = true;
            }

            return recetteBloquee;

        }


        /// <summary>
        /// Modifie une recette existante dans la base de donnée, Cette methode fonction supprime les anciens lien avec ses opérations, ajoute les nouvelles opérations 
        ///  et recrée les liens avec la table "Contenir".
        /// </summary>
        /// <param name="recette">Recette contenant les nouvelles informations à enregistrer.</param>
        public static void UpDateRecette(Recette recette)
        {
            try
            {
                //Modification du nom de la recette dans la table Recette.
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "UPDATE recette SET REC_Nom = @nomRecette WHERE Id_Recette = @idRecette;";


                    cmd.Parameters.AddWithValue("@nomRecette", recette.NomRecette);
                    cmd.Parameters.AddWithValue("@idRecette", recette.IdRecette);

                    cmd.ExecuteNonQuery();
                }

                //Suppression des anciens liens entre la recette et ses opérations.
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "DELETE FROM contenir WHERE Id_Recette = @idRecette;";


                    cmd.Parameters.AddWithValue("@idRecette", recette.IdRecette);

                    cmd.ExecuteNonQuery();
                }

                //Variable qui permet de garder l'ordre des opérations dans la recette.
                int numeroOperation = PremierNumeroOperation;

                //Parcours de toutes les opérations de la recette modifiée.
                foreach (OperationRecette operation in recette.Operations)
                {
                    // Ajout de l'opération dans la table operation.
                    long idOperation = CreateOperation(operation);

                    if (idOperation != IdInvalide )
                    {
                        //Ajout du lien dans la table Contenir.
                        AjouterOperationRecette(recette.IdRecette, idOperation, numeroOperation);
                        numeroOperation++;

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur modification recette :\n\n"  + ex.ToString());

            }
        }


        /// <summary>
        /// Vérifie si une recette est utilisée par au moins un lot, une recette utilisée par un lot ne peut pas être supprimée.
        /// </summary>
        /// <param name="idRecette">Identifiant de la recette à vérifier.</param>
        /// <returns>True si la recette est utilisée par un lot, sinon false.</returns>
        public static bool RecetteEstUtiliseeParLot(int idRecette)
        {
            bool recetteUtilisee = true;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) " +
                                      "FROM lot " +
                                      "WHERE Id_Recette = @idRecette;";

                    cmd.Parameters.AddWithValue("@idRecette", idRecette);

                    int nombreLots = Convert.ToInt32(cmd.ExecuteScalar());

                    recetteUtilisee = nombreLots > ValeurInactive;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur vérification utilisation recette : " + ex.Message);

                // Par sécurité, si la vérification échoue, on bloque la suppression.
                recetteUtilisee = true;
            }

            return recetteUtilisee;
        }


        /// <summary>
        /// Récupère toutes les opérations enregistrées dans la base de données.
        /// </summary>
        /// <returns>Liste des opérations enregistrées.</returns>
        public static List<OperationRecette> GetAllOperations()
        {
            List<OperationRecette> operations = new List<OperationRecette>();

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT Id_Operation, OPE_Nom, OPE_PositionMoteur, " +
                                      "OPE_TempsAttente, OPE_CycleVerin, OPE_Quittance, OPE_SensMoteur " +
                                      "FROM operation " +
                                      "ORDER BY OPE_Nom;";

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            OperationRecette operation = new OperationRecette();

                            operation.IdOperation = reader.GetInt32("Id_Operation");
                            operation.NomOperation = reader.GetString("OPE_Nom");
                            operation.Position = ConvertirPositionMoteurEnTexte(reader.GetInt32("OPE_PositionMoteur"));
                            operation.TempsAttente = reader.GetInt32("OPE_TempsAttente").ToString();
                            operation.CycleVerin = reader.GetBoolean("OPE_CycleVerin");
                            operation.Quittance = reader.GetBoolean("OPE_Quittance");

                            if (reader.GetInt32("OPE_PositionMoteur") == ValeurInactive)
                            {
                                operation.Sens = TexteVide;
                            }
                            else
                            {
                                operation.Sens = ConvertirSensMoteurEnTexte(reader.GetBoolean("OPE_SensMoteur"));
                            }

                            operations.Add(operation);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur chargement opérations : " + ex.Message);
            }

            return operations;
        }


        /// <summary>
        /// Vérifie si une opération est associée à au moins une recette.
        /// </summary>
        /// <param name="idOperation">Identifiant de l'opération à vérifier.</param>
        /// <returns>True si l'opération est associée à une recette, sinon false.</returns>
        public static bool OperationEstAssocieeARecette(int idOperation)
        {
            bool operationAssociee = true;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT COUNT(*) " +
                                      "FROM contenir " +
                                      "WHERE Id_Operation_est_contenu_dans = @idOperation;";

                    cmd.Parameters.AddWithValue("@idOperation", idOperation);

                    int nombreAssociations = Convert.ToInt32(cmd.ExecuteScalar());

                    operationAssociee = nombreAssociations > ValeurInactive;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur vérification utilisation opération : " + ex.Message);
                operationAssociee = true;
            }

            return operationAssociee;
        }


        /// <summary>
        /// Supprime une opération de la base de données si elle n'est associée à aucune recette.
        /// </summary>
        /// <param name="idOperation">Identifiant de l'opération à supprimer.</param>
        public static void DeleteOperation(int idOperation)
        {
            try
            {
                if (!OperationEstAssocieeARecette(idOperation))
                {
                    using (MySqlCommand cmd = GetConnection().CreateCommand())
                    {
                        cmd.CommandText = "DELETE FROM operation WHERE Id_Operation = @idOperation;";

                        cmd.Parameters.AddWithValue("@idOperation", idOperation);

                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer cette opération car elle est associée à une recette.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur suppression opération : " + ex.Message);
            }
        }
    }
}
