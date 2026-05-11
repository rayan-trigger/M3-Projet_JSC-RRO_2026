namespace M3_RRO_JSC
{
    partial class FrmGestionRecettes
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
            pnlGestionRecette = new Panel();
            grdGestionRecette = new DataGridView();
            txtRechercheRecettes = new TextBox();
            lblFiltresTextRecette = new Label();
            cboFiltresRecettes = new ComboBox();
            btnSupprimerRecette = new Button();
            btnModifierRecette = new Button();
            btnCreerRecette = new Button();
            btnAccueil = new Button();
            btnGestionLot = new Button();
            btnParametre = new Button();
            btnGestionRecette = new Button();
            btnTracabilite = new Button();
            pnlGestionRecetteText = new Panel();
            lblGestionRecette = new Label();
            pnlGestionRecette.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdGestionRecette).BeginInit();
            pnlGestionRecetteText.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGestionRecette
            // 
            pnlGestionRecette.BackColor = SystemColors.ActiveCaption;
            pnlGestionRecette.Controls.Add(grdGestionRecette);
            pnlGestionRecette.Controls.Add(txtRechercheRecettes);
            pnlGestionRecette.Controls.Add(lblFiltresTextRecette);
            pnlGestionRecette.Controls.Add(cboFiltresRecettes);
            pnlGestionRecette.Controls.Add(btnSupprimerRecette);
            pnlGestionRecette.Controls.Add(btnModifierRecette);
            pnlGestionRecette.Controls.Add(btnCreerRecette);
            pnlGestionRecette.Location = new Point(186, 88);
            pnlGestionRecette.Name = "pnlGestionRecette";
            pnlGestionRecette.Size = new Size(1133, 683);
            pnlGestionRecette.TabIndex = 1;
            // 
            // grdGestionRecette
            // 
            grdGestionRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGestionRecette.GridColor = SystemColors.InactiveBorder;
            grdGestionRecette.Location = new Point(220, 349);
            grdGestionRecette.Name = "grdGestionRecette";
            grdGestionRecette.RowHeadersWidth = 51;
            grdGestionRecette.Size = new Size(864, 188);
            grdGestionRecette.TabIndex = 6;
            // 
            // txtRechercheRecettes
            // 
            txtRechercheRecettes.BackColor = SystemColors.InactiveCaption;
            txtRechercheRecettes.BorderStyle = BorderStyle.None;
            txtRechercheRecettes.ForeColor = SystemColors.HighlightText;
            txtRechercheRecettes.Location = new Point(220, 296);
            txtRechercheRecettes.Name = "txtRechercheRecettes";
            txtRechercheRecettes.PlaceholderText = "Rechercher";
            txtRechercheRecettes.Size = new Size(864, 20);
            txtRechercheRecettes.TabIndex = 5;
            // 
            // lblFiltresTextRecette
            // 
            lblFiltresTextRecette.AutoSize = true;
            lblFiltresTextRecette.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextRecette.Location = new Point(786, 251);
            lblFiltresTextRecette.Name = "lblFiltresTextRecette";
            lblFiltresTextRecette.Size = new Size(55, 23);
            lblFiltresTextRecette.TabIndex = 4;
            lblFiltresTextRecette.Text = "Filtres";
            // 
            // cboFiltresRecettes
            // 
            cboFiltresRecettes.FormattingEnabled = true;
            cboFiltresRecettes.Location = new Point(864, 250);
            cboFiltresRecettes.Name = "cboFiltresRecettes";
            cboFiltresRecettes.Size = new Size(220, 28);
            cboFiltresRecettes.TabIndex = 3;
            // 
            // btnSupprimerRecette
            // 
            btnSupprimerRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerRecette.Location = new Point(426, 11);
            btnSupprimerRecette.Name = "btnSupprimerRecette";
            btnSupprimerRecette.Size = new Size(200, 60);
            btnSupprimerRecette.TabIndex = 2;
            btnSupprimerRecette.Text = "Supprimer";
            btnSupprimerRecette.UseVisualStyleBackColor = true;
            // 
            // btnModifierRecette
            // 
            btnModifierRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierRecette.Location = new Point(220, 11);
            btnModifierRecette.Name = "btnModifierRecette";
            btnModifierRecette.Size = new Size(200, 60);
            btnModifierRecette.TabIndex = 1;
            btnModifierRecette.Text = "Modifier";
            btnModifierRecette.UseVisualStyleBackColor = true;
            // 
            // btnCreerRecette
            // 
            btnCreerRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreerRecette.Location = new Point(14, 11);
            btnCreerRecette.Name = "btnCreerRecette";
            btnCreerRecette.Size = new Size(200, 60);
            btnCreerRecette.TabIndex = 0;
            btnCreerRecette.Text = "Créer";
            btnCreerRecette.UseVisualStyleBackColor = true;
            // 
            // btnAccueil
            // 
            btnAccueil.BackColor = SystemColors.ActiveCaption;
            btnAccueil.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(12, 12);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(168, 147);
            btnAccueil.TabIndex = 11;
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
            btnGestionLot.TabIndex = 12;
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
            btnParametre.TabIndex = 15;
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
            btnGestionRecette.TabIndex = 13;
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
            btnTracabilite.TabIndex = 14;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = false;
            // 
            // pnlGestionRecetteText
            // 
            pnlGestionRecetteText.BackColor = SystemColors.ActiveCaption;
            pnlGestionRecetteText.Controls.Add(lblGestionRecette);
            pnlGestionRecetteText.Location = new Point(186, 12);
            pnlGestionRecetteText.Name = "pnlGestionRecetteText";
            pnlGestionRecetteText.Size = new Size(1133, 70);
            pnlGestionRecetteText.TabIndex = 16;
            // 
            // lblGestionRecette
            // 
            lblGestionRecette.AutoSize = true;
            lblGestionRecette.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGestionRecette.Location = new Point(407, 14);
            lblGestionRecette.Name = "lblGestionRecette";
            lblGestionRecette.Size = new Size(307, 41);
            lblGestionRecette.TabIndex = 0;
            lblGestionRecette.Text = "Gestion des Recettes";
            // 
            // FrmGestionRecettes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 777);
            Controls.Add(pnlGestionRecetteText);
            Controls.Add(btnAccueil);
            Controls.Add(btnGestionLot);
            Controls.Add(btnParametre);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnTracabilite);
            Controls.Add(pnlGestionRecette);
            Name = "FrmGestionRecettes";
            Text = "Gestion des recettes";
            pnlGestionRecette.ResumeLayout(false);
            pnlGestionRecette.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grdGestionRecette).EndInit();
            pnlGestionRecetteText.ResumeLayout(false);
            pnlGestionRecetteText.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlGestionRecette;
        private Button btnSupprimerRecette;
        private Button btnModifierRecette;
        private Button btnCreerRecette;
        private Button btnAccueil;
        private Button btnGestionLot;
        private Button btnParametre;
        private Button btnGestionRecette;
        private Button btnTracabilite;
        private Panel pnlGestionRecetteText;
        private Label lblGestionRecette;
        private DataGridView grdGestionRecette;
        private TextBox txtRechercheRecettes;
        private Label lblFiltresTextRecette;
        private ComboBox cboFiltresRecettes;
    }
}