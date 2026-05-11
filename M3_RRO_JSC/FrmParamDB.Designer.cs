namespace M3_RRO_JSC
{
    partial class FrmParamDB
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

        // ── Layout constants ──────────────────────────────────────────────
        private const double SidebarRatio = 0.18;
        private const int SidebarMin = 160;
        private const int SidebarMax = 260;
        private const double NavBtnRatio = 0.22;
        private const double DBBtnRatio = 0.14;

        // ── Controls ──────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlWindows;
        private System.Windows.Forms.Panel _content;
        private System.Windows.Forms.Button _btnHome;
        private System.Windows.Forms.Button _btnLots;
        private System.Windows.Forms.Button _btnRecettes;
        private System.Windows.Forms.Button _btnTracabilite;
        private System.Windows.Forms.Button _btnDB;
        private System.Windows.Forms.Button _activeBtn;

        // ── Child pages ───────────────────────────────────────────────────
        //private DashboardPanel _dashboardPanel;
        //private GestionLotsPanel _lotsPanel;
        //private GestionRecettesPanel _recettesPanel;
        //private TracabilitePanel _tracabilitePanel;
        //private DatabasePanel _databasePanel;
    }
}