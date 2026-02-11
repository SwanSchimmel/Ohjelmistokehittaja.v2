namespace TokaProekti
{
    partial class BMIForm
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
            label2 = new Label();
            painoTB = new TextBox();
            pituusTB = new TextBox();
            LaskeBT = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 47);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "Anna paino:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 120);
            label2.Name = "label2";
            label2.Size = new Size(147, 32);
            label2.TabIndex = 1;
            label2.Text = "Anna pituus:";
            // 
            // painoTB
            // 
            painoTB.Location = new Point(208, 47);
            painoTB.Name = "painoTB";
            painoTB.Size = new Size(125, 39);
            painoTB.TabIndex = 2;
            // 
            // pituusTB
            // 
            pituusTB.Location = new Point(208, 120);
            pituusTB.Name = "pituusTB";
            pituusTB.Size = new Size(125, 39);
            pituusTB.TabIndex = 3;
            // 
            // LaskeBT
            // 
            LaskeBT.Location = new Point(55, 191);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(278, 69);
            LaskeBT.TabIndex = 4;
            LaskeBT.Text = "Laske painoindeksi";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(55, 284);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 5;
            label3.Text = "Vastaus";
            label3.Visible = false;
            // 
            // BMIForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 350);
            Controls.Add(label3);
            Controls.Add(LaskeBT);
            Controls.Add(pituusTB);
            Controls.Add(painoTB);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "BMIForm";
            Text = "_10_tehtava";
            Load += _10_tehtava_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox painoTB;
        private TextBox pituusTB;
        private Button LaskeBT;
        private Label label3;
    }
}