namespace _13_14_tehtava
{
    partial class DiaryForm
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
            paivakirjaTB = new TextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // paivakirjaTB
            // 
            paivakirjaTB.BackColor = SystemColors.Info;
            paivakirjaTB.Location = new Point(48, 40);
            paivakirjaTB.Multiline = true;
            paivakirjaTB.Name = "paivakirjaTB";
            paivakirjaTB.Size = new Size(514, 282);
            paivakirjaTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            TallennaBT.BackColor = Color.SeaShell;
            TallennaBT.Location = new Point(48, 347);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(514, 72);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna päväkirjaan";
            TallennaBT.UseVisualStyleBackColor = false;
            TallennaBT.Click += button1_Click;
            // 
            // DiaryForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(659, 461);
            Controls.Add(TallennaBT);
            Controls.Add(paivakirjaTB);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "DiaryForm";
            Text = "päiväkirjä";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paivakirjaTB;
        private Button TallennaBT;
    }
}
