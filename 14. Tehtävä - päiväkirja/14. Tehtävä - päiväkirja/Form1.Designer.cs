namespace _14._Tehtävä___päiväkirja
{
    partial class PaivakirjaForm
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
            SyottoTB = new RichTextBox();
            TallennaBT = new Button();
            SuspendLayout();
            // 
            // SyottoTB
            // 
            SyottoTB.Location = new Point(12, 12);
            SyottoTB.Name = "SyottoTB";
            SyottoTB.Size = new Size(776, 317);
            SyottoTB.TabIndex = 0;
            SyottoTB.Text = "";
            // 
            // TallennaBT
            // 
            TallennaBT.Location = new Point(12, 350);
            TallennaBT.Name = "TallennaBT";
            TallennaBT.Size = new Size(776, 88);
            TallennaBT.TabIndex = 1;
            TallennaBT.Text = "Tallenna";
            TallennaBT.UseVisualStyleBackColor = true;
            TallennaBT.Click += TallennaBT_Click;
            // 
            // PaivakirjaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TallennaBT);
            Controls.Add(SyottoTB);
            Name = "PaivakirjaForm";
            Text = "Paivakirja";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox SyottoTB;
        private Button TallennaBT;
    }
}
