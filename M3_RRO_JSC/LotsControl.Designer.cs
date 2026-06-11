namespace M3_RRO_JSC
{
    partial class LotsControl
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
            grdGestionLots = new DataGridView();
            txtRechercheLots = new TextBox();
            lblFiltresTextLot = new Label();
            cboFiltresLots = new ComboBox();
            btnEnvoyerProductionLot = new Button();
            btnSupprimerLot = new Button();
            btnCreerLot = new Button();
            btnModifierLot = new Button();
            ((System.ComponentModel.ISupportInitialize)grdGestionLots).BeginInit();
            SuspendLayout();
            // 
            // grdGestionLots
            // 
            grdGestionLots.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdGestionLots.GridColor = SystemColors.InactiveBorder;
            grdGestionLots.Location = new Point(106, 201);
            grdGestionLots.Name = "grdGestionLots";
            grdGestionLots.RowHeadersWidth = 51;
            grdGestionLots.Size = new Size(1015, 282);
            grdGestionLots.TabIndex = 10;
            // 
            // txtRechercheLots
            // 
            txtRechercheLots.BackColor = SystemColors.InactiveCaption;
            txtRechercheLots.BorderStyle = BorderStyle.None;
            txtRechercheLots.ForeColor = SystemColors.HighlightText;
            txtRechercheLots.Location = new Point(185, 139);
            txtRechercheLots.Name = "txtRechercheLots";
            txtRechercheLots.PlaceholderText = "Rechercher";
            txtRechercheLots.Size = new Size(864, 20);
            txtRechercheLots.TabIndex = 9;
            // 
            // lblFiltresTextLot
            // 
            lblFiltresTextLot.AutoSize = true;
            lblFiltresTextLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextLot.Location = new Point(768, 97);
            lblFiltresTextLot.Name = "lblFiltresTextLot";
            lblFiltresTextLot.Size = new Size(55, 23);
            lblFiltresTextLot.TabIndex = 8;
            lblFiltresTextLot.Text = "Filtres";
            // 
            // cboFiltresLots
            // 
            cboFiltresLots.FormattingEnabled = true;
            cboFiltresLots.Location = new Point(829, 96);
            cboFiltresLots.Name = "cboFiltresLots";
            cboFiltresLots.Size = new Size(220, 28);
            cboFiltresLots.TabIndex = 7;
            // 
            // btnEnvoyerProductionLot
            // 
            btnEnvoyerProductionLot.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEnvoyerProductionLot.Location = new Point(747, 586);
            btnEnvoyerProductionLot.Name = "btnEnvoyerProductionLot";
            btnEnvoyerProductionLot.Size = new Size(302, 40);
            btnEnvoyerProductionLot.TabIndex = 3;
            btnEnvoyerProductionLot.Text = "Envoyer en production ";
            btnEnvoyerProductionLot.UseVisualStyleBackColor = true;
            btnEnvoyerProductionLot.Click += btnEnvoyerProductionLot_Click;
            // 
            // btnSupprimerLot
            // 
            btnSupprimerLot.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerLot.Location = new Point(415, 3);
            btnSupprimerLot.Name = "btnSupprimerLot";
            btnSupprimerLot.Size = new Size(200, 60);
            btnSupprimerLot.TabIndex = 2;
            btnSupprimerLot.Text = "Supprimer";
            btnSupprimerLot.UseVisualStyleBackColor = true;
            btnSupprimerLot.Click += btnSupprimer_Click;
            // 
            // btnCreerLot
            // 
            btnCreerLot.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreerLot.Location = new Point(3, 3);
            btnCreerLot.Name = "btnCreerLot";
            btnCreerLot.Size = new Size(200, 60);
            btnCreerLot.TabIndex = 0;
            btnCreerLot.Text = "Créer";
            btnCreerLot.UseVisualStyleBackColor = true;
            btnCreerLot.Click += btnCreer_Click;
            // 
            // btnModifierLot
            // 
            btnModifierLot.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifierLot.Location = new Point(209, 3);
            btnModifierLot.Name = "btnModifierLot";
            btnModifierLot.Size = new Size(200, 60);
            btnModifierLot.TabIndex = 11;
            btnModifierLot.Text = "Modifier";
            btnModifierLot.UseVisualStyleBackColor = true;
            btnModifierLot.Click += btnModifierLot_Click;
            // 
            // LotsControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnModifierLot);
            Controls.Add(grdGestionLots);
            Controls.Add(btnEnvoyerProductionLot);
            Controls.Add(txtRechercheLots);
            Controls.Add(btnCreerLot);
            Controls.Add(lblFiltresTextLot);
            Controls.Add(cboFiltresLots);
            Controls.Add(btnSupprimerLot);
            Name = "LotsControl";
            Size = new Size(1210, 675);
            ((System.ComponentModel.ISupportInitialize)grdGestionLots).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdGestionLots;
        private TextBox txtRechercheLots;
        private Label lblFiltresTextLot;
        private ComboBox cboFiltresLots;
        private Button btnEnvoyerProductionLot;
        private Button btnSupprimerLot;
        private Button btnCreerLot;
        private Button btnModifierLot;
    }
}
