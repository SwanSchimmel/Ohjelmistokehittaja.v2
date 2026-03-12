using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelliohjelman
{
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();

        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            {
                String fname = textBoxFN.Text;
                String lname = textBoxLN.Text;
                String phone = textBoxPhone.Text;
                String country = textBoxCountry.Text;

                if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields - First & Last Name + Phone Number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Boolean insertClient = client.insertClient(fname, lname, phone, country);

                    if (insertClient)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("New Client Inserted Successfuly", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }


        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxID.Text = "";
            textBoxFN.Text = "";
            textBoxLN.Text = "";
            textBoxPhone.Text = "";
            textBoxCountry.Text = "";
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            {
                int id;
                String fname = textBoxFN.Text;
                String lname = textBoxLN.Text;
                String phone = textBoxPhone.Text;
                String country = textBoxCountry.Text;

                try
                {
                    id = Convert.ToInt32(textBoxID.Text);

                    if (fname.Trim().Equals("") || lname.Trim().Equals("") || phone.Trim().Equals(""))
                    {
                        MessageBox.Show("Required Fields - First & Last Name + Phone Number", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Boolean insertClient = client.editClient(id, fname, lname, phone, country);

                        if (insertClient)
                        {
                            dataGridView1.DataSource = client.getClients();
                            MessageBox.Show("New Client Updated Successfuly", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR - Client Not Updated", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    int id = Convert.ToInt32(textBoxID.Text);

                    if (client.removeClient(id))
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("Client Deleted Successfuly", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        // you can clear all textboxes after the delete if you want
                        // by calling the clear button
                        buttonClearFields.PerformClick();

                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }
    }
}
