namespace Tehtävät_9___Celcius_to_Fahrenheit
{
    partial class AsteMuuninForm
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
            groupBox1 = new GroupBox();
            FahrenheitRB = new RadioButton();
            CelsiusRB = new RadioButton();
            label1 = new Label();
            AsteetTB = new TextBox();
            muunaBT = new Button();
            VastausLB = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(FahrenheitRB);
            groupBox1.Controls.Add(CelsiusRB);
            groupBox1.Location = new Point(358, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Miten muunat";
            // 
            // FahrenheitRB
            // 
            FahrenheitRB.AutoSize = true;
            FahrenheitRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            FahrenheitRB.Location = new Point(31, 78);
            FahrenheitRB.Name = "FahrenheitRB";
            FahrenheitRB.Size = new Size(149, 35);
            FahrenheitRB.TabIndex = 1;
            FahrenheitRB.TabStop = true;
            FahrenheitRB.Text = "Fahrenheit";
            FahrenheitRB.UseVisualStyleBackColor = true;
            // 
            // CelsiusRB
            // 
            CelsiusRB.AutoSize = true;
            CelsiusRB.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            CelsiusRB.Location = new Point(31, 37);
            CelsiusRB.Name = "CelsiusRB";
            CelsiusRB.Size = new Size(109, 35);
            CelsiusRB.TabIndex = 0;
            CelsiusRB.TabStop = true;
            CelsiusRB.Text = "Celsius";
            CelsiusRB.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 67);
            label1.Name = "label1";
            label1.Size = new Size(140, 31);
            label1.TabIndex = 1;
            label1.Text = "Anna asteet:";
            // 
            // AsteetTB
            // 
            AsteetTB.Location = new Point(211, 67);
            AsteetTB.Name = "AsteetTB";
            AsteetTB.Size = new Size(125, 38);
            AsteetTB.TabIndex = 2;
            // 
            // muunaBT
            // 
            muunaBT.Location = new Point(679, 102);
            muunaBT.Name = "muunaBT";
            muunaBT.Size = new Size(122, 56);
            muunaBT.TabIndex = 3;
            muunaBT.Text = "Muuna";
            muunaBT.UseVisualStyleBackColor = true;
            muunaBT.Click += muunaBT_Click;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(65, 137);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(96, 31);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "Vastaus:";
            VastausLB.Visible = false;
            // 
            // AsteMuuninForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleGoldenrod;
            ClientSize = new Size(873, 264);
            Controls.Add(VastausLB);
            Controls.Add(muunaBT);
            Controls.Add(AsteetTB);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.DimGray;
            Margin = new Padding(5);
            Name = "AsteMuuninForm";
            Text = "Aste Muunin";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton CelsiusRB;
        private RadioButton FahrenheitRB;
        private Label label1;
        private TextBox AsteetTB;
        private Button muunaBT;
        private Label VastausLB;
    }
}
