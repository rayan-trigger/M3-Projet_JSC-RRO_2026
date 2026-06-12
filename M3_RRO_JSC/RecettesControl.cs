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
        private const string TexteOui = "Oui";
        private const string TexteNon = "Non";

        private const int AucuneSelection = -1;
        private const int ValeurInactive = 0;
        private const long IdInvalide = -1;


        public RecettesControl()
        {
            InitializeComponent();


            ChargerRecettes();
        }


        /// <summary>
        /// Recharge les recettes depuis la base de données si les paramètres de connexion sont valides,puis met à jour le tableau d'affichage des recettes.
        /// </summary>
        private void ChargerRecettes()
        {
            if (DBManager.ParametresConnexionValides())
            {
                RecetteData.ListeRecettes = RecetteManager.GetAllRecette();

                grdRecette.Rows.Clear();
                grdRecette.Columns.Clear();

                grdRecette.Columns.Add("IdRecette", "ID");
                grdRecette.Columns.Add("DateCreation", "Date de création");
                grdRecette.Columns.Add("NomRecette", "Nom de la recette");
                grdRecette.Columns.Add("NombreOperations", "Nombre d'opérations");

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

        }


        /// <summary>
        /// Affiche dans le tableau les opérations de la recette sélectionnée.
        /// </summary>
        private void ChargerOperationsRecetteSelectionner()
        {
            grdOperationRecette.Rows.Clear();
            grdOperationRecette.Columns.Clear();

            grdOperationRecette.Columns.Add("NomOperation", "Nom opération");
            grdOperationRecette.Columns.Add("Sens", "Sens");
            grdOperationRecette.Columns.Add("Position", "Position");
            grdOperationRecette.Columns.Add("TempsAttente", "Temps d'attente");
            grdOperationRecette.Columns.Add("CycleVerin", "Cycle vérin");
            grdOperationRecette.Columns.Add("Quittance", "Quittance");

            grdOperationRecette.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdOperationRecette.AllowUserToAddRows = false;
            grdOperationRecette.ReadOnly = true;
            grdOperationRecette.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdOperationRecette.MultiSelect = false;

            if (grdRecette.CurrentRow != null)
            {
                int index = grdRecette.CurrentRow.Index;

                if (index >= ValeurInactive && index < RecetteData.ListeRecettes.Count)
                {
                    Recette recetteSelectionnee = RecetteData.ListeRecettes[index];

                    foreach (OperationRecette operation in recetteSelectionnee.Operations)
                    {
                        grdOperationRecette.Rows.Add(
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
        }


        /// <summary>
        /// Ouvre le formulaire de modification pour la recette sélectionnée si celle-ci n'est pas bloquée par un lot. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModifierRecette_Click(object sender, EventArgs e)
        {
            if (grdRecette.CurrentRow != null)
            {
                int index = grdRecette.CurrentRow.Index;

                if (index >= ValeurInactive && index < RecetteData.ListeRecettes.Count)
                {
                    Recette recetteSelectionnee = RecetteData.ListeRecettes[index];

                    if (DBManager.ParametresConnexionValides())
                    {
                        if (RecetteManager.RecetteEstBloquee(recetteSelectionnee.IdRecette))
                        {
                            MessageBox.Show(
                                "Cette recette ne peut plus être modifiée car elle est utilisée par un lot envoyé en production.",
                                "Modification impossible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            FrmCreationRecette popup = new FrmCreationRecette(recetteSelectionnee);

                            if (popup.ShowDialog() == DialogResult.OK)
                            {
                                ChargerRecettes();
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
                MessageBox.Show("Veuillez sélectionner une recette à modifier.");
            }
        }


        /// <summary>
        /// Supprime la recette sélectionnée si elle n'est utilisée par aucun lot, la liste des recettes est ensuite rechargée depuis la base de données.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerRecette_Click(object sender, EventArgs e)
        {
            if (grdRecette.CurrentRow != null)
            {
                int index = grdRecette.CurrentRow.Index;

                if (index >= ValeurInactive && index < RecetteData.ListeRecettes.Count)
                {
                    Recette recetteSelectionnee = RecetteData.ListeRecettes[index];

                    if (DBManager.ParametresConnexionValides())
                    {
                        if (RecetteManager.RecetteEstUtiliseeParLot(recetteSelectionnee.IdRecette))
                        {
                            MessageBox.Show(
                                "Cette recette ne peut pas être supprimée car elle est utilisée par un lot.",
                                "Suppression impossible",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning
                            );
                        }
                        else
                        {
                            DialogResult confirmation = MessageBox.Show(
                                "Voulez-vous vraiment supprimer la recette : " + recetteSelectionnee.NomRecette + " ?",
                                "Confirmation de suppression",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Warning
                            );

                            if (confirmation == DialogResult.Yes)
                            {
                                RecetteManager.DeleteRecette(recetteSelectionnee.IdRecette);

                                ChargerRecettes();

                                MessageBox.Show("Recette supprimée avec succès.");
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
                MessageBox.Show("Veuillez sélectionner une recette à supprimer.");
            }
        }


        /// <summary>
        /// Ouvre le formulaire de création d'une recette.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreerRecette_Click(object sender, EventArgs e)
        {
            FrmCreationRecette popup = new FrmCreationRecette();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerRecettes();
            }
        }


        /// <summary>
        /// Recharge le tableau des opérations lorsqu'une recette est sélectionnée dans la grille.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void grdRecette_SelectionChanged(object sender, EventArgs e)
        {

            ChargerOperationsRecetteSelectionner();
        }

        private void cboRecette_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
