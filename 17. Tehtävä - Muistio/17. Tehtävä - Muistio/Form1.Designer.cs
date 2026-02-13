namespace _17._Tehtävä___Muistio
{
    partial class Muisto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Muisto));
            menuStrip1 = new MenuStrip();
            tiedostoToolStripMenuItem = new ToolStripMenuItem();
            uusiToolStripMenuItem = new ToolStripMenuItem();
            avaaToolStripMenuItem = new ToolStripMenuItem();
            tallennaToolStripMenuItem = new ToolStripMenuItem();
            tulostuksenEsikatseluToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            tallennaNimelläToolStripMenuItem = new ToolStripMenuItem();
            tulostaToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            poistuToolStripMenuItem = new ToolStripMenuItem();
            muokkaaToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            kopioiToolStripMenuItem = new ToolStripMenuItem();
            leikkaaToolStripMenuItem = new ToolStripMenuItem();
            liitäToolStripMenuItem = new ToolStripMenuItem();
            poistaToolStripMenuItem = new ToolStripMenuItem();
            valitseKaikkiToolStripMenuItem = new ToolStripMenuItem();
            muotoileToolStripMenuItem = new ToolStripMenuItem();
            kirjasinToolStripMenuItem = new ToolStripMenuItem();
            tekstinKorostusToolStripMenuItem = new ToolStripMenuItem();
            tekstinRivittysToolStripMenuItem = new ToolStripMenuItem();
            apuaToolStripMenuItem = new ToolStripMenuItem();
            tietoaToolStripMenuItem = new ToolStripMenuItem();
            rikasTB = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            printDialog1 = new PrintDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tiedostoToolStripMenuItem, muokkaaToolStripMenuItem, muotoileToolStripMenuItem, apuaToolStripMenuItem, tietoaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tiedostoToolStripMenuItem
            // 
            tiedostoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { uusiToolStripMenuItem, avaaToolStripMenuItem, tallennaToolStripMenuItem, tulostuksenEsikatseluToolStripMenuItem, toolStripMenuItem1, tallennaNimelläToolStripMenuItem, tulostaToolStripMenuItem, toolStripMenuItem3, poistuToolStripMenuItem });
            tiedostoToolStripMenuItem.Name = "tiedostoToolStripMenuItem";
            tiedostoToolStripMenuItem.Size = new Size(81, 24);
            tiedostoToolStripMenuItem.Text = "Tiedosto";
            // 
            // uusiToolStripMenuItem
            // 
            uusiToolStripMenuItem.Name = "uusiToolStripMenuItem";
            uusiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            uusiToolStripMenuItem.Size = new Size(237, 26);
            uusiToolStripMenuItem.Text = "Uusi";
            uusiToolStripMenuItem.Click += uusiToolStripMenuItem_Click;
            // 
            // avaaToolStripMenuItem
            // 
            avaaToolStripMenuItem.Name = "avaaToolStripMenuItem";
            avaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            avaaToolStripMenuItem.Size = new Size(237, 26);
            avaaToolStripMenuItem.Text = "Avaa";
            avaaToolStripMenuItem.Click += avaaToolStripMenuItem_Click;
            // 
            // tallennaToolStripMenuItem
            // 
            tallennaToolStripMenuItem.Name = "tallennaToolStripMenuItem";
            tallennaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            tallennaToolStripMenuItem.Size = new Size(237, 26);
            tallennaToolStripMenuItem.Text = "Tallenna";
            tallennaToolStripMenuItem.Click += tallennaToolStripMenuItem_Click;
            // 
            // tulostuksenEsikatseluToolStripMenuItem
            // 
            tulostuksenEsikatseluToolStripMenuItem.Name = "tulostuksenEsikatseluToolStripMenuItem";
            tulostuksenEsikatseluToolStripMenuItem.Size = new Size(237, 26);
            tulostuksenEsikatseluToolStripMenuItem.Text = "Tulostuksen esikatselu";
            tulostuksenEsikatseluToolStripMenuItem.Click += tulostuksenEsikatseluToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(234, 6);
            // 
            // tallennaNimelläToolStripMenuItem
            // 
            tallennaNimelläToolStripMenuItem.Name = "tallennaNimelläToolStripMenuItem";
            tallennaNimelläToolStripMenuItem.Size = new Size(237, 26);
            tallennaNimelläToolStripMenuItem.Text = "Tallenna nimellä ";
            tallennaNimelläToolStripMenuItem.Click += tallennaNimelläToolStripMenuItem_Click;
            // 
            // tulostaToolStripMenuItem
            // 
            tulostaToolStripMenuItem.Name = "tulostaToolStripMenuItem";
            tulostaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            tulostaToolStripMenuItem.Size = new Size(237, 26);
            tulostaToolStripMenuItem.Text = "Tulosta";
            tulostaToolStripMenuItem.Click += tulostaToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(234, 6);
            // 
            // poistuToolStripMenuItem
            // 
            poistuToolStripMenuItem.Name = "poistuToolStripMenuItem";
            poistuToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            poistuToolStripMenuItem.Size = new Size(237, 26);
            poistuToolStripMenuItem.Text = "Poistu";
            poistuToolStripMenuItem.Click += poistuToolStripMenuItem_Click;
            // 
            // muokkaaToolStripMenuItem
            // 
            muokkaaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { undoToolStripMenuItem, redoToolStripMenuItem, toolStripMenuItem2, kopioiToolStripMenuItem, leikkaaToolStripMenuItem, liitäToolStripMenuItem, poistaToolStripMenuItem, valitseKaikkiToolStripMenuItem });
            muokkaaToolStripMenuItem.Name = "muokkaaToolStripMenuItem";
            muokkaaToolStripMenuItem.Size = new Size(83, 24);
            muokkaaToolStripMenuItem.Text = "Muokkaa";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(228, 26);
            undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(228, 26);
            redoToolStripMenuItem.Text = "Redo";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(225, 6);
            // 
            // kopioiToolStripMenuItem
            // 
            kopioiToolStripMenuItem.Name = "kopioiToolStripMenuItem";
            kopioiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            kopioiToolStripMenuItem.Size = new Size(228, 26);
            kopioiToolStripMenuItem.Text = "Kopioi";
            // 
            // leikkaaToolStripMenuItem
            // 
            leikkaaToolStripMenuItem.Name = "leikkaaToolStripMenuItem";
            leikkaaToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            leikkaaToolStripMenuItem.Size = new Size(228, 26);
            leikkaaToolStripMenuItem.Text = "Leikkaa";
            // 
            // liitäToolStripMenuItem
            // 
            liitäToolStripMenuItem.Name = "liitäToolStripMenuItem";
            liitäToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            liitäToolStripMenuItem.Size = new Size(228, 26);
            liitäToolStripMenuItem.Text = "Liitä";
            // 
            // poistaToolStripMenuItem
            // 
            poistaToolStripMenuItem.Name = "poistaToolStripMenuItem";
            poistaToolStripMenuItem.Size = new Size(228, 26);
            poistaToolStripMenuItem.Text = "Poista";
            // 
            // valitseKaikkiToolStripMenuItem
            // 
            valitseKaikkiToolStripMenuItem.Name = "valitseKaikkiToolStripMenuItem";
            valitseKaikkiToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            valitseKaikkiToolStripMenuItem.Size = new Size(228, 26);
            valitseKaikkiToolStripMenuItem.Text = "Valitse kaikki";
            // 
            // muotoileToolStripMenuItem
            // 
            muotoileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { kirjasinToolStripMenuItem, tekstinKorostusToolStripMenuItem, tekstinRivittysToolStripMenuItem });
            muotoileToolStripMenuItem.Name = "muotoileToolStripMenuItem";
            muotoileToolStripMenuItem.Size = new Size(83, 24);
            muotoileToolStripMenuItem.Text = "Muotoile";
            // 
            // kirjasinToolStripMenuItem
            // 
            kirjasinToolStripMenuItem.Name = "kirjasinToolStripMenuItem";
            kirjasinToolStripMenuItem.Size = new Size(196, 26);
            kirjasinToolStripMenuItem.Text = "Kirjasin";
            // 
            // tekstinKorostusToolStripMenuItem
            // 
            tekstinKorostusToolStripMenuItem.Name = "tekstinKorostusToolStripMenuItem";
            tekstinKorostusToolStripMenuItem.Size = new Size(196, 26);
            tekstinKorostusToolStripMenuItem.Text = "Tekstin korostus";
            // 
            // tekstinRivittysToolStripMenuItem
            // 
            tekstinRivittysToolStripMenuItem.Name = "tekstinRivittysToolStripMenuItem";
            tekstinRivittysToolStripMenuItem.Size = new Size(196, 26);
            tekstinRivittysToolStripMenuItem.Text = "Tekstin rivittys";
            // 
            // apuaToolStripMenuItem
            // 
            apuaToolStripMenuItem.Name = "apuaToolStripMenuItem";
            apuaToolStripMenuItem.Size = new Size(58, 24);
            apuaToolStripMenuItem.Text = "Apua";
            // 
            // tietoaToolStripMenuItem
            // 
            tietoaToolStripMenuItem.Name = "tietoaToolStripMenuItem";
            tietoaToolStripMenuItem.Size = new Size(65, 24);
            tietoaToolStripMenuItem.Text = "Tietoa";
            // 
            // rikasTB
            // 
            rikasTB.Dock = DockStyle.Fill;
            rikasTB.Location = new Point(0, 28);
            rikasTB.Name = "rikasTB";
            rikasTB.Size = new Size(800, 422);
            rikasTB.TabIndex = 1;
            rikasTB.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Muisto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rikasTB);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Muisto";
            Text = "Muistio";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem tiedostoToolStripMenuItem;
        private ToolStripMenuItem uusiToolStripMenuItem;
        private ToolStripMenuItem avaaToolStripMenuItem;
        private RichTextBox rikasTB;
        private ToolStripMenuItem tallennaToolStripMenuItem;
        private ToolStripMenuItem tallennaNimelläToolStripMenuItem;
        private ToolStripMenuItem tulostuksenEsikatseluToolStripMenuItem;
        private ToolStripMenuItem tulostaToolStripMenuItem;
        private ToolStripMenuItem poistuToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem muokkaaToolStripMenuItem;
        private ToolStripMenuItem muotoileToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem kopioiToolStripMenuItem;
        private ToolStripMenuItem leikkaaToolStripMenuItem;
        private ToolStripMenuItem liitäToolStripMenuItem;
        private ToolStripMenuItem poistaToolStripMenuItem;
        private ToolStripMenuItem valitseKaikkiToolStripMenuItem;
        private ToolStripMenuItem kirjasinToolStripMenuItem;
        private ToolStripMenuItem tekstinKorostusToolStripMenuItem;
        private ToolStripMenuItem tekstinRivittysToolStripMenuItem;
        private ToolStripMenuItem apuaToolStripMenuItem;
        private ToolStripMenuItem tietoaToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
