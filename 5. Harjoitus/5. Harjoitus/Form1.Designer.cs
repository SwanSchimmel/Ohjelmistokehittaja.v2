namespace _5._Harjoitus
{
    partial class LukujenJarjestysFM
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
            lblOhje = new Label();
            VastausLB = new Label();
            uusiLukuTB = new TextBox();
            SuspendLayout();
            // 
            // lblOhje
            // 
            lblOhje.AutoSize = true;
            lblOhje.Font = new Font("Segoe UI", 14F);
            lblOhje.Location = new Point(49, 47);
            lblOhje.Name = "lblOhje";
            lblOhje.Size = new Size(283, 32);
            lblOhje.TabIndex = 0;
            lblOhje.Text = "Anna luku (-999 lopetus):";
            // 
            // VastausLB
            // 
            VastausLB.AllowDrop = true;
            VastausLB.Font = new Font("Segoe UI", 14F);
            VastausLB.Location = new Point(49, 112);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(99, 43);
            VastausLB.TabIndex = 1;
            VastausLB.Text = "Vastaus";
            VastausLB.UseWaitCursor = true;
            VastausLB.Visible = false;
            // 
            // uusiLukuTB
            // 
            uusiLukuTB.Location = new Point(363, 53);
            uusiLukuTB.Name = "uusiLukuTB";
            uusiLukuTB.Size = new Size(125, 27);
            uusiLukuTB.TabIndex = 2;
            uusiLukuTB.KeyPress += uusiLukuTB_KeyPress;
            // 
            // LukujenJarjestysFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 227);
            Controls.Add(uusiLukuTB);
            Controls.Add(VastausLB);
            Controls.Add(lblOhje);
            Name = "LukujenJarjestysFM";
            Text = "Lukujen järjestys";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOhje;
        private Label VastausLB;
        private TextBox uusiLukuTB;
    }
}
