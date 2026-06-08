using MySqlX.XDevAPI.Relational;
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
    public partial class RecettesControl : UserControl
    {
        public RecettesControl()
        {
            InitializeComponent();

            RecetteData.ListeRecettes = RecetteManager.GetAllRecette();

            ChargerRecettes();


        }
        private void ChargerRecettes()
        {
            grdRecette.Rows.Clear();
            grdRecette.Columns.Clear();

            grdRecette.Columns.Add("IdRecette", "ID");
            grdRecette.Columns.Add("DateCraetion", "Date de création");
            grdRecette.Columns.Add("NomRecette", "Nom de la recette");

            foreach (Recette recette in RecetteData.ListeRecettes)
            {
                grdRecette.Rows.Add(
                    recette.IdRecette,
                    recette.DateCreation.ToString("dd/MM/yyyy HH:mm"),
                    recette.NomRecette,
                    recette.Operations.Count
                );
            }

            grdRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdRecette.AllowUserToAddRows = false;
            grdRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdRecette.MultiSelect = false;

        }

        private void ChargerOperationsRecetteSelectionner()

        {
            grdOperationRecette.Rows.Clear();
            grdOperationRecette.Columns.Clear();

            grdOperationRecette.Columns.Add("NomOperation", "NomOperation");
            grdOperationRecette.Columns.Add("MoteurActif", "MoteurActif");
            grdOperationRecette.Columns.Add("Sens", "Sens");
            grdOperationRecette.Columns.Add("Position", "Position");
            grdOperationRecette.Columns.Add("TempsAttente", "TempsAttente");
            grdOperationRecette.Columns.Add("CycleVerin", "CycleVerin");
            grdOperationRecette.Columns.Add("Quitance", "Quittance");

            if (grdRecette.CurrentRow == null)
            {
                return;
            }

            int index = grdRecette.CurrentRow.Index;

            if (index < 0 || index >= RecetteData.ListeRecettes.Count)
            {
                return;
            }

            Recette recetteSelectionnee = RecetteData.ListeRecettes[index];

            foreach (OperationRecette operation in recetteSelectionnee.Operations)
            {
                grdOperationRecette.Rows.Add(
                    operation.NomOperation,
                    operation.MoteurActif ? "Oui" : "Non",
                    operation.Sens,
                    operation.Position,
                    operation.TempsAttente,
                    operation.CycleVerin ? "Oui" : "Non",
                    operation.Quittance ? "Oui" : "Non"
                       );
                grdOperationRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                grdOperationRecette.AllowUserToAddRows = false;
                grdOperationRecette.ReadOnly = true;
            }

        }


        private void InitialiserDataGridAvecTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Date et heure de création");
            table.Columns.Add("Nom du Pas");
            table.Columns.Add("Position Indexeur");
            table.Columns.Add("Sens Indexeur");
            table.Columns.Add("Nombre de Tour");
            table.Columns.Add("Temps d'arrêt");
            table.Columns.Add("Cycle Verin");
            table.Columns.Add("Quittance");

            table.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Pas 1", "100", "Avant", "2", "5", "Cycle 1", "OK");
            table.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Pas 2", "200", "Arrière", "1", "3", "Cycle 2", "OK");
            table.Rows.Add(DateTime.Now.ToString("dd/MM/yyyy HH:mm"), "Pas 3", "300", "Avant", "4", "2", "Cycle 3", "NOK");

            grdRecette.DataSource = table;
        }

        private void btnCreerRecette_Click(object sender, EventArgs e)
        {
            FrmCreationRecette popup = new FrmCreationRecette();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerRecettes();
            }
        }

        private void btnModifierRecette_Click(object sender, EventArgs e)
        {
            if (grdRecette.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une recette à modifier.");
                return;
            }

            int index = grdRecette.CurrentRow.Index;

            if (index < 0 || index >= RecetteData.ListeRecettes.Count)
            {
                MessageBox.Show("Sélection invalide.");
                return;
            }

            Recette recetteSelectionnee = RecetteData.ListeRecettes[index];

            FrmCreationRecette popup = new FrmCreationRecette(recetteSelectionnee);

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerRecettes();
            }
        }

        private void btnSupprimerRecette_Click(object sender, EventArgs e)
        {
            if (grdRecette.CurrentRow == null)
            {
                MessageBox.Show("Veuillez sélectionner une recette à supprimer");
                return;
            }


            int index = grdRecette.CurrentRow.Index;

            if (index < 0 || index >= RecetteData.ListeRecettes.Count)
            {
                MessageBox.Show("Selection invalide");
                return;
            }

            Recette recetteSlectionne = RecetteData.ListeRecettes[index];

            DialogResult confirmation = MessageBox.Show(
                "Voulez-vous vraiment supprimer la recette : " + recetteSlectionne.NomRecette + "?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            RecetteData.ListeRecettes.RemoveAt(index);

            ChargerRecettes();

            MessageBox.Show("Recette supprimée avec succès.");

        }




      

        private void grdRecette_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Sélection détectée");
            ChargerOperationsRecetteSelectionner();
        }
    }

}
