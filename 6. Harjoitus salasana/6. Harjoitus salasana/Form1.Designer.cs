namespace _6._Harjoitus_salasana
{
    partial class SalasananTarkastus
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SalasanaPanel = new Panel();
            label1 = new Label();
            label2 = new Label();
            KayttajaTB = new TextBox();
            SalasanaTB = new TextBox();
            TarkistaBT = new Button();
            SalasanaOikeinPanel = new Panel();
            label3 = new Label();
            VirheviestiLB = new Label();
            SalasanaPanel.SuspendLayout();
            SalasanaOikeinPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SalasanaPanel
            // 
            SalasanaPanel.BackColor = Color.MidnightBlue;
            SalasanaPanel.Controls.Add(VirheviestiLB);
            SalasanaPanel.Controls.Add(SalasanaOikeinPanel);
            SalasanaPanel.Controls.Add(TarkistaBT);
            SalasanaPanel.Controls.Add(SalasanaTB);
            SalasanaPanel.Controls.Add(KayttajaTB);
            SalasanaPanel.Controls.Add(label2);
            SalasanaPanel.Controls.Add(label1);
            SalasanaPanel.Dock = DockStyle.Fill;
            SalasanaPanel.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic);
            SalasanaPanel.ForeColor = Color.Gold;
            SalasanaPanel.Location = new Point(0, 0);
            SalasanaPanel.Name = "SalasanaPanel";
            SalasanaPanel.Size = new Size(920, 378);
            SalasanaPanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 72);
            label1.Name = "label1";
            label1.Size = new Size(275, 50);
            label1.TabIndex = 0;
            label1.Text = "Käyttäjätunnus:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 172);
            label2.Name = "label2";
            label2.Size = new Size(171, 50);
            label2.TabIndex = 1;
            label2.Text = "Salasana:";
            // 
            // KayttajaTB
            // 
            KayttajaTB.Location = new Point(432, 72);
            KayttajaTB.Name = "KayttajaTB";
            KayttajaTB.Size = new Size(125, 56);
            KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            SalasanaTB.Location = new Point(432, 169);
            SalasanaTB.Name = "SalasanaTB";
            SalasanaTB.PasswordChar = '●';
            SalasanaTB.Size = new Size(125, 56);
            SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            TarkistaBT.ForeColor = Color.Black;
            TarkistaBT.Location = new Point(17, 163);
            TarkistaBT.Name = "TarkistaBT";
            TarkistaBT.Size = new Size(184, 68);
            TarkistaBT.TabIndex = 4;
            TarkistaBT.Text = "Tarkista";
            TarkistaBT.UseVisualStyleBackColor = true;
            TarkistaBT.Click += TarkistaBT_Click;
            // 
            // SalasanaOikeinPanel
            // 
            SalasanaOikeinPanel.BackColor = Color.DarkRed;
            SalasanaOikeinPanel.Controls.Add(label3);
            SalasanaOikeinPanel.Dock = DockStyle.Fill;
            SalasanaOikeinPanel.Font = new Font("Segoe Script", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            SalasanaOikeinPanel.ForeColor = Color.Snow;
            SalasanaOikeinPanel.Location = new Point(0, 0);
            SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            SalasanaOikeinPanel.Size = new Size(920, 378);
            SalasanaOikeinPanel.TabIndex = 5;
            SalasanaOikeinPanel.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 112);
            label3.Name = "label3";
            label3.Size = new Size(721, 99);
            label3.TabIndex = 0;
            label3.Text = "Tervetuloa sivuilleni";
            // 
            // VirheviestiLB
            // 
            VirheviestiLB.AutoSize = true;
            VirheviestiLB.ForeColor = Color.Red;
            VirheviestiLB.Location = new Point(101, 277);
            VirheviestiLB.Name = "VirheviestiLB";
            VirheviestiLB.Size = new Size(109, 50);
            VirheviestiLB.TabIndex = 6;
            VirheviestiLB.Text = "Virhe";
            VirheviestiLB.Visible = false;
            // 
            // SalasananTarkastus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(920, 378);
            Controls.Add(SalasanaPanel);
            Name = "SalasananTarkastus";
            Text = "Salasanan tarkastus";
            SalasanaPanel.ResumeLayout(false);
            SalasanaPanel.PerformLayout();
            SalasanaOikeinPanel.ResumeLayout(false);
            SalasanaOikeinPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel SalasanaPanel;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Panel SalasanaOikeinPanel;
        private Label label3;
        private Label VirheviestiLB;
    }
}
