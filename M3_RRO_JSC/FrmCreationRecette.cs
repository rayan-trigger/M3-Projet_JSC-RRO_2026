using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Windows.Forms;
using static M3_RRO_JSC.OperationRecette;
using static System.Resources.ResXFileRef;
using MySql.Data.MySqlClient;

namespace M3_RRO_JSC
{
    public partial class FrmCreationRecette : Form

    {
        private const string COL_NOM_OPERATION = "Nom opération";
        private const string COL_SENS = "Sens";
        private const string COL_POSITION = "Position";
        private const string COL_TEMPS_ATTENTE = "Temps d'attente";
        private const string COL_CYCLE_VERIN = "Cycle vérin";
        private const string COL_QUITTANCE = "Quittance";

        private DataTable tableOperations;

        private Recette recetteAModifier = null; // Contient la recette que l'on veut modifier 

        private bool modeModification = false;  // Savoir si on est en mode création ou en mode modification

        private int indexOperationSelectionnee = -1;

        private bool chargementEnCours = false;

        public FrmCreationRecette()
        {
            InitializeComponent();

            InitialiserComboBox();
            InitialiserTableOperations();
            ActivationMoteur();
            ActivationCycleVerin();

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

        /// <summary>
        /// Initialise les comboBox du formulaire création recette.
        /// </summary>
        private void InitialiserComboBox()

        {
            cboSensCreaRecette.DataSource = null;
            cboSensCreaRecette.Items.Clear();
            cboSensCreaRecette.Items.Add("Horaire");
            cboSensCreaRecette.Items.Add("AntiHoraire");
            cboSensCreaRecette.SelectedIndex = -1;

            cboPositionCreaRecette.DataSource = null;
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

            tableOperations.Columns.Add(COL_NOM_OPERATION);
            tableOperations.Columns.Add(COL_SENS);
            tableOperations.Columns.Add(COL_POSITION);
            tableOperations.Columns.Add(COL_TEMPS_ATTENTE);
            tableOperations.Columns.Add(COL_CYCLE_VERIN);
            tableOperations.Columns.Add(COL_QUITTANCE);

            grdOperationCreaRecette.DataSource = tableOperations;

            grdOperationCreaRecette.ReadOnly = true;
            grdOperationCreaRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdOperationCreaRecette.MultiSelect = false;
            grdOperationCreaRecette.AllowUserToAddRows = false;
            grdOperationCreaRecette.AllowUserToDeleteRows = false;
            grdOperationCreaRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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

            string temps = "0";

            if (!ckbCycleVerinCreaRecette.Checked)
            {
                temps = cboTempsCreaRecette.SelectedItem.ToString();

            }


            if (indexOperationSelectionnee == -1)
            {
                tableOperations.Rows.Add(
                txtNomOperation.Text.Trim(),
                sens,
                position,
                temps,
                ckbCycleVerinCreaRecette.Checked ? "Oui" : "Non",
                ckbQuittanceCreaRecette.Checked ? "Oui" : "Non"
            );
            }

            else
            {
                DataRow row = tableOperations.Rows[indexOperationSelectionnee];

                row[COL_NOM_OPERATION] = txtNomOperation.Text.Trim();
                row[COL_SENS] = sens;
                row[COL_POSITION] = position;
                row[COL_TEMPS_ATTENTE] = temps;
                row[COL_CYCLE_VERIN] = ckbCycleVerinCreaRecette.Checked ? "Oui" : "Non";
                row[COL_QUITTANCE] = ckbQuittanceCreaRecette.Checked ? "Oui" : "Non";

            }

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

            if (!ckbCycleVerinCreaRecette.Checked && cboTempsCreaRecette.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner le temps d'attente.");
                cboTempsCreaRecette.Focus();
                return false;
            }

            return true;
        }


        private void ViderChampsOperation()
        {
            chargementEnCours = true;

            txtNomOperation.Clear();

            ckbMoteurCreaRecette.Checked = false;
            ckbCycleVerinCreaRecette.Checked = false;
            ckbQuittanceCreaRecette.Checked = false;

            cboSensCreaRecette.SelectedIndex = -1;
            cboPositionCreaRecette.SelectedIndex = -1;
            cboTempsCreaRecette.SelectedIndex = -1;

            indexOperationSelectionnee = -1;
            btnValiderCreaRecette.Text = " Valider l'opération";

            grdOperationCreaRecette.ClearSelection();

            chargementEnCours = false;

            // attends que le DataGridView ait fini ses actions automatiques, puis vide vraiment la sélection
            BeginInvoke(new Action(() =>

            {
                chargementEnCours = true;

                grdOperationCreaRecette.ClearSelection();
                indexOperationSelectionnee = -1;
                btnValiderCreaRecette.Text = "Valider l'opération";

                chargementEnCours = false;



                txtNomOperation.Focus();
            }));
        }

        /// <summary>
        /// Enregistre la recette selon le mode actuel du formualire. si le formulaire est en mode modification, la recette existante est mise à jour, sinon 
        /// une nouvelle recette est créée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerCreaRecette_Click(object sender, EventArgs e)
        {
            //Vérifie que le nom de la recette est saisi et qu'au moins une opération a été ajoutée.
            if (!RecetteValide())
            {
                return;
            }

            //Si le formulaire a été ouvert pour modifier une recette existante,on met à jour cette recette.

            if (modeModification)
            {
                ModifierRecetteExistante();
            }
            else
            {
                // Sinon le formulaire est en mode création 
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
        /// Supprime l'opération sélectionnée dans le tableau temporaire des opérations, mais on ne supprime rien de la base de donnée tant que l'utilisateur n'a pas appuyer sur le 
        /// boutons enregistrer modification car s'il entre 2 il clic sur annuler on aurait supprimer des donnée qu'on ne voulait pas. 
        /// Pendant la suppression, on bloque le chargement automatique de la sélection pour évité de lire une ligne qui vient d'être supprimé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerCreaRecette_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une opération est bien sélectionnée dans le tableau.
            if (indexOperationSelectionnee < 0 || indexOperationSelectionnee >= tableOperations.Rows.Count)
            {
                MessageBox.Show("Veuillez sélectionner une opération à supprimer.");
                return;
            }

            DialogResult result = MessageBox.Show(
                " Supprimer l'opération sélectionnée ?",
                "Confirmation",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
               );

            if (result != DialogResult.Yes)
            {
                return;
            }
            try
            {
                // Bloque temporairement le chargement automatique de la sélection. 
                chargementEnCours = true;

                // Supprime l'opération dans le tableau temporaire.
                tableOperations.Rows.RemoveAt(indexOperationSelectionnee);

                indexOperationSelectionnee = -1;

                ViderChampsOperation();
            }
            finally
            {
                // Réactiuve toujours le chargement automatique même si une erreur survient.
                chargementEnCours = false;
            }
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

            operation.NomOperation = row[COL_NOM_OPERATION].ToString();
            operation.Sens = row[COL_SENS].ToString();
            operation.Position = row[COL_POSITION].ToString();
            operation.TempsAttente = row[COL_TEMPS_ATTENTE].ToString();
            operation.CycleVerin = row[COL_CYCLE_VERIN].ToString() == "Oui";
            operation.Quittance = row[COL_QUITTANCE].ToString() == "Oui";

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

            long idRecette = RecetteManager.CreateRecette(nouvelleRecette.NomRecette);

            if (idRecette == -1)
            {
                MessageBox.Show("la recette n'a pas pu être enregistrer dans la base de donnée.");
                return;
            }

            int numeroOperation = 1;

            foreach (OperationRecette operation in nouvelleRecette.Operations)
            {
                long idOperation = RecetteManager.CreateOperation(operation);

                if (idOperation == -1)
                {
                    MessageBox.Show("Une opération n'a pas pu être enregistrée dans la base de données.");
                    return;
                }

                RecetteManager.AjouterOperationRecette(idRecette, idOperation, numeroOperation);

                numeroOperation++;

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
            // Modification du nom de la recette avec le texte saisi.
            recetteAModifier.NomRecette = txtNomCreaLot.Text.Trim();

            //On vide l'ancienne liste d'opérations de l'objet recette.
            recetteAModifier.Operations.Clear();

            //On recrée la liste des opérations à partir du tableau du formulaire.
            foreach (DataRow row in tableOperations.Rows)
            {
                OperationRecette operation = CreerOperationDepuisLigne(row);
                recetteAModifier.Operations.Add(operation);
            }

            //Enregistrement des modifications dans la base de données.
            RecetteManager.UpDateRecette(recetteAModifier);

            MessageBox.Show("Recette modifiée avec succès.");
        }

        /// <summary>
        /// Charge dans les champs du formulaire les informations de l'opération sélectionnée dans le tableau opération.
        /// Cette methode permet de modifier une opération existante, ci celle-ci est selctionnée les texteBox, Combox et checkBocx du formulaire se remplissent
        /// </summary>
        private void ChargerOperationSelectionnee()
        {
            if (grdOperationCreaRecette.CurrentRow == null)
            {
                return;
            }

            //Récupère l'index de la ligne sélectionnée dans le datagrid.
            int index = grdOperationCreaRecette.CurrentRow.Index;

            // Vérifie que l'index correspond bien à une ligne existante dans le Datatable.
            if (index < 0 || index >= tableOperations.Rows.Count)
            {
                return;
            }

            indexOperationSelectionnee = index;

            DataRow row = tableOperations.Rows[indexOperationSelectionnee];

            // évite de lire une ligne qui vient d'être supprimée (difficile a faire) .
            if (row.RowState == DataRowState.Deleted || row.RowState == DataRowState.Detached)
            {
                return;
            }

            txtNomOperation.Text = row[COL_NOM_OPERATION].ToString();

            ckbCycleVerinCreaRecette.Checked = row[COL_CYCLE_VERIN].ToString() == "Oui";
            ckbQuittanceCreaRecette.Checked = row[COL_QUITTANCE].ToString() == "Oui";

            string sensTexte = row[COL_SENS].ToString();
            string positionTexte = row[COL_POSITION].ToString();

            cboSensCreaRecette.SelectedItem = sensTexte;
            cboPositionCreaRecette.SelectedItem = positionTexte;

            cboTempsCreaRecette.SelectedItem = row[COL_TEMPS_ATTENTE].ToString();

            btnValiderCreaRecette.Text = "Modifier l'opération";
        }




        private void grdOperationCreaRecette_SelectionChanged(object sender, EventArgs e)
        {
            if (chargementEnCours)
            {
                return;
            }

            DataGridView dgv = sender as DataGridView ?? grdOperationCreaRecette;
            if (dgv?.CurrentRow == null)
            {
                indexOperationSelectionnee = -1;
                return;
            }
            ChargerOperationSelectionnee();
        }


        /// <summary>
        /// Active ou désactive les comboBox du moteur selon si la checkBox moteur est cocher ou non.
        /// Si le moteur n'est pas actif les comboBox sont vidés et desactivés
        /// </summary>
        private void ActivationMoteur()
        {
            bool moteurActif = ckbMoteurCreaRecette.Checked;

            cboSensCreaRecette.Enabled = moteurActif;
            cboPositionCreaRecette.Enabled = moteurActif;

            if (!moteurActif)
            {
                cboSensCreaRecette.SelectedIndex = -1;
                cboSensCreaRecette.SelectedIndex = -1;
            }
        }


        private void ActivationCycleVerin()
        {
            if (ckbCycleVerinCreaRecette.Checked)
            {
                cboTempsCreaRecette.SelectedItem = "0";
                cboTempsCreaRecette.Enabled = false;
            }
            else
            {
                cboTempsCreaRecette.Enabled = true;
            }
        }

        private void ckbMoteurCreaRecette_CheckedChanged(object sender, EventArgs e)
        {
            ActivationMoteur();
        }

        private void ckbCycleVerinCreaRecette_CheckedChanged(object sender, EventArgs e)
        {
            ActivationCycleVerin();
        }
    }





}