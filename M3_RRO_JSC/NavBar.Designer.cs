namespace M3_RRO_JSC
{
    partial class NavBar
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
            btnAccueil = new Button();
            btnGestionRecette = new Button();
            btnGestionLot = new Button();
            btnTracabilite = new Button();
            btnParametre = new Button();
            SuspendLayout();
            // 
            // btnAccueil
            // 
            btnAccueil.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccueil.Location = new Point(3, 3);
            btnAccueil.Name = "btnAccueil";
            btnAccueil.Size = new Size(175, 150);
            btnAccueil.TabIndex = 0;
            btnAccueil.Text = "Accueil";
            btnAccueil.UseVisualStyleBackColor = true;
            btnAccueil.Click += btnAccueil_Click;
            // 
            // btnGestionRecette
            // 
            btnGestionRecette.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionRecette.Location = new Point(3, 303);
            btnGestionRecette.Name = "btnGestionRecette";
            btnGestionRecette.Size = new Size(175, 150);
            btnGestionRecette.TabIndex = 1;
            btnGestionRecette.Text = "Gestion des recettes";
            btnGestionRecette.UseVisualStyleBackColor = true;
            btnGestionRecette.Click += btnGestionRecette_Click;
            // 
            // btnGestionLot
            // 
            btnGestionLot.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGestionLot.Location = new Point(3, 153);
            btnGestionLot.Name = "btnGestionLot";
            btnGestionLot.Size = new Size(175, 150);
            btnGestionLot.TabIndex = 2;
            btnGestionLot.Text = "Gestion des lots";
            btnGestionLot.UseVisualStyleBackColor = true;
            btnGestionLot.Click += btnGestionLot_Click;
            // 
            // btnTracabilite
            // 
            btnTracabilite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTracabilite.Location = new Point(3, 453);
            btnTracabilite.Name = "btnTracabilite";
            btnTracabilite.Size = new Size(175, 150);
            btnTracabilite.TabIndex = 3;
            btnTracabilite.Text = "Traçabilité";
            btnTracabilite.UseVisualStyleBackColor = true;
            btnTracabilite.Click += btnTracabilite_Click;
            // 
            // btnParametre
            // 
            btnParametre.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnParametre.Location = new Point(3, 603);
            btnParametre.Name = "btnParametre";
            btnParametre.Size = new Size(175, 150);
            btnParametre.TabIndex = 4;
            btnParametre.Text = "Paramètres";
            btnParametre.UseVisualStyleBackColor = true;
            btnParametre.Click += btnParametre_Click;
            // 
            // NavBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnParametre);
            Controls.Add(btnTracabilite);
            Controls.Add(btnGestionLot);
            Controls.Add(btnGestionRecette);
            Controls.Add(btnAccueil);
            Name = "NavBar";
            Size = new Size(180, 755);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAccueil;
        private Button btnGestionRecette;
        private Button btnGestionLot;
        private Button btnTracabilite;
        private Button btnParametre;
    }
}
