namespace M3_RRO_JSC
{
    partial class RecettesControl
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
            txtRechercheRecettes = new TextBox();
            lblFiltresTextRecette = new Label();
            cboFiltresRecettes = new ComboBox();
            btnSupprimerRecette = new Button();
            btnModifierRecette = new Button();
            btnCreerRecette = new Button();
            lstRecette = new ListBox();
            lstOperation = new ListBox();
            lblListeRecette = new Label();
            lblListeOperation = new Label();
            btnSupprimerOperation = new Button();
            SuspendLayout();
            // 
            // txtRechercheRecettes
            // 
            txtRechercheRecettes.BackColor = SystemColors.InactiveCaption;
            txtRechercheRecettes.BorderStyle = BorderStyle.None;
            txtRechercheRecettes.ForeColor = SystemColors.HighlightText;
            txtRechercheRecettes.Location = new Point(20, 157);
            txtRechercheRecettes.Name = "txtRechercheRecettes";
            txtRechercheRecettes.PlaceholderText = "Rechercher";
            txtRechercheRecettes.Size = new Size(293, 20);
            txtRechercheRecettes.TabIndex = 5;
            // 
            // lblFiltresTextRecette
            // 
            lblFiltresTextRecette.AutoSize = true;
            lblFiltresTextRecette.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFiltresTextRecette.Location = new Point(688, 158);
            lblFiltresTextRecette.Name = "lblFiltresTextRecette";
            lblFiltresTextRecette.Size = new Size(55, 23);
            lblFiltresTextRecette.TabIndex = 4;
            lblFiltresTextRecette.Text = "Filtres";
            // 
            // cboFiltresRecettes
            // 
            cboFiltresRecettes.FormattingEnabled = true;
            cboFiltresRecettes.Location = new Point(811, 157);
            cboFiltresRecettes.Name = "cboFiltresRecettes";
            cboFiltresRecettes.Size = new Size(220, 28);
            cboFiltresRecettes.TabIndex = 3;
            // 
            // btnSupprimerRecette
            // 
            btnSupprimerRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerRecette.Location = new Point(20, 555);
            btnSupprimerRecette.Name = "btnSupprimerRecette";
            btnSupprimerRecette.Size = new Size(346, 60);
            btnSupprimerRecette.TabIndex = 2;
            btnSupprimerRecette.Text = "Supprimer la recette selectionné";
            btnSupprimerRecette.UseVisualStyleBackColor = true;
            // 
            // btnModifierRecette
            // 
            btnModifierRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierRecette.Location = new Point(313, 13);
            btnModifierRecette.Name = "btnModifierRecette";
            btnModifierRecette.Size = new Size(200, 60);
            btnModifierRecette.TabIndex = 1;
            btnModifierRecette.Text = "Modifier";
            btnModifierRecette.UseVisualStyleBackColor = true;
            // 
            // btnCreerRecette
            // 
            btnCreerRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCreerRecette.Location = new Point(3, 3);
            btnCreerRecette.Name = "btnCreerRecette";
            btnCreerRecette.Size = new Size(200, 60);
            btnCreerRecette.TabIndex = 0;
            btnCreerRecette.Text = "Créer";
            btnCreerRecette.UseVisualStyleBackColor = true;
            // 
            // lstRecette
            // 
            lstRecette.FormattingEnabled = true;
            lstRecette.Location = new Point(20, 214);
            lstRecette.Name = "lstRecette";
            lstRecette.Size = new Size(346, 324);
            lstRecette.TabIndex = 6;
            // 
            // lstOperation
            // 
            lstOperation.FormattingEnabled = true;
            lstOperation.Location = new Point(387, 214);
            lstOperation.Name = "lstOperation";
            lstOperation.Size = new Size(346, 324);
            lstOperation.TabIndex = 7;
            // 
            // lblListeRecette
            // 
            lblListeRecette.AutoSize = true;
            lblListeRecette.Location = new Point(20, 113);
            lblListeRecette.Name = "lblListeRecette";
            lblListeRecette.Size = new Size(126, 20);
            lblListeRecette.TabIndex = 8;
            lblListeRecette.Text = "Liste des Recettes";
            // 
            // lblListeOperation
            // 
            lblListeOperation.AutoSize = true;
            lblListeOperation.Location = new Point(415, 113);
            lblListeOperation.Name = "lblListeOperation";
            lblListeOperation.Size = new Size(126, 20);
            lblListeOperation.TabIndex = 9;
            lblListeOperation.Text = "Liste des Recettes";
            // 
            // btnSupprimerOperation
            // 
            btnSupprimerOperation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerOperation.Location = new Point(387, 555);
            btnSupprimerOperation.Name = "btnSupprimerOperation";
            btnSupprimerOperation.Size = new Size(346, 60);
            btnSupprimerOperation.TabIndex = 10;
            btnSupprimerOperation.Text = "Supprimer l'opération selectionné";
            btnSupprimerOperation.UseVisualStyleBackColor = true;
            // 
            // RecettesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnSupprimerOperation);
            Controls.Add(lblListeOperation);
            Controls.Add(lblListeRecette);
            Controls.Add(lstOperation);
            Controls.Add(lstRecette);
            Controls.Add(txtRechercheRecettes);
            Controls.Add(btnCreerRecette);
            Controls.Add(lblFiltresTextRecette);
            Controls.Add(btnModifierRecette);
            Controls.Add(cboFiltresRecettes);
            Controls.Add(btnSupprimerRecette);
            Name = "RecettesControl";
            Size = new Size(1210, 675);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRechercheRecettes;
        private Label lblFiltresTextRecette;
        private ComboBox cboFiltresRecettes;
        private Button btnSupprimerRecette;
        private Button btnModifierRecette;
        private Button btnCreerRecette;
        private ListBox lstRecette;
        private ListBox lstOperation;
        private Label lblListeRecette;
        private Label lblListeOperation;
        private Button btnSupprimerOperation;
    }
}
