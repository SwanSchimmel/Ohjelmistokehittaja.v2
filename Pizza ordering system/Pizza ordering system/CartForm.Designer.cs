namespace Pizza_ordering_system
{
    partial class CartForm
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
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.listViewCart = new System.Windows.Forms.ListView();
            this.columnPizza = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnToppings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // buttonRemove
            // 
            this.buttonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonRemove.Location = new System.Drawing.Point(144, 355);
            this.buttonRemove.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(192, 94);
            this.buttonRemove.TabIndex = 0;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = false;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonCheckout.Location = new System.Drawing.Point(502, 355);
            this.buttonCheckout.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(173, 94);
            this.buttonCheckout.TabIndex = 1;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = false;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // listViewCart
            // 
            this.listViewCart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnPizza,
            this.columnSize,
            this.columnQty,
            this.columnToppings,
            this.columnPrice});
            this.listViewCart.FullRowSelect = true;
            this.listViewCart.GridLines = true;
            this.listViewCart.HideSelection = false;
            this.listViewCart.Location = new System.Drawing.Point(11, 11);
            this.listViewCart.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCart.Name = "listViewCart";
            this.listViewCart.Size = new System.Drawing.Size(805, 328);
            this.listViewCart.TabIndex = 15;
            this.listViewCart.UseCompatibleStateImageBehavior = false;
            this.listViewCart.View = System.Windows.Forms.View.Details;
            this.columnPizza.Text = "Пицца";
            this.columnPizza.Width = 220;
            this.columnSize.Text = "Размер";
            this.columnSize.Width = 120;
            this.columnQty.Text = "Кол-во";
            this.columnQty.Width = 80;
            this.columnToppings.Text = "Добавки";
            this.columnToppings.Width = 240;
            this.columnPrice.Text = "Цена";
            this.columnPrice.Width = 100;
            // 
            // CartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1036, 578);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.listViewCart);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CartForm";
            this.Text = "CartForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.ListView listViewCart;
        private System.Windows.Forms.ColumnHeader columnPizza;
        private System.Windows.Forms.ColumnHeader columnSize;
        private System.Windows.Forms.ColumnHeader columnQty;
        private System.Windows.Forms.ColumnHeader columnToppings;
        private System.Windows.Forms.ColumnHeader columnPrice;
    }
}