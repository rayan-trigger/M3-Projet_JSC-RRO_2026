// Fichier: FrmCreationRecette.cs
// Description: Formulaire pour créer ou modifier une recette. Gère l'interface utilisateur
// et la logique locale pour ajouter, modifier et supprimer des opérations avant
// l'enregistrement en base de données.
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;
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

namespace M3_RRO_JSC
{
    public partial class FrmCreationRecette : Form

    {
        private const int AucuneSelection = -1;
        private const int ValeurInactive = 0;
        private const long IdInvalide = -1;
        private const int PremierNumeroOperation = 1;

        private const string TexteOui = "Oui";
        private const string TexteNon = "Non";
        private const string TexteVide = "";
        private const string TempsAttenteDefaut = "0";

        private const string SensHoraire = "Horaire";
        private const string SensAntiHoraire = "AntiHoraire";

        private const string Position3h = "3h";
        private const string Position6h = "6h";
        private const string Position9h = "9h";
        private const string Position12h = "12h";

        private const int TempsAttenteMin = 0;
        private const int TempsAttenteMax = 10;


        private const string COL_NOM_OPERATION = "Nom opération";
        private const string COL_SENS = "Sens";
        private const string COL_POSITION = "Position";
        private const string COL_TEMPS_ATTENTE = "Temps d'attente";
        private const string COL_CYCLE_VERIN = "Cycle vérin";
        private const string COL_QUITTANCE = "Quittance";

        private DataTable tableOperations;

        private Recette recetteAModifier = null; // Contient la recette que l'on veut modifier 

        private bool modeModification = false;  // Savoir si on est en mode création ou en mode modification

        private int indexOperationSelectionnee = AucuneSelection;

        private bool chargementEnCours = false;

        public FrmCreationRecette()
        {
            InitializeComponent();

            InitialiserComboBox();
            InitialiserTableOperations();
            ActivationMoteur();
            ActivationCycleVerin();
            ChargerToutesOperations();

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
            ChargerToutesOperations();
        }

        /// <summary>
        /// Initialise les comboBox du formulaire création recette.
        /// </summary>
        private void InitialiserComboBox()

        {
            cboSensCreaRecette.DataSource = null;
            cboSensCreaRecette.Items.Clear();
            cboSensCreaRecette.Items.Add(SensHoraire);
            cboSensCreaRecette.Items.Add(SensAntiHoraire);
            cboSensCreaRecette.SelectedIndex = AucuneSelection;

            cboPositionCreaRecette.DataSource = null;
            cboPositionCreaRecette.Items.Clear();
            cboPositionCreaRecette.Items.Add(Position3h);
            cboPositionCreaRecette.Items.Add(Position6h);
            cboPositionCreaRecette.Items.Add(Position9h);
            cboPositionCreaRecette.Items.Add(Position12h);
            cboPositionCreaRecette.SelectedIndex = AucuneSelection;


            cboTempsCreaRecette.Items.Clear();

            for (int temps = TempsAttenteMin; temps <= TempsAttenteMax; temps++)
            {
                cboTempsCreaRecette.Items.Add(temps.ToString());
            }


            cboTempsCreaRecette.SelectedIndex = AucuneSelection;
        }

        /// <summary>
        /// Initialise le tableau temporaire des opérations de la recette,ce tableau sert à afficher les opérations 
        /// dans la grille avant l'enregistrement en base de données.
        /// </summary>
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


