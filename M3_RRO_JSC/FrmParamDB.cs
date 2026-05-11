using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Text;
using System.Windows.Forms;

namespace M3_RRO_JSC
{
    public partial class FrmParamDB : Form
    {
        public FrmParamDB()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.Text = "Gestion de Production";
            this.Size = new Size(1100, 700);
            this.MinimumSize = new Size(800, 500);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // ── Sidebar ───────────────────────────────────────────────────
            pnlWindows = new Panel
            {
                BackColor = Color.White,
                // Do NOT use Dock – we position it manually so we can resize it.
                Location = new Point(0, 0),
                Width = SidebarWidth(this.ClientSize.Width),
                Height = this.ClientSize.Height
            };

            // Nav buttons – absolute positioned inside sidebar
            _btnHome = MakeNavButton("", iconType: "house");
            _btnLots = MakeNavButton("Gestion des\nlots");
            _btnRecettes = MakeNavButton("Gestion des\nrecettes");
            _btnTracabilite = MakeNavButton("Traçabilité");
            _btnDB = MakeNavButton("", iconType: "db");

            //_btnHome.Click += (s, e) => ShowPanel(_dashboardPanel, _btnHome);
            //_btnLots.Click += (s, e) => ShowPanel(_lotsPanel, _btnLots);
            //_btnRecettes.Click += (s, e) => ShowPanel(_recettesPanel, _btnRecettes);
            //_btnTracabilite.Click += (s, e) => ShowPanel(_tracabilitePanel, _btnTracabilite);
            //_btnDB.Click += (s, e) => ShowPanel(_databasePanel, _btnDB);

            pnlWindows.Controls.AddRange(new Control[]
                { _btnHome, _btnLots, _btnRecettes, _btnTracabilite, _btnDB });

            // ── Content area ──────────────────────────────────────────────
            _content = new Panel { BackColor = Color.White };
            LayoutContent(this.ClientSize.Width, this.ClientSize.Height);

            //_dashboardPanel = new DashboardPanel { Dock = DockStyle.Fill, Visible = false };
            //_lotsPanel = new GestionLotsPanel { Dock = DockStyle.Fill, Visible = false };
            //_recettesPanel = new GestionRecettesPanel { Dock = DockStyle.Fill, Visible = false };
            //_tracabilitePanel = new TracabilitePanel { Dock = DockStyle.Fill, Visible = false };
            //_databasePanel = new DatabasePanel { Dock = DockStyle.Fill, Visible = false };

            //_content.Controls.AddRange(new Control[]
            //{
            //    _dashboardPanel, _lotsPanel, _recettesPanel,
            //    _tracabilitePanel, _databasePanel
            //});

            this.Controls.Add(pnlWindows);
            this.Controls.Add(_content);

            // Initial layout pass
            LayoutSidebar(this.ClientSize.Width, this.ClientSize.Height);

            // ── Responsive: recompute on every resize ─────────────────────
            this.SizeChanged += (s, e) =>
            {
                int w = this.ClientSize.Width;
                int h = this.ClientSize.Height;
                LayoutSidebar(w, h);
                LayoutContent(w, h);
            };
        }


        // ── Responsive layout helpers ─────────────────────────────────────

        private int SidebarWidth(int formW)
            => Math.Max(SidebarMin, Math.Min(SidebarMax, (int)(formW * SidebarRatio)));

        /// <summary>
        /// Re-positions and re-sizes every button in the sidebar
        /// so that together they fill the full sidebar height.
        ///
        /// Layout (top → bottom):
        ///   [Home]         NavBtnRatio × H
        ///   [Lots]         NavBtnRatio × H
        ///   [Recettes]     NavBtnRatio × H
        ///   [Traçabilité]  NavBtnRatio × H
        ///   [spacer]       remaining space
        ///   [DB]           DBBtnRatio  × H  (pinned at bottom)
        /// </summary>
        private void LayoutSidebar(int formW, int formH)
        {
            int sw = SidebarWidth(formW);
            pnlWindows.SetBounds(0, 0, sw, formH);

            int navH = (int)(formH * NavBtnRatio);
            int dbH = (int)(formH * DBBtnRatio);
            // Keep each button at least 60 px and no more than 140 px
            navH = Math.Max(60, Math.Min(140, navH));
            dbH = Math.Max(60, Math.Min(120, dbH));

            // Font scale: roughly sw / 14, clamped 9–14 pt
            float fontSize = Math.Max(9f, Math.Min(14f, sw / 14f));
            // Icon size: 40% of navH, clamped 20–52 px
            int iconSize = Math.Max(20, Math.Min(52, (int)(navH * 0.40)));

            Button[] navBtns = { _btnHome, _btnLots, _btnRecettes, _btnTracabilite };
            int y = 0;
            for (int i = 0; i < navBtns.Length; i++)
            {
                var btn = navBtns[i];
                btn.SetBounds(0, y, sw, navH);
                btn.Font = new Font("Segoe UI", fontSize, FontStyle.Regular);
                y += navH;
            }

            // Update icons at new size
            _btnHome.Image = DrawHouseIcon(iconSize, iconSize);
            _btnHome.ImageAlign = ContentAlignment.MiddleCenter;

            _btnDB.SetBounds(0, formH - dbH, sw, dbH);
            _btnDB.Image = DrawDBIcon(iconSize, iconSize);
            _btnDB.ImageAlign = ContentAlignment.MiddleCenter;
        }

