using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static M3_RRO_JSC.OperationRecette;

namespace M3_RRO_JSC
{
    public partial class FrmCreationRecette : Form
    {
        private DataTable tableOperations;

        private Recette recetteAModifier = null; // Contient la recette que l'on veut modifier 

        private bool modeModification = false;  // Savoir si on est en mode création ou en mode modification

        private int indexOperationSelectionnee = -1;

        public FrmCreationRecette()
        {
            InitializeComponent();

            InitialiserComboBox();
            InitialiserTableOperations();

            this.Text = "Création de recette";
            btnEnregistrerCreaRecette.Text = "Enregistrer la recette";
        }

        public FrmCreationRecette(Recette recette)
        {
            InitializeComponent();

            InitialiserComboBox();
            InitialiserTableOperations();

            recetteAModifier = recette;
            modeModification = true;

            this.Text = "Modification de recette";
            btnEnregistrerCreaRecette.Text = "Enregistrer la modification";

            ChargerRecetteAModifier();
        }

        private void InitialiserComboBox()
        {
            cboSensCreaRecette.Items.Clear();
            cboSensCreaRecette.Items.Add("Horaire");
            cboSensCreaRecette.Items.Add("Anti-horaire");
            cboSensCreaRecette.SelectedIndex = -1;

            cboPositionCreaRecette.Items.Clear();
            cboPositionCreaRecette.Items.Add("3h");
            cboPositionCreaRecette.Items.Add("6h");
            cboPositionCreaRecette.Items.Add("9h");
            cboPositionCreaRecette.Items.Add("12h");
            cboPositionCreaRecette.SelectedIndex = -1;

            cboTempsCreaRecette.Items.Clear();
            cboTempsCreaRecette.Items.Add("0");
            cboTempsCreaRecette.Items.Add("1");
            cboTempsCreaRecette.Items.Add("2");
            cboTempsCreaRecette.Items.Add("3");
            cboTempsCreaRecette.Items.Add("4");
            cboTempsCreaRecette.Items.Add("5");
            cboTempsCreaRecette.Items.Add("6");
            cboTempsCreaRecette.Items.Add("7");
            cboTempsCreaRecette.Items.Add("8");
            cboTempsCreaRecette.Items.Add("9");
            cboTempsCreaRecette.Items.Add("10");
            cboTempsCreaRecette.SelectedIndex = -1;
        }

        private void InitialiserTableOperations()
        {
            tableOperations = new DataTable();

            tableOperations.Columns.Add("Nom opération");
            tableOperations.Columns.Add("Moteur actif");
            tableOperations.Columns.Add("Sens");
            tableOperations.Columns.Add("Position");
            tableOperations.Columns.Add("Temps d'attente");
            tableOperations.Columns.Add("Cycle vérin");
            tableOperations.Columns.Add("Quittance");

            grdOperationCreaRecette.DataSource = tableOperations;

            grdOperationCreaRecette.ReadOnly= true;
            grdOperationCreaRecette.SelectionMode= DataGridViewSelectionMode.FullRowSelect;
            grdOperationCreaRecette.MultiSelect= false;
            grdOperationCreaRecette.AllowUserToAddRows = false;
            grdOperationCreaRecette.AllowUserToDeleteRows = false;
            grdOperationCreaRecette.AutoSizeColumnsMode=DataGridViewAutoSizeColumnsMode.Fill;

        }


        private void btnValiderCreaRecette_Click(object sender, EventArgs e)
        {
            if (!OperationValide())
            {
                return;
            }

            string sens = "";
            string position = "";

            if (ckbMoteurCreaRecette.Checked)
            {
                sens = cboSensCreaRecette.SelectedItem.ToString();
                position = cboPositionCreaRecette.SelectedItem.ToString();
            }

            string temps = cboTempsCreaRecette.SelectedItem.ToString();

            tableOperations.Rows.Add(
                txtNomOperation.Text.Trim(),
                ckbMoteurCreaRecette.Checked ? "Oui" : "Non",
                sens,
                position,
                temps,
                ckbCycleVerinCreaRecette.Checked ? "Oui" : "Non",
                ckbQuittanceCreaRecette.Checked ? "Oui" : "Non"
            );

            ViderChampsOperation();
        }



