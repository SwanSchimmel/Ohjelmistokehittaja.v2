namespace _13_14_tehtava
{
    partial class _13_Tehtävä___koodi
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
            label1 = new Label();
            NimiTB = new TextBox();
            VastausLB = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(65, 51);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(618, 31);
            label1.TabIndex = 0;
            label1.Text = "anna nimesi, niin tarkistan, onko se 50 suosituimam joukossa:";
            // 
            // NimiTB
            // 
            NimiTB.BackColor = SystemColors.InactiveBorder;
            NimiTB.Location = new Point(769, 54);
            NimiTB.Margin = new Padding(5);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(233, 39);
            NimiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Segoe UI", 13.8F, FontStyle.Italic, GraphicsUnit.Point);
            VastausLB.Location = new Point(75, 130);
            VastausLB.Margin = new Padding(5, 0, 5, 0);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(87, 31);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "vastaus";
            VastausLB.Visible = false;
            VastausLB.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(772, 130);
            button1.Margin = new Padding(5);
            button1.Name = "button1";
            button1.Size = new Size(232, 63);
            button1.TabIndex = 3;
            button1.Text = "tarkasta";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // _13_Tehtävä___koodi
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1060, 253);
            Controls.Add(button1);
            Controls.Add(VastausLB);
            Controls.Add(NimiTB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "_13_Tehtävä___koodi";
            Text = "_13_Tehtävä___koodi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NimiTB;
        private Label VastausLB;
        private Button button1;
    }
}