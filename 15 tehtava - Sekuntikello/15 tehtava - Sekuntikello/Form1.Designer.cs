namespace _15_tehtava___Sekuntikello
{
    partial class SekkariForm
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
            components = new System.ComponentModel.Container();
            AikaLB = new Label();
            TyhjennäBT = new Button();
            LopetaBT = new Button();
            KäymistäBT = new Button();
            AjanottoTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // AikaLB
            // 
            AikaLB.AutoSize = true;
            AikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            AikaLB.Location = new Point(37, 70);
            AikaLB.Name = "AikaLB";
            AikaLB.Size = new Size(730, 159);
            AikaLB.TabIndex = 0;
            AikaLB.Text = "00:00:00.000";
            // 
            // TyhjennäBT
            // 
            TyhjennäBT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            TyhjennäBT.Location = new Point(535, 256);
            TyhjennäBT.Name = "TyhjennäBT";
            TyhjennäBT.Size = new Size(191, 63);
            TyhjennäBT.TabIndex = 1;
            TyhjennäBT.Text = "Tyhjennä";
            TyhjennäBT.UseVisualStyleBackColor = true;
            TyhjennäBT.Click += TyhjennäBT_Click;
            // 
            // LopetaBT
            // 
            LopetaBT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LopetaBT.Location = new Point(299, 256);
            LopetaBT.Name = "LopetaBT";
            LopetaBT.Size = new Size(204, 63);
            LopetaBT.TabIndex = 2;
            LopetaBT.Text = "Lopeta";
            LopetaBT.UseVisualStyleBackColor = true;
            LopetaBT.Click += LopetaBT_Click;
            // 
            // KäymistäBT
            // 
            KäymistäBT.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            KäymistäBT.Location = new Point(60, 256);
            KäymistäBT.Name = "KäymistäBT";
            KäymistäBT.Size = new Size(201, 62);
            KäymistäBT.TabIndex = 3;
            KäymistäBT.Text = "Käymistä";
            KäymistäBT.UseVisualStyleBackColor = true;
            KäymistäBT.Click += KäymistäBT_Click;
            // 
            // AjanottoTM
            // 
            AjanottoTM.Enabled = true;
            AjanottoTM.Tick += this.AjanottoTM;
            // 
            // SekkariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(KäymistäBT);
            Controls.Add(LopetaBT);
            Controls.Add(TyhjennäBT);
            Controls.Add(AikaLB);
            Name = "SekkariForm";
            Text = "Sekkuntinkello";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AikaLB;
        private Button TyhjennäBT;
        private Button LopetaBT;
        private Button KäymistäBT;
        private System.Windows.Forms.Timer AjanottoTM;
    }
}
