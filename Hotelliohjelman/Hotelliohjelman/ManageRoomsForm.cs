using System;
using System.Data;
using System.Windows.Forms;

namespace Hotelliohjelman
{
    public partial class ManageRoomsForm : Form
    {
        Room room = new Room();

        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        // LOAD FORM
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            // Загрузка типов комнат
            comboBoxRoomType.DataSource = room.GetRoomTypes();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            // Загрузка комнат
            dataGridView2.DataSource = room.GetRooms();
        }

        // CLICK ON GRID
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.CurrentRow != null)
            {
                textBoxRoomN.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                comboBoxRoomType.SelectedValue = dataGridView2.CurrentRow.Cells[1].Value;
                textBoxPhoneRCL.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();

                string free = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                if (free == "Yes")
                    YesradioButton.Checked = true;
                else
                    NoradioButton.Checked = true;
            }
        }

        // ADD ROOM
        private void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number");
                    return;
                }

                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue);
                string phone = textBoxPhoneRCL.Text;
                string free = YesradioButton.Checked ? "Yes" : "No";

                if (room.AddRoom(number, type, phone, free))
                {
                    dataGridView2.DataSource = room.GetRooms();
                    MessageBox.Show("Room Added");
                }
                else
                {
                    MessageBox.Show("Error adding room");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // EDIT ROOM
        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number");
                    return;
                }

                int type = Convert.ToInt32(comboBoxRoomType.SelectedValue);
                string phone = textBoxPhoneRCL.Text;
                string free = YesradioButton.Checked ? "Yes" : "No";

                if (room.EditRoom(number, type, phone, free))
                {
                    dataGridView2.DataSource = room.GetRooms();
                    MessageBox.Show("Room Updated");
                }
                else
                {
                    MessageBox.Show("Error updating room");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE ROOM
        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                if (!int.TryParse(textBoxRoomN.Text, out int number))
                {
                    MessageBox.Show("Invalid room number");
                    return;
                }

                if (room.RemoveRoom(number))
                {
                    dataGridView2.DataSource = room.GetRooms();
                    MessageBox.Show("Room Deleted");
                }
                else
                {
                    MessageBox.Show("Error deleting room");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // CLEAR FIELDS
        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxRoomN.Clear();
            textBoxPhoneRCL.Clear();
            comboBoxRoomType.SelectedIndex = 0;
            YesradioButton.Checked = true;
        }
    }
}