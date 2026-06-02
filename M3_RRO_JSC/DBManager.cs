using MySql.Data.MySqlClient;
using System;
using System.Data;

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
        // Instance unique de la connexion MySQL pour toute l'application
        private static MySqlConnection _connection;

        // Objet de verrouillage pour rendre l'accès thread-safe (évite les accès concurrents)
        private static readonly object _lock = new object();

        // Chaîne de connexion mémorisée après l'appel à ConnectToDB
        private static string _connectionString;

        /// <summary>
        /// Initialise la chaîne de connexion et tente une première ouverture.
        /// A appeler une seule fois au démarrage de l'application (ex: Form_Load).
        /// </summary>
        public static void ConnectToDB(string databaseName, string userName, string password)
        {
            _connectionString =
                $"server=localhost;database={databaseName};user={userName};password={password};port=3306;SslMode=None;";

            // S'assure que la connexion est ouverte dès le début
            EnsureConnection();
        }

        /// <summary>
        /// Vérifie l'état de la connexion et l'ouvre si elle est fermée ou inexistante.
        /// Cette méthode est appelée avant CHAQUE requête.
        /// </summary>
        private static void EnsureConnection()
        {
            lock (_lock) // Empêche plusieurs threads d'ouvrir la connexion en même temps
            {
                // Si la connexion n'existe pas, on la crée
                if (_connection == null)
                    _connection = new MySqlConnection(_connectionString);

                // Si la connexion est fermée ou cassée, on la rouvre
                if (_connection.State != ConnectionState.Open)
                {
                    try
                    {
                        _connection.Open();
                    }
                    catch (Exception ex)
                    {
                        // Erreur claire si la base est inaccessible
                        throw new Exception("Impossible de se connecter à la base MySQL.", ex);
                    }
                }
            }
        }

        /// <summary>
        /// Retourne une connexion valide et ouverte.
        /// Cette méthode est utilisée en interne uniquement.
        /// </summary>
        private static MySqlConnection GetConnection()
        {
            EnsureConnection();
            return _connection;
        }

        /// <summary>
        /// Ferme proprement la connexion à la fermeture de l'application.
        /// </summary>
        public static void CloseDBConnection()
        {
            lock (_lock)
            {
                if (_connection != null)
                {
                    _connection.Close();
                    _connection.Dispose();
                    _connection = null;
                }
            }
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
    }
}