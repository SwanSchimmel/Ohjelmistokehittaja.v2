using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Hotelliohjelman
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

     



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Assume grid columns: 0 = number, 1 = type, 2 = phone
            textBoxRoomN.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value;
            // phone is expected in column 2
            textBoxPhoneRCL.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
        }

    

        Room room = new Room();

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";
            // load existing rooms into the grid on form load
            dataGridView2.DataSource = room.addRoom();
        }

        private void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            
            object selType = comboBoxRoomType.SelectedValue;
            int type = selType == null ? 0 : Convert.ToInt32(selType);
            string phone = textBoxPhoneRCL.Text;
            string free = "";

            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (YesradioButton.Checked)
                {
                    free = "Yes";
                }
                else if (NoradioButton.Checked)
                {
                    free = "No";
                }

                if (room.buttonAddNewRoom(number, type, phone, free))
                {
                    dataGridView2.DataSource = room.addRoom();
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            object selType2 = comboBoxRoomType.SelectedValue;
            int type = selType2 == null ? 0 : Convert.ToInt32(selType2);
            String phone = textBoxPhoneRCL.Text;
            String free = "";

            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (YesradioButton.Checked)
                {
                    free = "Yes";
                }
                else if (NoradioButton.Checked)
                {
                    free = "No";
                }

                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView2.DataSource = room.addRoom();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (room.removeRoom(number))
                {
                    dataGridView2.DataSource = room.addRoom();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
