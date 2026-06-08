using Microsoft.VisualBasic.Logging;
using MySql.Data.MySqlClient;
using Mysqlx.Expr;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Windows.Markup;
using static M3_RRO_JSC.DBManager;

namespace M3_RRO_JSC
{
    internal class RecetteManager
    {

        /// <summary>
        /// Cette méthode reçoit le texte sélectionné dans le ComboBox.Elle essaie de le convertir en valeur de l’enum PosMoteur.
        /// Par exemple : C’est 2 qui est enregistré dans la colonne OPE_PositionMoteur si on choisit la position 3H.
        /// </summary>
        /// <param name="positionTexte"></param>
        /// <returns> Si la conversion fonctionne, on retourne la valeur numérique de cette position pour l’enregistrer dans la base.
        /// </returns> Si la conversion échoue, on retourne 0, qui correspond à Inactif.
        public static int ConvertirPositionMoteur(String positionTexte)
        {
            if (System.Enum.TryParse(positionTexte, out PosMoteur position))

            {
                return (int)position;
            }

            else
            {
                return 0;

            }

        }


        /// <summary>
        /// Cette méhthode recoit le texte sélectionné dans le combo box, en valeur booléenne utilisable pour la base de donnée
        /// Si la conversion fonctionne, on retourne la valeur numérique du Sens moteur  pour l’enregistrer dans la base.
        /// </summary>
        /// <param name="sensTexte"></param>
        /// Texte sélectonné dans le comboBox.
        /// <returns>Retourne true si le sens sélectionné est horaire 
        /// </returns>Retourne false si le sens est AntiHoraire
        public static  bool ConvertirSensMoteur(String sensTexte)

        {
            if (System.Enum.TryParse(sensTexte, out SensMoteur sens))

            {
                return sens == SensMoteur.Horaire;
            }

            else
            {
                return false;

            }

        }

        /// <summary>
        /// Convertit le temps d'attente sélectionné dans le comboBox en nombre entier, converstion necessaire car la base attend un INT
        /// </summary>
        /// <param name="tempsTexte"> Texte récupére depuis le comboBox du temps d'attente</param>
        /// <returns> Le temps d'attente sous forme d'entier si la conversion fonction 
        /// </returns> 0 si si le texte est vide ou si la conversion échoue.
        public static int ConvertirTempsAttente(string tempsTexte)
        {
            if(string.IsNullOrWhiteSpace(tempsTexte))
            {
                return 0;
            }

            else if  (int.TryParse(tempsTexte, out int temps))
                    {
                        return temps;
                    }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Convertit la position du moteur enregistrés dans la base de donnée en texte utilisable dans le tableau DataGrid
        /// </summary>
        /// <param name="positionValeur">Valeur numérique stockée dans la base de donnée</param>
        /// <returns> Le nom de la position moteur correspondante 
        /// </returns> Positon inactive, pas de position choisit
        public static string ConvertirPositionMoteurEnTexte( int positionValeur)
        {
            if (System.Enum.IsDefined(typeof(PosMoteur),positionValeur))
            {
                return ((PosMoteur)positionValeur).ToString();
            }
            else
            {
                return PosMoteur.Inactif.ToString();
            }

        }

        /// <summary>
        /// Convertit le sens moteur enregistré en base 
        /// </summary>
        /// <returns></returns>
        public static string ConvertirSensMoteurEnTexte(bool sensValeur)
        {
            if (sensValeur)
            {
                return SensMoteur.Horaire.ToString();
            }

            else
            {
                return SensMoteur.AntiHoraire.ToString();
            }
        }
       

        /// <summary>
        /// Crée une nouvelle recette dans la table "Recette" de la base de données
        /// </summary>
        /// <param name="nomRecette"> Nom de la recette a enregistrer </param>
        /// <returns> L'identifiant de la recette crée 
        /// </returns> -1 si l'ajout échoue
        public static long CreateRecette(string nomRecette)
        {
            long idRecette = -1;

            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = " INSERT INTO Recette (REC_Nom, REC_DateHeureCreation) VALUES (@nomRecette, @dateCreation);";

                    cmd.Parameters.AddWithValue("@nomRecette", nomRecette);
                    cmd.Parameters.AddWithValue("@dateCreation", DateTime.Now);

                    int nbreRecetteAjoutees = cmd.ExecuteNonQuery();
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
        /// Crée une nouvelle ligne opération dans la table opération  de la base de donnée
        /// </summary>
        /// <param name="operation"> Contient les informations de l'opération a enregistrer </param>
        /// <returns> L'identifiant de l'opération crée
        /// </returns> -1 si l'ajourt échoue 
        public static long CreateOperation(OperationRecette operation)
        {
            long idOperation = -1;

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

                    int nbreOperationAjoutees = cmd.ExecuteNonQuery();

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
        /// Crée un lien entre une recette et une opération dans la table " Contenir ".Cette table permet de savoir quelles opérations appartient a une recette
        /// </summary>
        /// <param name="idRecette"> Identifiant de la recette </param>
        /// <param name="idOperation">  Identifiant de l'opération </param>
        /// <param name="numeroOperation"> Numéro de l'opération dans la recette, une recette peut contenir plusieurs opération </param>
        public static void AjouterOperationRecette( long idRecette, long idOperation, int numeroOperation)
        {
            try
            {
                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {

                    cmd.CommandText = "INSERT INTO Contenir " +
                                     "(Id_Operation_est_contenu_dans, Id_Recette, CON_NoOperation) " +
                                     "VALUES (@idOperation, @idRecette, @numeroOperation);";

                    cmd.Parameters.AddWithValue("@idOperation", idOperation);
                    cmd.Parameters.AddWithValue("@idRecette", idRecette);
                    cmd.Parameters.AddWithValue("@numeroOperation", numeroOperation);

                    int nbreLiensAjoutes = cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur ajout lien recette-operation: " + ex.Message);
            }
                
           
        }

        /// <summary>
        /// Récupère toutes les recettes enregistrées dans la table "Recette".
        /// </summary>
        /// <returns> Une liste de recette contenant leurs identifiant, leur noms et leurs dates.
        /// </returns> Si une erruer survient, retourne une lsite vide.
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
                    cmd.CommandText = "SELECT Id_Recette, Rec_Nom, REC_DateHeureCreation FROM Recette;";

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
        /// Récupère toutes les opérations associées à une recette données, les opérations sont retrouvées grâce à la table " Contenir".
        /// </summary>
        /// <param name="idRecette"> Identifiant de la recette dont on veur récupèrer les opérations </param>
        /// <returns> La liste des opérations liées à la recette.
        /// </returns> Une liste vide si aucune opération n'est trouvée ou si une erreur survient.
        public static List<OperationRecette> GetOperationsByRecetteId ( int idRecette)
        {
            List<OperationRecette> operations = new List<OperationRecette>();

            try
            {

                using (MySqlCommand cmd = GetConnection().CreateCommand())
                {
                    cmd.CommandText = "SELECT o.Id_Operation, o.OPE_Nom, o.OPE_PositionMoteur, o.OPE_TempsAttente, o.OPE_CycleVerin, o.OPE_Quittance, o.OPE_SensMoteur " +
                                      "FROM operation o " +
                                      "INNER JOIN Contenir c ON o.Id_Operation = c.Id_Operation_est_contenu_dans " +
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








        public void UpdateRecette()
        {
            // Logique pour mettre à jour un lot
        }

        public void DeleteRecette()
        {
            // Logique pour supprimer un lot
        }

        public void GetRecetteById(int id)
        {
            // Logique pour récupérer un lot par son ID
        }

        
    }
}
