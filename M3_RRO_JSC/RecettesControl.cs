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

            ChargerRecettes();


        }
        private void ChargerRecettes()
        {
            grdRecette.Rows.Clear();
            grdRecette.Columns.Clear();

            grdRecette.Columns.Add("DateCreation", "Date de création");
            grdRecette.Columns.Add("NomRecette", "Nom de la recette");
            grdRecette.Columns.Add("NbOperations", "Nombre d'opérations");

            foreach (Recette recette in RecetteData.ListeRecettes)
            {
                grdRecette.Rows.Add(
                    recette.DateCreation.ToString("dd/MM/yyyy HH:mm"),
                    recette.NomRecette,
                    recette.Operations.Count
                );
            }

            grdRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdRecette.AllowUserToAddRows = false;
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
    }

}
