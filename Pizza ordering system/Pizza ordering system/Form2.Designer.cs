namespace Pizza_ordering_system
{
    partial class Form2
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
            this.comboBoxPizza = new System.Windows.Forms.ComboBox();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.checkedListBoxToppings = new System.Windows.Forms.CheckedListBox();
            this.numericUpDownQty = new System.Windows.Forms.NumericUpDown();
            this.buttonAddToCart = new System.Windows.Forms.Button();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPizza
            // 
            this.comboBoxPizza.FormattingEnabled = true;
            this.comboBoxPizza.Items.AddRange(new object[] {
            "Pepperoni",
            "Hawaii",
            "Chicken"});
            this.comboBoxPizza.Location = new System.Drawing.Point(349, 116);
            this.comboBoxPizza.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxPizza.Name = "comboBoxPizza";
            this.comboBoxPizza.Size = new System.Drawing.Size(333, 43);
            this.comboBoxPizza.TabIndex = 0;
            this.comboBoxPizza.Text = "Pizza Type";
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(347, 195);
            this.comboBoxSize.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(335, 43);
            this.comboBoxSize.TabIndex = 1;
            this.comboBoxSize.Text = "Pizzas Size";
            // 
            // checkedListBoxToppings
            // 
            this.checkedListBoxToppings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.checkedListBoxToppings.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBoxToppings.FormattingEnabled = true;
            this.checkedListBoxToppings.Items.AddRange(new object[] {
            "Extra Cheese",
            "Mushrooms",
            "Olives"});
            this.checkedListBoxToppings.Location = new System.Drawing.Point(347, 357);
            this.checkedListBoxToppings.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.checkedListBoxToppings.Name = "checkedListBoxToppings";
            this.checkedListBoxToppings.Size = new System.Drawing.Size(335, 114);
            this.checkedListBoxToppings.TabIndex = 2;
            // 
            // numericUpDownQty
            // 
            this.numericUpDownQty.Location = new System.Drawing.Point(347, 285);
            this.numericUpDownQty.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.numericUpDownQty.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQty.Name = "numericUpDownQty";
            this.numericUpDownQty.Size = new System.Drawing.Size(335, 43);
            this.numericUpDownQty.TabIndex = 3;
            this.numericUpDownQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownQty.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonAddToCart
            // 
            this.buttonAddToCart.Location = new System.Drawing.Point(347, 509);
            this.buttonAddToCart.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonAddToCart.Name = "buttonAddToCart";
            this.buttonAddToCart.Size = new System.Drawing.Size(335, 107);
            this.buttonAddToCart.TabIndex = 4;
            this.buttonAddToCart.Text = "Add To Cart";
            this.buttonAddToCart.UseVisualStyleBackColor = true;
            this.buttonAddToCart.Click += new System.EventHandler(this.buttonAddToCart_Click);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPrice.Location = new System.Drawing.Point(442, 38);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(123, 48);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Menu";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 35F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1021, 726);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.buttonAddToCart);
            this.Controls.Add(this.numericUpDownQty);
            this.Controls.Add(this.checkedListBoxToppings);
            this.Controls.Add(this.comboBoxSize);
            this.Controls.Add(this.comboBoxPizza);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form2";
            this.Text = "Select Your Pizza Now!";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPizza;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.CheckedListBox checkedListBoxToppings;
        private System.Windows.Forms.NumericUpDown numericUpDownQty;
        private System.Windows.Forms.Button buttonAddToCart;
        private System.Windows.Forms.Label labelPrice;
    }
}