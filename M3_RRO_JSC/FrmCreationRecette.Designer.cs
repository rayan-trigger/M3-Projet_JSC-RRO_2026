namespace M3_RRO_JSC
{
    partial class FrmCreationRecette
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
            btnAnnulerCreaRecette = new Button();
            btnTerminerCreaRecette = new Button();
            cboRecetteCreaLot = new ComboBox();
            txtQuantiteCreaLot = new TextBox();
            txtNomCreaLot = new TextBox();
            lblRecetteCreaLot = new Label();
            lblQuantiteCreaLot = new Label();
            lblNomCreaRecette = new Label();
            lblTitreCreaRecette = new Label();
            SuspendLayout();
            // 
            // btnAnnulerCreaRecette
            // 
            btnAnnulerCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnulerCreaRecette.Location = new Point(504, 366);
            btnAnnulerCreaRecette.Name = "btnAnnulerCreaRecette";
            btnAnnulerCreaRecette.Size = new Size(150, 75);
            btnAnnulerCreaRecette.TabIndex = 20;
            btnAnnulerCreaRecette.Text = "Annuler";
            btnAnnulerCreaRecette.UseVisualStyleBackColor = true;
            // 
            // btnTerminerCreaRecette
            // 
            btnTerminerCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTerminerCreaRecette.Location = new Point(313, 366);
            btnTerminerCreaRecette.Name = "btnTerminerCreaRecette";
            btnTerminerCreaRecette.Size = new Size(150, 75);
            btnTerminerCreaRecette.TabIndex = 19;
            btnTerminerCreaRecette.Text = "Terminer";
            btnTerminerCreaRecette.UseVisualStyleBackColor = true;
            // 
            // cboRecetteCreaLot
            // 
            cboRecetteCreaLot.FormattingEnabled = true;
            cboRecetteCreaLot.Location = new Point(404, 206);
            cboRecetteCreaLot.Name = "cboRecetteCreaLot";
            cboRecetteCreaLot.Size = new Size(250, 28);
            cboRecetteCreaLot.TabIndex = 17;
            // 
            // txtQuantiteCreaLot
            // 
            txtQuantiteCreaLot.Location = new Point(404, 144);
            txtQuantiteCreaLot.Name = "txtQuantiteCreaLot";
            txtQuantiteCreaLot.Size = new Size(250, 27);
            txtQuantiteCreaLot.TabIndex = 16;
            // 
            // txtNomCreaLot
            // 
            txtNomCreaLot.Location = new Point(404, 91);
            txtNomCreaLot.Name = "txtNomCreaLot";
            txtNomCreaLot.Size = new Size(250, 27);
            txtNomCreaLot.TabIndex = 15;
            // 
            // lblRecetteCreaLot
            // 
            lblRecetteCreaLot.AutoSize = true;
            lblRecetteCreaLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecetteCreaLot.Location = new Point(142, 202);
            lblRecetteCreaLot.Name = "lblRecetteCreaLot";
            lblRecetteCreaLot.Size = new Size(215, 28);
            lblRecetteCreaLot.TabIndex = 14;
            lblRecetteCreaLot.Text = "Selectionner la recette";
            // 
            // lblQuantiteCreaLot
            // 
            lblQuantiteCreaLot.AutoSize = true;
            lblQuantiteCreaLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantiteCreaLot.Location = new Point(142, 140);
            lblQuantiteCreaLot.Name = "lblQuantiteCreaLot";
            lblQuantiteCreaLot.Size = new Size(183, 28);
            lblQuantiteCreaLot.TabIndex = 13;
            lblQuantiteCreaLot.Text = "Quantité de piéces";
            // 
            // lblNomCreaRecette
            // 
            lblNomCreaRecette.AutoSize = true;
            lblNomCreaRecette.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomCreaRecette.Location = new Point(142, 87);
            lblNomCreaRecette.Name = "lblNomCreaRecette";
            lblNomCreaRecette.Size = new Size(176, 28);
            lblNomCreaRecette.TabIndex = 12;
            lblNomCreaRecette.Text = "Nom de la recette";
            // 
            // lblTitreCreaRecette
            // 
            lblTitreCreaRecette.AutoSize = true;
            lblTitreCreaRecette.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreCreaRecette.Location = new Point(234, 23);
            lblTitreCreaRecette.Name = "lblTitreCreaRecette";
            lblTitreCreaRecette.Size = new Size(353, 31);
            lblTitreCreaRecette.TabIndex = 11;
            lblTitreCreaRecette.Text = "Assistant de Gestion des recettes";
            // 
            // FrmCreationRecette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAnnulerCreaRecette);
            Controls.Add(btnTerminerCreaRecette);
            Controls.Add(cboRecetteCreaLot);
            Controls.Add(txtQuantiteCreaLot);
            Controls.Add(txtNomCreaLot);
            Controls.Add(lblRecetteCreaLot);
            Controls.Add(lblQuantiteCreaLot);
            Controls.Add(lblNomCreaRecette);
            Controls.Add(lblTitreCreaRecette);
            Name = "FrmCreationRecette";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnulerCreaRecette;
        private Button btnTerminerCreaRecette;
        private ComboBox cboRecetteCreaLot;
        private TextBox txtQuantiteCreaLot;
        private TextBox txtNomCreaLot;
        private Label lblRecetteCreaLot;
        private Label lblQuantiteCreaLot;
        private Label lblNomCreaRecette;
        private Label lblTitreCreaRecette;
    }
}