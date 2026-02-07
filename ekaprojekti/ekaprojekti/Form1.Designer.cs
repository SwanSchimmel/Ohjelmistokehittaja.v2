namespace ekaprojekti
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
            TeksttiBT = new Label();
            SuspendLayout();
            // 
            // TeksttiBT
            // 
            TeksttiBT.AutoSize = true;
            TeksttiBT.Location = new Point(30, 47);
            TeksttiBT.Name = "TeksttiBT";
            TeksttiBT.Size = new Size(44, 20);
            TeksttiBT.TabIndex = 0;
            TeksttiBT.Text = "Paina";
            TeksttiBT.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TeksttiBT);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TeksttiBT;
    }
}
