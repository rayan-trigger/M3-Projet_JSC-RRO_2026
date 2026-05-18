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
            NavBarMain = new NavBar();
            pnlRight = new Panel();
            pnlTitre = new Panel();
            lblTitre = new Label();
            pnlMain = new Panel();
            pnlRight.SuspendLayout();
            pnlTitre.SuspendLayout();
            SuspendLayout();
            // 
            // NavBarMain
            // 
            NavBarMain.Location = new Point(12, 7);
            NavBarMain.Name = "NavBarMain";
            NavBarMain.Size = new Size(180, 755);
            NavBarMain.TabIndex = 8;
            // 
            // pnlRight
            // 
            pnlRight.Controls.Add(pnlTitre);
            pnlRight.Location = new Point(198, 7);
            pnlRight.Name = "pnlRight";
            pnlRight.Size = new Size(1210, 755);
            pnlRight.TabIndex = 9;
            // 
            // pnlTitre
            // 
            pnlTitre.BackColor = SystemColors.ActiveCaption;
            pnlTitre.Controls.Add(lblTitre);
            pnlTitre.Location = new Point(0, 0);
            pnlTitre.Name = "pnlTitre";
            pnlTitre.Size = new Size(1210, 75);
            pnlTitre.TabIndex = 0;
            // 
            // lblTitre
            // 
            lblTitre.AutoSize = true;
            lblTitre.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(540, 16);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(131, 46);
            lblTitre.TabIndex = 1;
            lblTitre.Text = "Accueil";
            // 
            // pnlMain
            // 
            pnlMain.Location = new Point(198, 84);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(1210, 675);
            pnlMain.TabIndex = 1;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1415, 774);
            Controls.Add(pnlMain);
            Controls.Add(NavBarMain);
            Controls.Add(pnlRight);
            Name = "FrmMain";
            Text = "Acceuil";
            pnlRight.ResumeLayout(false);
            pnlTitre.ResumeLayout(false);
            pnlTitre.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private NavBar NavBarMain;
        private Panel pnlTitre;
        private Panel pnlRight;
        private Label lblTitre;
        private Panel pnlMain;
    }
}