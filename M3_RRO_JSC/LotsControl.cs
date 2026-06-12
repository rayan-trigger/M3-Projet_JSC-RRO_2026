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

        private const int ValeurInactive = 0;

        public LotsControl()
        {
            InitializeComponent();

            InitialiserGrilleLots();
            ChargerLots();
        }


        /// <summary>
        /// Initialise les colonnes du tableau d'affichage des lots.
        /// </summary>
        private void InitialiserGrilleLots()
        {
            grdGestionLots.Columns.Clear();

            grdGestionLots.Columns.Add("DateCreation", "Date de création");
            grdGestionLots.Columns.Add("NomLot", "Nom du lot");
            grdGestionLots.Columns.Add("QuantitePieces", "Quantité pièces");
            grdGestionLots.Columns.Add("Recette", "Recette");

            grdGestionLots.ReadOnly = true;
            grdGestionLots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdGestionLots.MultiSelect = false;
            grdGestionLots.AllowUserToAddRows = false;
            grdGestionLots.AllowUserToDeleteRows = false;
            grdGestionLots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        /// <summary>
        /// Récupère tous les lots enregistrés dans la base de données et met à jour le DataGridView d'affichage des lots.
        /// </summary>
        private void ChargerLots()
        {
            if (DBManager.ParametresConnexionValides())
            {

                LotData.ListeLots = LotManager.GetAllLots();

                grdGestionLots.Rows.Clear();

                foreach (Lot lot in LotData.ListeLots)
                {
                    grdGestionLots.Rows.Add(
                        lot.DateCreation,
                        lot.NomLot,
                        lot.QuantitePieces,
                        lot.RecetteAssociee.NomRecette
                    );
                }
            }
        }


        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        /// <summary>
        /// Ouvre le formulaire de création d'un lot, si le lot est créé correctement, la liste des lots est rechargée depuis la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreer_Click(object sender, EventArgs e)
        {
            FrmCreationLot popup = new FrmCreationLot();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerLots();
            }
        }


        /// <summary>
        /// Ouvre le formulaire de modification du lot sélectionné si celui-ci est encore modifiable,après modification, 
        /// la liste des lots est rechargée depuis la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierLot_Click(object sender, EventArgs e)
        {
            if (grdGestionLots.CurrentRow != null)
            {
                int index = grdGestionLots.CurrentRow.Index;

                if (index >= ValeurInactive && index < LotData.ListeLots.Count)
                {
                    Lot lotSelectionne = LotData.ListeLots[index];

                    if (DBManager.ParametresConnexionValides())
                    {
                        if (LotManager.LotBloque(lotSelectionne.IdLot))
                        {
                            MessageBox.Show(
                                "Ce lot ne peut plus être modifié car il n'est plus en attente.",
                                "Modification impossible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            FrmCreationLot popup = new FrmCreationLot(lotSelectionne);

                            if (popup.ShowDialog() == DialogResult.OK)
                            {
                                ChargerLots();
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Sélection invalide.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un lot à modifier.");
            }
        }



        /// <summary>
        /// Supprime le lot sélectionné si celui-ci est encore en attente,puis recharge la liste des lots depuis la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bool suppressionDemandee = false;

            if (grdGestionLots.CurrentRow != null)
            {
                int index = grdGestionLots.CurrentRow.Index;

                if (index >= ValeurInactive && index < LotData.ListeLots.Count)
                {
                    Lot lotSelectionne = LotData.ListeLots[index];

                    DialogResult result = MessageBox.Show(
                        "Voulez-vous vraiment supprimer ce lot ?",
                        "Confirmation",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        LotManager.DeleteLot(lotSelectionne.IdLot);
                        suppressionDemandee = true;
                    }
                }
                else
                {
                    MessageBox.Show("Sélection invalide.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un lot à supprimer.");
            }

            if (suppressionDemandee)
            {
                ChargerLots();
            }
        }
    }
}
       
            

