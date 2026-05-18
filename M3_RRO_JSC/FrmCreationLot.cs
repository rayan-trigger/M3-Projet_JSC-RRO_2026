using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class FrmCreationLot : Form
    {
        public FrmCreationLot()
        {
            InitializeComponent();
        }


        private void btnTerminer_Click(object sender, EventArgs e)
        {
            if (!ChampsValides())
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
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

            popup.StartPosition = FormStartPosition.CenterParent;
            popup.ShowDialog(this);
        }
    }

}
