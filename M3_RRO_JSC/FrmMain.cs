// Fichier: FrmMain.cs
// Description: Formulaire principal de l'application. Gère la navigation entre
// les pages (UserControl) et la confirmation de fermeture.
using System;
using System.Drawing;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.FormClosing += FrmMain_FormClosing;

            // Page affichée au démarrage
            AfficherPage(new AccueilControl(), "Accueil");
        }


        /// <summary>
        /// Affiche une nouvelle page dans le panneau principal de l'application, et met à jour le titre du bandeau.
        /// </summary>
        /// <param name="page"></param>
        /// <param name="titre"></param>
        public void AfficherPage(UserControl page, string titre)
        {
            // Change le texte du bandeau
            lblTitre.Text = titre;

            // Supprime l'ancienne page
            pnlMain.Controls.Clear();

            // Place la nouvelle page dans pnlMain
            page.Location = new Point(0, 0);
            page.Size = pnlMain.ClientSize;

            // Permet à la page de suivre la taille de pnlMain si besoin
            page.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            pnlMain.Controls.Add(page);
            page.BringToFront();
        }


        /// <summary>
        /// Demande une confirmation avant de fermer l'application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Attention, vous allez fermer l'application. Voulez-vous continuer ?",
                "Confirmation de fermeture",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}