using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static M3_RRO_JSC.DBManager;

namespace M3_RRO_JSC
{
    public partial class AccueilControl : UserControl
    {
        public AccueilControl()
        {
            InitializeComponent();
            SetStatus(IsConnected);
        }

        public void SetStatus(bool isConnected)
        {
            if (isConnected)
            {
                lblEtatConnection.Text = "Connecté";
                lblEtatConnection.BackColor = Color.Green;
                SetInfoDB(_connectionString);
            }
            else
            {
                lblEtatConnection.Text = "Déconnecté";
                lblEtatConnection.BackColor = Color.Red;
            }
        }

        public void SetInfoDB(string _connectionString)
        {
            var builder = new MySqlConnectionStringBuilder(_connectionString);

            lblIPDB.Text = builder.Server;
            lblNomDb.Text = builder.Database;
            lblUtilisateur.Text = builder.UserID;
            lblPort.Text = builder.Port.ToString();
        }

        private void AccueilControl_Load(object sender, EventArgs e)
        {
            UpdateConnectionInfo();
        }

        private void UpdateConnectionInfo()
        {
            if (IsConnected)
            SetInfoDB(_connectionString);
        }
    }
}
