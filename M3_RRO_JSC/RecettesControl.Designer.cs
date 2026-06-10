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
            btnSupprimerRecette = new Button();
            btnModifierRecette = new Button();
            btnCreerRecette = new Button();
            lblListeRecette = new Label();
            grdRecette = new DataGridView();
            cboRecette = new ComboBox();
            grdOperationRecette = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdRecette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOperationRecette).BeginInit();
            SuspendLayout();
            // 
            // txtRechercheRecettes
            // 
            txtRechercheRecettes.BackColor = SystemColors.InactiveCaption;
            txtRechercheRecettes.BorderStyle = BorderStyle.None;
            txtRechercheRecettes.ForeColor = SystemColors.HighlightText;
            txtRechercheRecettes.Location = new Point(604, 81);
            txtRechercheRecettes.Name = "txtRechercheRecettes";
            txtRechercheRecettes.PlaceholderText = "Rechercher";
            txtRechercheRecettes.Size = new Size(293, 20);
            txtRechercheRecettes.TabIndex = 5;
            // 
            // btnSupprimerRecette
            // 
            btnSupprimerRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSupprimerRecette.Location = new Point(561, 3);
            btnSupprimerRecette.Name = "btnSupprimerRecette";
            btnSupprimerRecette.Size = new Size(346, 60);
            btnSupprimerRecette.TabIndex = 2;
            btnSupprimerRecette.Text = "Supprimer la recette selectionné";
            btnSupprimerRecette.UseVisualStyleBackColor = true;
            btnSupprimerRecette.Click += btnSupprimerRecette_Click;
            // 
            // btnModifierRecette
            // 
            btnModifierRecette.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModifierRecette.Location = new Point(209, 3);
            btnModifierRecette.Name = "btnModifierRecette";
            btnModifierRecette.Size = new Size(346, 60);
            btnModifierRecette.TabIndex = 1;
            btnModifierRecette.Text = "Modifier la recette selectionné";
            btnModifierRecette.UseVisualStyleBackColor = true;
            btnModifierRecette.Click += btnModifierRecette_Click;
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
            btnCreerRecette.Click += btnCreerRecette_Click;
            // 
            // lblListeRecette
            // 
            lblListeRecette.AutoSize = true;
            lblListeRecette.Location = new Point(10, 81);
            lblListeRecette.Name = "lblListeRecette";
            lblListeRecette.Size = new Size(210, 20);
            lblListeRecette.TabIndex = 8;
            lblListeRecette.Text = "Selectionner la recette afiicher";
            // 
            // grdRecette
            // 
            grdRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRecette.Location = new Point(3, 115);
            grdRecette.Name = "grdRecette";
            grdRecette.RowHeadersWidth = 51;
            grdRecette.Size = new Size(1037, 214);
            grdRecette.TabIndex = 11;
            grdRecette.SelectionChanged += grdRecette_SelectionChanged;
            // 
            // cboRecette
            // 
            cboRecette.FormattingEnabled = true;
            cboRecette.Location = new Point(240, 81);
            cboRecette.Name = "cboRecette";
            cboRecette.Size = new Size(200, 28);
            cboRecette.TabIndex = 12;
            // 
            // grdOperationRecette
            // 
            grdOperationRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOperationRecette.Location = new Point(0, 373);
            grdOperationRecette.Name = "grdOperationRecette";
            grdOperationRecette.RowHeadersWidth = 51;
            grdOperationRecette.Size = new Size(1037, 244);
            grdOperationRecette.TabIndex = 13;
            // 
            // RecettesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(grdOperationRecette);
            Controls.Add(cboRecette);
            Controls.Add(grdRecette);
            Controls.Add(lblListeRecette);
            Controls.Add(txtRechercheRecettes);
            Controls.Add(btnCreerRecette);
            Controls.Add(btnModifierRecette);
            Controls.Add(btnSupprimerRecette);
            Name = "RecettesControl";
            Size = new Size(1210, 675);
            ((System.ComponentModel.ISupportInitialize)grdRecette).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdOperationRecette).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtRechercheRecettes;
        private Button btnSupprimerRecette;
        private Button btnModifierRecette;
        private Button btnCreerRecette;
        private Label lblListeRecette;
        private DataGridView grdRecette;
        private ComboBox cboRecette;
        private DataGridView dataGridView1;
        private DataGridView grdOperationRecette;
    }
}
