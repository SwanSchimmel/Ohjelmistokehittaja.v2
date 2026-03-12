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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClientsForm ManageClientsForm = new ManageClientsForm();

            ManageClientsForm.ShowDialog();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRoomsForm ManageRoomsForm = new ManageRoomsForm();

            ManageRoomsForm.ShowDialog();
        }

        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)

        {

            ManageReservationsForm ManageReservationsForm = new ManageReservationsForm();

            ManageReservationsForm.ShowDialog();

        }
    }
}
