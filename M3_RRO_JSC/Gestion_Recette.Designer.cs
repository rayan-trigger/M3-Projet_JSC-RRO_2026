namespace M3_RRO_JSC
{
    partial class Gestion_Recette
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
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            button5 = new Button();
            panel3 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Turquoise;
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1623, 810);
            panel2.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(177, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1434, 62);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(532, 15);
            label1.Name = "label1";
            label1.Size = new Size(308, 41);
            label1.TabIndex = 0;
            label1.Text = "Gestion des recettes ";
            label1.Click += label1_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(3, 651);
            button5.Name = "button5";
            button5.Size = new Size(168, 149);
            button5.TabIndex = 5;
            button5.Text = "Paramètres";
            button5.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveCaption;
            panel3.Controls.Add(button8);
            panel3.Controls.Add(button7);
            panel3.Controls.Add(button6);
            panel3.Location = new Point(177, 79);
            panel3.Name = "panel3";
            panel3.Size = new Size(1434, 721);
            panel3.TabIndex = 1;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Location = new Point(255, 13);
            button8.Name = "button8";
            button8.Size = new Size(120, 40);
            button8.TabIndex = 2;
            button8.Text = "Supprimer";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Location = new Point(129, 13);
            button7.Name = "button7";
            button7.Size = new Size(120, 40);
            button7.TabIndex = 1;
            button7.Text = "Modifier";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Location = new Point(3, 13);
            button6.Name = "button6";
            button6.Size = new Size(120, 40);
            button6.TabIndex = 0;
            button6.Text = "Créer";
            button6.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaption;
            button4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(3, 440);
            button4.Name = "button4";
            button4.Size = new Size(168, 178);
            button4.TabIndex = 4;
            button4.Text = "Traçabilité";
            button4.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(168, 89);
            button1.TabIndex = 1;
            button1.Text = "Accueil";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(3, 98);
            button2.Name = "button2";
            button2.Size = new Size(168, 152);
            button2.TabIndex = 2;
            button2.Text = "Gestion des lots ";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaption;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(0, 256);
            button3.Name = "button3";
            button3.Size = new Size(168, 178);
            button3.TabIndex = 3;
            button3.Text = "Gestion des recettes";
            button3.UseVisualStyleBackColor = false;
            // 
            // Gestion_Recette
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1626, 813);
            Controls.Add(panel2);
            Name = "Gestion_Recette";
            Text = "Gestion des recettes";
            Load += Gestion_Recette_Load;
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Button button5;
        private Panel panel3;
        private Button button4;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Button button8;
        private Button button7;
        private Button button6;
        private Label label1;
    }
}