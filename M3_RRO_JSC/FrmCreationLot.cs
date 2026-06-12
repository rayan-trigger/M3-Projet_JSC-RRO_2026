using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class FrmCreationLot : Form
    {
        private Lot? lotAModifier;

        private bool modeModification = false;

        private const int AucuneSelection = -1;
        private const int ValeurInactive = 0;
        private const long IdInvalide = -1;


        public FrmCreationLot()
        {
            InitializeComponent();

            ChargerComboRecettes();

        }

        public FrmCreationLot(Lot lot)
        {
            InitializeComponent();

            ChargerComboRecettes();

            lotAModifier = lot;

            modeModification = true;

            this.Text = " Modification de lot ";
            btnTerminerCreaLot.Text = " Enregister la modification ";

            ChargerLotAModifier();
        }


        /// <summary>
        /// Vérifie que les champs nécessaires à la création ou à la modification d'un lot sont correctement remplis.
        /// </summary>
        /// <returns> True si tous les champs sont valides, sinon false.</returns>
        private bool ChampsValides()
        {
            bool champsValides = true;

            if (string.IsNullOrWhiteSpace(txtNomCreaLot.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du lot.");
                txtNomCreaLot.Focus();
                champsValides = false;
            }


            else if (!int.TryParse(txtQuantiteCreaLot.Text, out int quantite) || quantite <= ValeurInactive)
            {
                MessageBox.Show ("La quantité de pièces doit être un nombre supérieur à 0.");
                txtQuantiteCreaLot.Focus();
                champsValides = false;
            }

            else if (cboRecetteCreaLot.SelectedIndex == AucuneSelection)
            {
                MessageBox.Show("Veuillez sélectionner une recette.");
                cboRecetteCreaLot.Focus();
                champsValides = false;
            }

            return champsValides;
        }




        /// <summary>
        ///  Charge dans la ComboBox la liste des recettes disponibles depuis la base de données.
        /// </summary>
        private void ChargerComboRecettes()
        {
            if (DBManager.ParametresConnexionValides())
            {
                RecetteData.ListeRecettes = RecetteManager.GetAllRecette();

                cboRecetteCreaLot.DataSource = null;
                cboRecetteCreaLot.DataSource = RecetteData.ListeRecettes.ToList();
                cboRecetteCreaLot.DisplayMember = "NomRecette";
                cboRecetteCreaLot.ValueMember = "IdRecette";

                cboRecetteCreaLot.SelectedIndex = AucuneSelection;
            }
        }



        /// <summary>
        /// Charge dans les champs du formulaire les informations du lot à modifier.
        /// </summary>
        private void ChargerLotAModifier()
        {
            if (lotAModifier != null)
            {
                txtNomCreaLot.Text = lotAModifier.NomLot;
                txtQuantiteCreaLot.Text = lotAModifier.QuantitePieces.ToString();

                if (lotAModifier.RecetteAssociee != null)
                {
                    cboRecetteCreaLot.SelectedValue = lotAModifier.RecetteAssociee.IdRecette;
                }
            }
       }


        /// <summary>
        /// Crée un nouveau lot à partir des informations saisies dans le formulaire et les enregistrer dans la base de donnée.
        /// </summary>
        /// <returns>True si le lot a été crée sion false.</returns>
        private bool CreerNouveauLot()
        {
            bool lotCree = false;

            Recette recetteSelectionnee = cboRecetteCreaLot.SelectedItem as Recette;

            if (recetteSelectionnee != null)
            {
                Lot nouveauLot = new Lot
                {
                    NomLot = txtNomCreaLot.Text.Trim(),
                    QuantitePieces = int.Parse(txtQuantiteCreaLot.Text),
                    RecetteAssociee = recetteSelectionnee,
                    DateCreation = DateTime.Now
                };

                long idLot = LotManager.CreateLot(nouveauLot);

                if (idLot != IdInvalide)
                {
                    MessageBox.Show("Lot créer avec succés");
                    lotCree = true;
                }
            }
            return lotCree;
        }


        /// <summary>
        /// Modifie le lot existant avec les informations saisies dans le formulaire et on enregistre les changement dans la base de donnée.
        /// </summary>
        /// <returns> True si le lot a été modifier, sinon false </returns>
        private bool ModifierLotExistant()
        {
            bool lotModifier = false;

            Recette recetteSelectionnee = cboRecetteCreaLot.SelectedItem as Recette;

            if (lotAModifier != null && recetteSelectionnee !=null)
            {
                lotAModifier.NomLot = txtNomCreaLot.Text.Trim();
                lotAModifier.QuantitePieces = int.Parse(txtQuantiteCreaLot.Text);
                lotAModifier.RecetteAssociee = recetteSelectionnee;


                LotManager.UpdateLot(lotAModifier);

                MessageBox.Show("Lot modifié avec succès.");
                lotModifier = true;
            }

            else
            {
                MessageBox.Show("Impossible de modifier le lot.");
            }

            return lotModifier;
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////





        /// <summary>
        /// Valide les champs du formulaire puis crée ou modifie un lot selon le mode du formulaire, si cela réussit le formulaire se ferme avec le 
        /// résultat OK.
        /// </summary>
        /// <param name="sender">>Objet qui déclenche l'événement.</param>
        /// <param name="e">Arguments de l'événement.</param>
        private void btnTerminer_Click(object sender, EventArgs e)
        {
            bool operationReussie = false;

            if (ChampsValides())
            {
                if (modeModification)
                {
                    operationReussie = ModifierLotExistant();
                }

                else
                {
                    operationReussie = CreerNouveauLot();

                }
            }
            if (operationReussie)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        /// <summary>
        /// Ouvre la fenêtre de détail de la recette sélectionnée afin d'afficher ses opérations.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoirOperation_Click(object sender, EventArgs e)
        {
            if (cboRecetteCreaLot.SelectedIndex != AucuneSelection)
            {
                Recette recetteSelectionnee = (Recette)cboRecetteCreaLot.SelectedItem;

                FrmDetailsRecette popup = new FrmDetailsRecette(recetteSelectionnee);
                popup.ShowDialog(this);

            }
            else
            {
                MessageBox.Show("Veuillez selectionner une recette");
                cboRecetteCreaLot.Focus();
            }
        }

        /// <summary>
        /// Annule la création ou la modification du lot et ferme le formulaire.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerCreaLot_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Ouvre la fenêtre d'assistance de réation de recette, si une recette est créée, la liste des recettes est rechargée.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreeCreaLot_Click(object sender, EventArgs e)
        {

            FrmCreationRecette popup = new FrmCreationRecette();

            if (popup.ShowDialog() == DialogResult.OK)
            {
                ChargerComboRecettes();
            }
        }


        /// <summary>
        /// Change le curseur de la souris en main lorsque le bouton est survolé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminerCreaLot_MouseEnter(object sender, EventArgs e)
        {
            btnTerminerCreaLot.Cursor = Cursors.Hand;
        }


        /// <summary>
        /// Remet le curseur par défaut lorsque la souris quitte le bouton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTerminerCreaLot_MouseLeave(object sender, EventArgs e)
        {
            btnTerminerCreaLot.Cursor = Cursors.Default;
        }


        /// <summary>
        /// Change le curseur de la souris en main lorsque le bouton est survolé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerCreaLot_MouseEnter(object sender, EventArgs e)
        {
            btnAnnulerCreaLot.Cursor = Cursors.Hand;
        }


        /// <summary>
        /// Remet le curseur par défaut lorsque la souris quitte le bouton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnulerCreaLot_MouseLeave(object sender, EventArgs e)
        {
            btnAnnulerCreaLot.Cursor = Cursors.Default;

        }



        /// <summary>
        /// Change le curseur de la souris en main lorsque le bouton est survolé.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreeCreaLot_MouseEnter(object sender, EventArgs e)
        {
            btnCreeCreaLot.Cursor = Cursors.Hand;

        }


        /// <summary>
        /// Remet le curseur par défaut lorsque la souris quitte le bouton.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreeCreaLot_MouseLeave(object sender, EventArgs e)
        {
            btnCreeCreaLot.Cursor = Cursors.Default;

        }



    }
    

}

