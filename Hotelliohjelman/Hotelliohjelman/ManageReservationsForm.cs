using System;
using System.Data;
using System.Windows.Forms;

namespace Hotelliohjelman
{
    public partial class ManageReservationsForm : Form
    {
        RESERVATION reservation = new RESERVATION();
        Room room = new Room();

        public ManageReservationsForm()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            // Привязка comboBoxRoomNumber к номерам комнат
            comboBoxRoomNumber.DataSource = room.GetRooms();
            comboBoxRoomNumber.DisplayMember = "number"; // название столбца с номером
            comboBoxRoomNumber.ValueMember = "number";

            // Загрузка всех бронирований
            dataGridView1.DataSource = reservation.GetAllReservations();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxReservID.Clear();
            textBoxClientID.Clear();
            comboBoxRoomNumber.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
        }

        private void buttonAddNewReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePicker1.Value.Date;
                DateTime dateOut = dateTimePicker2.Value.Date;

                // Проверки дат
                if (dateIn < DateTime.Now.Date)
                {
                    MessageBox.Show("Date In must be today or later", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dateOut < dateIn)
                {
                    MessageBox.Show("Date Out must be after Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Добавление бронирования
                if (reservation.AddReservation(roomNumber, clientID, dateIn, dateOut))
                {
                    room.SetRoomFree(roomNumber, "No"); // ставим комнату занятой
                    dataGridView1.DataSource = reservation.GetAllReservations();
                    MessageBox.Show("Reservation added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation NOT added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int reservID = Convert.ToInt32(textBoxReservID.Text);
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePicker1.Value.Date;
                DateTime dateOut = dateTimePicker2.Value.Date;

                // Проверки дат
                if (dateIn < DateTime.Now.Date)
                {
                    MessageBox.Show("Date In must be today or later", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dateOut < dateIn)
                {
                    MessageBox.Show("Date Out must be after Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (reservation.EditReservation(reservID, roomNumber, clientID, dateIn, dateOut))
                {
                    room.SetRoomFree(roomNumber, "No"); // ставим комнату занятой
                    dataGridView1.DataSource = reservation.GetAllReservations();
                    MessageBox.Show("Reservation updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation NOT updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Edit Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int reservID = Convert.ToInt32(textBoxReservID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);

                if (reservation.RemoveReservation(reservID))
                {
                    room.SetRoomFree(roomNumber, "Yes"); // освобождаем комнату
                    dataGridView1.DataSource = reservation.GetAllReservations();
                    MessageBox.Show("Reservation deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation NOT deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}