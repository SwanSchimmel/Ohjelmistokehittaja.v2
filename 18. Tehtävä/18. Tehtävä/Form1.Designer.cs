namespace _18._Tehtävä
{
    partial class AvainhenkilötForm
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
            OppilaitosLB = new Label();
            OppilaitosCB = new ComboBox();
            PuhelinLB = new Label();
            PostitoimipaikkaLB = new Label();
            PostinumeroLB = new Label();
            OsoiteLB = new Label();
            TitteliLB = new Label();
            PostinLB = new Label();
            SähköpostiLB = new Label();
            PuhLB = new Label();
            vastuuhloCB = new ComboBox();
            vastuuhenLB = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(54, 48);
            label1.Name = "label1";
            label1.Size = new Size(559, 60);
            label1.TabIndex = 0;
            label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // OppilaitosLB
            // 
            OppilaitosLB.AutoSize = true;
            OppilaitosLB.Location = new Point(68, 138);
            OppilaitosLB.Name = "OppilaitosLB";
            OppilaitosLB.Size = new Size(193, 31);
            OppilaitosLB.TabIndex = 1;
            OppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // OppilaitosCB
            // 
            OppilaitosCB.BackColor = SystemColors.GradientActiveCaption;
            OppilaitosCB.FormattingEnabled = true;
            OppilaitosCB.Location = new Point(68, 191);
            OppilaitosCB.Name = "OppilaitosCB";
            OppilaitosCB.Size = new Size(151, 39);
            OppilaitosCB.TabIndex = 2;
            OppilaitosCB.SelectedIndexChanged += OppilaitosCB_SelectedIndexChanged;
            // 
            // PuhelinLB
            // 
            PuhelinLB.AutoSize = true;
            PuhelinLB.Location = new Point(68, 411);
            PuhelinLB.Name = "PuhelinLB";
            PuhelinLB.Size = new Size(90, 31);
            PuhelinLB.TabIndex = 3;
            PuhelinLB.Text = "Puhelin";
            // 
            // PostitoimipaikkaLB
            // 
            PostitoimipaikkaLB.AutoSize = true;
            PostitoimipaikkaLB.Location = new Point(68, 358);
            PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            PostitoimipaikkaLB.Size = new Size(182, 31);
            PostitoimipaikkaLB.TabIndex = 4;
            PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PostinumeroLB
            // 
            PostinumeroLB.AutoSize = true;
            PostinumeroLB.Location = new Point(68, 305);
            PostinumeroLB.Name = "PostinumeroLB";
            PostinumeroLB.Size = new Size(142, 31);
            PostinumeroLB.TabIndex = 5;
            PostinumeroLB.Text = "Postinumero";
            // 
            // OsoiteLB
            // 
            OsoiteLB.AutoSize = true;
            OsoiteLB.Location = new Point(68, 252);
            OsoiteLB.Name = "OsoiteLB";
            OsoiteLB.Size = new Size(80, 31);
            OsoiteLB.TabIndex = 6;
            OsoiteLB.Text = "Osoite";
            // 
            // TitteliLB
            // 
            TitteliLB.AutoSize = true;
            TitteliLB.Location = new Point(363, 252);
            TitteliLB.Name = "TitteliLB";
            TitteliLB.Size = new Size(72, 31);
            TitteliLB.TabIndex = 12;
            TitteliLB.Text = "Titteli";
            // 
            // PostinLB
            // 
            PostinLB.Location = new Point(363, 305);
            PostinLB.Name = "PostinLB";
            PostinLB.Size = new Size(76, 31);
            PostinLB.TabIndex = 11;
            PostinLB.Text = "Postin";
            // 
            // SähköpostiLB
            // 
            SähköpostiLB.AutoSize = true;
            SähköpostiLB.Location = new Point(363, 358);
            SähköpostiLB.Name = "SähköpostiLB";
            SähköpostiLB.Size = new Size(126, 31);
            SähköpostiLB.TabIndex = 10;
            SähköpostiLB.Text = "Sähköposti";
            // 
            // PuhLB
            // 
            PuhLB.AutoSize = true;
            PuhLB.Location = new Point(363, 411);
            PuhLB.Name = "PuhLB";
            PuhLB.Size = new Size(90, 31);
            PuhLB.TabIndex = 9;
            PuhLB.Text = "Puhelin";
            // 
            // vastuuhloCB
            // 
            vastuuhloCB.BackColor = SystemColors.GradientActiveCaption;
            vastuuhloCB.FormattingEnabled = true;
            vastuuhloCB.Location = new Point(363, 191);
            vastuuhloCB.Name = "vastuuhloCB";
            vastuuhloCB.Size = new Size(151, 39);
            vastuuhloCB.TabIndex = 8;
            vastuuhloCB.SelectedIndexChanged += vastuuhloCB_SelectedIndexChanged;
            // 
            // vastuuhenLB
            // 
            vastuuhenLB.AutoSize = true;
            vastuuhenLB.Location = new Point(363, 138);
            vastuuhenLB.Name = "vastuuhenLB";
            vastuuhenLB.Size = new Size(232, 31);
            vastuuhenLB.TabIndex = 7;
            vastuuhenLB.Text = "Valitse vastuuhenkilö:";
            // 
            // AvainhenkilötForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(870, 552);
            Controls.Add(TitteliLB);
            Controls.Add(PostinLB);
            Controls.Add(SähköpostiLB);
            Controls.Add(PuhLB);
            Controls.Add(vastuuhloCB);
            Controls.Add(vastuuhenLB);
            Controls.Add(OsoiteLB);
            Controls.Add(PostinumeroLB);
            Controls.Add(PostitoimipaikkaLB);
            Controls.Add(PuhelinLB);
            Controls.Add(OppilaitosCB);
            Controls.Add(OppilaitosLB);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.FromArgb(64, 64, 64);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AvainhenkilötForm";
            Text = "Oppilaitosten avainhenkilöt";
            Load += AvainhenkilötForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label OppilaitosLB;
        private ComboBox OppilaitosCB;
        private Label PuhelinLB;
        private Label PostitoimipaikkaLB;
        private Label PostinumeroLB;
        private Label OsoiteLB;
        private Label TitteliLB;
        private Label PostinLB;
        private Label SähköpostiLB;
        private Label PuhLB;
        private ComboBox vastuuhloCB;
        private Label vastuuhenLB;
    }
}
