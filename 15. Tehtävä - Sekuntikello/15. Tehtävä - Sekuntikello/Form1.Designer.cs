namespace _15._Tehtävä___Sekuntikello
{
    partial class sekkariForm
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
            aikaLB = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            ajanottoTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point);
            aikaLB.Location = new Point(69, 61);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(763, 159);
            aikaLB.TabIndex = 0;
            aikaLB.Text = " 00:00:00.000";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ActiveCaption;
            button1.Location = new Point(137, 240);
            button1.Name = "button1";
            button1.Size = new Size(157, 65);
            button1.TabIndex = 1;
            button1.Text = "käynnistä";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(620, 240);
            button2.Name = "button2";
            button2.Size = new Size(157, 65);
            button2.TabIndex = 2;
            button2.Text = "tyhjennä";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(388, 240);
            button3.Name = "button3";
            button3.Size = new Size(157, 65);
            button3.TabIndex = 3;
            button3.Text = "lopeta";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ajanottoTM
            // 
            ajanottoTM.Enabled = true;
            ajanottoTM.Tick += ajanottoTM_Tick;
            // 
            // sekkariForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(957, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(aikaLB);
            ForeColor = SystemColors.ActiveCaption;
            Name = "sekkariForm";
            Text = "sekuntikello";
            Load += sekkariForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label aikaLB;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer ajanottoTM;
    }
}
