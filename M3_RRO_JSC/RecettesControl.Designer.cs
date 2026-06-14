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
            btnSupprimerRecette = new Button();
            btnModifierRecette = new Button();
            btnCreerRecette = new Button();
            lblListeRecette = new Label();
            grdRecette = new DataGridView();
            grdOperationRecette = new DataGridView();
            txtOperationRecette = new TextBox();
            ((System.ComponentModel.ISupportInitialize)grdRecette).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOperationRecette).BeginInit();
            SuspendLayout();
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
            lblListeRecette.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblListeRecette.Location = new Point(514, 81);
            lblListeRecette.Name = "lblListeRecette";
            lblListeRecette.Size = new Size(114, 38);
            lblListeRecette.TabIndex = 8;
            lblListeRecette.Text = "Recette";
            // 
            // grdRecette
            // 
            grdRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdRecette.Location = new Point(33, 125);
            grdRecette.Name = "grdRecette";
            grdRecette.RowHeadersWidth = 51;
            grdRecette.Size = new Size(1037, 214);
            grdRecette.TabIndex = 11;
            grdRecette.SelectionChanged += grdRecette_SelectionChanged;
            // 
            // grdOperationRecette
            // 
            grdOperationRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOperationRecette.Location = new Point(33, 413);
            grdOperationRecette.Name = "grdOperationRecette";
            grdOperationRecette.RowHeadersWidth = 51;
            grdOperationRecette.Size = new Size(1037, 244);
            grdOperationRecette.TabIndex = 13;
            // 
            // txtOperationRecette
            // 
            txtOperationRecette.BackColor = SystemColors.Control;
            txtOperationRecette.BorderStyle = BorderStyle.None;
            txtOperationRecette.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtOperationRecette.Location = new Point(271, 364);
            txtOperationRecette.Name = "txtOperationRecette";
            txtOperationRecette.Size = new Size(606, 36);
            txtOperationRecette.TabIndex = 14;
            txtOperationRecette.Text = "Opération contenu dans la rectte sélectionneé";
            txtOperationRecette.TextAlign = HorizontalAlignment.Right;
            // 
            // RecettesControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtOperationRecette);
            Controls.Add(grdOperationRecette);
            Controls.Add(grdRecette);
            Controls.Add(lblListeRecette);
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
        private Button btnSupprimerRecette;
        private Button btnModifierRecette;
        private Button btnCreerRecette;
        private Label lblListeRecette;
        private DataGridView grdRecette;
        private DataGridView grdOperationRecette;
        private TextBox txtOperationRecette;
    }
}
