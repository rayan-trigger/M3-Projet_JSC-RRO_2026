// Fichier: NavBar.cs
// Description: Barre de navigation (UserControl) permettant de basculer entre
// les différentes pages de l'application (Accueil, Recettes, Lots, Traçabilité, Paramètres).
using System;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class NavBar : UserControl
    {
        public NavBar()
        {
            InitializeComponent();
        }

        private FrmMain GetMainForm()
        {
            return (FrmMain)this.FindForm();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            GetMainForm().AfficherPage(new AccueilControl(), "Accueil");
        }

        private void btnGestionRecette_Click(object sender, EventArgs e)
        {
            GetMainForm().AfficherPage(new RecettesControl(), "Gestion des recettes");
        }

        private void btnGestionLot_Click(object sender, EventArgs e)
        {
            GetMainForm().AfficherPage(new LotsControl(), "Gestion des lots");
        }

        private void btnTracabilite_Click(object sender, EventArgs e)
        {
            GetMainForm().AfficherPage(new TracabiliteControl(), "Traçabilité");
        }

        private void btnParametre_Click(object sender, EventArgs e)
        {
            GetMainForm().AfficherPage(new ParametreControl(), "Paramètres");
        }

        private void NavBar_Load(object sender, EventArgs e)
        {

        }
    }
}