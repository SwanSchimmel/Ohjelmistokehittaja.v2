namespace _16_Tehtävä___Ajastin
{
    partial class laskuri
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
            minuutitLB = new Label();
            sekunnitLB = new Label();
            startBT = new Button();
            stopBT = new Button();
            minuutitCB = new ComboBox();
            sekunnitCB = new ComboBox();
            aikaLB = new Label();
            AjastinTM = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // minuutitLB
            // 
            minuutitLB.AutoSize = true;
            minuutitLB.Location = new Point(56, 67);
            minuutitLB.Margin = new Padding(6, 0, 6, 0);
            minuutitLB.Name = "minuutitLB";
            minuutitLB.Size = new Size(127, 38);
            minuutitLB.TabIndex = 0;
            minuutitLB.Text = "minuutit:";
            // 
            // sekunnitLB
            // 
            sekunnitLB.AutoSize = true;
            sekunnitLB.Location = new Point(207, 67);
            sekunnitLB.Margin = new Padding(6, 0, 6, 0);
            sekunnitLB.Name = "sekunnitLB";
            sekunnitLB.Size = new Size(128, 38);
            sekunnitLB.TabIndex = 1;
            sekunnitLB.Text = "sekunnit:";
            // 
            // startBT
            // 
            startBT.Location = new Point(43, 342);
            startBT.Margin = new Padding(6);
            startBT.Name = "startBT";
            startBT.Size = new Size(140, 62);
            startBT.TabIndex = 2;
            startBT.Text = "start";
            startBT.UseVisualStyleBackColor = true;
            startBT.Click += startBT_Click;
            // 
            // stopBT
            // 
            stopBT.Location = new Point(207, 342);
            stopBT.Margin = new Padding(6);
            stopBT.Name = "stopBT";
            stopBT.Size = new Size(140, 62);
            stopBT.TabIndex = 3;
            stopBT.Text = "stop";
            stopBT.UseVisualStyleBackColor = true;
            stopBT.Click += stopBT_Click;
            // 
            // minuutitCB
            // 
            minuutitCB.FormattingEnabled = true;
            minuutitCB.Location = new Point(43, 123);
            minuutitCB.Margin = new Padding(6);
            minuutitCB.Name = "minuutitCB";
            minuutitCB.Size = new Size(140, 45);
            minuutitCB.TabIndex = 4;
            minuutitCB.SelectedIndexChanged += minuutitCB_SelectedIndexChanged;
            // 
            // sekunnitCB
            // 
            sekunnitCB.FormattingEnabled = true;
            sekunnitCB.Location = new Point(207, 123);
            sekunnitCB.Margin = new Padding(6);
            sekunnitCB.Name = "sekunnitCB";
            sekunnitCB.RightToLeft = RightToLeft.Yes;
            sekunnitCB.Size = new Size(140, 45);
            sekunnitCB.TabIndex = 5;
            // 
            // aikaLB
            // 
            aikaLB.AutoSize = true;
            aikaLB.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
            aikaLB.Location = new Point(85, 202);
            aikaLB.Name = "aikaLB";
            aikaLB.Size = new Size(234, 106);
            aikaLB.TabIndex = 6;
            aikaLB.Text = "00:00";
            aikaLB.Click += aikaLB_Click;
            // 
            // AjastinTM
            // 
            AjastinTM.Interval = 1000;
            AjastinTM.Tick += AjastinTM_Tick;
            // 
            // laskuri
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gold;
            ClientSize = new Size(410, 487);
            Controls.Add(aikaLB);
            Controls.Add(sekunnitCB);
            Controls.Add(minuutitCB);
            Controls.Add(stopBT);
            Controls.Add(startBT);
            Controls.Add(sekunnitLB);
            Controls.Add(minuutitLB);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "laskuri";
            Text = "laskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label minuutitLB;
        private Label sekunnitLB;
        private Button startBT;
        private Button stopBT;
        private ComboBox minuutitCB;
        private ComboBox sekunnitCB;
        private Label aikaLB;
        private System.Windows.Forms.Timer AjastinTM;
    }
}
