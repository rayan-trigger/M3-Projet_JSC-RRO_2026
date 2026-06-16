// Fichier: TracabilitéManager.cs
// Description: Manager responsable du chargement, du filtrage et de la
// recherche des événements de traçabilité. Fournit une API réutilisable par
// le contrôle TracabiliteControl.
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static M3_RRO_JSC.DBManager;

namespace M3_RRO_JSC
{
    internal class TracabilitéManager
    {
    /// <summary>
    /// Gestionnaire de la page Traçabilité.
    /// Gère le chargement, le filtrage et la recherche des événements/opérations.
    /// </summary>
    public class TracabiliteManager
        {
            // ─── Références aux contrôles du formulaire ───────────────────────────
            private readonly DataGridView _dataGridView;
            private readonly TextBox _textBoxRecherche;
            private readonly ComboBox _comboBoxFiltre;

            // ─── Cache du DataTable complet (avant filtre/recherche) ──────────────
            private DataTable _donneesCompletes = new DataTable();

            // ─── Requête SQL principale ───────────────────────────────────────────
            private const string QUERY_CHARGEMENT = @"
            SELECT
                e.Id_Evenement      AS 'ID',
                e.EVE_DateHeure     AS 'Date / Heure',
                l.LOT_Nom           AS 'Lot',
                r.REC_Nom           AS 'Recette',
                e.EVE_Message       AS 'Description',
                et.ETA_Libelle      AS 'Statut'
            FROM evenement e
            INNER JOIN lot      l  ON e.Id_Lot      = l.Id_Lot
            INNER JOIN recette  r  ON l.Id_Recette  = r.Id_Recette
            INNER JOIN etat     et ON l.Id_Etat     = et.Id_Etat
            ORDER BY e.EVE_DateHeure DESC";

            // ─── Constructeur ─────────────────────────────────────────────────────
            /// <summary>
            /// Initialise le manager avec les contrôles du formulaire.
            /// </summary>
            /// <param name="dataGridView">Le DataGridView d'affichage</param>
            /// <param name="textBoxRecherche">La TextBox de recherche</param>
            /// <param name="comboBoxFiltre">Le ComboBox de filtre par statut</param>
            public TracabiliteManager(DataGridView dataGridView, TextBox textBoxRecherche, ComboBox comboBoxFiltre)
            {
                _dataGridView = dataGridView ?? throw new ArgumentNullException(nameof(dataGridView));
                _textBoxRecherche = textBoxRecherche ?? throw new ArgumentNullException(nameof(textBoxRecherche));
                _comboBoxFiltre = comboBoxFiltre ?? throw new ArgumentNullException(nameof(comboBoxFiltre));

                ConfigurerDataGridView();
                ChargerFiltres();
                AbonnerEvenements();
            }

            // ═════════════════════════════════════════════════════════════════════
            // INITIALISATION
            // ═════════════════════════════════════════════════════════════════════

            /// <summary>
            /// Configure l'apparence du DataGridView.
            /// </summary>
            public void ConfigurerDataGridView()
            {
                _dataGridView.ReadOnly = true;
                _dataGridView.AllowUserToAddRows = false;
                _dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                _dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                _dataGridView.BackgroundColor = System.Drawing.Color.White;
                _dataGridView.RowHeadersVisible = false;
            }

