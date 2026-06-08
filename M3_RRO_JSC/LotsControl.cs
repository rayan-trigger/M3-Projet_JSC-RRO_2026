using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class LotsControl : UserControl
    {
        public LotsControl()
        {
            InitializeComponent();

            ChargerLots();
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            FrmCreationLot popup = new FrmCreationLot();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerLots();
            }
        }


        private void ChargerLots()
        {
            grdGestionLots.Rows.Clear();
            grdGestionLots.Columns.Clear();

            grdGestionLots.Columns.Add("DateCreation", "Date de création");
            grdGestionLots.Columns.Add("NomLot", "Nom du lot");
            grdGestionLots.Columns.Add("QuantitePieces", "Quantité pièces");
            grdGestionLots.Columns.Add("Recette", "Recette");

            foreach (Lot lot in LotData.ListeLots)
            {
                grdGestionLots.Rows.Add(
                    lot.DateCreation.ToString("dd/MM/yyyy HH:mm"),
                    lot.NomLot,
                    lot.QuantitePieces,
                    lot.RecetteAssociee != null ? lot.RecetteAssociee.NomRecette : ""
                );
            }

            grdGestionLots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdGestionLots.AllowUserToAddRows = false;
        }

        private void btnModifierLot_Click(object sender, EventArgs e)
        {
            if(grdGestionLots.CurrentRow == null)
            {
                MessageBox.Show("Veuillet selectionner un lot a modifier");
                return;
            }

            int index = grdGestionLots.CurrentRow.Index;

            if ( index < 0 ||index >= LotData.ListeLots.Count)
            {
                MessageBox.Show(" Selection invalide");
            }

           Lot lotSelectionne = LotData.ListeLots[index];

            FrmCreationLot popup = new FrmCreationLot(lotSelectionne);

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerLots();
            }

        }



        

    }
}
