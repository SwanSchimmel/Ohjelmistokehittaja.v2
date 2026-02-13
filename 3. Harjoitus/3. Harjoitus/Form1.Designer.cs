namespace _3._Harjoitus
{
    partial class Laskin
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
            LukuYksiTB = new TextBox();
            LaskutoimitusCB = new ComboBox();
            LukuKaksiTB = new TextBox();
            label1 = new Label();
            VastausLB = new Label();
            LaskeBT = new Button();
            SuspendLayout();
            // 
            // LukuYksiTB
            // 
            LukuYksiTB.Font = new Font("Segoe UI", 16F);
            LukuYksiTB.Location = new Point(41, 61);
            LukuYksiTB.Name = "LukuYksiTB";
            LukuYksiTB.Size = new Size(86, 43);
            LukuYksiTB.TabIndex = 0;
            LukuYksiTB.TextChanged += LukuYksiTB_TextChanged;
            // 
            // LaskutoimitusCB
            // 
            LaskutoimitusCB.Font = new Font("Segoe UI", 16F);
            LaskutoimitusCB.FormattingEnabled = true;
            LaskutoimitusCB.Items.AddRange(new object[] { "+", "-", "*", "/" });
            LaskutoimitusCB.Location = new Point(148, 59);
            LaskutoimitusCB.Name = "LaskutoimitusCB";
            LaskutoimitusCB.Size = new Size(59, 45);
            LaskutoimitusCB.TabIndex = 1;
            // 
            // LukuKaksiTB
            // 
            LukuKaksiTB.Font = new Font("Segoe UI", 16F);
            LukuKaksiTB.Location = new Point(222, 61);
            LukuKaksiTB.Name = "LukuKaksiTB";
            LukuKaksiTB.Size = new Size(100, 43);
            LukuKaksiTB.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(340, 64);
            label1.Name = "label1";
            label1.Size = new Size(35, 37);
            label1.TabIndex = 3;
            label1.Text = "=";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 16F);
            VastausLB.Location = new Point(381, 67);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(33, 37);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "X";
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 16F);
            LaskeBT.Location = new Point(420, 59);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(129, 60);
            LaskeBT.TabIndex = 5;
            LaskeBT.Text = "Laske";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // Laskin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LaskeBT);
            Controls.Add(VastausLB);
            Controls.Add(label1);
            Controls.Add(LukuKaksiTB);
            Controls.Add(LaskutoimitusCB);
            Controls.Add(LukuYksiTB);
            Font = new Font("Segoe UI", 9F);
            Name = "Laskin";
            Text = "Yksinkertainen nelilaskin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LukuYksiTB;
        private ComboBox LaskutoimitusCB;
        private TextBox LukuKaksiTB;
        private Label label1;
        private Label VastausLB;
        private Button LaskeBT;
    }
}
