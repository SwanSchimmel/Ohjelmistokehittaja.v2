namespace _10_tehtävät___BMI_laskuri
{
    partial class BMIForm
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
            PainoOtsikkoLB = new Label();
            PituusOtsikkoLB = new Label();
            LaskeBT = new Button();
            PainoTB = new TextBox();
            PituusTB = new TextBox();
            VastausLB = new Label();
            KuvausLB = new Label();
            SuspendLayout();
            // 
            // PainoOtsikkoLB
            // 
            PainoOtsikkoLB.AutoSize = true;
            PainoOtsikkoLB.Location = new Point(26, 31);
            PainoOtsikkoLB.Margin = new Padding(5, 0, 5, 0);
            PainoOtsikkoLB.Name = "PainoOtsikkoLB";
            PainoOtsikkoLB.Size = new Size(136, 31);
            PainoOtsikkoLB.TabIndex = 0;
            PainoOtsikkoLB.Text = "Anna paino:";
            // 
            // PituusOtsikkoLB
            // 
            PituusOtsikkoLB.AutoSize = true;
            PituusOtsikkoLB.Location = new Point(21, 102);
            PituusOtsikkoLB.Margin = new Padding(5, 0, 5, 0);
            PituusOtsikkoLB.Name = "PituusOtsikkoLB";
            PituusOtsikkoLB.Size = new Size(142, 31);
            PituusOtsikkoLB.TabIndex = 1;
            PituusOtsikkoLB.Text = "Anna pituus:";
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(26, 160);
            LaskeBT.Margin = new Padding(5);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(301, 50);
            LaskeBT.TabIndex = 2;
            LaskeBT.Text = "Laske Painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // PainoTB
            // 
            PainoTB.Location = new Point(202, 31);
            PainoTB.Name = "PainoTB";
            PainoTB.Size = new Size(125, 38);
            PainoTB.TabIndex = 3;
            // 
            // PituusTB
            // 
            PituusTB.Location = new Point(202, 102);
            PituusTB.Name = "PituusTB";
            PituusTB.Size = new Size(125, 38);
            PituusTB.TabIndex = 4;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(26, 242);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(91, 31);
            VastausLB.TabIndex = 5;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // KuvausLB
            // 
            KuvausLB.AutoSize = true;
            KuvausLB.Location = new Point(28, 289);
            KuvausLB.Name = "KuvausLB";
            KuvausLB.Size = new Size(86, 31);
            KuvausLB.TabIndex = 6;
            KuvausLB.Text = "Kuvaus";
            KuvausLB.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 363);
            Controls.Add(KuvausLB);
            Controls.Add(VastausLB);
            Controls.Add(PituusTB);
            Controls.Add(PainoTB);
            Controls.Add(LaskeBT);
            Controls.Add(PituusOtsikkoLB);
            Controls.Add(PainoOtsikkoLB);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "BMIForm";
            Text = "BMI laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PainoOtsikkoLB;
        private Label PituusOtsikkoLB;
        private Button LaskeBT;
        private TextBox PainoTB;
        private TextBox PituusTB;
        private Label VastausLB;
        private Label KuvausLB;
    }
}
