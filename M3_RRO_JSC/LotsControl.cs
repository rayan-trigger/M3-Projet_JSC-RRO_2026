using Org.BouncyCastle.Cmp;
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

            grdGestionLots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdGestionLots.MultiSelect = false;
            grdGestionLots.AllowUserToAddRows = false;
        }

        private void btnModifierLot_Click(object sender, EventArgs e)
        {
            if (grdGestionLots.CurrentRow == null)
            {
                MessageBox.Show("Veuillet selectionner un lot a modifier");
                return;
            }

            int index = grdGestionLots.CurrentRow.Index;

            if (index < 0 || index >= LotData.ListeLots.Count)
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

        private void btnSupprimerLot_Click(object sender, EventArgs e)
        {
            if (grdGestionLots.CurrentRow == null)
            {
                MessageBox.Show(" Veuillez selctionner un lot a supprimer");
                return;
            }

            int index = grdGestionLots.CurrentRow.Index;

            if (index < 0 || index >= LotData.ListeLots.Count)
            {
                MessageBox.Show("Selection invalide");
                return;
            }

            Lot lotSelectionner = LotData.ListeLots[index];

            DialogResult confirmation = MessageBox.Show(
                "Voulez-Vous vraiment supprimer le lot : " + lotSelectionner.NomLot + " ?",
                "Confirmation de suppression ",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );

            if (confirmation != DialogResult.Yes)
            {
                return;
            }

            LotData.ListeLots.RemoveAt(index);

            ChargerLots();

            MessageBox.Show("Lot supprimer avec succès.");
        }

        private void btnEnvoyerProductionLot_Click(object sender, EventArgs e)
        {
            if (grdGestionLots.CurrentRow == null )
            {
                MessageBox.Show("Veuillez sélectionner un lot à envoyer en production.");
                return;
                 
            }

            int index = grdGestionLots.CurrentRow.Index;

            if (index <  0 || index >= LotData.ListeLots.Count)
            {
                MessageBox.Show("Sélection invalide.");
            }

            Lot lotSelectionne = LotData.ListeLots [index];

            DialogResult confirmation = MessageBox.Show(
                "Voulez-vous envoyer le lot ' " + lotSelectionne.NomLot + " ' en production ?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ); 

            if (confirmation  != DialogResult.Yes )
            {
                return;
            }
             
            LotData.LotEnProduction = lotSelectionne;

            MessageBox.Show("L e lot '" + lotSelectionne.NomLot + "' a été envoyé en production.");
        
        }
    }
}
