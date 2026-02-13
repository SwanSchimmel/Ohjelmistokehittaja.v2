namespace _4._Harjoitus
{
    partial class IkaLaskuriFM
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
            SynttariDTP = new DateTimePicker();
            LaskeBT = new Button();
            VuosinaLB = new Label();
            KuukausinaLB = new Label();
            PaivinaLB = new Label();
            TunteinaLB = new Label();
            MinuutteinaLB = new Label();
            SekunteinaLB = new Label();
            SuspendLayout();
            // 
            // SynttariDTP
            // 
            SynttariDTP.Font = new Font("Segoe UI", 16F);
            SynttariDTP.Format = DateTimePickerFormat.Short;
            SynttariDTP.Location = new Point(63, 55);
            SynttariDTP.Name = "SynttariDTP";
            SynttariDTP.Size = new Size(274, 43);
            SynttariDTP.TabIndex = 0;
            // 
            // LaskeBT
            // 
            LaskeBT.Font = new Font("Segoe UI", 14F);
            LaskeBT.Location = new Point(359, 52);
            LaskeBT.Name = "LaskeBT";
            LaskeBT.Size = new Size(107, 46);
            LaskeBT.TabIndex = 1;
            LaskeBT.Text = "Laske ikä";
            LaskeBT.UseVisualStyleBackColor = true;
            LaskeBT.Click += LaskeBT_Click;
            // 
            // VuosinaLB
            // 
            VuosinaLB.AutoSize = true;
            VuosinaLB.Font = new Font("Segoe UI", 16F);
            VuosinaLB.Location = new Point(63, 119);
            VuosinaLB.Name = "VuosinaLB";
            VuosinaLB.Size = new Size(111, 37);
            VuosinaLB.TabIndex = 2;
            VuosinaLB.Text = "Vuosina";
            // 
            // KuukausinaLB
            // 
            KuukausinaLB.AutoSize = true;
            KuukausinaLB.Font = new Font("Segoe UI", 16F);
            KuukausinaLB.Location = new Point(63, 176);
            KuukausinaLB.Name = "KuukausinaLB";
            KuukausinaLB.Size = new Size(152, 37);
            KuukausinaLB.TabIndex = 3;
            KuukausinaLB.Text = "Kuukausina";
            KuukausinaLB.Click += label2_Click;
            // 
            // PaivinaLB
            // 
            PaivinaLB.AutoSize = true;
            PaivinaLB.Font = new Font("Segoe UI", 16F);
            PaivinaLB.Location = new Point(63, 242);
            PaivinaLB.Name = "PaivinaLB";
            PaivinaLB.Size = new Size(101, 37);
            PaivinaLB.TabIndex = 4;
            PaivinaLB.Text = "Paivina";
            // 
            // TunteinaLB
            // 
            TunteinaLB.AutoSize = true;
            TunteinaLB.Font = new Font("Segoe UI", 16F);
            TunteinaLB.Location = new Point(256, 119);
            TunteinaLB.Name = "TunteinaLB";
            TunteinaLB.Size = new Size(120, 37);
            TunteinaLB.TabIndex = 5;
            TunteinaLB.Text = "Tunteina";
            // 
            // MinuutteinaLB
            // 
            MinuutteinaLB.AutoSize = true;
            MinuutteinaLB.Font = new Font("Segoe UI", 16F);
            MinuutteinaLB.Location = new Point(256, 176);
            MinuutteinaLB.Name = "MinuutteinaLB";
            MinuutteinaLB.Size = new Size(161, 37);
            MinuutteinaLB.TabIndex = 6;
            MinuutteinaLB.Text = "Minuutteina";
            MinuutteinaLB.Click += MinuutteinaLB_Click;
            // 
            // SekunteinaLB
            // 
            SekunteinaLB.AutoSize = true;
            SekunteinaLB.Font = new Font("Segoe UI", 16F);
            SekunteinaLB.Location = new Point(256, 242);
            SekunteinaLB.Name = "SekunteinaLB";
            SekunteinaLB.Size = new Size(147, 37);
            SekunteinaLB.TabIndex = 7;
            SekunteinaLB.Text = "Sekunteina";
            // 
            // IkaLaskuriFM
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(539, 452);
            Controls.Add(SekunteinaLB);
            Controls.Add(MinuutteinaLB);
            Controls.Add(TunteinaLB);
            Controls.Add(PaivinaLB);
            Controls.Add(KuukausinaLB);
            Controls.Add(VuosinaLB);
            Controls.Add(LaskeBT);
            Controls.Add(SynttariDTP);
            Font = new Font("Segoe UI", 9F);
            Name = "IkaLaskuriFM";
            Text = "IkaLaskuri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker SynttariDTP;
        private Button LaskeBT;
        private Label VuosinaLB;
        private Label KuukausinaLB;
        private Label PaivinaLB;
        private Label TunteinaLB;
        private Label MinuutteinaLB;
        private Label SekunteinaLB;
    }
}
