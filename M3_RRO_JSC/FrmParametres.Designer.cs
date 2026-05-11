namespace M3_RRO_JSC
{
    partial class FrmParametres
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
            pnlParametreText = new Panel();
            lblParametre = new Label();
            pnlParametre = new Panel();
            btnAccueil = new Button();
            btnGestionLot = new Button();
            btnParametre = new Button();
            btnGestionRecette = new Button();
            btnTracabilite = new Button();
            lblBasePara = new Label();
            lblUtilisateurPara = new Label();
            lblMotPassePara = new Label();
            lblAdressePara = new Label();
            lblPortSqlPara = new Label();
            btnTesterPara = new Button();
            btnConnecterPara = new Button();
            txtNomBasePara = new TextBox();
            txtAdresseIpPara = new TextBox();
            txtMotPassePara = new TextBox();
            txtNomUtiliPara = new TextBox();
            txtPortSqlPara = new TextBox();
            pnlParametreText.SuspendLayout();
            pnlParametre.SuspendLayout();
            SuspendLayout();
            // 
            // pnlParametreText
            // 
            pnlParametreText.BackColor = SystemColors.ActiveCaption;
            pnlParametreText.Controls.Add(lblParametre);
            pnlParametreText.Location = new Point(186, 12);
            pnlParametreText.Name = "pnlParametreText";
            pnlParametreText.Size = new Size(1133, 70);
            pnlParametreText.TabIndex = 25;
            // 
            // lblParametre
            // 
            lblParametre.AutoSize = true;
            lblParametre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParametre.Location = new Point(289, 12);
            lblParametre.Name = "lblParametre";
            lblParametre.Size = new Size(479, 41);
            lblParametre.TabIndex = 0;
            lblParametre.Text = "Paramètres de la base de donnée";
            // 
            // pnlParametre
            // 
            pnlParametre.BackColor = SystemColors.ActiveCaption;
            pnlParametre.Controls.Add(txtPortSqlPara);
            pnlParametre.Controls.Add(txtNomUtiliPara);
            pnlParametre.Controls.Add(txtMotPassePara);
            pnlParametre.Controls.Add(txtAdresseIpPara);
            pnlParametre.Controls.Add(txtNomBasePara);
            pnlParametre.Controls.Add(btnConnecterPara);
            pnlParametre.Controls.Add(btnTesterPara);
            pnlParametre.Controls.Add(lblPortSqlPara);
            pnlParametre.Controls.Add(lblAdressePara);
            pnlParametre.Controls.Add(lblMotPassePara);
            pnlParametre.Controls.Add(lblUtilisateurPara);
            pnlParametre.Controls.Add(lblBasePara);
            pnlParametre.Location = new Point(186, 88);
            pnlParametre.Name = "pnlParametre";
            pnlParametre.Size = new Size(1133, 677);
            pnlParametre.TabIndex = 19;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = SystemColors.ActiveCaption;
            btnAccueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(12, 9);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(168, 147);
            btnAccueil.TabIndex = 20;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = false;
            // 
            // btnGestionLot
            // 
            btnGestionLot.BackColor = SystemColors.ActiveCaption;
            btnGestionLot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionLot.Location = new Point(12, 162);
            btnGestionLot.Name = "btnGestionLot";
            btnGestionLot.Size = new Size(168, 147);
            btnGestionLot.TabIndex = 21;
            btnGestionLot.Text = "Gestion des lots ";
            btnGestionLot.UseVisualStyleBackColor = false;
            // 
            // btnParametre
            // 
            btnParametre.BackColor = SystemColors.ActiveCaption;
            btnParametre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParametre.Location = new Point(12, 621);
            btnParametre.Name = "btnParametre";
            btnParametre.Size = new Size(168, 147);
            btnParametre.TabIndex = 24;
            btnParametre.Text = "Paramètres";
            btnParametre.UseVisualStyleBackColor = false;
            // 
            // btnGestionRecette
            // 
            btnGestionRecette.BackColor = SystemColors.ActiveCaption;
            btnGestionRecette.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionRecette.Location = new Point(12, 315);
            btnGestionRecette.Name = "btnGestionRecette";
            btnGestionRecette.Size = new Size(168, 147);
            btnGestionRecette.TabIndex = 22;
            btnGestionRecette.Text = "Gestion des recettes";
            btnGestionRecette.UseVisualStyleBackColor = false;
            // 
            // btnTracabilite
            // 
            btnTracabilite.BackColor = SystemColors.ActiveCaption;
            btnTracabilite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTracabilite.Location = new Point(12, 468);
            btnTracabilite.Name = "btnTracabilite";
            btnTracabilite.Size = new Size(168, 147);
            btnTracabilite.TabIndex = 23;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = false;
            // 
            // lblBasePara
            // 
            lblBasePara.AutoSize = true;
            lblBasePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasePara.Location = new Point(151, 116);
            lblBasePara.Name = "lblBasePara";
            lblBasePara.Size = new Size(161, 28);
            lblBasePara.TabIndex = 5;
            lblBasePara.Text = "Nom de la base ";
            // 
            // lblUtilisateurPara
            // 
            lblUtilisateurPara.AutoSize = true;
            lblUtilisateurPara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilisateurPara.Location = new Point(151, 183);
            lblUtilisateurPara.Name = "lblUtilisateurPara";
            lblUtilisateurPara.Size = new Size(170, 28);
            lblUtilisateurPara.TabIndex = 6;
            lblUtilisateurPara.Text = "Nom d'utilisateur";
            // 
            // lblMotPassePara
            // 
            lblMotPassePara.AutoSize = true;
            lblMotPassePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotPassePara.Location = new Point(151, 251);
            lblMotPassePara.Name = "lblMotPassePara";
            lblMotPassePara.Size = new Size(135, 28);
            lblMotPassePara.TabIndex = 7;
            lblMotPassePara.Text = "Mot de passe";
            // 
            // lblAdressePara
            // 
            lblAdressePara.AutoSize = true;
            lblAdressePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdressePara.Location = new Point(151, 323);
            lblAdressePara.Name = "lblAdressePara";
            lblAdressePara.Size = new Size(108, 28);
            lblAdressePara.TabIndex = 8;
            lblAdressePara.Text = "Adresse IP";
            // 
            // lblPortSqlPara
            // 
            lblPortSqlPara.AutoSize = true;
            lblPortSqlPara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortSqlPara.Location = new Point(151, 401);
            lblPortSqlPara.Name = "lblPortSqlPara";
            lblPortSqlPara.Size = new Size(92, 28);
            lblPortSqlPara.TabIndex = 9;
            lblPortSqlPara.Text = "Port SQL";
            // 
            // btnTesterPara
            // 
            btnTesterPara.Location = new Point(389, 490);
            btnTesterPara.Name = "btnTesterPara";
            btnTesterPara.Size = new Size(200, 60);
            btnTesterPara.TabIndex = 10;
            btnTesterPara.Text = "Tester";
            btnTesterPara.UseVisualStyleBackColor = true;
            // 
            // btnConnecterPara
            // 
            btnConnecterPara.Location = new Point(884, 579);
            btnConnecterPara.Name = "btnConnecterPara";
            btnConnecterPara.Size = new Size(200, 60);
            btnConnecterPara.TabIndex = 11;
            btnConnecterPara.Text = "Se connecter";
            btnConnecterPara.UseVisualStyleBackColor = true;
            // 
            // txtNomBasePara
            // 
            txtNomBasePara.Location = new Point(389, 117);
            txtNomBasePara.Name = "txtNomBasePara";
            txtNomBasePara.Size = new Size(400, 27);
            txtNomBasePara.TabIndex = 12;
            // 
            // txtAdresseIpPara
            // 
            txtAdresseIpPara.Location = new Point(389, 327);
            txtAdresseIpPara.Name = "txtAdresseIpPara";
            txtAdresseIpPara.Size = new Size(400, 27);
            txtAdresseIpPara.TabIndex = 13;
            // 
            // txtMotPassePara
            // 
            txtMotPassePara.Location = new Point(389, 251);
            txtMotPassePara.Name = "txtMotPassePara";
            txtMotPassePara.Size = new Size(400, 27);
            txtMotPassePara.TabIndex = 14;
            // 
            // txtNomUtiliPara
            // 
            txtNomUtiliPara.Location = new Point(389, 187);
            txtNomUtiliPara.Name = "txtNomUtiliPara";
            txtNomUtiliPara.Size = new Size(400, 27);
            txtNomUtiliPara.TabIndex = 15;
            // 
            // txtPortSqlPara
            // 
            txtPortSqlPara.Location = new Point(389, 405);
            txtPortSqlPara.Name = "txtPortSqlPara";
            txtPortSqlPara.Size = new Size(200, 27);
            txtPortSqlPara.TabIndex = 16;
            // 
            // FrmParametres
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 777);
            Controls.Add(pnlParametreText);
            Controls.Add(pnlParametre);
            Controls.Add(btnAccueil);
            Controls.Add(btnGestionLot);
            Controls.Add(btnParametre);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnTracabilite);
            Name = "FrmParametres";
            Text = "Form1";
            pnlParametreText.ResumeLayout(false);
            pnlParametreText.PerformLayout();
            pnlParametre.ResumeLayout(false);
            pnlParametre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlParametreText;
        private Label lblParametre;
        private Panel pnlParametre;
        private Button btnAccueil;
        private Button btnGestionLot;
        private Button btnParametre;
        private Button btnGestionRecette;
        private Button btnTracabilite;
        private Label lblUtilisateurPara;
        private Label lblBasePara;
        private Button btnConnecterPara;
        private Button btnTesterPara;
        private Label lblPortSqlPara;
        private Label lblAdressePara;
        private Label lblMotPassePara;
        private TextBox txtPortSqlPara;
        private TextBox txtNomUtiliPara;
        private TextBox txtMotPassePara;
        private TextBox txtAdresseIpPara;
        private TextBox txtNomBasePara;
    }
}