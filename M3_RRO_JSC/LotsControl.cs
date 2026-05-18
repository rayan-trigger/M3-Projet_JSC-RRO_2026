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
        }

        private void btnCreerLot_Click(object sender, EventArgs e)
        {
            FrmCreationLot popup = new FrmCreationLot();

            popup.StartPosition = FormStartPosition.CenterParent;

            if (popup.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Lot créé avec succès.");

                // Plus tard : recharger la liste des lots
                // ChargerLots();
            }
        }
    }
}
