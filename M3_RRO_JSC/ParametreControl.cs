using MySql.Data.MySqlClient;
using static M3_RRO_JSC.DBManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class ParametreControl : UserControl
    {
        public ParametreControl()
        {
            InitializeComponent();

            txtNomBasePara.Text = "m3_db";
            txtNomUtiliPara.Text = "root";
            txtPortSqlPara.Text = "3306";
            txtAdresseIpPara.Text = "127.0.0.1";

        }

        private void btnTesterPara_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs de texte
            // Tester la connexion à la base de données avec les paramètres fournis
            TestConnexion(txtAdresseIpPara.Text.Trim(), txtNomBasePara.Text.Trim(), txtNomUtiliPara.Text.Trim(), txtMotPassePara.Text.Trim(), txtPortSqlPara.Text.Trim());
        }

        private void btnTesterPara_MouseEnter(object sender, EventArgs e)
        {
            btnTesterPara.Cursor = Cursors.Hand;
        }

        private void btnTesterPara_MouseLeave(object sender, EventArgs e)
        {
            btnTesterPara.Cursor = Cursors.Default;
        }

        private void btnConnexionDB_Click(object sender, EventArgs e)
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                CloseDBConnection();
                UpdateConnectionButton();
            }

            else
            {
                // Récupérer les valeurs des champs de texte
                // Initialisation d'une connexion à la base de données
                ConnectToDB(txtAdresseIpPara.Text.Trim(), txtNomBasePara.Text.Trim(), txtNomUtiliPara.Text.Trim(), txtMotPassePara.Text.Trim(), txtPortSqlPara.Text.Trim());
                UpdateConnectionButton();
            }
        }


        private void btnConnexionDB_MouseLeave(object sender, EventArgs e)
        {
            btnConnexionDB.Cursor = Cursors.Default;
        }

        private void btnConnexionDB_MouseEnter(object sender, EventArgs e)
        {
            btnConnexionDB.Cursor = Cursors.Hand;
        }

        private void txtNomBasePara_MouseLeave(object sender, EventArgs e)
        {
            txtNomBasePara.Cursor = Cursors.Default;
        }

        private void txtNomBasePara_MouseEnter(object sender, EventArgs e)
        {
            txtNomBasePara.Cursor = Cursors.IBeam;
        }

        private void txtNomUtiliPara_MouseEnter(object sender, EventArgs e)
        {
            txtNomUtiliPara.Cursor = Cursors.IBeam;
        }

        private void txtNomUtiliPara_MouseLeave(object sender, EventArgs e)
        {
            txtNomUtiliPara.Cursor = Cursors.Default;
        }

        private void txtMotPassePara_MouseLeave(object sender, EventArgs e)
        {
            txtMotPassePara.Cursor = Cursors.Default;
        }

        private void txtMotPassePara_MouseEnter(object sender, EventArgs e)
        {
            txtMotPassePara.Cursor = Cursors.IBeam;
        }

        private void txtAdresseIpPara_MouseEnter(object sender, EventArgs e)
        {
            txtAdresseIpPara.Cursor = Cursors.IBeam;
        }

        private void txtAdresseIpPara_MouseLeave(object sender, EventArgs e)
        {
            txtAdresseIpPara.Cursor = Cursors.Default;
        }

        private void txtPortSqlPara_MouseLeave(object sender, EventArgs e)
        {
            txtPortSqlPara.Cursor = Cursors.Default;
        }

        private void txtPortSqlPara_MouseEnter(object sender, EventArgs e)
        {
            txtPortSqlPara.Cursor = Cursors.IBeam;
        }

        private void ParametreControl_Load(object sender, EventArgs e)
        {
            UpdateConnectionButton();
        }

        private void UpdateConnectionButton()
        {
            btnConnexionDB.Text = IsConnected
                ? "Se déconnecter"
                : "Se connecter";
        }
    }
}
