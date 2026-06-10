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
            lblEtatMachine = new Label();
            lblMachineNumero = new Label();
            lblEtatText = new Label();
            lblMachineText = new Label();
            pnlLotProduction = new Panel();
            grdLotEnProd = new DataGridView();
            lblLotProduction = new Label();
            pnlEtatConnectionDb.SuspendLayout();
            pnlEtatMachine.SuspendLayout();
            pnlLotProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLotEnProd).BeginInit();
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
            lblEtatConnectionText.Location = new Point(208, 16);
            lblEtatConnectionText.Name = "lblEtatConnectionText";
            lblEtatConnectionText.Size = new Size(387, 28);
            lblEtatConnectionText.TabIndex = 1;
            lblEtatConnectionText.Text = "Etat de la connexion à la base de donnée";
            // 
            // pnlEtatMachine
            // 
            pnlEtatMachine.BackColor = SystemColors.ActiveCaption;
            pnlEtatMachine.Controls.Add(lblEtatMachine);
            pnlEtatMachine.Controls.Add(lblMachineNumero);
            pnlEtatMachine.Controls.Add(lblEtatText);
            pnlEtatMachine.Controls.Add(lblMachineText);
            pnlEtatMachine.Location = new Point(416, 0);
            pnlEtatMachine.Name = "pnlEtatMachine";
            pnlEtatMachine.Size = new Size(794, 206);
            pnlEtatMachine.TabIndex = 10;
            // 
            // lblEtatMachine
            // 
            lblEtatMachine.AutoSize = true;
            lblEtatMachine.Location = new Point(489, 78);
            lblEtatMachine.Name = "lblEtatMachine";
            lblEtatMachine.Size = new Size(35, 20);
            lblEtatMachine.TabIndex = 3;
            lblEtatMachine.Text = "etat";
            // 
            // lblMachineNumero
            // 
            lblMachineNumero.AutoSize = true;
            lblMachineNumero.Location = new Point(478, 27);
            lblMachineNumero.Name = "lblMachineNumero";
            lblMachineNumero.Size = new Size(65, 20);
            lblMachineNumero.TabIndex = 2;
            lblMachineNumero.Text = "Machine";
            // 
            // lblEtatText
            // 
            lblEtatText.AutoSize = true;
            lblEtatText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEtatText.Location = new Point(406, 71);
            lblEtatText.Name = "lblEtatText";
            lblEtatText.Size = new Size(63, 28);
            lblEtatText.TabIndex = 1;
            lblEtatText.Text = "Etat : ";
            // 
            // lblMachineText
            // 
            lblMachineText.AutoSize = true;
            lblMachineText.BackColor = SystemColors.ActiveCaption;
            lblMachineText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMachineText.Location = new Point(364, 19);
            lblMachineText.Name = "lblMachineText";
            lblMachineText.Size = new Size(100, 28);
            lblMachineText.TabIndex = 0;
            lblMachineText.Text = "Machine :";
            // 
            // pnlLotProduction
            // 
            pnlLotProduction.BackColor = SystemColors.ActiveCaption;
            pnlLotProduction.Controls.Add(grdLotEnProd);
            pnlLotProduction.Controls.Add(lblLotProduction);
            pnlLotProduction.Location = new Point(0, 0);
            pnlLotProduction.Name = "pnlLotProduction";
            pnlLotProduction.Size = new Size(410, 675);
            pnlLotProduction.TabIndex = 8;
            // 
            // grdLotEnProd
            // 
            grdLotEnProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLotEnProd.Location = new Point(53, 71);
            grdLotEnProd.Name = "grdLotEnProd";
            grdLotEnProd.RowHeadersWidth = 51;
            grdLotEnProd.Size = new Size(301, 397);
            grdLotEnProd.TabIndex = 1;
            // 
            // lblLotProduction
            // 
            lblLotProduction.AutoSize = true;
            lblLotProduction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLotProduction.Location = new Point(105, 20);
            lblLotProduction.Name = "lblLotProduction";
            lblLotProduction.Size = new Size(185, 28);
            lblLotProduction.TabIndex = 0;
            lblLotProduction.Text = "Lots en production";
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
            ((System.ComponentModel.ISupportInitialize)grdLotEnProd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlEtatConnectionDb;
        private Label lblIPDBText;
        private Label lblNomDbText;
        private Label lblEtatConnectionText;
        private Panel pnlEtatMachine;
        private Label lblEtatMachine;
        private Label lblMachineNumero;
        private Label lblEtatText;
        private Label lblMachineText;
        private Panel pnlLotProduction;
        private DataGridView grdLotEnProd;
        private Label lblLotProduction;
        public Label lblNomDb;
        public Label lblUtilisateur;
        public Label lblEtatConnection;
        private Label lblUtilisateurText;
        public Label lblIPDB;
        public Label lblPort;
        private Label lblPortText;
    }
}
