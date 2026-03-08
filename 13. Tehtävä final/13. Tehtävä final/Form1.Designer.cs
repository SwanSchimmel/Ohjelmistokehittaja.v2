namespace _13._Tehtävä_final
{
    partial class NimesiForm
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
            buttonTarkastetaan = new Button();
            label1 = new Label();
            label2 = new Label();
            VastausLB = new Label();
            NimiTB = new TextBox();
            SuspendLayout();
            // 
            // buttonTarkastetaan
            // 
            buttonTarkastetaan.Location = new Point(717, 123);
            buttonTarkastetaan.Margin = new Padding(5);
            buttonTarkastetaan.Name = "buttonTarkastetaan";
            buttonTarkastetaan.Size = new Size(143, 49);
            buttonTarkastetaan.TabIndex = 0;
            buttonTarkastetaan.Text = "Tarkastetaan";
            buttonTarkastetaan.UseVisualStyleBackColor = true;
            buttonTarkastetaan.Click += buttonTarkastetaan_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label1.Location = new Point(27, 60);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(670, 33);
            label1.TabIndex = 2;
            label1.Text = "Anna nimesi, niin tarkastetaan, onko se 50 suosituimman joukossa:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold);
            label2.Location = new Point(27, 131);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(468, 33);
            label2.TabIndex = 3;
            label2.Text = "Nimesi 35. suosituinpoikien nimi vuonna 2020";
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(38, 191);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(63, 25);
            VastausLB.TabIndex = 4;
            VastausLB.Text = "label3";
            VastausLB.Visible = false;
            // 
            // NimiTB
            // 
            NimiTB.Location = new Point(717, 60);
            NimiTB.Name = "NimiTB";
            NimiTB.Size = new Size(143, 33);
            NimiTB.TabIndex = 5;
            // 
            // NimesiForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 256);
            Controls.Add(NimiTB);
            Controls.Add(VastausLB);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonTarkastetaan);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "NimesiForm";
            Text = "Onko nimesi suosittajien joukossa?";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTarkastetaan;
        private Label label1;
        private Label label2;
        private Label VastausLB;
        private TextBox NimiTB;
    }
}
