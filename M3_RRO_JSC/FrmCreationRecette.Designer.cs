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
            btnEnregistrerCreaRecette = new Button();
            txtNomCreaLot = new TextBox();
            lblNomCreaRecette = new Label();
            lblTitreCreaRecette = new Label();
            lblNomOperation = new Label();
            lblSmoteurCreaRecette = new Label();
            lblTempsCreaRecette = new Label();
            txtNomOperation = new TextBox();
            lblPositionMoteurCreaRecette = new Label();
            grdOperationCreaRecette = new DataGridView();
            ckbMoteurCreaRecette = new CheckBox();
            cboSensCreaRecette = new ComboBox();
            cboPositionCreaRecette = new ComboBox();
            cboTempsCreaRecette = new ComboBox();
            ckbQuittanceCreaRecette = new CheckBox();
            ckbCycleVerinCreaRecette = new CheckBox();
            btnValiderCreaRecette = new Button();
            btnSupprimerCreaRecette = new Button();
            ((System.ComponentModel.ISupportInitialize)grdOperationCreaRecette).BeginInit();
            SuspendLayout();
            // 
            // btnAnnulerCreaRecette
            // 
            btnAnnulerCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAnnulerCreaRecette.Location = new Point(313, 512);
            btnAnnulerCreaRecette.Name = "btnAnnulerCreaRecette";
            btnAnnulerCreaRecette.Size = new Size(150, 75);
            btnAnnulerCreaRecette.TabIndex = 20;
            btnAnnulerCreaRecette.Text = "Annuler";
            btnAnnulerCreaRecette.UseVisualStyleBackColor = true;
            btnAnnulerCreaRecette.Click += btnAnnulerCreaRecette_Click;
            // 
            // btnEnregistrerCreaRecette
            // 
            btnEnregistrerCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnregistrerCreaRecette.Location = new Point(133, 512);
            btnEnregistrerCreaRecette.Name = "btnEnregistrerCreaRecette";
            btnEnregistrerCreaRecette.Size = new Size(150, 75);
            btnEnregistrerCreaRecette.TabIndex = 19;
            btnEnregistrerCreaRecette.Text = "Enregistrer la recette";
            btnEnregistrerCreaRecette.UseVisualStyleBackColor = true;
            btnEnregistrerCreaRecette.Click += btnEnregistrerCreaRecette_Click;
            // 
            // txtNomCreaLot
            // 
            txtNomCreaLot.Location = new Point(213, 88);
            txtNomCreaLot.Name = "txtNomCreaLot";
            txtNomCreaLot.Size = new Size(250, 27);
            txtNomCreaLot.TabIndex = 15;
            // 
            // lblNomCreaRecette
            // 
            lblNomCreaRecette.AutoSize = true;
            lblNomCreaRecette.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNomCreaRecette.Location = new Point(12, 84);
            lblNomCreaRecette.Name = "lblNomCreaRecette";
            lblNomCreaRecette.Size = new Size(176, 28);
            lblNomCreaRecette.TabIndex = 12;
            lblNomCreaRecette.Text = "Nom de la recette";
            // 
            // lblTitreCreaRecette
            // 
            lblTitreCreaRecette.AutoSize = true;
            lblTitreCreaRecette.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitreCreaRecette.Location = new Point(467, 9);
            lblTitreCreaRecette.Name = "lblTitreCreaRecette";
            lblTitreCreaRecette.Size = new Size(342, 31);
            lblTitreCreaRecette.TabIndex = 11;
            lblTitreCreaRecette.Text = "Assistant de Creation de recette";
            // 
            // lblNomOperation
            // 
            lblNomOperation.AutoSize = true;
            lblNomOperation.Location = new Point(33, 186);
            lblNomOperation.Name = "lblNomOperation";
            lblNomOperation.Size = new Size(139, 20);
            lblNomOperation.TabIndex = 22;
            lblNomOperation.Text = "Nom de l'opération";
            // 
            // lblSmoteurCreaRecette
            // 
            lblSmoteurCreaRecette.AutoSize = true;
            lblSmoteurCreaRecette.Location = new Point(597, 185);
            lblSmoteurCreaRecette.Name = "lblSmoteurCreaRecette";
            lblSmoteurCreaRecette.Size = new Size(39, 20);
            lblSmoteurCreaRecette.TabIndex = 24;
            lblSmoteurCreaRecette.Text = "Sens";
            // 
            // lblTempsCreaRecette
            // 
            lblTempsCreaRecette.AutoSize = true;
            lblTempsCreaRecette.Location = new Point(44, 229);
            lblTempsCreaRecette.Name = "lblTempsCreaRecette";
            lblTempsCreaRecette.Size = new Size(117, 20);
            lblTempsCreaRecette.TabIndex = 26;
            lblTempsCreaRecette.Text = "Temps D'attente";
            // 
            // txtNomOperation
            // 
            txtNomOperation.Location = new Point(178, 183);
            txtNomOperation.Name = "txtNomOperation";
            txtNomOperation.Size = new Size(216, 27);
            txtNomOperation.TabIndex = 29;
            // 
            // lblPositionMoteurCreaRecette
            // 
            lblPositionMoteurCreaRecette.AutoSize = true;
            lblPositionMoteurCreaRecette.Location = new Point(836, 187);
            lblPositionMoteurCreaRecette.Name = "lblPositionMoteurCreaRecette";
            lblPositionMoteurCreaRecette.Size = new Size(61, 20);
            lblPositionMoteurCreaRecette.TabIndex = 30;
            lblPositionMoteurCreaRecette.Text = "Position";
            // 
            // grdOperationCreaRecette
            // 
            grdOperationCreaRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOperationCreaRecette.Location = new Point(44, 287);
            grdOperationCreaRecette.Name = "grdOperationCreaRecette";
            grdOperationCreaRecette.RowHeadersWidth = 51;
            grdOperationCreaRecette.Size = new Size(1214, 205);
            grdOperationCreaRecette.TabIndex = 31;
            grdOperationCreaRecette.SelectionChanged += grdOperationCreaRecette_SelectionChanged;
            // 
            // ckbMoteurCreaRecette
            // 
            ckbMoteurCreaRecette.AutoSize = true;
            ckbMoteurCreaRecette.Location = new Point(445, 186);
            ckbMoteurCreaRecette.Name = "ckbMoteurCreaRecette";
            ckbMoteurCreaRecette.Size = new Size(112, 24);
            ckbMoteurCreaRecette.TabIndex = 33;
            ckbMoteurCreaRecette.Text = "Moteur actif";
            ckbMoteurCreaRecette.UseVisualStyleBackColor = true;
            // 
            // cboSensCreaRecette
            // 
            cboSensCreaRecette.FormattingEnabled = true;
            cboSensCreaRecette.Location = new Point(642, 183);
            cboSensCreaRecette.Name = "cboSensCreaRecette";
            cboSensCreaRecette.Size = new Size(151, 28);
            cboSensCreaRecette.TabIndex = 34;
            // 
            // cboPositionCreaRecette
            // 
            cboPositionCreaRecette.FormattingEnabled = true;
            cboPositionCreaRecette.Location = new Point(914, 182);
            cboPositionCreaRecette.Name = "cboPositionCreaRecette";
            cboPositionCreaRecette.Size = new Size(151, 28);
            cboPositionCreaRecette.TabIndex = 35;
            // 
            // cboTempsCreaRecette
            // 
            cboTempsCreaRecette.FormattingEnabled = true;
            cboTempsCreaRecette.Location = new Point(185, 229);
            cboTempsCreaRecette.Name = "cboTempsCreaRecette";
            cboTempsCreaRecette.Size = new Size(46, 28);
            cboTempsCreaRecette.TabIndex = 36;
            // 
            // ckbQuittanceCreaRecette
            // 
            ckbQuittanceCreaRecette.AutoSize = true;
            ckbQuittanceCreaRecette.Location = new Point(597, 231);
            ckbQuittanceCreaRecette.Name = "ckbQuittanceCreaRecette";
            ckbQuittanceCreaRecette.Size = new Size(95, 24);
            ckbQuittanceCreaRecette.TabIndex = 37;
            ckbQuittanceCreaRecette.Text = "Quittance";
            ckbQuittanceCreaRecette.UseVisualStyleBackColor = true;
            // 
            // ckbCycleVerinCreaRecette
            // 
            ckbCycleVerinCreaRecette.AutoSize = true;
            ckbCycleVerinCreaRecette.Location = new Point(347, 229);
            ckbCycleVerinCreaRecette.Name = "ckbCycleVerinCreaRecette";
            ckbCycleVerinCreaRecette.Size = new Size(103, 24);
            ckbCycleVerinCreaRecette.TabIndex = 38;
            ckbCycleVerinCreaRecette.Text = "Cycle Verin";
            ckbCycleVerinCreaRecette.UseVisualStyleBackColor = true;
            // 
            // btnValiderCreaRecette
            // 
            btnValiderCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValiderCreaRecette.Location = new Point(584, 527);
            btnValiderCreaRecette.Name = "btnValiderCreaRecette";
            btnValiderCreaRecette.Size = new Size(285, 44);
            btnValiderCreaRecette.TabIndex = 39;
            btnValiderCreaRecette.Text = "Valider l'opération";
            btnValiderCreaRecette.UseVisualStyleBackColor = true;
            btnValiderCreaRecette.Click += btnValiderCreaRecette_Click;
            // 
            // btnSupprimerCreaRecette
            // 
            btnSupprimerCreaRecette.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimerCreaRecette.Location = new Point(901, 527);
            btnSupprimerCreaRecette.Name = "btnSupprimerCreaRecette";
            btnSupprimerCreaRecette.Size = new Size(285, 44);
            btnSupprimerCreaRecette.TabIndex = 40;
            btnSupprimerCreaRecette.Text = "Supprimer l'opération";
            btnSupprimerCreaRecette.UseVisualStyleBackColor = true;
            btnSupprimerCreaRecette.Click += btnSupprimerCreaRecette_Click;
            // 
            // FrmCreationRecette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 638);
            Controls.Add(btnSupprimerCreaRecette);
            Controls.Add(btnValiderCreaRecette);
            Controls.Add(ckbCycleVerinCreaRecette);
            Controls.Add(ckbQuittanceCreaRecette);
            Controls.Add(cboTempsCreaRecette);
            Controls.Add(cboPositionCreaRecette);
            Controls.Add(cboSensCreaRecette);
            Controls.Add(ckbMoteurCreaRecette);
            Controls.Add(grdOperationCreaRecette);
            Controls.Add(lblPositionMoteurCreaRecette);
            Controls.Add(txtNomOperation);
            Controls.Add(lblTempsCreaRecette);
            Controls.Add(lblSmoteurCreaRecette);
            Controls.Add(lblNomOperation);
            Controls.Add(btnAnnulerCreaRecette);
            Controls.Add(btnEnregistrerCreaRecette);
            Controls.Add(txtNomCreaLot);
            Controls.Add(lblNomCreaRecette);
            Controls.Add(lblTitreCreaRecette);
            Name = "FrmCreationRecette";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)grdOperationCreaRecette).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAnnulerCreaRecette;
        private Button btnEnregistrerCreaRecette;
        private TextBox txtNomCreaLot;
        private Label lblNomCreaRecette;
        private Label lblTitreCreaRecette;
        private Label label1;
        private Label lblNomOperation;
        private Label lblSmoteurCreaRecette;
        private Label lblTempsCreaRecette;
        private TextBox txtNomOperation;
        private Label lblPositionMoteurCreaRecette;
        private DataGridView grdOperationCreaRecette;
        private CheckBox ckbMoteurCreaRecette;
        private ComboBox cboSensCreaRecette;
        private ComboBox cboPositionCreaRecette;
        private ComboBox cboTempsCreaRecette;
        private CheckBox ckbQuittanceCreaRecette;
        private CheckBox ckbCycleVerinCreaRecette;
        private Button btnValiderCreaRecette;
        private Button btnSupprimerCreaRecette;
    }
}