        private void LayoutContent(int formW, int formH)
        {
            int sw = SidebarWidth(formW);
            _content.SetBounds(sw, 0, formW - sw, formH);
        }

        // ── Button factory ────────────────────────────────────────────────

        private Button MakeNavButton(string text, string iconType = )
        {
            var btn = new Button
            {
                Text = text,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(220, 220, 220),
                ForeColor = Color.Black,
                TextAlign = ContentAlignment.MiddleCenter,
                Cursor = Cursors.Hand
            };
            btn.FlatAppearance.BorderColor = Color.FromArgb(170, 170, 170);
            btn.FlatAppearance.BorderSize = 1;

            // Hover effect
            btn.MouseEnter += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(60, 60, 60))
                    btn.BackColor = Color.FromArgb(200, 200, 200);
            };
            btn.MouseLeave += (s, e) =>
            {
                if (btn.BackColor != Color.FromArgb(60, 60, 60))
                    btn.BackColor = Color.FromArgb(220, 220, 220);
            };

            return btn;
        }

        // ── Navigation ────────────────────────────────────────────────────

        private void ShowPanel(Panel panel, Button btn)
        {
            foreach (Control c in pnlWindows.Controls)
                if (c is Button b)
                {
                    b.BackColor = Color.FromArgb(220, 220, 220);
                    b.ForeColor = Color.Black;
                }

            btn.BackColor = Color.FromArgb(60, 60, 60);
            btn.ForeColor = Color.White;

            //if (panel is DashboardPanel dp) dp.Refresh();
            //if (panel is GestionLotsPanel lp) lp.RefreshData();
            //if (panel is GestionRecettesPanel rp) rp.RefreshData();
            //if (panel is TracabilitePanel tp) tp.RefreshData();

            foreach (Control c in _content.Controls)
                c.Visible = false;
            panel.Visible = true;
            _activeBtn = btn;
        }

        // ── Icon drawing ──────────────────────────────────────────────────

        private Image DrawHouseIcon(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                float cx = w / 2f;
                using (var pen = new Pen(Color.Black, Math.Max(1.5f, w / 18f)))
                {
                    // Roof
                    g.DrawLines(pen, new PointF[]
                    {
                        new PointF(w * 0.05f, h * 0.52f),
                        new PointF(cx,        h * 0.08f),
                        new PointF(w * 0.95f, h * 0.52f)
                    });
                    // Chimney
                    g.DrawRectangle(pen, w * 0.60f, h * 0.15f, w * 0.12f, h * 0.20f);
                    // Body
                    g.DrawRectangle(pen, w * 0.12f, h * 0.52f, w * 0.76f, h * 0.38f);
                    // Door
                    g.DrawRectangle(pen, w * 0.38f, h * 0.65f, w * 0.24f, h * 0.25f);
                }
            }
            return bmp;
        }

        private Image DrawDBIcon(int w, int h)
        {
            var bmp = new Bitmap(w, h);
            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.Clear(Color.Transparent);
                using (var pen = new Pen(Color.Black, Math.Max(1.5f, w / 20f)))
                {
                    float ex = w * 0.10f, ew = w * 0.80f;
                    float eh = h * 0.18f;
                    // Three ellipses (top, mid, bottom of cylinder)
                    g.DrawEllipse(pen, ex, h * 0.04f, ew, eh);
                    g.DrawEllipse(pen, ex, h * 0.27f, ew, eh);
                    g.DrawEllipse(pen, ex, h * 0.50f, ew, eh);
                    // Sides
                    g.DrawLine(pen, ex, h * 0.13f, ex, h * 0.59f);
                    g.DrawLine(pen, ex + ew, h * 0.13f, ex + ew, h * 0.59f);
                    // Gear (bottom-right)
                    float gr = w * 0.18f;
                    float gx = w * 0.60f, gy = h * 0.72f;
                    g.DrawEllipse(pen, gx - gr, gy - gr, gr * 2, gr * 2);
                    g.DrawEllipse(pen, gx - gr * 0.45f, gy - gr * 0.45f, gr * 0.9f, gr * 0.9f);
                    // Gear teeth (4 lines radiating out)
                    for (int t = 0; t < 4; t++)
                    {
                        double angle = t * Math.PI / 4;
                        float dx = (float)Math.Cos(angle);
                        float dy = (float)Math.Sin(angle);
                        g.DrawLine(pen,
                            gx + dx * gr, gy + dy * gr,
                            gx + dx * (gr * 1.5f), gy + dy * (gr * 1.5f));
                    }
                }
            }
            return bmp;
        }
    }
}
