namespace _20.Harjoitus___CRUD_uusi
{
    partial class TietotauluForm
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
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.IDTB = new System.Windows.Forms.TextBox();
            this.TyhjennäBT = new System.Windows.Forms.Button();
            this.IDLB = new System.Windows.Forms.Label();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.PäivitäBT = new System.Windows.Forms.Button();
            this.PoistaBT = new System.Windows.Forms.Button();
            this.EtunimiLB = new System.Windows.Forms.Label();
            this.EtunimiTB = new System.Windows.Forms.TextBox();
            this.SukunimiLB = new System.Windows.Forms.Label();
            this.SukunimiTB = new System.Windows.Forms.TextBox();
            this.OpiskelijanroLB = new System.Windows.Forms.Label();
            this.OpiskelijanroTB = new System.Windows.Forms.TextBox();
            this.SähköpostiLB = new System.Windows.Forms.Label();
            this.SähköpostiTB = new System.Windows.Forms.TextBox();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.PuhelinTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.GridColor = System.Drawing.Color.Honeydew;
            this.TietotauluDG.Location = new System.Drawing.Point(12, 292);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.RowHeadersWidth = 51;
            this.TietotauluDG.RowTemplate.Height = 24;
            this.TietotauluDG.Size = new System.Drawing.Size(1280, 478);
            this.TietotauluDG.TabIndex = 0;
            // 
            // IDTB
            // 
            this.IDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDTB.Location = new System.Drawing.Point(152, 36);
            this.IDTB.Name = "IDTB";
            this.IDTB.Size = new System.Drawing.Size(294, 34);
            this.IDTB.TabIndex = 5;
            // 
            // TyhjennäBT
            // 
            this.TyhjennäBT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TyhjennäBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TyhjennäBT.Location = new System.Drawing.Point(93, 207);
            this.TyhjennäBT.Name = "TyhjennäBT";
            this.TyhjennäBT.Size = new System.Drawing.Size(239, 64);
            this.TyhjennäBT.TabIndex = 7;
            this.TyhjennäBT.Text = "Tyhjennä";
            this.TyhjennäBT.UseVisualStyleBackColor = false;
            this.TyhjennäBT.Click += new System.EventHandler(this.TyhjennäBT_Click);
            // 
            // IDLB
            // 
            this.IDLB.AutoSize = true;
            this.IDLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDLB.Location = new System.Drawing.Point(41, 36);
            this.IDLB.Name = "IDLB";
            this.IDLB.Size = new System.Drawing.Size(48, 36);
            this.IDLB.TabIndex = 11;
            this.IDLB.Text = "ID";
            // 
            // TallennaBT
            // 
            this.TallennaBT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.TallennaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TallennaBT.Location = new System.Drawing.Point(385, 207);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(239, 64);
            this.TallennaBT.TabIndex = 12;
            this.TallennaBT.Text = "Tallenna";
            this.TallennaBT.UseVisualStyleBackColor = false;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // PäivitäBT
            // 
            this.PäivitäBT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PäivitäBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PäivitäBT.Location = new System.Drawing.Point(661, 207);
            this.PäivitäBT.Name = "PäivitäBT";
            this.PäivitäBT.Size = new System.Drawing.Size(239, 64);
            this.PäivitäBT.TabIndex = 13;
            this.PäivitäBT.Text = "Päivitä";
            this.PäivitäBT.UseVisualStyleBackColor = false;
            this.PäivitäBT.Click += new System.EventHandler(this.PäivitäBT_Click);
            // 
            // PoistaBT
            // 
            this.PoistaBT.BackColor = System.Drawing.Color.PaleTurquoise;
            this.PoistaBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PoistaBT.Location = new System.Drawing.Point(949, 207);
            this.PoistaBT.Name = "PoistaBT";
            this.PoistaBT.Size = new System.Drawing.Size(239, 64);
            this.PoistaBT.TabIndex = 14;
            this.PoistaBT.Text = "Poista";
            this.PoistaBT.UseVisualStyleBackColor = false;
            this.PoistaBT.Click += new System.EventHandler(this.PoistaBT_Click);
            // 
            // EtunimiLB
            // 
            this.EtunimiLB.AutoSize = true;
            this.EtunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EtunimiLB.Location = new System.Drawing.Point(41, 93);
            this.EtunimiLB.Name = "EtunimiLB";
            this.EtunimiLB.Size = new System.Drawing.Size(125, 36);
            this.EtunimiLB.TabIndex = 16;
            this.EtunimiLB.Text = "Etunimi";
            // 
            // EtunimiTB
            // 
            this.EtunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EtunimiTB.Location = new System.Drawing.Point(152, 93);
            this.EtunimiTB.Name = "EtunimiTB";
            this.EtunimiTB.Size = new System.Drawing.Size(294, 34);
            this.EtunimiTB.TabIndex = 15;
            // 
            // SukunimiLB
            // 
            this.SukunimiLB.AutoSize = true;
            this.SukunimiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SukunimiLB.Location = new System.Drawing.Point(41, 151);
            this.SukunimiLB.Name = "SukunimiLB";
            this.SukunimiLB.Size = new System.Drawing.Size(150, 36);
            this.SukunimiLB.TabIndex = 18;
            this.SukunimiLB.Text = "Sukunimi";
            // 
            // SukunimiTB
            // 
            this.SukunimiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SukunimiTB.Location = new System.Drawing.Point(152, 151);
            this.SukunimiTB.Name = "SukunimiTB";
            this.SukunimiTB.Size = new System.Drawing.Size(294, 34);
            this.SukunimiTB.TabIndex = 17;
            // 
            // OpiskelijanroLB
            // 
            this.OpiskelijanroLB.AutoSize = true;
            this.OpiskelijanroLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpiskelijanroLB.Location = new System.Drawing.Point(547, 151);
            this.OpiskelijanroLB.Name = "OpiskelijanroLB";
            this.OpiskelijanroLB.Size = new System.Drawing.Size(211, 36);
            this.OpiskelijanroLB.TabIndex = 24;
            this.OpiskelijanroLB.Text = "Opiskelijanro";
            // 
            // OpiskelijanroTB
            // 
            this.OpiskelijanroTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OpiskelijanroTB.Location = new System.Drawing.Point(658, 151);
            this.OpiskelijanroTB.Name = "OpiskelijanroTB";
            this.OpiskelijanroTB.Size = new System.Drawing.Size(294, 34);
            this.OpiskelijanroTB.TabIndex = 23;
            // 
            // SähköpostiLB
            // 
            this.SähköpostiLB.AutoSize = true;
            this.SähköpostiLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SähköpostiLB.Location = new System.Drawing.Point(547, 93);
            this.SähköpostiLB.Name = "SähköpostiLB";
            this.SähköpostiLB.Size = new System.Drawing.Size(179, 36);
            this.SähköpostiLB.TabIndex = 22;
            this.SähköpostiLB.Text = "Sähköposti";
            // 
            // SähköpostiTB
            // 
            this.SähköpostiTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SähköpostiTB.Location = new System.Drawing.Point(658, 93);
            this.SähköpostiTB.Name = "SähköpostiTB";
            this.SähköpostiTB.Size = new System.Drawing.Size(294, 34);
            this.SähköpostiTB.TabIndex = 21;
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PuhelinLB.Location = new System.Drawing.Point(547, 36);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(126, 36);
            this.PuhelinLB.TabIndex = 20;
            this.PuhelinLB.Text = "Puhelin";
            // 
            // PuhelinTB
            // 
            this.PuhelinTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PuhelinTB.Location = new System.Drawing.Point(658, 38);
            this.PuhelinTB.Name = "PuhelinTB";
            this.PuhelinTB.Size = new System.Drawing.Size(294, 34);
            this.PuhelinTB.TabIndex = 19;
            // 
            // TietotauluForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1304, 782);
            this.Controls.Add(this.OpiskelijanroLB);
            this.Controls.Add(this.OpiskelijanroTB);
            this.Controls.Add(this.SähköpostiLB);
            this.Controls.Add(this.SähköpostiTB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PuhelinTB);
            this.Controls.Add(this.SukunimiLB);
            this.Controls.Add(this.SukunimiTB);
            this.Controls.Add(this.EtunimiLB);
            this.Controls.Add(this.EtunimiTB);
            this.Controls.Add(this.PoistaBT);
            this.Controls.Add(this.PäivitäBT);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.IDLB);
            this.Controls.Add(this.TyhjennäBT);
            this.Controls.Add(this.IDTB);
            this.Controls.Add(this.TietotauluDG);
            this.Name = "TietotauluForm";
            this.Text = "Tietotaulu";
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.TextBox IDTB;
        private System.Windows.Forms.Button TyhjennäBT;
        private System.Windows.Forms.Label IDLB;
        private System.Windows.Forms.Button TallennaBT;
        private System.Windows.Forms.Button PäivitäBT;
        private System.Windows.Forms.Button PoistaBT;
        private System.Windows.Forms.Label EtunimiLB;
        private System.Windows.Forms.TextBox EtunimiTB;
        private System.Windows.Forms.Label SukunimiLB;
        private System.Windows.Forms.TextBox SukunimiTB;
        private System.Windows.Forms.Label OpiskelijanroLB;
        private System.Windows.Forms.TextBox OpiskelijanroTB;
        private System.Windows.Forms.Label SähköpostiLB;
        private System.Windows.Forms.TextBox SähköpostiTB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.TextBox PuhelinTB;
    }
}

