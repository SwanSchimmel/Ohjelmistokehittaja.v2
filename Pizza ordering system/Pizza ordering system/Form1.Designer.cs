namespace Pizza_ordering_system
{
    partial class Form1
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
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonCart = new System.Windows.Forms.Button();
            this.buttonPayment = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.ForeColor = System.Drawing.SystemColors.MenuText;
            this.buttonMenu.Location = new System.Drawing.Point(216, 158);
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(143, 58);
            this.buttonMenu.TabIndex = 0;
            this.buttonMenu.Text = "MENU ";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // buttonCart
            // 
            this.buttonCart.Location = new System.Drawing.Point(428, 158);
            this.buttonCart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCart.Name = "buttonCart";
            this.buttonCart.Size = new System.Drawing.Size(151, 58);
            this.buttonCart.TabIndex = 1;
            this.buttonCart.Text = "CART ";
            this.buttonCart.UseVisualStyleBackColor = true;
            this.buttonCart.Click += new System.EventHandler(this.buttonCart_Click);
            // 
            // buttonPayment
            // 
            this.buttonPayment.Location = new System.Drawing.Point(216, 294);
            this.buttonPayment.Margin = new System.Windows.Forms.Padding(5);
            this.buttonPayment.Name = "buttonPayment";
            this.buttonPayment.Size = new System.Drawing.Size(143, 55);
            this.buttonPayment.TabIndex = 2;
            this.buttonPayment.Text = "PAYMENT ";
            this.buttonPayment.UseVisualStyleBackColor = true;
            this.buttonPayment.Click += new System.EventHandler(this.buttonPayment_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonExit.Location = new System.Drawing.Point(428, 294);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(5);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(151, 55);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.Text = "EXIT ";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft YaHei", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(291, 52);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(223, 36);
            this.labelTitle.TabIndex = 4;
            this.labelTitle.Text = "Make an order:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(793, 537);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonPayment);
            this.Controls.Add(this.buttonCart);
            this.Controls.Add(this.buttonMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "POS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonCart;
        private System.Windows.Forms.Button buttonPayment;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelTitle;
    }
}