            /// <summary>
            /// Charge les statuts disponibles depuis la table Etat dans le ComboBox.
            /// Ajoute "Tous" en première entrée pour afficher sans filtre.
            /// </summary>
            private void ChargerFiltres()
            {
                try
                {
                    _comboBoxFiltre.Items.Clear();
                    _comboBoxFiltre.Items.Add("Tous");

                    DataTable statuts = DBManager.ExecuteQuery(
                        "SELECT ETA_Libelle FROM etat ORDER BY ETA_Libelle");

                    foreach (DataRow row in statuts.Rows)
                    {
                        _comboBoxFiltre.Items.Add(row["ETA_Libelle"].ToString());
                    }

                    _comboBoxFiltre.SelectedIndex = 0; // "Tous" sélectionné par défaut
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement des filtres :\n{ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            /// <summary>
            /// Abonne les événements des contrôles pour déclencher filtre/recherche en temps réel.
            /// </summary>
            private void AbonnerEvenements()
            {
                _textBoxRecherche.TextChanged += (s, e) => AppliquerFiltreEtRecherche();
                _comboBoxFiltre.SelectedIndexChanged += (s, e) => AppliquerFiltreEtRecherche();
            }

            // ═════════════════════════════════════════════════════════════════════
            // CHARGEMENT DES DONNÉES
            // ═════════════════════════════════════════════════════════════════════

            /// <summary>
            /// Charge tous les événements depuis la base de données et les affiche.
            /// À appeler au chargement du formulaire et après toute modification.
            /// </summary>
            public void ChargerDonnees()
            {
                try
                {
                    _donneesCompletes = DBManager.ExecuteQuery(QUERY_CHARGEMENT);
                    AppliquerFiltreEtRecherche();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors du chargement de la traçabilité :\n{ex.Message}",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // ═════════════════════════════════════════════════════════════════════
            // FILTRE + RECHERCHE
            // ═════════════════════════════════════════════════════════════════════

            /// <summary>
            /// Applique simultanément le filtre par statut et la recherche textuelle.
            /// Le résultat est affiché dans le DataGridView via une vue filtrée.
            /// </summary>
            private void AppliquerFiltreEtRecherche()
            {
                if (_donneesCompletes == null) return;

                string filtreStatut = _comboBoxFiltre.SelectedItem?.ToString() ?? "Tous";
                string texteRecherche = _textBoxRecherche.Text.Trim();

                // Construction du filtre DataView
                string filtre = ConstruireFiltre(filtreStatut, texteRecherche);

                DataView vue = new DataView(_donneesCompletes);
                vue.RowFilter = filtre;

                // Liaison au DataGridView via une copie du résultat filtré
                _dataGridView.DataSource = vue.ToTable();
            }

            /// <summary>
            /// Construit la chaîne de filtre DataView à partir du statut sélectionné
            /// et du texte de recherche saisi.
            /// </summary>
            /// <param name="statut">Statut sélectionné dans le ComboBox ("Tous" = pas de filtre)</param>
            /// <param name="recherche">Texte saisi dans la TextBox de recherche</param>
            /// <returns>Expression de filtre compatible DataView.RowFilter</returns>
            private string ConstruireFiltre(string statut, string recherche)
            {
                string filtreStatut = string.Empty;
                string filtreRecherche = string.Empty;

                // ── Filtre statut ──────────────────────────────────────────────
                if (!string.IsNullOrEmpty(statut) && statut != "Tous")
                {
                    // Échappement des apostrophes pour éviter les erreurs de syntaxe
                    string statutEchappe = statut.Replace("'", "''");
                    filtreStatut = $"Statut = '{statutEchappe}'";
                }

                // ── Filtre recherche (cherche dans ID, Lot, Recette, Description) ─
                if (!string.IsNullOrEmpty(recherche))
                {
                    string r = recherche.Replace("'", "''");
                    filtreRecherche = $"(" +
                        $"CONVERT(ID, System.String) LIKE '%{r}%' OR " +
                        $"lot          LIKE '%{r}%' OR " +
                        $"recette      LIKE '%{r}%' OR " +
                        $"description  LIKE '%{r}%'" +
                        $")";
                }

                // ── Combinaison des deux filtres ───────────────────────────────
                if (!string.IsNullOrEmpty(filtreStatut) && !string.IsNullOrEmpty(filtreRecherche))
                    return $"{filtreStatut} AND {filtreRecherche}";

                if (!string.IsNullOrEmpty(filtreStatut))
                    return filtreStatut;

                if (!string.IsNullOrEmpty(filtreRecherche))
                    return filtreRecherche;

                return string.Empty; // Aucun filtre → tout afficher
            }

            // ═════════════════════════════════════════════════════════════════════
            // UTILITAIRES PUBLICS
            // ═════════════════════════════════════════════════════════════════════

            /// <summary>
            /// Remet à zéro le filtre et la recherche, puis recharge les données.
            /// </summary>
            public void Reinitialiser()
            {
                _textBoxRecherche.Clear();
                _comboBoxFiltre.SelectedIndex = 0;
                ChargerDonnees();
            }

            /// <summary>
            /// Retourne le nombre de lignes actuellement affichées dans le DataGridView.
            /// </summary>
            public int NombreLignesAffichees => _dataGridView.RowCount;
        }

    }
}
