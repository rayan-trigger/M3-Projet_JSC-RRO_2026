using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class TracabiliteControl : UserControl
    {
        private TracabilitéManager.TracabiliteManager _manager;

        public TracabiliteControl()
        {
            InitializeComponent();
            // Initialize manager with the controls created by InitializeComponent
            _manager = new TracabilitéManager.TracabiliteManager(grdTracabilite, txtRechercheTracabilite, cboFiltresTracabilite);
        }

        private void TracabiliteControl_Load(object sender, EventArgs e)
        {
            _manager.ChargerDonnees();
        }
    }
}
