namespace Hotelliohjelman
{
    partial class ManageClientsForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddNewClient = new System.Windows.Forms.Button();
            this.textBoxCountry = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buttonClearFields);
            this.panel1.Controls.Add(this.buttonRemove);
            this.panel1.Controls.Add(this.buttonEdit);
            this.panel1.Controls.Add(this.buttonAddNewClient);
            this.panel1.Controls.Add(this.textBoxCountry);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxPhone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxLN);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxFN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBoxID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1016, 553);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(491, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(502, 413);
            this.dataGridView1.TabIndex = 15;
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClearFields.Location = new System.Drawing.Point(30, 469);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(440, 42);
            this.buttonClearFields.TabIndex = 14;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemove.Location = new System.Drawing.Point(358, 399);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(112, 42);
            this.buttonRemove.TabIndex = 13;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(228, 399);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(112, 42);
            this.buttonEdit.TabIndex = 12;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddNewClient
            // 
            this.buttonAddNewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNewClient.Location = new System.Drawing.Point(30, 399);
            this.buttonAddNewClient.Name = "buttonAddNewClient";
            this.buttonAddNewClient.Size = new System.Drawing.Size(179, 42);
            this.buttonAddNewClient.TabIndex = 11;
            this.buttonAddNewClient.Text = "Add New Client";
            this.buttonAddNewClient.UseVisualStyleBackColor = true;
            this.buttonAddNewClient.Click += new System.EventHandler(this.buttonAddNewClient_Click);
            // 
            // textBoxCountry
            // 
            this.textBoxCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxCountry.Location = new System.Drawing.Point(160, 343);
            this.textBoxCountry.Name = "textBoxCountry";
            this.textBoxCountry.Size = new System.Drawing.Size(310, 34);
            this.textBoxCountry.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(45, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 29);
            this.label6.TabIndex = 9;
            this.label6.Text = "Country:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhone.Location = new System.Drawing.Point(160, 290);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(310, 34);
            this.textBoxPhone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(57, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Phone:";
            // 
            // textBoxLN
            // 
            this.textBoxLN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLN.Location = new System.Drawing.Point(160, 237);
            this.textBoxLN.Name = "textBoxLN";
            this.textBoxLN.Size = new System.Drawing.Size(310, 34);
            this.textBoxLN.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(21, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // textBoxFN
            // 
            this.textBoxFN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFN.Location = new System.Drawing.Point(160, 184);
            this.textBoxFN.Name = "textBoxFN";
            this.textBoxFN.Size = new System.Drawing.Size(310, 34);
            this.textBoxFN.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // textBoxID
            // 
            this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxID.Location = new System.Drawing.Point(160, 131);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(107, 34);
            this.textBoxID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(112, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrchid;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1016, 92);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(328, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage clients";
            // 
            // ManageClientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 553);
            this.Controls.Add(this.panel1);
            this.Name = "ManageClientsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageClientsForm";
            this.Load += new System.EventHandler(this.ManageClientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCountry;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAddNewClient;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}