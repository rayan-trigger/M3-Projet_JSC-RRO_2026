namespace M3_RRO_JSC
{
    partial class FrmGestionLots
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
            btnAccueil = new Button();
            btnGestionLot = new Button();
            btnParametre = new Button();
            btnGestionRecette = new Button();
            btnTracabilite = new Button();
            pnlGestionLot = new Panel();
            listBox1 = new ListBox();
            btnEnvoyerProductionLot = new Button();
            btnSupprimerLot = new Button();
            btnModifierLot = new Button();
            btnCreerLot = new Button();
            pnlGestionLotText = new Panel();
            lblGestionLot = new Label();
            grdGestionLots = new DataGridView();
            txtRechercheLots = new TextBox();
            lblFiltresTextLot = new Label();
            cboFiltresLots = new ComboBox();
            pnlGestionLot.SuspendLayout();
            pnlGestionLotText.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdGestionLots).BeginInit();
            SuspendLayout();
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = SystemColors.ActiveCaption;
            btnAccueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(12, 12);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(168, 147);
            btnAccueil.TabIndex = 6;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = false;
            // 
            // btnGestionLot
            // 
            btnGestionLot.BackColor = SystemColors.ActiveCaption;
            btnGestionLot.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionLot.Location = new Point(12, 165);
            btnGestionLot.Name = "btnGestionLot";
            btnGestionLot.Size = new Size(168, 147);
            btnGestionLot.TabIndex = 7;
            btnGestionLot.Text = "Gestion des lots ";
            btnGestionLot.UseVisualStyleBackColor = false;
            // 
            // btnParametre
            // 
            btnParametre.BackColor = SystemColors.ActiveCaption;
            btnParametre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParametre.Location = new Point(12, 624);
            btnParametre.Name = "btnParametre";
            btnParametre.Size = new Size(168, 147);
            btnParametre.TabIndex = 10;
            btnParametre.Text = "Paramètres";
            btnParametre.UseVisualStyleBackColor = false;
            // 
            // btnGestionRecette
            // 
            btnGestionRecette.BackColor = SystemColors.ActiveCaption;
            btnGestionRecette.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionRecette.Location = new Point(12, 318);
            btnGestionRecette.Name = "btnGestionRecette";
            btnGestionRecette.Size = new Size(168, 147);
            btnGestionRecette.TabIndex = 8;
            btnGestionRecette.Text = "Gestion des recettes";
            btnGestionRecette.UseVisualStyleBackColor = false;
            // 
            // btnTracabilite
            // 
            btnTracabilite.BackColor = SystemColors.ActiveCaption;
            btnTracabilite.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTracabilite.Location = new Point(12, 471);
            btnTracabilite.Name = "btnTracabilite";
            btnTracabilite.Size = new Size(168, 147);
            btnTracabilite.TabIndex = 9;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = false;
            // 
            // pnlGestionLot
            // 
            pnlGestionLot.BackColor = SystemColors.ActiveCaption;
            pnlGestionLot.Controls.Add(grdGestionLots);
            pnlGestionLot.Controls.Add(txtRechercheLots);
            pnlGestionLot.Controls.Add(lblFiltresTextLot);
            pnlGestionLot.Controls.Add(cboFiltresLots);
            pnlGestionLot.Controls.Add(listBox1);
            pnlGestionLot.Controls.Add(btnEnvoyerProductionLot);
            pnlGestionLot.Controls.Add(btnSupprimerLot);
            pnlGestionLot.Controls.Add(btnModifierLot);
            pnlGestionLot.Controls.Add(btnCreerLot);
            pnlGestionLot.Location = new Point(186, 88);
            pnlGestionLot.Name = "pnlGestionLot";
            pnlGestionLot.Size = new Size(1133, 677);
            pnlGestionLot.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(686, 315);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(8, 4);
            listBox1.TabIndex = 4;
            // 
            // btnEnvoyerProductionLot
            // 
            btnEnvoyerProductionLot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnvoyerProductionLot.Location = new Point(741, 599);
            btnEnvoyerProductionLot.Name = "btnEnvoyerProductionLot";
            btnEnvoyerProductionLot.Size = new Size(302, 40);
            btnEnvoyerProductionLot.TabIndex = 3;
            btnEnvoyerProductionLot.Text = "Envoyer en production ";
            btnEnvoyerProductionLot.UseVisualStyleBackColor = true;
            // 
            // btnSupprimerLot
            // 
            btnSupprimerLot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerLot.Location = new Point(426, 11);
            btnSupprimerLot.Name = "btnSupprimerLot";
            btnSupprimerLot.Size = new Size(200, 60);
            btnSupprimerLot.TabIndex = 2;
            btnSupprimerLot.Text = "Supprimer";
            btnSupprimerLot.UseVisualStyleBackColor = true;
            // 
            // btnModifierLot
            // 
            btnModifierLot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierLot.Location = new Point(220, 11);
            btnModifierLot.Name = "btnModifierLot";
            btnModifierLot.Size = new Size(200, 60);
            btnModifierLot.TabIndex = 1;
            btnModifierLot.Text = "Modifier";
            btnModifierLot.UseVisualStyleBackColor = true;
            // 
            // btnCreerLot
            // 
            btnCreerLot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreerLot.Location = new Point(14, 12);
            btnCreerLot.Name = "btnCreerLot";
            btnCreerLot.Size = new Size(200, 60);
            btnCreerLot.TabIndex = 0;
            btnCreerLot.Text = "Créer";
            btnCreerLot.UseVisualStyleBackColor = true;
            // 
            // pnlGestionLotText
            // 
            pnlGestionLotText.BackColor = SystemColors.ActiveCaption;
            pnlGestionLotText.Controls.Add(lblGestionLot);
            pnlGestionLotText.Location = new Point(186, 12);
            pnlGestionLotText.Name = "pnlGestionLotText";
            pnlGestionLotText.Size = new Size(1133, 70);
            pnlGestionLotText.TabIndex = 11;
            // 
            // lblGestionLot
            // 
            lblGestionLot.AutoSize = true;
            lblGestionLot.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionLot.Location = new Point(407, 14);
            lblGestionLot.Name = "lblGestionLot";
            lblGestionLot.Size = new Size(241, 41);
            lblGestionLot.TabIndex = 0;
            lblGestionLot.Text = "Gestion des lots";
            // 
            // grdGestionLots
            // 
            grdGestionLots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGestionLots.GridColor = SystemColors.InactiveBorder;
            grdGestionLots.Location = new Point(179, 315);
            grdGestionLots.Name = "grdGestionLots";
            grdGestionLots.RowHeadersWidth = 51;
            grdGestionLots.Size = new Size(864, 188);
            grdGestionLots.TabIndex = 10;
            // 
            // txtRechercheLots
            // 
            txtRechercheLots.BackColor = SystemColors.InactiveCaption;
            txtRechercheLots.BorderStyle = BorderStyle.None;
            txtRechercheLots.ForeColor = SystemColors.HighlightText;
            txtRechercheLots.Location = new Point(179, 262);
            txtRechercheLots.Name = "txtRechercheLots";
            txtRechercheLots.PlaceholderText = "Rechercher";
            txtRechercheLots.Size = new Size(864, 20);
            txtRechercheLots.TabIndex = 9;
            // 
            // lblFiltresTextLot
            // 
            lblFiltresTextLot.AutoSize = true;
            lblFiltresTextLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextLot.Location = new Point(745, 217);
            lblFiltresTextLot.Name = "lblFiltresTextLot";
            lblFiltresTextLot.Size = new Size(55, 23);
            lblFiltresTextLot.TabIndex = 8;
            lblFiltresTextLot.Text = "Filtres";
            // 
            // cboFiltresLots
            // 
            cboFiltresLots.FormattingEnabled = true;
            cboFiltresLots.Location = new Point(823, 216);
            cboFiltresLots.Name = "cboFiltresLots";
            cboFiltresLots.Size = new Size(220, 28);
            cboFiltresLots.TabIndex = 7;
            // 
            // Gestion_lot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 777);
            Controls.Add(pnlGestionLotText);
            Controls.Add(pnlGestionLot);
            Controls.Add(btnAccueil);
            Controls.Add(btnGestionLot);
            Controls.Add(btnParametre);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnTracabilite);
            Name = "Gestion_lot";
            Text = "Gestion des lots ";
            pnlGestionLot.ResumeLayout(false);
            pnlGestionLot.PerformLayout();
            pnlGestionLotText.ResumeLayout(false);
            pnlGestionLotText.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdGestionLots).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAccueil;
        private Button btnGestionLot;
        private Button btnParametre;
        private Button btnGestionRecette;
        private Button btnTracabilite;
        private Panel pnlGestionLot;
        private Button btnEnvoyerProductionLot;
        private Button btnSupprimerLot;
        private Button btnModifierLot;
        private Button btnCreerLot;
        private Panel pnlGestionLotText;
        private Label lblGestionLot;
        private ListBox listBox1;
        private DataGridView grdGestionLots;
        private TextBox txtRechercheLots;
        private Label lblFiltresTextLot;
        private ComboBox cboFiltresLots;
    }
}