        /// <summary>
        /// Vérifie que les champs nécessaires à l'ajout ou à la modification d'une opération sont valides.
        /// </summary>
        /// <returns> True si les champs sont valides, sinon false </returns>
        private bool OperationValide()
        {
            bool operationValide = true;

            if (string.IsNullOrWhiteSpace(txtNomOperation.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de l'opération.");
                txtNomOperation.Focus();
                operationValide = false;
            }

            else if (ckbMoteurCreaRecette.Checked && cboSensCreaRecette.SelectedIndex == AucuneSelection)
            {
                MessageBox.Show("Veuillez sélectionner le sens du moteur.");
                cboSensCreaRecette.Focus();
                operationValide = false;
            }

            else if (ckbMoteurCreaRecette.Checked && cboPositionCreaRecette.SelectedIndex == AucuneSelection)
            {
                MessageBox.Show("Veuillez sélectionner la position du moteur.");
                cboPositionCreaRecette.Focus();
                operationValide = false;
            }

            else if (!ckbCycleVerinCreaRecette.Checked && cboTempsCreaRecette.SelectedIndex == AucuneSelection)
            {
                MessageBox.Show("Veuillez sélectionner le temps d'attente.");
                cboTempsCreaRecette.Focus();
                operationValide = false;
            }
            return operationValide;
        }


        /// <summary>
        /// Vide les champs de saisie d'une opération et remet le formulaire en mode ajout.
        /// La sélection de la grille est aussi supprimée afin d'éviter de modifier une ancienne opération sélectionnée.
        /// </summary>
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
        /// Vérifie que la recette possède un nom et au moins une opération.
        /// </summary>
        /// <returns>True si la recette est valide, sinon false.</returns>
        private bool RecetteValide()
        {
            bool recetteValide = true;

            if (string.IsNullOrWhiteSpace(txtNomCreaLot.Text))
            {
                MessageBox.Show("Veuillez saisir le nom de la recette.");
                txtNomCreaLot.Focus();
                recetteValide = false;
            }

            else if (tableOperations.Rows.Count == ValeurInactive)
            {
                MessageBox.Show("Veuillez ajouter au moins une opération à la recette.");
                txtNomOperation.Focus();
                recetteValide = false;
            }
            return recetteValide;
        }


        /// <summary>
        /// Charge les informations de la recette à modifier et met à jour les champs du formulaire, les opérations de la recette sont 
        /// aussi ajoutées dans le tableau temporaire des opérations.
        /// </summary>
        private void ChargerRecetteAModifier()
        {
            if (recetteAModifier != null)
            {
                txtNomCreaLot.Text = recetteAModifier.NomRecette;

                tableOperations.Rows.Clear();

                foreach (OperationRecette operation in recetteAModifier.Operations)
                {
                    tableOperations.Rows.Add(
                        operation.NomOperation,
                        operation.Sens,
                        operation.Position,
                        operation.TempsAttente,
                        operation.CycleVerin ? TexteOui : TexteNon,
                        operation.Quittance ? TexteOui : TexteNon
                    );
                }
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
        /// Crée une nouvelle recette avec ses opérations et l'enregistre dans la base de données.
        /// </summary>
        /// <returns>True si la recette est crée sinon false.</returns>
        private bool CreerNouvelleRecette()
        {
            bool recetteCree = false;
            Recette nouvelleRecette = new Recette();

            nouvelleRecette.NomRecette = txtNomCreaLot.Text.Trim();
            nouvelleRecette.DateCreation = DateTime.Now;

            foreach (DataRow row in tableOperations.Rows)
            {
                OperationRecette operation = CreerOperationDepuisLigne(row);
                nouvelleRecette.Operations.Add(operation);
            }

            long idRecette = RecetteManager.CreateRecette(nouvelleRecette.NomRecette);

            if (idRecette != IdInvalide)
            {
                int numeroOperation = PremierNumeroOperation;
                bool operationsEnregistrees = true;

                foreach (OperationRecette operation in nouvelleRecette.Operations)
                {
                    long idOperation = RecetteManager.CreateOperation(operation);

                    if (idOperation != IdInvalide)
                    {
                        RecetteManager.AjouterOperationRecette(idRecette, idOperation, numeroOperation);
                        numeroOperation++;
                    }
                    else
                    {
                        operationsEnregistrees = false;
                    }
                }

                if (operationsEnregistrees)
                {
                    MessageBox.Show("Recette enregistré avec succés");
                    recetteCree = true;
                }
                else
                {
                    MessageBox.Show("Une opération n'a pas pu être enregistrée dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("la recette n'a pas pu être enregistrer dans la base de donnée.");
            }
            return recetteCree;
        }


        /// <summary>
        /// Modifie la recette existante avec les informations saisies dans le formulaire,puis enregistre les changements dans la base de données.
        /// </summary>
        /// <returns>true si la recette est modifiée, sinon false.</returns>
        private bool ModifierRecetteExistante()
        {
            bool recetteModifier = false;

            if (recetteAModifier != null)
            {
                // Modification du nom de la recette avec le texte saisi.
                recetteAModifier.NomRecette = txtNomCreaLot.Text.Trim();

                //On vide l'ancienne liste d'opérations de l'objet recette.
                recetteAModifier.Operations.Clear();

                foreach (DataRow row in tableOperations.Rows)
                {
                    OperationRecette operation = CreerOperationDepuisLigne(row);
                    recetteAModifier.Operations.Add(operation);
                }

                //Enregistrement des modifications dans la base de données.
                RecetteManager.UpDateRecette(recetteAModifier);

                MessageBox.Show("Recette modifiée avec succès.");
                recetteModifier = true;
            }
            else
            {
                MessageBox.Show("Impossible de modifier la recette");
            }
            return recetteModifier;
        }


        /// <summary>
        /// Charge dans les champs du formulaire les informations de l'opération sélectionnée dans le tableau temporaire des opérations,
        /// cela permet ensuite de modifier cette opération.
        /// </summary>
        private void ChargerOperationSelectionnee()
        {
            if (grdOperationCreaRecette.CurrentRow != null)
            {
                int index = grdOperationCreaRecette.CurrentRow.Index;

                if (index >= ValeurInactive && index < tableOperations.Rows.Count)
                {
                    DataRow row = tableOperations.Rows[index];

                    if (row.RowState != DataRowState.Deleted && row.RowState != DataRowState.Detached)
                    {
                        indexOperationSelectionnee = index;

                        txtNomOperation.Text = row[COL_NOM_OPERATION].ToString();

                        string sensTexte = row[COL_SENS].ToString();
                        string positionTexte = row[COL_POSITION].ToString();

                        ckbMoteurCreaRecette.Checked = !string.IsNullOrWhiteSpace(sensTexte)
                                                     && !string.IsNullOrWhiteSpace(positionTexte);

                        ActivationMoteur();

                        cboSensCreaRecette.SelectedItem = sensTexte;
                        cboPositionCreaRecette.SelectedItem = positionTexte;

                        ckbCycleVerinCreaRecette.Checked = row[COL_CYCLE_VERIN].ToString() == TexteOui;
                        ActivationCycleVerin();

                        if (ckbCycleVerinCreaRecette.Checked)
                        {
                            cboTempsCreaRecette.SelectedItem = TempsAttenteDefaut;
                        }
                        else
                        {
                            cboTempsCreaRecette.SelectedItem = row[COL_TEMPS_ATTENTE].ToString();
                        }

                        ckbQuittanceCreaRecette.Checked = row[COL_QUITTANCE].ToString() == TexteOui;

                        btnValiderCreaRecette.Text = "Modifier l'opération";
                    }
                }
            }
        }


        /// <summary>
        /// Charge les informations de l'opération sélectionnée lorsque la sélection change dans la grille, Si le formulaire est en cours de chargement, 
        /// aucune action n'est effectuée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdOperationCreaRecette_SelectionChanged(object sender, EventArgs e)
        {
            if (!chargementEnCours)
            {
                if (grdOperationCreaRecette.CurrentRow != null)
                {
                    ChargerOperationSelectionnee();
                }
                else
                {
                    indexOperationSelectionnee = AucuneSelection;
                }
            }
        }


        /// <summary>
        /// Active ou désactive les ComboBox du moteur selon l'état de la CheckBox moteur, Si le moteur n'est pas actif, 
        /// les ComboBox sont vidées et désactivées.
        /// </summary>
        private void ActivationMoteur()
        {
            bool moteurActif = ckbMoteurCreaRecette.Checked;

            cboSensCreaRecette.Enabled = moteurActif;
            cboPositionCreaRecette.Enabled = moteurActif;

            if (!moteurActif)
            {
                cboSensCreaRecette.SelectedIndex = AucuneSelection;
                cboPositionCreaRecette.SelectedIndex = AucuneSelection;
            }
        }


        /// <summary>
        /// Active ou désactive le temps d'attente selon l'état du cycle vérin, si le cycle verin est actif le temps d'attente est forcé a 0.
        /// </summary>
        private void ActivationCycleVerin()
        {
            if (ckbCycleVerinCreaRecette.Checked)
            {
                cboTempsCreaRecette.SelectedItem = TempsAttenteDefaut;
                cboTempsCreaRecette.Enabled = false;
            }
            else
            {
                cboTempsCreaRecette.Enabled = true;
            }
        }

        /// <summary>
        /// Recharge toutes les opérations enregistrées dans la base de données et les affiche dans la grille des opérations disponibles.
        /// </summary>
        private void ChargerToutesOperations()
        {
            grdToutesOperationsCreaRecette.Rows.Clear();
            grdToutesOperationsCreaRecette.Columns.Clear();

            grdToutesOperationsCreaRecette.Columns.Add("IdOperation", "ID");
            grdToutesOperationsCreaRecette.Columns.Add("NomOperation", "Nom opération");
            grdToutesOperationsCreaRecette.Columns.Add("Sens", "Sens");
            grdToutesOperationsCreaRecette.Columns.Add("Position", "Position");
            grdToutesOperationsCreaRecette.Columns.Add("TempsAttente", "Temps attente");
            grdToutesOperationsCreaRecette.Columns.Add("CycleVerin", "Cycle vérin");
            grdToutesOperationsCreaRecette.Columns.Add("Quittance", "Quittance");

            List<OperationRecette> operations = RecetteManager.GetAllOperations();

            foreach (OperationRecette operation in operations)
            {
                grdToutesOperationsCreaRecette.Rows.Add(
                    operation.IdOperation,
                    operation.NomOperation,
                    operation.Sens,
                    operation.Position,
                    operation.TempsAttente,
                    operation.CycleVerin ? TexteOui : TexteNon,
                    operation.Quittance ? TexteOui : TexteNon
                );
            }

            grdToutesOperationsCreaRecette.Columns["IdOperation"].Visible = false;

            grdToutesOperationsCreaRecette.ReadOnly = true;
            grdToutesOperationsCreaRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdToutesOperationsCreaRecette.MultiSelect = false;
            grdToutesOperationsCreaRecette.AllowUserToAddRows = false;
            grdToutesOperationsCreaRecette.AllowUserToDeleteRows = false;
            grdToutesOperationsCreaRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        /// <summary>
        /// Ajoute une nouvelle opération dans le tableau temporaire ou modifie l'opération sélectionnée,les données seront enregistrées
        /// en base seulement lorsque la recette sera enregistrée.
        /// </summary>
        /// <param name="sender"</param>
        /// <param name="e"></param>
        private void btnValiderCreaRecette_Click(object sender, EventArgs e)
        {
            if (OperationValide())
            {
                string sens = TexteVide;
                string position = TexteVide;
                string temps = TempsAttenteDefaut;

                if (ckbMoteurCreaRecette.Checked)
                {
                    sens = cboSensCreaRecette.SelectedItem.ToString();
                    position = cboPositionCreaRecette.SelectedItem.ToString();
                }

                if (!ckbCycleVerinCreaRecette.Checked)
                {
                    temps = cboTempsCreaRecette.SelectedItem.ToString();
                }

                if (indexOperationSelectionnee == AucuneSelection)
                {
                    tableOperations.Rows.Add(
                        txtNomOperation.Text.Trim(),
                        sens,
                        position,
                        temps,
                        ckbCycleVerinCreaRecette.Checked ? TexteOui : TexteNon,
                        ckbQuittanceCreaRecette.Checked ? TexteOui : TexteNon
                    );
                }
                else
                {
                    DataRow row = tableOperations.Rows[indexOperationSelectionnee];

                    row[COL_NOM_OPERATION] = txtNomOperation.Text.Trim();
                    row[COL_SENS] = sens;
                    row[COL_POSITION] = position;
                    row[COL_TEMPS_ATTENTE] = temps;
                    row[COL_CYCLE_VERIN] = ckbCycleVerinCreaRecette.Checked ? TexteOui : TexteNon;
                    row[COL_QUITTANCE] = ckbQuittanceCreaRecette.Checked ? TexteOui : TexteNon;
                }

                ViderChampsOperation();
            }
        }


        /// <summary>
        /// Valide la recette puis crée ou modifie la recette selon le mode du formulaire, si l'opération réussit, le formulaire se ferme avec le résultat OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrerCreaRecette_Click(object sender, EventArgs e)
        {
            bool operationReussie = false;

            //Vérifie que le nom de la recette est saisi et qu'au moins une opération a été ajoutée.
            if (RecetteValide())
            {
                if (modeModification)
                {
                    operationReussie = ModifierRecetteExistante();
                }
                else
                {
                    operationReussie = CreerNouvelleRecette();
                }
            }

            if (operationReussie)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        /// <summary>
        /// Annule la création ou la modification de la recette,
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerCreaRecette_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Supprime l'opération sélectionnée dans le tableau temporaire des opérations, la suppression n'est pas directement enregistrée en base de données.
        /// elle sera prise en compte seulement lorsque l'utilisateur enregistrera la recette.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerCreaRecette_Click(object sender, EventArgs e)
        {
            if (indexOperationSelectionnee >= ValeurInactive && indexOperationSelectionnee < tableOperations.Rows.Count)
            {
                DialogResult result = MessageBox.Show(
                    "Supprimer l'opération sélectionnée ?",
                    "Confirmation",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    tableOperations.Rows.RemoveAt(indexOperationSelectionnee);
                    indexOperationSelectionnee = AucuneSelection;
                    ViderChampsOperation();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une opération à supprimer.");
            }
        }



        /// <summary>
        /// CheckBox du moteur activé dans le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbMoteurCreaRecette_CheckedChanged(object sender, EventArgs e)
        {
            ActivationMoteur();
        }





        /// <summary>
        /// CheckBox du cycle vérin dans le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ckbCycleVerinCreaRecette_CheckedChanged(object sender, EventArgs e)
        {
            ActivationCycleVerin();
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerOperation_Click(object sender, EventArgs e)
        {
            if (grdToutesOperationsCreaRecette.CurrentRow != null)
            {
                int idOperation = Convert.ToInt32(grdToutesOperationsCreaRecette.CurrentRow.Cells["IdOperation"].Value);

                DialogResult confirmation = MessageBox.Show(
                    "Voulez-vous vraiment supprimer cette opération ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmation == DialogResult.Yes)
                {
                    RecetteManager.DeleteOperation(idOperation);
                    ChargerToutesOperations();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une opération à supprimer.");
            }
        }

        private void btnIntroduireOpeCreaRecette_Click(object sender, EventArgs e)
        {
            if (grdToutesOperationsCreaRecette.CurrentRow != null)
            {
                DataGridViewRow sourceRow = grdToutesOperationsCreaRecette.CurrentRow;

                string nom = sourceRow.Cells["NomOperation"].Value?.ToString() ?? string.Empty;
                string sens = sourceRow.Cells["Sens"].Value?.ToString() ?? string.Empty;
                string position = sourceRow.Cells["Position"].Value?.ToString() ?? string.Empty;
                string temps = sourceRow.Cells["TempsAttente"].Value?.ToString() ?? TempsAttenteDefaut;
                string cycle = sourceRow.Cells["CycleVerin"].Value?.ToString() ?? TexteNon;
                string quittance = sourceRow.Cells["Quittance"].Value?.ToString() ?? TexteNon;

                if (string.IsNullOrWhiteSpace(nom))
                {
                    MessageBox.Show("Opération invalide.");
                    return;
                }

                // Empêcher l'ajout d'un doublon exact
                foreach (DataRow existing in tableOperations.Rows)
                {
                    if (existing[COL_NOM_OPERATION].ToString() == nom
                        && existing[COL_SENS].ToString() == sens
                        && existing[COL_POSITION].ToString() == position
                        && existing[COL_TEMPS_ATTENTE].ToString() == temps
                        && existing[COL_CYCLE_VERIN].ToString() == cycle
                        && existing[COL_QUITTANCE].ToString() == quittance)
                    {
                        MessageBox.Show("Cette opération est déjà présente dans la recette.");
                        return;
                    }
                }

                tableOperations.Rows.Add(nom, sens, position, temps, cycle, quittance);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une opération à introduire.");
            }
        }
    }

}