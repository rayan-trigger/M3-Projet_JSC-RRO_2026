namespace M3_RRO_JSC
{
    partial class FrmCreationLot
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
            lblTitreCreaLot = new Label();
            lblNomCreaLot = new Label();
            lblQuantiteCreaLot = new Label();
            lblRecetteCreaLot = new Label();
            txtNomCreaLot = new TextBox();
            txtQuantiteCreaLot = new TextBox();
            cboRecetteCreaLot = new ComboBox();
            btnTerminerCreaLot = new Button();
            btnAnnulerCreaLot = new Button();
            btnCreeCreaLot = new Button();
            SuspendLayout();
            // 
            // lblTitreCreaLot
            // 
            lblTitreCreaLot.AutoSize = true;
            lblTitreCreaLot.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreCreaLot.Location = new Point(283, 31);
            lblTitreCreaLot.Name = "lblTitreCreaLot";
            lblTitreCreaLot.Size = new Size(309, 31);
            lblTitreCreaLot.TabIndex = 0;
            lblTitreCreaLot.Text = "Assistant de Gestion des lots";
            // 
            // lblNomCreaLot
            // 
            lblNomCreaLot.AutoSize = true;
            lblNomCreaLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomCreaLot.Location = new Point(142, 108);
            lblNomCreaLot.Name = "lblNomCreaLot";
            lblNomCreaLot.Size = new Size(117, 28);
            lblNomCreaLot.TabIndex = 1;
            lblNomCreaLot.Text = "Nom du lot";
            // 
            // lblQuantiteCreaLot
            // 
            lblQuantiteCreaLot.AutoSize = true;
            lblQuantiteCreaLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantiteCreaLot.Location = new Point(142, 161);
            lblQuantiteCreaLot.Name = "lblQuantiteCreaLot";
            lblQuantiteCreaLot.Size = new Size(183, 28);
            lblQuantiteCreaLot.TabIndex = 2;
            lblQuantiteCreaLot.Text = "Quantité de piéces";
            // 
            // lblRecetteCreaLot
            // 
            lblRecetteCreaLot.AutoSize = true;
            lblRecetteCreaLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecetteCreaLot.Location = new Point(142, 223);
            lblRecetteCreaLot.Name = "lblRecetteCreaLot";
            lblRecetteCreaLot.Size = new Size(215, 28);
            lblRecetteCreaLot.TabIndex = 3;
            lblRecetteCreaLot.Text = "Selectionner la recette";
            // 
            // txtNomCreaLot
            // 
            txtNomCreaLot.Location = new Point(404, 112);
            txtNomCreaLot.Name = "txtNomCreaLot";
            txtNomCreaLot.Size = new Size(250, 27);
            txtNomCreaLot.TabIndex = 4;
            // 
            // txtQuantiteCreaLot
            // 
            txtQuantiteCreaLot.Location = new Point(404, 165);
            txtQuantiteCreaLot.Name = "txtQuantiteCreaLot";
            txtQuantiteCreaLot.Size = new Size(250, 27);
            txtQuantiteCreaLot.TabIndex = 5;
            // 
            // cboRecetteCreaLot
            // 
            cboRecetteCreaLot.FormattingEnabled = true;
            cboRecetteCreaLot.Location = new Point(404, 227);
            cboRecetteCreaLot.Name = "cboRecetteCreaLot";
            cboRecetteCreaLot.Size = new Size(250, 28);
            cboRecetteCreaLot.TabIndex = 6;
            // 
            // btnTerminerCreaLot
            // 
            btnTerminerCreaLot.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTerminerCreaLot.Location = new Point(313, 387);
            btnTerminerCreaLot.Name = "btnTerminerCreaLot";
            btnTerminerCreaLot.Size = new Size(150, 75);
            btnTerminerCreaLot.TabIndex = 8;
            btnTerminerCreaLot.Text = "Terminer";
            btnTerminerCreaLot.UseVisualStyleBackColor = true;
            btnTerminerCreaLot.Click += btnTerminer_Click;
            // 
            // btnAnnulerCreaLot
            // 
            btnAnnulerCreaLot.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnulerCreaLot.Location = new Point(504, 387);
            btnAnnulerCreaLot.Name = "btnAnnulerCreaLot";
            btnAnnulerCreaLot.Size = new Size(150, 75);
            btnAnnulerCreaLot.TabIndex = 10;
            btnAnnulerCreaLot.Text = "Annuler";
            btnAnnulerCreaLot.UseVisualStyleBackColor = true;
            btnAnnulerCreaLot.Click += btnAnnulerCreaLot_Click;
            // 
            // btnCreeCreaLot
            // 
            btnCreeCreaLot.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreeCreaLot.Location = new Point(508, 283);
            btnCreeCreaLot.Name = "btnCreeCreaLot";
            btnCreeCreaLot.Size = new Size(150, 40);
            btnCreeCreaLot.TabIndex = 7;
            btnCreeCreaLot.Text = "Créer Recette";
            btnCreeCreaLot.UseVisualStyleBackColor = true;
            btnCreeCreaLot.Click += btnCreeCreaLot_Click;
            // 
            // FrmCreationLot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(btnAnnulerCreaLot);
            Controls.Add(btnTerminerCreaLot);
            Controls.Add(btnCreeCreaLot);
            Controls.Add(cboRecetteCreaLot);
            Controls.Add(txtQuantiteCreaLot);
            Controls.Add(txtNomCreaLot);
            Controls.Add(lblRecetteCreaLot);
            Controls.Add(lblQuantiteCreaLot);
            Controls.Add(lblNomCreaLot);
            Controls.Add(lblTitreCreaLot);
            Name = "FrmCreationLot";
            Text = "FrmCreationLot";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitreCreaLot;
        private Label lblNomCreaLot;
        private Label lblQuantiteCreaLot;
        private Label lblRecetteCreaLot;
        private TextBox txtNomCreaLot;
        private TextBox txtQuantiteCreaLot;
        private ComboBox cboRecetteCreaLot;
        private Button btnTerminerCreaLot;
        private Button btnAnnulerCreaLot;
        private Button btnCreeCreaLot;
    }
}