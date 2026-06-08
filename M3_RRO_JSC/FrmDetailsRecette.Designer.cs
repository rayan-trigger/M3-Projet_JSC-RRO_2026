namespace M3_RRO_JSC
{
    partial class FrmDetailsRecette
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
            grdDetailsRecette = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grdDetailsRecette).BeginInit();
            SuspendLayout();
            // 
            // grdDetailsRecette
            // 
            grdDetailsRecette.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDetailsRecette.Location = new Point(29, 99);
            grdDetailsRecette.Name = "grdDetailsRecette";
            grdDetailsRecette.RowHeadersWidth = 51;
            grdDetailsRecette.Size = new Size(840, 202);
            grdDetailsRecette.TabIndex = 0;
            // 
            // FrmDetailsRecette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 450);
            Controls.Add(grdDetailsRecette);
            Name = "FrmDetailsRecette";
            Text = "FrmDetailsRecette";
            ((System.ComponentModel.ISupportInitialize)grdDetailsRecette).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView grdDetailsRecette;
    }
}