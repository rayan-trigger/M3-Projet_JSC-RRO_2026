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

            // Page affichée au démarrage
            AfficherPage(new AccueilControl(), "Accueil");
        }

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
    }
}