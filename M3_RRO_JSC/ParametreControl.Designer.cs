namespace M3_RRO_JSC
{
    partial class ParametreControl
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
            txtPortSqlPara = new TextBox();
            txtNomUtiliPara = new TextBox();
            txtMotPassePara = new TextBox();
            txtAdresseIpPara = new TextBox();
            txtNomBasePara = new TextBox();
            btnTesterPara = new Button();
            lblPortSqlPara = new Label();
            lblAdressePara = new Label();
            lblMotPassePara = new Label();
            lblUtilisateurPara = new Label();
            lblBasePara = new Label();
            btnResetDB = new Button();
            SuspendLayout();
            // 
            // txtPortSqlPara
            // 
            txtPortSqlPara.Location = new Point(494, 381);
            txtPortSqlPara.Name = "txtPortSqlPara";
            txtPortSqlPara.Size = new Size(200, 27);
            txtPortSqlPara.TabIndex = 16;
            // 
            // txtNomUtiliPara
            // 
            txtNomUtiliPara.Location = new Point(494, 158);
            txtNomUtiliPara.Name = "txtNomUtiliPara";
            txtNomUtiliPara.Size = new Size(400, 27);
            txtNomUtiliPara.TabIndex = 15;
            // 
            // txtMotPassePara
            // 
            txtMotPassePara.Location = new Point(494, 235);
            txtMotPassePara.Name = "txtMotPassePara";
            txtMotPassePara.Size = new Size(400, 27);
            txtMotPassePara.TabIndex = 14;
            // 
            // txtAdresseIpPara
            // 
            txtAdresseIpPara.Location = new Point(494, 306);
            txtAdresseIpPara.Name = "txtAdresseIpPara";
            txtAdresseIpPara.Size = new Size(400, 27);
            txtAdresseIpPara.TabIndex = 13;
            // 
            // txtNomBasePara
            // 
            txtNomBasePara.Location = new Point(494, 84);
            txtNomBasePara.Name = "txtNomBasePara";
            txtNomBasePara.Size = new Size(400, 27);
            txtNomBasePara.TabIndex = 12;
            // 
            // btnTesterPara
            // 
            btnTesterPara.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTesterPara.Location = new Point(494, 486);
            btnTesterPara.Name = "btnTesterPara";
            btnTesterPara.Size = new Size(200, 60);
            btnTesterPara.TabIndex = 10;
            btnTesterPara.Text = "Tester";
            btnTesterPara.UseVisualStyleBackColor = true;
            // 
            // lblPortSqlPara
            // 
            lblPortSqlPara.AutoSize = true;
            lblPortSqlPara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPortSqlPara.Location = new Point(148, 377);
            lblPortSqlPara.Name = "lblPortSqlPara";
            lblPortSqlPara.Size = new Size(92, 28);
            lblPortSqlPara.TabIndex = 9;
            lblPortSqlPara.Text = "Port SQL";
            // 
            // lblAdressePara
            // 
            lblAdressePara.AutoSize = true;
            lblAdressePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAdressePara.Location = new Point(148, 302);
            lblAdressePara.Name = "lblAdressePara";
            lblAdressePara.Size = new Size(108, 28);
            lblAdressePara.TabIndex = 8;
            lblAdressePara.Text = "Adresse IP";
            // 
            // lblMotPassePara
            // 
            lblMotPassePara.AutoSize = true;
            lblMotPassePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMotPassePara.Location = new Point(148, 231);
            lblMotPassePara.Name = "lblMotPassePara";
            lblMotPassePara.Size = new Size(135, 28);
            lblMotPassePara.TabIndex = 7;
            lblMotPassePara.Text = "Mot de passe";
            // 
            // lblUtilisateurPara
            // 
            lblUtilisateurPara.AutoSize = true;
            lblUtilisateurPara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUtilisateurPara.Location = new Point(148, 154);
            lblUtilisateurPara.Name = "lblUtilisateurPara";
            lblUtilisateurPara.Size = new Size(170, 28);
            lblUtilisateurPara.TabIndex = 6;
            lblUtilisateurPara.Text = "Nom d'utilisateur";
            // 
            // lblBasePara
            // 
            lblBasePara.AutoSize = true;
            lblBasePara.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBasePara.Location = new Point(148, 80);
            lblBasePara.Name = "lblBasePara";
            lblBasePara.Size = new Size(260, 28);
            lblBasePara.TabIndex = 5;
            lblBasePara.Text = "Nom de la base de donnée";
            // 
            // btnResetDB
            // 
            btnResetDB.Location = new Point(923, 602);
            btnResetDB.Name = "btnResetDB";
            btnResetDB.Size = new Size(247, 29);
            btnResetDB.TabIndex = 17;
            btnResetDB.Text = "Reset de la base de donnée";
            btnResetDB.UseVisualStyleBackColor = true;
            // 
            // ParametreControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnResetDB);
            Controls.Add(txtPortSqlPara);
            Controls.Add(btnTesterPara);
            Controls.Add(txtAdresseIpPara);
            Controls.Add(txtMotPassePara);
            Controls.Add(lblPortSqlPara);
            Controls.Add(txtNomUtiliPara);
            Controls.Add(lblBasePara);
            Controls.Add(lblUtilisateurPara);
            Controls.Add(lblMotPassePara);
            Controls.Add(txtNomBasePara);
            Controls.Add(lblAdressePara);
            Name = "ParametreControl";
            Size = new Size(1210, 675);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtPortSqlPara;
        private TextBox txtNomUtiliPara;
        private TextBox txtMotPassePara;
        private TextBox txtAdresseIpPara;
        private TextBox txtNomBasePara;
        private Button btnTesterPara;
        private Label lblPortSqlPara;
        private Label lblAdressePara;
        private Label lblMotPassePara;
        private Label lblUtilisateurPara;
        private Label lblBasePara;
        private Button btnResetDB;
    }
}
