using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class FrmDetailsRecette : Form
    {

        private const string COL_NOM_OPERATION = "Nom opération";
        private const string COL_SENS = "Sens";
        private const string COL_POSITION = "Position";
        private const string COL_TEMPS_ATTENTE = "Temps d'attente";
        private const string COL_CYCLE_VERIN = "Cycle vérin";
        private const string COL_QUITTANCE = "Quittance";


        private Recette recette;

        public FrmDetailsRecette(Recette recetteSelectionnee)
        {
            InitializeComponent();

            recette = recetteSelectionnee;

            this.Text = " Détail de la recette : " + recette.NomRecette;

            ChargerOperationRecette();

        }

        private void ChargerOperationRecette()
        {

            DataTable table = new DataTable();

            table.Columns.Add(COL_NOM_OPERATION);
            table.Columns.Add (COL_SENS);
            table.Columns.Add (COL_POSITION);
            table.Columns.Add (COL_TEMPS_ATTENTE);
            table.Columns.Add(COL_CYCLE_VERIN);
            table.Columns.Add(COL_QUITTANCE);

            if (recette.Operations != null)

            {

                foreach (OperationRecette operation in recette.Operations)
                {
                    table.Rows.Add(
                    operation.NomOperation,
                    operation.Sens,
                    operation.Position,
                    operation.TempsAttente,
                    operation.CycleVerin ? "Oui" : "Non",
                    operation.Quittance ? "Oui" : "Non"
                       );

                }

            }

            grdDetailsRecette.DataSource = table;

            grdDetailsRecette.ReadOnly = true;
            grdDetailsRecette.AllowUserToAddRows = false;
            grdDetailsRecette.AllowUserToDeleteRows = false;
            grdDetailsRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdDetailsRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdDetailsRecette.MultiSelect = false;

            if (table.Rows.Count == 0)
            {
                MessageBox.Show("Aucune opération trouvée pour cette recette");
            }
       }
    }
}
