namespace M3_RRO_JSC
{
    partial class TracabiliteControl
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
            grdTracabilite = new DataGridView();
            txtRechercheTracabilite = new TextBox();
            lblFiltresTextTracabilite = new Label();
            cboFiltresTracabilite = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)grdTracabilite).BeginInit();
            SuspendLayout();
            // 
            // grdTracabilite
            // 
            grdTracabilite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdTracabilite.GridColor = SystemColors.InactiveBorder;
            grdTracabilite.Location = new Point(200, 177);
            grdTracabilite.Name = "grdTracabilite";
            grdTracabilite.RowHeadersWidth = 51;
            grdTracabilite.Size = new Size(864, 336);
            grdTracabilite.TabIndex = 10;
            // 
            // txtRechercheTracabilite
            // 
            txtRechercheTracabilite.BackColor = SystemColors.InactiveCaption;
            txtRechercheTracabilite.BorderStyle = BorderStyle.None;
            txtRechercheTracabilite.ForeColor = SystemColors.HighlightText;
            txtRechercheTracabilite.Location = new Point(200, 134);
            txtRechercheTracabilite.Name = "txtRechercheTracabilite";
            txtRechercheTracabilite.PlaceholderText = "Rechercher";
            txtRechercheTracabilite.Size = new Size(864, 20);
            txtRechercheTracabilite.TabIndex = 9;
            // 
            // lblFiltresTextTracabilite
            // 
            lblFiltresTextTracabilite.AutoSize = true;
            lblFiltresTextTracabilite.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextTracabilite.Location = new Point(773, 89);
            lblFiltresTextTracabilite.Name = "lblFiltresTextTracabilite";
            lblFiltresTextTracabilite.Size = new Size(55, 23);
            lblFiltresTextTracabilite.TabIndex = 8;
            lblFiltresTextTracabilite.Text = "Filtres";
            // 
            // cboFiltresTracabilite
            // 
            cboFiltresTracabilite.FormattingEnabled = true;
            cboFiltresTracabilite.Location = new Point(844, 88);
            cboFiltresTracabilite.Name = "cboFiltresTracabilite";
            cboFiltresTracabilite.Size = new Size(220, 28);
            cboFiltresTracabilite.TabIndex = 7;
            cboFiltresTracabilite.SelectedIndexChanged += cboFiltresTracabilite_SelectedIndexChanged;
            // 
            // TracabiliteControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grdTracabilite);
            Controls.Add(lblFiltresTextTracabilite);
            Controls.Add(txtRechercheTracabilite);
            Controls.Add(cboFiltresTracabilite);
            Name = "TracabiliteControl";
            Size = new Size(1210, 675);
            Load += TracabiliteControl_Load;
            ((System.ComponentModel.ISupportInitialize)grdTracabilite).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView grdTracabilite;
        private TextBox txtRechercheTracabilite;
        private Label lblFiltresTextTracabilite;
        private ComboBox cboFiltresTracabilite;
    }
}
