namespace M3_RRO_JSC
{
    partial class AccueilControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            pnlEtatConnectionDb = new Panel();
            lblPort = new Label();
            lblPortText = new Label();
            lblIPDB = new Label();
            lblUtilisateurText = new Label();
            lblUtilisateur = new Label();
            lblNomDb = new Label();
            lblEtatConnection = new Label();
            lblIPDBText = new Label();
            lblNomDbText = new Label();
            lblEtatConnectionText = new Label();
            pnlEtatMachine = new Panel();
            txtMachineMaintReponse = new TextBox();
            txtMachineEnProdReponse = new TextBox();
            txtMachinePreteReponse = new TextBox();
            txtMachineMaint = new TextBox();
            txtMachineEnProd = new TextBox();
            txtMachinePrete = new TextBox();
            txtMachineAcceuil = new TextBox();
            pnlLotProduction = new Panel();
            grdEtatLotsAccueil = new DataGridView();
            lblLotProduction = new Label();
            btnParcMachine = new Button();
            pnlEtatConnectionDb.SuspendLayout();
            pnlEtatMachine.SuspendLayout();
            pnlLotProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdEtatLotsAccueil).BeginInit();
            SuspendLayout();
            // 
            // pnlEtatConnectionDb
            // 
            pnlEtatConnectionDb.BackColor = SystemColors.ActiveCaption;
            pnlEtatConnectionDb.Controls.Add(lblPort);
            pnlEtatConnectionDb.Controls.Add(lblPortText);
            pnlEtatConnectionDb.Controls.Add(lblIPDB);
            pnlEtatConnectionDb.Controls.Add(lblUtilisateurText);
            pnlEtatConnectionDb.Controls.Add(lblUtilisateur);
            pnlEtatConnectionDb.Controls.Add(lblNomDb);
            pnlEtatConnectionDb.Controls.Add(lblEtatConnection);
            pnlEtatConnectionDb.Controls.Add(lblIPDBText);
            pnlEtatConnectionDb.Controls.Add(lblNomDbText);
            pnlEtatConnectionDb.Controls.Add(lblEtatConnectionText);
            pnlEtatConnectionDb.Location = new Point(416, 212);
            pnlEtatConnectionDb.Name = "pnlEtatConnectionDb";
            pnlEtatConnectionDb.Size = new Size(794, 463);
            pnlEtatConnectionDb.TabIndex = 11;
            // 
            // lblPort
            // 
            lblPort.AutoSize = true;
            lblPort.Location = new Point(501, 237);
            lblPort.Name = "lblPort";
            lblPort.Size = new Size(35, 20);
            lblPort.TabIndex = 10;
            lblPort.Text = "Port";
            // 
            // lblPortText
            // 
            lblPortText.AutoSize = true;
            lblPortText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortText.Location = new Point(418, 229);
            lblPortText.Name = "lblPortText";
            lblPortText.Size = new Size(61, 28);
            lblPortText.TabIndex = 9;
            lblPortText.Text = "Port :";
            // 
            // lblIPDB
            // 
            lblIPDB.AutoSize = true;
            lblIPDB.Location = new Point(501, 209);
            lblIPDB.Name = "lblIPDB";
            lblIPDB.Size = new Size(21, 20);
            lblIPDB.TabIndex = 8;
            lblIPDB.Text = "IP";
            // 
            // lblUtilisateurText
            // 
            lblUtilisateurText.AutoSize = true;
            lblUtilisateurText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilisateurText.Location = new Point(364, 173);
            lblUtilisateurText.Name = "lblUtilisateurText";
            lblUtilisateurText.Size = new Size(115, 28);
            lblUtilisateurText.TabIndex = 3;
            lblUtilisateurText.Text = "Utilisateur :";
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Location = new Point(501, 181);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(76, 20);
            lblUtilisateur.TabIndex = 6;
            lblUtilisateur.Text = "Utilisateur";
            // 
            // lblNomDb
            // 
            lblNomDb.AutoSize = true;
            lblNomDb.Location = new Point(501, 153);
            lblNomDb.Name = "lblNomDb";
            lblNomDb.Size = new Size(42, 20);
            lblNomDb.TabIndex = 5;
            lblNomDb.Text = "Nom";
            // 
            // lblEtatConnection
            // 
            lblEtatConnection.AutoSize = true;
            lblEtatConnection.BackColor = Color.Chartreuse;
            lblEtatConnection.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtatConnection.Location = new Point(364, 75);
            lblEtatConnection.Name = "lblEtatConnection";
            lblEtatConnection.Size = new Size(104, 28);
            lblEtatConnection.TabIndex = 4;
            lblEtatConnection.Text = "Connecté ";
            // 
            // lblIPDBText
            // 
            lblIPDBText.AutoSize = true;
            lblIPDBText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIPDBText.Location = new Point(386, 201);
            lblIPDBText.Name = "lblIPDBText";
            lblIPDBText.Size = new Size(93, 28);
            lblIPDBText.TabIndex = 3;
            lblIPDBText.Text = "Serveur :";
            // 
            // lblNomDbText
            // 
            lblNomDbText.AutoSize = true;
            lblNomDbText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomDbText.Location = new Point(208, 145);
            lblNomDbText.Name = "lblNomDbText";
            lblNomDbText.Size = new Size(271, 28);
            lblNomDbText.TabIndex = 2;
            lblNomDbText.Text = "Nom de la Base de donnée :";
            // 
            // lblEtatConnectionText
            // 
            lblEtatConnectionText.AutoSize = true;
            lblEtatConnectionText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtatConnectionText.Location = new Point(208, 28);
            lblEtatConnectionText.Name = "lblEtatConnectionText";
            lblEtatConnectionText.Size = new Size(387, 28);
            lblEtatConnectionText.TabIndex = 1;
            lblEtatConnectionText.Text = "Etat de la connexion à la base de donnée";
            // 
            // pnlEtatMachine
            // 
            pnlEtatMachine.BackColor = SystemColors.ActiveCaption;
            pnlEtatMachine.Controls.Add(btnParcMachine);
            pnlEtatMachine.Controls.Add(txtMachineMaintReponse);
            pnlEtatMachine.Controls.Add(txtMachineEnProdReponse);
            pnlEtatMachine.Controls.Add(txtMachinePreteReponse);
            pnlEtatMachine.Controls.Add(txtMachineMaint);
            pnlEtatMachine.Controls.Add(txtMachineEnProd);
            pnlEtatMachine.Controls.Add(txtMachinePrete);
            pnlEtatMachine.Controls.Add(txtMachineAcceuil);
            pnlEtatMachine.Location = new Point(416, 0);
            pnlEtatMachine.Name = "pnlEtatMachine";
            pnlEtatMachine.Size = new Size(794, 206);
            pnlEtatMachine.TabIndex = 10;
            // 
            // txtMachineMaintReponse
            // 
            txtMachineMaintReponse.BackColor = SystemColors.ActiveCaption;
            txtMachineMaintReponse.BorderStyle = BorderStyle.None;
            txtMachineMaintReponse.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMachineMaintReponse.Location = new Point(467, 146);
            txtMachineMaintReponse.Name = "txtMachineMaintReponse";
            txtMachineMaintReponse.Size = new Size(125, 24);
            txtMachineMaintReponse.TabIndex = 10;
            txtMachineMaintReponse.Text = "5";
            // 
            // txtMachineEnProdReponse
            // 
            txtMachineEnProdReponse.BackColor = SystemColors.ActiveCaption;
            txtMachineEnProdReponse.BorderStyle = BorderStyle.None;
            txtMachineEnProdReponse.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMachineEnProdReponse.Location = new Point(467, 113);
            txtMachineEnProdReponse.Name = "txtMachineEnProdReponse";
            txtMachineEnProdReponse.Size = new Size(125, 24);
            txtMachineEnProdReponse.TabIndex = 9;
            txtMachineEnProdReponse.Text = "2";
            // 
            // txtMachinePreteReponse
            // 
            txtMachinePreteReponse.BackColor = SystemColors.ActiveCaption;
            txtMachinePreteReponse.BorderStyle = BorderStyle.None;
            txtMachinePreteReponse.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMachinePreteReponse.ForeColor = SystemColors.InactiveCaptionText;
            txtMachinePreteReponse.Location = new Point(467, 80);
            txtMachinePreteReponse.Name = "txtMachinePreteReponse";
            txtMachinePreteReponse.Size = new Size(125, 24);
            txtMachinePreteReponse.TabIndex = 8;
            txtMachinePreteReponse.Text = "10";
            // 
            // txtMachineMaint
            // 
            txtMachineMaint.BackColor = SystemColors.ActiveCaption;
            txtMachineMaint.BorderStyle = BorderStyle.None;
            txtMachineMaint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMachineMaint.Location = new Point(208, 146);
            txtMachineMaint.Name = "txtMachineMaint";
            txtMachineMaint.Size = new Size(253, 27);
            txtMachineMaint.TabIndex = 7;
            txtMachineMaint.Text = " Machine en Maintenance :";
            // 
            // txtMachineEnProd
            // 
            txtMachineEnProd.BackColor = SystemColors.ActiveCaption;
            txtMachineEnProd.BorderStyle = BorderStyle.None;
            txtMachineEnProd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMachineEnProd.Location = new Point(208, 113);
            txtMachineEnProd.Name = "txtMachineEnProd";
            txtMachineEnProd.Size = new Size(253, 27);
            txtMachineEnProd.TabIndex = 6;
            txtMachineEnProd.Text = "    Machine en Production :";
            // 
            // txtMachinePrete
            // 
            txtMachinePrete.BackColor = SystemColors.ActiveCaption;
            txtMachinePrete.BorderStyle = BorderStyle.None;
            txtMachinePrete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMachinePrete.Location = new Point(208, 80);
            txtMachinePrete.Name = "txtMachinePrete";
            txtMachinePrete.Size = new Size(253, 27);
            txtMachinePrete.TabIndex = 5;
            txtMachinePrete.Text = "Machine Prête a Produire  :";
            // 
            // txtMachineAcceuil
            // 
            txtMachineAcceuil.BackColor = SystemColors.ActiveCaption;
            txtMachineAcceuil.BorderStyle = BorderStyle.None;
            txtMachineAcceuil.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtMachineAcceuil.Location = new Point(208, 19);
            txtMachineAcceuil.Name = "txtMachineAcceuil";
            txtMachineAcceuil.Size = new Size(382, 36);
            txtMachineAcceuil.TabIndex = 4;
            txtMachineAcceuil.Text = "Etat général du parc machine ";
            // 
            // pnlLotProduction
            // 
            pnlLotProduction.BackColor = SystemColors.ActiveCaption;
            pnlLotProduction.Controls.Add(grdEtatLotsAccueil);
            pnlLotProduction.Controls.Add(lblLotProduction);
            pnlLotProduction.Location = new Point(0, 0);
            pnlLotProduction.Name = "pnlLotProduction";
            pnlLotProduction.Size = new Size(410, 675);
            pnlLotProduction.TabIndex = 8;
            // 
            // grdEtatLotsAccueil
            // 
            grdEtatLotsAccueil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEtatLotsAccueil.Location = new Point(23, 58);
            grdEtatLotsAccueil.Name = "grdEtatLotsAccueil";
            grdEtatLotsAccueil.RowHeadersWidth = 51;
            grdEtatLotsAccueil.Size = new Size(360, 397);
            grdEtatLotsAccueil.TabIndex = 1;
            // 
            // lblLotProduction
            // 
            lblLotProduction.AutoSize = true;
            lblLotProduction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLotProduction.Location = new Point(134, 27);
            lblLotProduction.Name = "lblLotProduction";
            lblLotProduction.Size = new Size(128, 28);
            lblLotProduction.TabIndex = 0;
            lblLotProduction.Text = "Etat des Lots";
            // 
            // btnParcMachine
            // 
            btnParcMachine.BackColor = Color.YellowGreen;
            btnParcMachine.BackgroundImageLayout = ImageLayout.Center;
            btnParcMachine.CausesValidation = false;
            btnParcMachine.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParcMachine.Location = new Point(42, 80);
            btnParcMachine.Name = "btnParcMachine";
            btnParcMachine.Size = new Size(124, 70);
            btnParcMachine.TabIndex = 11;
            btnParcMachine.Text = "Mise à Jour  Parc Machine";
            btnParcMachine.UseVisualStyleBackColor = false;
            btnParcMachine.Click += btnParcMachine_Click;
            // 
            // AccueilControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlEtatConnectionDb);
            Controls.Add(pnlEtatMachine);
            Controls.Add(pnlLotProduction);
            Name = "AccueilControl";
            Size = new Size(1210, 675);
            Load += AccueilControl_Load;
            pnlEtatConnectionDb.ResumeLayout(false);
            pnlEtatConnectionDb.PerformLayout();
            pnlEtatMachine.ResumeLayout(false);
            pnlEtatMachine.PerformLayout();
            pnlLotProduction.ResumeLayout(false);
            pnlLotProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdEtatLotsAccueil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEtatConnectionDb;
        private Label lblIPDBText;
        private Label lblNomDbText;
        private Label lblEtatConnectionText;
        private Panel pnlEtatMachine;
        private Label lblEtatMachine;
        private Label lblEtatText;
        private Label lblMachineText;
        private Panel pnlLotProduction;
        private DataGridView grdEtatLotsAccueil;
        private Label lblLotProduction;
        public Label lblNomDb;
        public Label lblUtilisateur;
        public Label lblEtatConnection;
        private Label lblUtilisateurText;
        public Label lblIPDB;
        public Label lblPort;
        private Label lblPortText;
        private TextBox txtMachineAcceuil;
        private TextBox txtMachineMaint;
        private TextBox txtMachineEnProd;
        private TextBox txtMachinePrete;
        private TextBox txtMachineMaintReponse;
        private TextBox txtMachineEnProdReponse;
        private TextBox txtMachinePreteReponse;
        private Button btnParcMachine;
    }
}
