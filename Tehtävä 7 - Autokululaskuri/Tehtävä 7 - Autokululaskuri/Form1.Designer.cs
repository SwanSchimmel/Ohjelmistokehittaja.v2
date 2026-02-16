namespace Tehtävä_7___Autokululaskuri
{
    partial class KilometrikulutuslaskuriFM
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
            LainaTB = new TextBox();
            KilometriCB = new ComboBox();
            LainaLB = new Label();
            PesutLB = new Label();
            NesteetLB = new Label();
            HuollotLB = new Label();
            VakuutuksetLB = new Label();
            MuutLB = new Label();
            RenkaatLB = new Label();
            VastausLB = new Label();
            KilometriLB = new Label();
            Kilometrikulutuslaskuri = new Label();
            NesteetTB = new TextBox();
            VakuutuksetTB = new TextBox();
            MuutTB = new TextBox();
            PesutTB = new TextBox();
            HuollotTB = new TextBox();
            RenkaatTB = new TextBox();
            PolttonesteLB = new Label();
            PolttonesteTB = new TextBox();
            SuspendLayout();
            // 
            // LainaTB
            // 
            LainaTB.Font = new Font("Ink Free", 18F);
            LainaTB.Location = new Point(372, 115);
            LainaTB.Name = "LainaTB";
            LainaTB.Size = new Size(125, 45);
            LainaTB.TabIndex = 0;
            // 
            // KilometriCB
            // 
            KilometriCB.Font = new Font("Ink Free", 18F);
            KilometriCB.FormattingEnabled = true;
            KilometriCB.Items.AddRange(new object[] { "5000", "10000", "15000", "20000", "25000", "35000", "40000", "45000", "50000", "55000", "60000", "65000", "70000", "75000", "80000", "85000", "90000", "95000", "100000" });
            KilometriCB.Location = new Point(817, 352);
            KilometriCB.Name = "KilometriCB";
            KilometriCB.Size = new Size(151, 45);
            KilometriCB.TabIndex = 1;
            KilometriCB.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // LainaLB
            // 
            LainaLB.AutoSize = true;
            LainaLB.Font = new Font("Ink Free", 18F);
            LainaLB.Location = new Point(46, 123);
            LainaLB.Name = "LainaLB";
            LainaLB.Size = new Size(320, 37);
            LainaLB.TabIndex = 2;
            LainaLB.Text = "Lainan lyhyt korkoineen:";
            // 
            // PesutLB
            // 
            PesutLB.AutoSize = true;
            PesutLB.Font = new Font("Ink Free", 18F);
            PesutLB.Location = new Point(572, 115);
            PesutLB.Name = "PesutLB";
            PesutLB.Size = new Size(97, 37);
            PesutLB.TabIndex = 3;
            PesutLB.Text = "Pesut:";
            // 
            // NesteetLB
            // 
            NesteetLB.AutoSize = true;
            NesteetLB.Font = new Font("Ink Free", 18F);
            NesteetLB.Location = new Point(46, 191);
            NesteetLB.Name = "NesteetLB";
            NesteetLB.Size = new Size(277, 37);
            NesteetLB.TabIndex = 4;
            NesteetLB.Text = "Lisättävät nesteet:";
            // 
            // HuollotLB
            // 
            HuollotLB.AutoSize = true;
            HuollotLB.Font = new Font("Ink Free", 18F);
            HuollotLB.Location = new Point(572, 194);
            HuollotLB.Name = "HuollotLB";
            HuollotLB.Size = new Size(112, 37);
            HuollotLB.TabIndex = 5;
            HuollotLB.Text = "Huollot:";
            // 
            // VakuutuksetLB
            // 
            VakuutuksetLB.AutoSize = true;
            VakuutuksetLB.Font = new Font("Ink Free", 18F);
            VakuutuksetLB.Location = new Point(46, 250);
            VakuutuksetLB.Name = "VakuutuksetLB";
            VakuutuksetLB.Size = new Size(239, 37);
            VakuutuksetLB.TabIndex = 6;
            VakuutuksetLB.Text = "Vakuutusmaksut:";
            // 
            // MuutLB
            // 
            MuutLB.AutoSize = true;
            MuutLB.Font = new Font("Ink Free", 18F);
            MuutLB.Location = new Point(46, 319);
            MuutLB.Name = "MuutLB";
            MuutLB.Size = new Size(167, 37);
            MuutLB.TabIndex = 7;
            MuutLB.Text = "Muut kulut:";
            // 
            // RenkaatLB
            // 
            RenkaatLB.AutoSize = true;
            RenkaatLB.Font = new Font("Ink Free", 18F);
            RenkaatLB.Location = new Point(572, 276);
            RenkaatLB.Name = "RenkaatLB";
            RenkaatLB.Size = new Size(132, 37);
            RenkaatLB.TabIndex = 8;
            RenkaatLB.Text = "Renkaat:";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Ink Free", 18F);
            VastausLB.Location = new Point(46, 498);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(121, 37);
            VastausLB.TabIndex = 9;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // KilometriLB
            // 
            KilometriLB.AutoSize = true;
            KilometriLB.Font = new Font("Ink Free", 18F);
            KilometriLB.Location = new Point(562, 360);
            KilometriLB.Name = "KilometriLB";
            KilometriLB.Size = new Size(249, 37);
            KilometriLB.TabIndex = 10;
            KilometriLB.Text = "Kilometrit/vuodet:";
            // 
            // Kilometrikulutuslaskuri
            // 
            Kilometrikulutuslaskuri.AutoSize = true;
            Kilometrikulutuslaskuri.Font = new Font("Lucida Sans Unicode", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Kilometrikulutuslaskuri.Location = new Point(319, 35);
            Kilometrikulutuslaskuri.Name = "Kilometrikulutuslaskuri";
            Kilometrikulutuslaskuri.Size = new Size(365, 37);
            Kilometrikulutuslaskuri.TabIndex = 11;
            Kilometrikulutuslaskuri.Text = "Auton kustannuslaskuri";
            // 
            // NesteetTB
            // 
            NesteetTB.Font = new Font("Ink Free", 18F);
            NesteetTB.Location = new Point(372, 181);
            NesteetTB.Name = "NesteetTB";
            NesteetTB.Size = new Size(125, 45);
            NesteetTB.TabIndex = 12;
            // 
            // VakuutuksetTB
            // 
            VakuutuksetTB.Font = new Font("Ink Free", 18F);
            VakuutuksetTB.Location = new Point(372, 242);
            VakuutuksetTB.Name = "VakuutuksetTB";
            VakuutuksetTB.Size = new Size(125, 45);
            VakuutuksetTB.TabIndex = 13;
            // 
            // MuutTB
            // 
            MuutTB.Font = new Font("Ink Free", 18F);
            MuutTB.Location = new Point(372, 311);
            MuutTB.Name = "MuutTB";
            MuutTB.Size = new Size(125, 45);
            MuutTB.TabIndex = 14;
            // 
            // PesutTB
            // 
            PesutTB.Font = new Font("Ink Free", 18F);
            PesutTB.Location = new Point(817, 115);
            PesutTB.Name = "PesutTB";
            PesutTB.Size = new Size(125, 45);
            PesutTB.TabIndex = 15;
            // 
            // HuollotTB
            // 
            HuollotTB.Font = new Font("Ink Free", 18F);
            HuollotTB.Location = new Point(817, 191);
            HuollotTB.Name = "HuollotTB";
            HuollotTB.Size = new Size(125, 45);
            HuollotTB.TabIndex = 16;
            // 
            // RenkaatTB
            // 
            RenkaatTB.Font = new Font("Ink Free", 18F);
            RenkaatTB.Location = new Point(817, 268);
            RenkaatTB.Name = "RenkaatTB";
            RenkaatTB.Size = new Size(125, 45);
            RenkaatTB.TabIndex = 17;
            // 
            // PolttonesteLB
            // 
            PolttonesteLB.AutoSize = true;
            PolttonesteLB.Font = new Font("Ink Free", 18F);
            PolttonesteLB.Location = new Point(46, 383);
            PolttonesteLB.Name = "PolttonesteLB";
            PolttonesteLB.Size = new Size(172, 37);
            PolttonesteLB.TabIndex = 18;
            PolttonesteLB.Text = "Polttoneste:";
            // 
            // PolttonesteTB
            // 
            PolttonesteTB.Font = new Font("Ink Free", 18F);
            PolttonesteTB.Location = new Point(372, 375);
            PolttonesteTB.Name = "PolttonesteTB";
            PolttonesteTB.Size = new Size(125, 45);
            PolttonesteTB.TabIndex = 19;
            // 
            // KilometrikulutuslaskuriFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1009, 587);
            Controls.Add(PolttonesteTB);
            Controls.Add(PolttonesteLB);
            Controls.Add(RenkaatTB);
            Controls.Add(HuollotTB);
            Controls.Add(PesutTB);
            Controls.Add(MuutTB);
            Controls.Add(VakuutuksetTB);
            Controls.Add(NesteetTB);
            Controls.Add(Kilometrikulutuslaskuri);
            Controls.Add(KilometriLB);
            Controls.Add(VastausLB);
            Controls.Add(RenkaatLB);
            Controls.Add(MuutLB);
            Controls.Add(VakuutuksetLB);
            Controls.Add(HuollotLB);
            Controls.Add(NesteetLB);
            Controls.Add(PesutLB);
            Controls.Add(LainaLB);
            Controls.Add(KilometriCB);
            Controls.Add(LainaTB);
            Name = "KilometrikulutuslaskuriFM";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LainaTB;
        private ComboBox KilometriCB;
        private Label LainaLB;
        private Label PesutLB;
        private Label NesteetLB;
        private Label HuollotLB;
        private Label VakuutuksetLB;
        private Label MuutLB;
        private Label RenkaatLB;
        private Label VastausLB;
        private Label KilometriLB;
        private Label Kilometrikulutuslaskuri;
        private TextBox NesteetTB;
        private TextBox VakuutuksetTB;
        private TextBox MuutTB;
        private TextBox PesutTB;
        private TextBox HuollotTB;
        private TextBox RenkaatTB;
        private Label PolttonesteLB;
        private TextBox PolttonesteTB;
    }
}
