namespace M3_RRO_JSC
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGestionRecette = new Button();
            btnGestionLot = new Button();
            btnAccueil = new Button();
            btnTracabilite = new Button();
            pnlLotProduction = new Panel();
            grdLotEnProd = new DataGridView();
            lblLotProduction = new Label();
            btnParametre = new Button();
            pnlEtatMachine = new Panel();
            lblEtatMachine = new Label();
            lblMachineNumero = new Label();
            lblEtatText = new Label();
            lblMachineText = new Label();
            pnlAccueil = new Panel();
            lblAccueil = new Label();
            pnlEtatConnectionDb = new Panel();
            lblUtilisateur = new Label();
            lblNomDb = new Label();
            lblEtatConnection = new Label();
            lblUtilisateurText = new Label();
            lblNomDbText = new Label();
            lblEtatConnectionText = new Label();
            pnlLotProduction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdLotEnProd).BeginInit();
            pnlEtatMachine.SuspendLayout();
            pnlAccueil.SuspendLayout();
            pnlEtatConnectionDb.SuspendLayout();
            SuspendLayout();
            // 
            // btnGestionRecette
            // 
            btnGestionRecette.BackColor = SystemColors.ActiveCaption;
            btnGestionRecette.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionRecette.Location = new Point(12, 312);
            btnGestionRecette.Name = "btnGestionRecette";
            btnGestionRecette.Size = new Size(168, 147);
            btnGestionRecette.TabIndex = 3;
            btnGestionRecette.Text = "Gestion des recettes";
            btnGestionRecette.UseVisualStyleBackColor = false;
            // 
            // btnGestionLot
            // 
            btnGestionLot.BackColor = SystemColors.ActiveCaption;
            btnGestionLot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionLot.Location = new Point(12, 159);
            btnGestionLot.Name = "btnGestionLot";
            btnGestionLot.Size = new Size(168, 147);
            btnGestionLot.TabIndex = 2;
            btnGestionLot.Text = "Gestion des lots ";
            btnGestionLot.UseVisualStyleBackColor = false;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = SystemColors.ActiveCaption;
            btnAccueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(12, 6);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(168, 147);
            btnAccueil.TabIndex = 1;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = false;
            // 
            // btnTracabilite
            // 
            btnTracabilite.BackColor = SystemColors.ActiveCaption;
            btnTracabilite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTracabilite.Location = new Point(12, 465);
            btnTracabilite.Name = "btnTracabilite";
            btnTracabilite.Size = new Size(168, 147);
            btnTracabilite.TabIndex = 4;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = false;
            // 
            // pnlLotProduction
            // 
            pnlLotProduction.BackColor = SystemColors.ActiveCaption;
            pnlLotProduction.Controls.Add(grdLotEnProd);
            pnlLotProduction.Controls.Add(lblLotProduction);
            pnlLotProduction.Location = new Point(186, 88);
            pnlLotProduction.Name = "pnlLotProduction";
            pnlLotProduction.Size = new Size(333, 677);
            pnlLotProduction.TabIndex = 1;
            // 
            // grdLotEnProd
            // 
            grdLotEnProd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdLotEnProd.Location = new Point(18, 71);
            grdLotEnProd.Name = "grdLotEnProd";
            grdLotEnProd.RowHeadersWidth = 51;
            grdLotEnProd.Size = new Size(301, 300);
            grdLotEnProd.TabIndex = 1;
            // 
            // lblLotProduction
            // 
            lblLotProduction.AutoSize = true;
            lblLotProduction.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLotProduction.Location = new Point(77, 19);
            lblLotProduction.Name = "lblLotProduction";
            lblLotProduction.Size = new Size(185, 28);
            lblLotProduction.TabIndex = 0;
            lblLotProduction.Text = "Lots en production";
            // 
            // btnParametre
            // 
            btnParametre.BackColor = SystemColors.ActiveCaption;
            btnParametre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParametre.Location = new Point(12, 618);
            btnParametre.Name = "btnParametre";
            btnParametre.Size = new Size(168, 147);
            btnParametre.TabIndex = 5;
            btnParametre.Text = "Paramètres";
            btnParametre.UseVisualStyleBackColor = false;
            // 
            // pnlEtatMachine
            // 
            pnlEtatMachine.BackColor = SystemColors.ActiveCaption;
            pnlEtatMachine.Controls.Add(lblEtatMachine);
            pnlEtatMachine.Controls.Add(lblMachineNumero);
            pnlEtatMachine.Controls.Add(lblEtatText);
            pnlEtatMachine.Controls.Add(lblMachineText);
            pnlEtatMachine.Location = new Point(525, 88);
            pnlEtatMachine.Name = "pnlEtatMachine";
            pnlEtatMachine.Size = new Size(794, 330);
            pnlEtatMachine.TabIndex = 6;
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
            // pnlAccueil
            // 
            pnlAccueil.BackColor = SystemColors.ActiveCaption;
            pnlAccueil.Controls.Add(lblAccueil);
            pnlAccueil.Location = new Point(186, 12);
            pnlAccueil.Name = "pnlAccueil";
            pnlAccueil.Size = new Size(1133, 70);
            pnlAccueil.TabIndex = 3;
            // 
            // lblAccueil
            // 
            lblAccueil.AutoSize = true;
            lblAccueil.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAccueil.Location = new Point(489, 16);
            lblAccueil.Name = "lblAccueil";
            lblAccueil.Size = new Size(119, 41);
            lblAccueil.TabIndex = 0;
            lblAccueil.Text = "Accueil";
            // 
            // pnlEtatConnectionDb
            // 
            pnlEtatConnectionDb.BackColor = SystemColors.ActiveCaption;
            pnlEtatConnectionDb.Controls.Add(lblUtilisateur);
            pnlEtatConnectionDb.Controls.Add(lblNomDb);
            pnlEtatConnectionDb.Controls.Add(lblEtatConnection);
            pnlEtatConnectionDb.Controls.Add(lblUtilisateurText);
            pnlEtatConnectionDb.Controls.Add(lblNomDbText);
            pnlEtatConnectionDb.Controls.Add(lblEtatConnectionText);
            pnlEtatConnectionDb.Location = new Point(525, 427);
            pnlEtatConnectionDb.Name = "pnlEtatConnectionDb";
            pnlEtatConnectionDb.Size = new Size(794, 338);
            pnlEtatConnectionDb.TabIndex = 7;
            // 
            // lblUtilisateur
            // 
            lblUtilisateur.AutoSize = true;
            lblUtilisateur.Location = new Point(531, 219);
            lblUtilisateur.Name = "lblUtilisateur";
            lblUtilisateur.Size = new Size(76, 20);
            lblUtilisateur.TabIndex = 6;
            lblUtilisateur.Text = "Utilisateur";
            // 
            // lblNomDb
            // 
            lblNomDb.AutoSize = true;
            lblNomDb.Location = new Point(531, 152);
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
            // lblUtilisateurText
            // 
            lblUtilisateurText.AutoSize = true;
            lblUtilisateurText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilisateurText.Location = new Point(364, 211);
            lblUtilisateurText.Name = "lblUtilisateurText";
            lblUtilisateurText.Size = new Size(115, 28);
            lblUtilisateurText.TabIndex = 3;
            lblUtilisateurText.Text = "Utilisateur :";
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
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 777);
            Controls.Add(pnlEtatConnectionDb);
            Controls.Add(pnlEtatMachine);
            Controls.Add(pnlAccueil);
            Controls.Add(btnAccueil);
            Controls.Add(btnGestionLot);
            Controls.Add(pnlLotProduction);
            Controls.Add(btnParametre);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnTracabilite);
            Name = "FrmMain";
            Text = "Acceuil";
            pnlLotProduction.ResumeLayout(false);
            pnlLotProduction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdLotEnProd).EndInit();
            pnlEtatMachine.ResumeLayout(false);
            pnlEtatMachine.PerformLayout();
            pnlAccueil.ResumeLayout(false);
            pnlAccueil.PerformLayout();
            pnlEtatConnectionDb.ResumeLayout(false);
            pnlEtatConnectionDb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGestionRecette;
        private Button btnGestionLot;
        private Button btnAccueil;
        private Button btnTracabilite;
        private Panel pnlLotProduction;
        private Label lblLotProduction;
        private Button btnParametre;
        private Panel pnlEtatMachine;
        private Panel pnlAccueil;
        private Label lblAccueil;
        private Panel pnlEtatConnectionDb;
        private Label lblMachineText;
        private Label lblEtatConnectionText;
        private Label lblUtilisateurText;
        private Label lblNomDbText;
        private Label lblEtatConnection;
        private Label lblEtatMachine;
        private Label lblMachineNumero;
        private Label lblEtatText;
        private Label lblUtilisateur;
        private Label lblNomDb;
        private DataGridView grdLotEnProd;
    }
}