using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System;
﻿using System;
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
    


        public void ChargerLotEnProduction()
        {

            grdLotEnProd.Rows.Clear();
            grdLotEnProd.Columns.Clear();

            grdLotEnProd.Columns.Add("NomLot", " Nom du lot");
            grdLotEnProd.Columns.Add("Quantite", "Quantité");
            grdLotEnProd.Columns.Add("Recette", "Recette");
            grdLotEnProd.Columns.Add("DateCreation", "Date de création");

            if (LotData.LotEnProduction != null)
            {
                Lot lot = LotData.LotEnProduction;

                grdLotEnProd.Rows.Add(
                    lot.NomLot,
                    lot.QuantitePieces,
                    lot.RecetteAssociee != null ? lot.RecetteAssociee.NomRecette : "",
                    lot.DateCreation.ToString("dd/MM/yyyy HH:mm")
                    );
            }


            grdLotEnProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdLotEnProd.AllowUserToAddRows = false;
            grdLotEnProd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdLotEnProd.MultiSelect = false;
        }






                
                
            

    }
}
