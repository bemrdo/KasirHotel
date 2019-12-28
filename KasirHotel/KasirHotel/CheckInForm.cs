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
    public partial class CheckInForm : Form
    {
        Reservation rsv = new Reservation();

        public CheckInForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            comboBoxRoom.Items.Clear();
            dateTimeCheckin.Text = DateTime.Now.ToString();
            dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String phone = textBoxPhone.Text;
            String address = textBoxAddress.Text;
            String room = comboBoxRoom.Text;
            DateTime checkin = dateTimeCheckin.Value;
            DateTime checkout = dateTimeCheckout.Value;
            Int32 deposit = Int32.Parse(labelDeposit.Text);

            if (name.Trim().Equals("") || phone.Trim().Equals("") || address.Trim().Equals("") || room.Trim().Equals(""))
            {
                MessageBox.Show("Required Fields - Don't Left Any Field(s) Blank", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean insertRsv = rsv.insertRsv(name, phone, address, room, checkin, checkout, deposit);
                Boolean addRoom = rsv.addRoom(rsv.chekId(), room);

                if (insertRsv && addRoom)
                {
                    MessageBox.Show("New Reservation Added Successfully", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    comboBoxRoom.Items.Clear();
                    dateTimeCheckin.Text = DateTime.Now.ToString();
                    dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                }
                else if (!addRoom)
                {
                    MessageBox.Show("Room Does Not Available", "Check Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR - Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CheckInForm_Shown(object sender, EventArgs e)
        {
            Int32 checkRoom = rsv.checkRoom();
            if (checkRoom == 0)
            {
                MessageBox.Show("All Rooms Were Booked", "Room Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Hide();
                ManageReservationForm manresForm = new ManageReservationForm();
                manresForm.ShowDialog();
            }
        }

        private void dateTimeCheckout_ValueChanged(object sender, EventArgs e)
        {
            labelDeposit.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
        }

        private void dateTimeCheckin_ValueChanged(object sender, EventArgs e)
        {
            labelDeposit.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
            dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            dateTimeCheckout.Value = dateTimeCheckin.Value.AddDays(1);
        }

        private void comboBoxRoom_Click(object sender, EventArgs e)
        {
            comboBoxRoom.Items.Clear();
            var count = rsv.checkRoom();
            for (int i = 0; i < count; i++)
            {
                comboBoxRoom.Items.Add(rsv.emptykRoom().Rows[i]["room"].ToString());
            }
        }

        private void CheckInForm_Load(object sender, EventArgs e)
        {
            dateTimeCheckin.MinDate = DateTime.Now;
            dateTimeCheckout.MinDate = DateTime.Now.AddDays(1);
        }
    }
}

// DONE