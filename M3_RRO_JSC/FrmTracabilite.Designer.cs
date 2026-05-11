namespace M3_RRO_JSC
{
    partial class FrmTracabilite
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
            pnlTracabiliteText = new Panel();
            lblTracabilite = new Label();
            pnlTracabilite = new Panel();
            grdTracabilite = new DataGridView();
            txtRechercheTracabilite = new TextBox();
            lblFiltresTextTracabilite = new Label();
            cboFiltresTracabilite = new ComboBox();
            listBox1 = new ListBox();
            btnAccueil = new Button();
            btnGestionLot = new Button();
            btnParametre = new Button();
            btnGestionRecette = new Button();
            btnTracabilite = new Button();
            pnlTracabiliteText.SuspendLayout();
            pnlTracabilite.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdTracabilite).BeginInit();
            SuspendLayout();
            // 
            // pnlTracabiliteText
            // 
            pnlTracabiliteText.BackColor = SystemColors.ActiveCaption;
            pnlTracabiliteText.Controls.Add(lblTracabilite);
            pnlTracabiliteText.Location = new Point(186, 12);
            pnlTracabiliteText.Name = "pnlTracabiliteText";
            pnlTracabiliteText.Size = new Size(1133, 70);
            pnlTracabiliteText.TabIndex = 18;
            // 
            // lblTracabilite
            // 
            lblTracabilite.AutoSize = true;
            lblTracabilite.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTracabilite.Location = new Point(407, 14);
            lblTracabilite.Name = "lblTracabilite";
            lblTracabilite.Size = new Size(344, 41);
            lblTracabilite.TabIndex = 0;
            lblTracabilite.Text = "Historique / Tracabilité";
            // 
            // pnlTracabilite
            // 
            pnlTracabilite.BackColor = SystemColors.ActiveCaption;
            pnlTracabilite.Controls.Add(grdTracabilite);
            pnlTracabilite.Controls.Add(txtRechercheTracabilite);
            pnlTracabilite.Controls.Add(lblFiltresTextTracabilite);
            pnlTracabilite.Controls.Add(cboFiltresTracabilite);
            pnlTracabilite.Controls.Add(listBox1);
            pnlTracabilite.Location = new Point(186, 88);
            pnlTracabilite.Name = "pnlTracabilite";
            pnlTracabilite.Size = new Size(1133, 677);
            pnlTracabilite.TabIndex = 12;
            // 
            // grdTracabilite
            // 
            grdTracabilite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTracabilite.GridColor = SystemColors.InactiveBorder;
            grdTracabilite.Location = new Point(179, 315);
            grdTracabilite.Name = "grdTracabilite";
            grdTracabilite.RowHeadersWidth = 51;
            grdTracabilite.Size = new Size(864, 188);
            grdTracabilite.TabIndex = 10;
            // 
            // txtRechercheTracabilite
            // 
            txtRechercheTracabilite.BackColor = SystemColors.InactiveCaption;
            txtRechercheTracabilite.BorderStyle = BorderStyle.None;
            txtRechercheTracabilite.ForeColor = SystemColors.HighlightText;
            txtRechercheTracabilite.Location = new Point(179, 262);
            txtRechercheTracabilite.Name = "txtRechercheTracabilite";
            txtRechercheTracabilite.PlaceholderText = "Rechercher";
            txtRechercheTracabilite.Size = new Size(864, 20);
            txtRechercheTracabilite.TabIndex = 9;
            // 
            // lblFiltresTextTracabilite
            // 
            lblFiltresTextTracabilite.AutoSize = true;
            lblFiltresTextTracabilite.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextTracabilite.Location = new Point(745, 217);
            lblFiltresTextTracabilite.Name = "lblFiltresTextTracabilite";
            lblFiltresTextTracabilite.Size = new Size(55, 23);
            lblFiltresTextTracabilite.TabIndex = 8;
            lblFiltresTextTracabilite.Text = "Filtres";
            // 
            // cboFiltresTracabilite
            // 
            cboFiltresTracabilite.FormattingEnabled = true;
            cboFiltresTracabilite.Location = new Point(823, 216);
            cboFiltresTracabilite.Name = "cboFiltresTracabilite";
            cboFiltresTracabilite.Size = new Size(220, 28);
            cboFiltresTracabilite.TabIndex = 7;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(686, 315);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(8, 4);
            listBox1.TabIndex = 4;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = SystemColors.ActiveCaption;
            btnAccueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(12, 9);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(168, 147);
            btnAccueil.TabIndex = 13;
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
            btnGestionLot.TabIndex = 14;
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
            btnParametre.TabIndex = 17;
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
            btnGestionRecette.TabIndex = 15;
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
            btnTracabilite.TabIndex = 16;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = false;
            // 
            // FrmTracabilite
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 777);
            Controls.Add(pnlTracabiliteText);
            Controls.Add(pnlTracabilite);
            Controls.Add(btnAccueil);
            Controls.Add(btnGestionLot);
            Controls.Add(btnParametre);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnTracabilite);
            Name = "FrmTracabilite";
            Text = "Form1";
            pnlTracabiliteText.ResumeLayout(false);
            pnlTracabiliteText.PerformLayout();
            pnlTracabilite.ResumeLayout(false);
            pnlTracabilite.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdTracabilite).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTracabiliteText;
        private Label lblTracabilite;
        private Panel pnlTracabilite;
        private DataGridView grdTracabilite;
        private TextBox txtRechercheTracabilite;
        private Label lblFiltresTextTracabilite;
        private ComboBox cboFiltresTracabilite;
        private ListBox listBox1;
        private Button btnAccueil;
        private Button btnGestionLot;
        private Button btnParametre;
        private Button btnGestionRecette;
        private Button btnTracabilite;
    }
}