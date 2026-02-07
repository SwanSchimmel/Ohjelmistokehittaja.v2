namespace TokaProekti
{
    partial class Harjoitus_2
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
            OtsikkoLB = new Label();
            label1 = new Label();
            ViestiTB = new TextBox();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            OtsikkoLB.Location = new Point(176, 98);
            OtsikkoLB.Margin = new Padding(6, 0, 6, 0);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(220, 25);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(176, 176);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(56, 25);
            label1.TabIndex = 1;
            label1.Text = "xxxx";
            label1.Visible = false;
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            ViestiTB.Location = new Point(408, 95);
            ViestiTB.Margin = new Padding(6, 6, 6, 6);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(457, 29);
            ViestiTB.TabIndex = 2;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Location = new Point(633, 176);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(232, 51);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tekstiksi tulosta ";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Harjoitus_2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(1500, 832);
            Controls.Add(TulostaBT);
            Controls.Add(ViestiTB);
            Controls.Add(label1);
            Controls.Add(OtsikkoLB);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.MintCream;
            Margin = new Padding(6, 6, 6, 6);
            Name = "Harjoitus_2";
            Text = "Harjoitus_2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private Label label1;
        private TextBox ViestiTB;
        private Button TulostaBT;
    }
}