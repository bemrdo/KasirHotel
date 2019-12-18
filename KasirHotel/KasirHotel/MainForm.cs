using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KasirHotel
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

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // tampilkan login form
            this.Hide();
            LoginForm lForm = new LoginForm();
            lForm.Show();
        }

        private void cHECKINToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckInForm checkinForm = new CheckInForm();
            checkinForm.ShowDialog();
        }

        private void cHECKOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckOutForm checkoutForm = new CheckOutForm();
            checkoutForm.ShowDialog();
        }

        private void mANAGERESERVATIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservationForm manresForm = new ManageReservationForm();
            manresForm.ShowDialog();
        }
    }
}
