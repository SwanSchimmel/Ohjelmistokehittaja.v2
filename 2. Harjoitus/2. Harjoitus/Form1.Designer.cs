namespace _2._Harjoitus
{
    partial class Form1
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
            OtsikkoLB = new Label();
            ViestiTB = new TextBox();
            TulostusLB = new Label();
            TulostaBT = new Button();
            SuspendLayout();
            // 
            // OtsikkoLB
            // 
            OtsikkoLB.AutoSize = true;
            OtsikkoLB.Font = new Font("Segoe Script", 16F);
            OtsikkoLB.Location = new Point(44, 37);
            OtsikkoLB.Name = "OtsikkoLB";
            OtsikkoLB.Size = new Size(371, 42);
            OtsikkoLB.TabIndex = 0;
            OtsikkoLB.Text = "Anna tulostettava teksti:";
            // 
            // ViestiTB
            // 
            ViestiTB.Font = new Font("Segoe UI", 16F);
            ViestiTB.Location = new Point(421, 37);
            ViestiTB.Name = "ViestiTB";
            ViestiTB.Size = new Size(242, 43);
            ViestiTB.TabIndex = 1;
            // 
            // TulostusLB
            // 
            TulostusLB.AutoSize = true;
            TulostusLB.Font = new Font("Segoe Script", 16F);
            TulostusLB.Location = new Point(59, 120);
            TulostusLB.Name = "TulostusLB";
            TulostusLB.Size = new Size(91, 42);
            TulostusLB.TabIndex = 2;
            TulostusLB.Text = "xxxx";
            TulostusLB.Visible = false;
            // 
            // TulostaBT
            // 
            TulostaBT.FlatStyle = FlatStyle.System;
            TulostaBT.Font = new Font("Segoe UI", 16F);
            TulostaBT.Location = new Point(421, 106);
            TulostaBT.Name = "TulostaBT";
            TulostaBT.Size = new Size(171, 62);
            TulostaBT.TabIndex = 3;
            TulostaBT.Text = "Tulosta teksti";
            TulostaBT.UseVisualStyleBackColor = true;
            TulostaBT.Click += TulostaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Salmon;
            ClientSize = new Size(800, 450);
            Controls.Add(TulostaBT);
            Controls.Add(TulostusLB);
            Controls.Add(ViestiTB);
            Controls.Add(OtsikkoLB);
            ForeColor = Color.MintCream;
            Name = "Form1";
            Text = "Harjoitus 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OtsikkoLB;
        private TextBox ViestiTB;
        private Label TulostusLB;
        private Button TulostaBT;
    }
}
