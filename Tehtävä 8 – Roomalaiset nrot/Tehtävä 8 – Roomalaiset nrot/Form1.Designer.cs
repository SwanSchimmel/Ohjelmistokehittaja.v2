namespace Tehtävä_8___Roomalaiset_nrot
{
    partial class RoomalasiksiForm
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
            label1 = new Label();
            label2 = new Label();
            TekstiTB = new TextBox();
            VastausLB = new Label();
            MuutaBT = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(104, 54);
            label1.Name = "label1";
            label1.Size = new Size(842, 111);
            label1.TabIndex = 0;
            label1.Text = "Roomalaiset numerot";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 229);
            label2.Name = "label2";
            label2.Size = new Size(674, 32);
            label2.TabIndex = 1;
            label2.Text = "Anna numero välillö 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // TekstiTB
            // 
            TekstiTB.Location = new Point(831, 231);
            TekstiTB.Name = "TekstiTB";
            TekstiTB.Size = new Size(131, 40);
            TekstiTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Font = new Font("Comic Sans MS", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            VastausLB.Location = new Point(119, 304);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(204, 65);
            VastausLB.TabIndex = 3;
            VastausLB.Text = "Vastaus";
            VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            MuutaBT.Location = new Point(831, 314);
            MuutaBT.Name = "MuutaBT";
            MuutaBT.Size = new Size(131, 55);
            MuutaBT.TabIndex = 4;
            MuutaBT.Text = "Muuta";
            MuutaBT.UseVisualStyleBackColor = true;
            MuutaBT.Click += MuutaBT_Click;
            // 
            // RoomalasiksiForm
            // 
            AutoScaleDimensions = new SizeF(14F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1095, 511);
            Controls.Add(MuutaBT);
            Controls.Add(VastausLB);
            Controls.Add(TekstiTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "RoomalasiksiForm";
            Text = "Roomalaiset";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TekstiTB;
        private Label VastausLB;
        private Button MuutaBT;
    }
}
