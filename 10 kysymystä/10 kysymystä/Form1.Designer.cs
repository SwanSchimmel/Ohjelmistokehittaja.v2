namespace _10_kysymystä
{
    partial class VastauslomakeForm
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
            RadioButton VastausARB;
            RadioButton VastausBRB;
            RadioButton VastausDRB;
            RadioButton VastausCRB;
            KysymysLB = new Label();
            groupBox1 = new GroupBox();
            DummyRB = new RadioButton();
            VastausLB = new Label();
            VastausARB = new RadioButton();
            VastausBRB = new RadioButton();
            VastausDRB = new RadioButton();
            VastausCRB = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // KysymysLB
            // 
            KysymysLB.AutoSize = true;
            KysymysLB.Location = new Point(40, 49);
            KysymysLB.Name = "KysymysLB";
            KysymysLB.Size = new Size(271, 32);
            KysymysLB.TabIndex = 0;
            KysymysLB.Text = "Vastaus 1. kysymykseen:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(VastausDRB);
            groupBox1.Controls.Add(VastausCRB);
            groupBox1.Controls.Add(VastausBRB);
            groupBox1.Controls.Add(VastausARB);
            groupBox1.Controls.Add(DummyRB);
            groupBox1.Location = new Point(317, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 263);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "vastaus";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // DummyRB
            // 
            DummyRB.AutoSize = true;
            DummyRB.Location = new Point(18, 38);
            DummyRB.Name = "DummyRB";
            DummyRB.Size = new Size(47, 36);
            DummyRB.TabIndex = 0;
            DummyRB.TabStop = true;
            DummyRB.Text = "E";
            DummyRB.UseVisualStyleBackColor = true;
            // 
            // VastausARB
            // 
            VastausARB.AutoSize = true;
            VastausARB.Location = new Point(18, 80);
            VastausARB.Name = "VastausARB";
            VastausARB.Size = new Size(50, 36);
            VastausARB.TabIndex = 1;
            VastausARB.TabStop = true;
            VastausARB.Text = "A";
            VastausARB.UseVisualStyleBackColor = true;
            // 
            // VastausBRB
            // 
            VastausBRB.AutoSize = true;
            VastausBRB.Location = new Point(19, 122);
            VastausBRB.Name = "VastausBRB";
            VastausBRB.Size = new Size(49, 36);
            VastausBRB.TabIndex = 2;
            VastausBRB.TabStop = true;
            VastausBRB.Text = "B";
            VastausBRB.UseVisualStyleBackColor = true;
            // 
            // VastausDRB
            // 
            VastausDRB.AutoSize = true;
            VastausDRB.Location = new Point(13, 206);
            VastausDRB.Name = "VastausDRB";
            VastausDRB.Size = new Size(52, 36);
            VastausDRB.TabIndex = 4;
            VastausDRB.TabStop = true;
            VastausDRB.Text = "D";
            VastausDRB.UseVisualStyleBackColor = true;
            // 
            // VastausCRB
            // 
            VastausCRB.AutoSize = true;
            VastausCRB.Location = new Point(18, 164);
            VastausCRB.Name = "VastausCRB";
            VastausCRB.Size = new Size(50, 36);
            VastausCRB.TabIndex = 3;
            VastausCRB.TabStop = true;
            VastausCRB.Text = "C";
            VastausCRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            VastausLB.AutoSize = true;
            VastausLB.Location = new Point(51, 257);
            VastausLB.Name = "VastausLB";
            VastausLB.Size = new Size(93, 32);
            VastausLB.TabIndex = 2;
            VastausLB.Text = "Vastaus";
            // 
            // VastauslomakeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 377);
            Controls.Add(VastausLB);
            Controls.Add(groupBox1);
            Controls.Add(KysymysLB);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 5, 5, 5);
            Name = "VastauslomakeForm";
            Text = "VastauslomakeForm";
            Load += VastauslomakeForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label KysymysLB;
        private GroupBox groupBox1;
        private RadioButton DummyRB;
        private RadioButton VastausARB;
        private Label VastausLB;
    }
}
