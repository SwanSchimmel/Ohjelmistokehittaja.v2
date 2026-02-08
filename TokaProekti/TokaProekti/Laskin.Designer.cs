namespace TokaProekti
{
    partial class Laskin
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
            LaskutoimitusCB = new ComboBox();
            LukuKaksiTB = new TextBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            LukuYksiTB = new TextBox();
            SuspendLayout();
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(128, 58);
            LaskutoimitusCB.Margin = new Padding(3, 2, 3, 2);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(39, 29);
            LaskutoimitusCB.TabIndex = 0;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LukuKaksiTB.Location = new Point(188, 58);
            LukuKaksiTB.Margin = new Padding(3, 2, 3, 2);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(70, 29);
            LukuKaksiTB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            label1.Location = new Point(290, 64);
            label1.Name = "label1";
            label1.Size = new Size(21, 21);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            VastausLB.Location = new Point(317, 64);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(19, 21);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            VastausLB.Click += label2_Click;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(357, 62);
            LaskeBT.Margin = new Padding(3, 2, 3, 2);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(82, 22);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "loske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += button1_Click;
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            LukuYksiTB.Location = new Point(41, 58);
            LukuYksiTB.Margin = new Padding(3, 2, 3, 2);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(58, 29);
            LukuYksiTB.TabIndex = 6;
            // 
            // Laskin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(LukuYksiTB);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LaskutoimitusCB);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Laskin";
            Text = "Laskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox LaskutoimitusCB;
        private TextBox LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
        private TextBox LukuYksiTB;
    }
}