        private bool OperationValide()
        {
            if (string.IsNullOrWhiteSpace(txtNomOperation.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de l'opération.");
                txtNomOperation.Focus();
                return false;
            }

            if (!ckbMoteurCreaRecette.Checked && !ckbCycleVerinCreaRecette.Checked)
            {
                MessageBox.Show("Veuillez sélectionner au moins une action : moteur actif ou cycle vérin.");
                ckbMoteurCreaRecette.Focus();
                return false;
            }

            if (ckbMoteurCreaRecette.Checked)
            {
                if (cboSensCreaRecette.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner le sens du moteur.");
                    cboSensCreaRecette.Focus();
                    return false;
                }

                if (cboPositionCreaRecette.SelectedIndex == -1)
                {
                    MessageBox.Show("Veuillez sélectionner la position du moteur.");
                    cboPositionCreaRecette.Focus();
                    return false;
                }
            }

            if (cboTempsCreaRecette.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner le temps d'attente.");
                cboTempsCreaRecette.Focus();
                return false;
            }

            return true;
        }


        private void ViderChampsOperation()
        {
            txtNomOperation.Clear();

            ckbMoteurCreaRecette.Checked = false;
            ckbCycleVerinCreaRecette.Checked = false;
            ckbQuittanceCreaRecette.Checked = false;

            cboSensCreaRecette.SelectedIndex = -1;
            cboPositionCreaRecette.SelectedIndex = -1;
            cboTempsCreaRecette.SelectedIndex = -1;

            txtNomOperation.Focus();
        }

        private void btnEnregistrerCreaRecette_Click(object sender, EventArgs e)
        {
            if (!RecetteValide())
            {
                return;
            }

            if (modeModification)
            {
                ModifierRecetteExistante();
            }
            else
            {
                CreerNouvelleRecette();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private bool RecetteValide()
        {
            if (string.IsNullOrWhiteSpace(txtNomCreaLot.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de la recette.");
                txtNomCreaLot.Focus();
                return false;
            }

            if (tableOperations.Rows.Count == 0)
            {
                MessageBox.Show("Veuillez ajouter au moins une opération à la recette.");
                txtNomOperation.Focus();
                return false;
            }

            return true;
        }

        private void btnAnnulerCreaRecette_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        /// <summary>
        /// Charge les informations de la recette à modifier et met à jour l'interface utilisateur avec ses données.§
        /// </summary>
        /// <remarks>Cette méthode met à jour les champs de saisie et le tableau des opérations en
        /// fonction de la recette sélectionnée pour modification. Si aucune recette n'est sélectionnée, la méthode ne
        /// fait rien.</remarks>
        private void ChargerRecetteAModifier()
        {
            if (recetteAModifier == null)
            {
                return;
            }

            txtNomCreaLot.Text = recetteAModifier.NomRecette;

            tableOperations.Rows.Clear();

            foreach (OperationRecette operation in recetteAModifier.Operations)
            {
                tableOperations.Rows.Add(
                    operation.NomOperation,
                    operation.MoteurActif ? "Oui" : "Non",
                    operation.Sens,
                    operation.Position,
                    operation.TempsAttente,
                    operation.CycleVerin ? "Oui" : "Non",
                    operation.Quittance ? "Oui" : "Non"
                );
            }
        }
        /// <summary>
        /// Crée une nouvelle instance de la classe OperationRecette à partir des données d'une ligne de DataRow.
        /// </summary>
        /// <remarks>Les valeurs des colonnes doivent être présentes et au format attendu. Les colonnes de
        /// type booléen sont interprétées comme <see langword="true"/> si la valeur est "Oui" ; sinon, <see
        /// langword="false"/>.</remarks>
        /// <param name="row">La ligne de données source contenant les informations nécessaires à la création de l'opération. Doit inclure
        /// les colonnes attendues telles que "Nom opération", "Moteur actif", "Sens", "Position", "Temps d'attente",
        /// "Cycle vérin" et "Quittance".</param>
        /// <returns>Une instance d'OperationRecette initialisée avec les valeurs extraites de la ligne de données fournie.</returns>
        private OperationRecette CreerOperationDepuisLigne(DataRow row)
        {
            OperationRecette operation = new OperationRecette();

            operation.NomOperation = row["Nom opération"].ToString();
            operation.MoteurActif = row["Moteur actif"].ToString() == "Oui";
            operation.Sens = row["Sens"].ToString();
            operation.Position = row["Position"].ToString();
            operation.TempsAttente = row["Temps d'attente"].ToString();
            operation.CycleVerin = row["Cycle vérin"].ToString() == "Oui";
            operation.Quittance = row["Quittance"].ToString() == "Oui";

            return operation;
        }

        /// <summary>
        /// Crée une nouvelle recette à partir des informations saisies par l'utilisateur et l'ajoute à la liste des
        /// recettes existantes.
        /// </summary>
        /// <remarks>Cette méthode lit les données de l'interface utilisateur et des opérations associées,
        /// puis enregistre la nouvelle recette. Un message de confirmation s'affiche à la fin de l'opération. Cette
        /// méthode doit être appelée dans un contexte où l'interface utilisateur et les données nécessaires sont
        /// valides.</remarks>
        private void CreerNouvelleRecette()
        {
            Recette nouvelleRecette = new Recette();

            nouvelleRecette.NomRecette = txtNomCreaLot.Text.Trim();
            nouvelleRecette.DateCreation = DateTime.Now;

            foreach (DataRow row in tableOperations.Rows)
            {
                OperationRecette operation = CreerOperationDepuisLigne(row);
                nouvelleRecette.Operations.Add(operation);
            }

            RecetteData.ListeRecettes.Add(nouvelleRecette);

            MessageBox.Show("Recette enregistrée avec succès.");
        }

        /// <summary>
        /// Met à jour les informations de la recette existante avec les valeurs saisies par l'utilisateur et remplace
        /// la liste des opérations associées.
        /// </summary>
        /// <remarks>Cette méthode doit être appelée lorsque l'utilisateur souhaite enregistrer les
        /// modifications apportées à une recette existante. Toutes les opérations précédemment associées à la recette
        /// sont supprimées et remplacées par celles définies dans la table des opérations. Un message de confirmation
        /// s'affiche à la fin de l'opération.</remarks>
        private void ModifierRecetteExistante()
        {
            recetteAModifier.NomRecette = txtNomCreaLot.Text.Trim();

            recetteAModifier.Operations.Clear();

            foreach (DataRow row in tableOperations.Rows)
            {
                OperationRecette operation = CreerOperationDepuisLigne(row);
                recetteAModifier.Operations.Add(operation);
            }

            MessageBox.Show("Recette modifiée avec succès.");
        }

        private void grdOperationCreaRecette_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <  0)
            {
                return;
            }

            indexOperationSelectionnee = e.RowIndex;

            DataRow




    }



}