using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static M3_RRO_JSC.OperationRecette;

namespace M3_RRO_JSC
{
    public partial class FrmCreationLot : Form
    {
        private Lot lotAModifier = null;

        private bool modeModification = false;

        public FrmCreationLot()
        {
            InitializeComponent();

            ChargerComboRecettes();
        }

        public FrmCreationLot( Lot lot)
        {
            InitializeComponent( );

            ChargerComboRecettes();

            lotAModifier = lot; 

            modeModification = true;

            this.Text = " Modification de lot ";
            btnTerminerCreaLot.Text = " Enregister la modification ";

            ChargerLotAModifier();
        }


        private void btnTerminer_Click(object sender, EventArgs e)
        {
            {
                if (!ChampsValides())
                {
                    return;
                }

                if (modeModification)
                {
                    ModifierLotExistant();

                }

                else
                {
                    CreerNouveauLot(); 

                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ChampsValides()

        {
            if (string.IsNullOrWhiteSpace(txtNomCreaLot.Text))
            {
                MessageBox.Show("Veuillez saisir le nom du lot.");
                txtNomCreaLot.Focus();
                return false;
            }


            if (!int.TryParse(txtQuantiteCreaLot.Text, out int quantite) || quantite <= 0)
            {
                MessageBox.Show("La quantité de pièces doit être un nombre supérieur à 0.");
                txtQuantiteCreaLot.Focus();
                return false;
            }

            if (cboRecetteCreaLot.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner une recette.");
                cboRecetteCreaLot.Focus();
                return false;
            }

            return true;
        }


        private void btnAnnulerCreaLot_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnCreeCreaLot_Click(object sender, EventArgs e)
        {
            
                FrmCreationRecette popup = new FrmCreationRecette();

                if (popup.ShowDialog() == DialogResult.OK)
                {
                    ChargerComboRecettes();
                }
            
        }

        private void ChargerComboRecettes()
        {
            cboRecetteCreaLot.DataSource = null;

            cboRecetteCreaLot.DataSource = RecetteData.ListeRecettes.ToList();
            cboRecetteCreaLot.DisplayMember = "NomRecette";
            cboRecetteCreaLot.ValueMember = "NomRecette";

            cboRecetteCreaLot.SelectedIndex = -1;
        }

        private void ChargerLotAModifier()
        {
            if (lotAModifier == null)
            {
                return;
            }

            txtNomCreaLot.Text = lotAModifier.NomLot;
            txtQuantiteCreaLot.Text = lotAModifier.QuantitePieces.ToString();

            cboRecetteCreaLot.SelectedItem = lotAModifier.RecetteAssociee;
            
            
        }

        

        private void CreerNouveauLot()
        {
            Recette recetteSelectionnee = cboRecetteCreaLot.SelectedItem as Recette;

            Lot nouveauLot = new Lot

            {
                NomLot = txtNomCreaLot.Text.Trim(),
                QuantitePieces = int.Parse(txtQuantiteCreaLot.Text),
                RecetteAssociee = recetteSelectionnee,
                DateCreation = DateTime.Now

            };

            LotData.ListeLots.Add(nouveauLot);

            MessageBox.Show("Lot créer avec succés");

        }

        private void ModifierLotExistant()
        {
            Recette recetteSelectionnee = cboRecetteCreaLot.SelectedItem as Recette;

            lotAModifier.NomLot = txtNomCreaLot.Text.Trim();
            lotAModifier.QuantitePieces = int.Parse(txtQuantiteCreaLot.Text);
            lotAModifier.RecetteAssociee = recetteSelectionnee;

        }
    }

}
