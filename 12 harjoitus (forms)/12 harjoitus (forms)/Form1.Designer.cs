namespace _12_harjoitus__forms_
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
            label1 = new Label();
            noppa01PB = new PictureBox();
            noppa02PB = new PictureBox();
            HeitaBT = new Button();
            ((System.ComponentModel.ISupportInitialize)noppa01PB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(274, 52);
            label1.TabIndex = 0;
            label1.Text = "Nopan heitto";
            // 
            // noppa01PB
            // 
            noppa01PB.Cursor = Cursors.IBeam;
            noppa01PB.Image = Properties.Resources.dice01;
            noppa01PB.Location = new Point(41, 134);
            noppa01PB.Name = "noppa01PB";
            noppa01PB.Size = new Size(100, 100);
            noppa01PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa01PB.TabIndex = 1;
            noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            noppa02PB.Image = Properties.Resources.dice01;
            noppa02PB.Location = new Point(202, 134);
            noppa02PB.Name = "noppa02PB";
            noppa02PB.Size = new Size(100, 100);
            noppa02PB.SizeMode = PictureBoxSizeMode.Zoom;
            noppa02PB.TabIndex = 2;
            noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            HeitaBT.Font = new Font("MV Boli", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HeitaBT.Location = new Point(41, 262);
            HeitaBT.Name = "HeitaBT";
            HeitaBT.Size = new Size(261, 59);
            HeitaBT.TabIndex = 3;
            HeitaBT.Text = "Heita";
            HeitaBT.UseVisualStyleBackColor = true;
            HeitaBT.Click += HeitaBT_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(HeitaBT);
            Controls.Add(noppa02PB);
            Controls.Add(noppa01PB);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)noppa01PB).EndInit();
            ((System.ComponentModel.ISupportInitialize)noppa02PB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox noppa01PB;
        private PictureBox noppa02PB;
        private Button HeitaBT;
    }
}
