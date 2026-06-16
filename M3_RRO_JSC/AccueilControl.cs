// Fichier: AccueilControl.cs
// Description: Contrôle utilisateur affiché sur la page d'accueil. Montre les
// informations de connexion à la base de données et la liste des derniers lots.
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

            InitialiserGrilleLotsAccueil();
            ChargerLotsAccueil();
        }



        /// <summary>
        /// Initialise les colonnes du tableau des lots affiché sur la page d'accueil.
        /// </summary>
        private void InitialiserGrilleLotsAccueil()
        {
            grdEtatLotsAccueil.Columns.Clear();

            grdEtatLotsAccueil.Columns.Add("DateCreation", "Date de création");
            grdEtatLotsAccueil.Columns.Add("NomLot", "Nom du lot");
            grdEtatLotsAccueil.Columns.Add("Etat", "État");

            grdEtatLotsAccueil.ReadOnly = true;
            grdEtatLotsAccueil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEtatLotsAccueil.MultiSelect = false;
            grdEtatLotsAccueil.AllowUserToAddRows = false;
            grdEtatLotsAccueil.AllowUserToDeleteRows = false;
            grdEtatLotsAccueil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Charge les dix derniers lots créés depuis la base de données et les affiche dans le tableau de la page d'accueil.
        /// </summary>
        private void ChargerLotsAccueil()
        {
            if (DBManager.ParametresConnexionValides())
            {
                List<Lot> derniersLots = LotManager.GetDixDerniersLots();

                grdEtatLotsAccueil.Rows.Clear();

                foreach (Lot lot in derniersLots)
                {
                    grdEtatLotsAccueil.Rows.Add(
                        lot.DateCreation,
                        lot.NomLot,
                        lot.Etat
                    );
                }
            }
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
