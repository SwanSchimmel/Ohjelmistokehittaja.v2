namespace Pizza_ordering_system
{
    partial class PaymentForm
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
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.buttonPay = new System.Windows.Forms.Button();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(172, 89);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(322, 43);
            this.textBoxFirstName.TabIndex = 0;
            this.textBoxFirstName.Text = "First Name";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(172, 162);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(322, 43);
            this.textBoxLastName.TabIndex = 1;
            this.textBoxLastName.Text = "Last Name";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Card",
            "Cash"});
            this.comboBoxPayment.Location = new System.Drawing.Point(172, 330);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(322, 43);
            this.comboBoxPayment.TabIndex = 2;
            // 
            // buttonPay
            // 
            this.buttonPay.Location = new System.Drawing.Point(172, 415);
            this.buttonPay.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonPay.Name = "buttonPay";
            this.buttonPay.Size = new System.Drawing.Size(322, 168);
            this.buttonPay.TabIndex = 3;
            this.buttonPay.Text = "Pay for my pizza";
            this.buttonPay.UseVisualStyleBackColor = true;
            this.buttonPay.Click += new System.EventHandler(this.buttonPay_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(172, 240);
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(322, 43);
            this.textBoxAddress.TabIndex = 4;
            this.textBoxAddress.Text = "Address";
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 706);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.buttonPay);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PaymentForm";
            this.Text = "Payment Method ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Button buttonPay;
        private System.Windows.Forms.TextBox textBoxAddress;
    }
}