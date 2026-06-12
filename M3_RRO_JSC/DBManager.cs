using MySql.Data.MySqlClient;
using System;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace M3_RRO_JSC
{
    /// <summary>
    /// Gestionnaire centralisé de la connexion MySQL.
    /// Cette classe :
    /// - Ouvre la connexion si nécessaire
    /// - La maintient vivante
    /// - Gère la reconnexion automatique
    /// - Fournit des méthodes propres pour exécuter des requêtes
    /// </summary>
    public static class DBManager
    {
        public static bool IsConnected =>
            _connection != null && _connection.State == System.Data.ConnectionState.Open;


        // Instance unique de la connexion MySQL pour toute l'application
        public static MySqlConnection? _connection;

        // Objet de verrouillage pour rendre l'accès thread-safe (évite les accès concurrents)
        private static readonly object _lock = new object();

        // Chaîne de connexion mémorisée après l'appel à ConnectToDB
        public static string _connectionString = string.Empty;

        /// <summary>
        /// Initialise la chaîne de connexion et tente une première ouverture.
        /// A appeler une seule fois au démarrage de l'application (ex: Form_Load).
        /// </summary>
        public static void ConnectToDB(string databaseIP, string databaseName, string userName, string password, string SQLPort)
        {
            _connectionString =
                $"server={databaseIP};database={databaseName};user={userName};password={password};port={SQLPort};";

            try
            {
                // S'assure que la connexion est ouverte dès le début
                EnsureConnection();
                MessageBox.Show("Connexion réussie à la base de données !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            /// <summary>
            /// Teste la connexion à la base de données avec les paramètres fournis.
            /// Affiche un message de succès ou d'échec.
            /// Retourne true si la connexion est réussie, false sinon.
            /// Cette méthode est utilisée pour valider les paramètres avant de les enregistrer.
            /// Elle n'affecte pas la connexion principale utilisée par l'application.
            /// </summary>
        public static bool TestConnexion(string databaseIP, string databaseName, string userName, string password, string SQLPort) {
            _connectionString =
                $"server={databaseIP};database={databaseName};user={userName};password={password};port={SQLPort};";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(_connectionString))
                {
                    conn.Open();
                    return conn.State == System.Data.ConnectionState.Open && true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        /// <summary>
        /// Vérifie l'état de la connexion et l'ouvre si elle est fermée ou inexistante.
        /// Cette méthode est appelée avant CHAQUE requête.
        /// </summary>
        private static void EnsureConnection()
        {
            lock (_lock) // Empêche plusieurs threads d'ouvrir la connexion en même temps
            {
                // Utiliser une variable locale pour éviter les avertissements de nullabilité
                var conn = _connection;

                // Si la connexion n'existe pas, on la crée et on l'assigne à la variable partagée
                if (conn == null)
                {
                    conn = new MySqlConnection(_connectionString);
                    _connection = conn;
                }

                // Si la connexion est fermée ou cassée, on la rouvre
                if (conn.State != ConnectionState.Open)
                {
                    try
                    {
                        conn.Open();
                    }
                    catch (Exception ex)
                    {
                        // Erreur claire si la base est inaccessible
                        MessageBox.Show($"Base de données inaccessible :\n{ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Retourne une connexion valide et ouverte.
        /// Cette méthode est utilisée en interne uniquement.
        /// </summary>
        public static MySqlConnection GetConnection()
        {
            EnsureConnection();

            if (_connection == null)
                throw new InvalidOperationException("La connexion MySQL n'a pas été initialisée.");

            return _connection;
        }

        /// <summary>
        /// Ferme proprement la connexion à la fermeture de l'application.
        /// </summary>
        public static void CloseDBConnection()
        {
            lock (_lock)
            {
                var conn = _connection;
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                    conn.Dispose();
                    _connection = null;
                }
            }        }

        public static string GetConnexionInfo()
        {
            return _connectionString;
        }

        // ================== MÉTHODES D'EXÉCUTION DE REQUÊTES ==================

        /// <summary>
        /// Exécute une requête SELECT et retourne le résultat sous forme de DataTable.
        /// Compatible directement avec DataGridView.
        /// </summary>
        public static DataTable ExecuteQuery(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, GetConnection());

            // Ajout sécurisé des paramètres (anti injection SQL)
            cmd.Parameters.AddRange(parameters);

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();

            // Remplit le DataTable avec le résultat de la requête
            adapter.Fill(table);

            return table;
        }

        /// <summary>
        /// Exécute une requête INSERT, UPDATE ou DELETE.
        /// Retourne le nombre de lignes affectées.
        /// </summary>
        public static int ExecuteNonQuery(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Exécute une requête qui retourne une seule valeur (COUNT, MAX, SUM, etc.).
        /// </summary>
        public static object ExecuteScalar(string query, params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(query, GetConnection());
            cmd.Parameters.AddRange(parameters);

            return cmd.ExecuteScalar();
        }



        /// <summary>
        /// Vérifie si les paramètres nécessaires à la connexion sont renseignés.
        /// </summary>
        /// <returns>True si les paramètres de connexion sont valides, sinon false.</returns>
        public static bool ParametresConnexionValides()
        {
            bool parametresValides = true;

            if (string.IsNullOrWhiteSpace(_connectionString))
            {
                parametresValides = false;
            }
            else if (!_connectionString.Contains("server=") && !_connectionString.Contains("Server="))
            {
                parametresValides = false;
            }
            else if (_connectionString.Contains("server=;") || _connectionString.Contains("Server=;"))
            {
                parametresValides = false;
            }

            return parametresValides;
        }
    }
}