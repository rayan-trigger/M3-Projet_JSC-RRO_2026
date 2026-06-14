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
        //Empêche l'événement du filtre de s'exécuter pendant l'initialisation de la ComboBox.
        private bool chargementFiltresEnCours = false;

        // Contient la liste des lots actuellement affichés dans la grille, elle permet de modifier ou supprimer le bon lot même lorsqu'un filtre est actif.
        private List<Lot> lotsAffiches = new List<Lot>();

        private const int ValeurInactive = 0;

        private const string FiltreTous = "Tous";
        private const string EtatEnAttente = "En attente";
        private const string EtatEnCours = "En cours";
        private const string EtatTermine = "Terminé";
        private const string EtatErreur = "Erreur";
        private const string TexteVide = "";

        
        public LotsControl()
        {
            InitializeComponent();

            InitialiserGrilleLots();

            InitialiserFiltresLots();
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
            grdGestionLots.Columns.Add("Etat", "État");


            grdGestionLots.ReadOnly = true;
            grdGestionLots.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdGestionLots.MultiSelect = false;
            grdGestionLots.AllowUserToAddRows = false;
            grdGestionLots.AllowUserToDeleteRows = false;
            grdGestionLots.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Initialise la ComboBox de filtre des lots avec les différents états possibles.
        /// </summary>
        private void InitialiserFiltresLots()
        {
            chargementFiltresEnCours = true;

            cboFiltresLots.Items.Clear();

            cboFiltresLots.Items.Add(FiltreTous);
            cboFiltresLots.Items.Add(EtatEnAttente);
            cboFiltresLots.Items.Add(EtatEnCours);
            cboFiltresLots.Items.Add(EtatTermine);
            cboFiltresLots.Items.Add(EtatErreur);

            cboFiltresLots.SelectedIndex = ValeurInactive;

            chargementFiltresEnCours = false;
        }



        /// <summary>
        /// Récupère tous les lots enregistrés dans la base de données et met à jour le DataGridView d'affichage des lots.
        /// </summary>
        private void ChargerLots()
        {
            if (DBManager.ParametresConnexionValides())
            {
                LotData.ListeLots = LotManager.GetAllLots();
                AfficherLots(LotData.ListeLots);
            }
        }


        /// <summary>
        /// Affiche dans la grille les lots reçus en paramètre, la liste affichée est conservée afin de pouvoir modifier ou supprimer le bon lot même lorsqu'un filtre est actif.

        /// </summary>
        /// <param name="lots">Liste des lots à afficher.</param>
        private void AfficherLots(List<Lot> lots)
        {
            lotsAffiches = lots;

            grdGestionLots.Rows.Clear();

            foreach (Lot lot in lotsAffiches)
            {
                grdGestionLots.Rows.Add(
                    lot.DateCreation.ToString("dd/MM/yyyy HH:mm"),
                    lot.NomLot,
                    lot.QuantitePieces,
                    lot.RecetteAssociee != null ? lot.RecetteAssociee.NomRecette : TexteVide,
                    lot.Etat
                );
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

                if (index >= ValeurInactive && index < lotsAffiches.Count)
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

                if (index >= ValeurInactive && index < lotsAffiches.Count)
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


        /// <summary>
        /// Filtre l'affichage des lots selon l'état sélectionné dans la ComboBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboFiltresLots_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!chargementFiltresEnCours && cboFiltresLots.SelectedItem != null && grdGestionLots.Columns.Count > ValeurInactive)
            {
                List<Lot> lotsFiltres = new List<Lot>();
                string filtreSelectionne = cboFiltresLots.SelectedItem.ToString();

                if (filtreSelectionne == FiltreTous)
                {
                    lotsFiltres = LotData.ListeLots;
                }
                else
                {
                    foreach (Lot lot in LotData.ListeLots)
                    {
                        if (lot.Etat == filtreSelectionne)
                        {
                            lotsFiltres.Add(lot);
                        }
                    }
                }

                AfficherLots(lotsFiltres);
            }
        }

    }
}
       
            

