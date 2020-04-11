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
    public partial class ManageReservationForm : Form
    {
        Reservation rsv = new Reservation();

        public ManageReservationForm()
        {
            InitializeComponent();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxId.ReadOnly = false;
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            comboBoxRoom.Text = "";
            dateTimeCheckin.Text = DateTime.Now.ToString();
            dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
            radioButtonBooked.Checked = false;
            radioButtonFinished.Checked = false;
            textBoxDeposit.Text = "";
            textBoxPrice.Text = "";
        }

        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rsv.getRsv();
            dateTimeCheckin.Text = DateTime.Now.ToString();
            dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            String id = textBoxId.Text;
            String name = textBoxName.Text;
            String phone = textBoxPhone.Text;
            String address = textBoxAddress.Text;
            String room = comboBoxRoom.Text;
            String oldroom = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DateTime checkin = dateTimeCheckin.Value;
            DateTime checkout = dateTimeCheckout.Value;
            String deposit = textBoxDeposit.Text;
            String price = textBoxPrice.Text;
            String status = "";
            if (radioButtonBooked.Checked == true)
            {
                status = "booked";
                price = "0";
            }
            else if (radioButtonFinished.Checked == true)
            {
                status = "finished";
                price = (Convert.ToInt32((checkout - checkin).TotalDays) * 500000).ToString();
            }

            if (id.Trim().Equals("") || name.Trim().Equals("") || phone.Trim().Equals("") || address.Trim().Equals("") || room.Trim().Equals("") || deposit.Trim().Equals("") || status.Trim().Equals(""))
            {
                MessageBox.Show("Please Select Or Search Reservation Data ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                comboBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                radioButtonBooked.Checked = false;
                radioButtonFinished.Checked = false;
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            else
            {
                Int32 rid = Convert.ToInt32(id);
                Int32 rdeposit = Convert.ToInt32(deposit);
                Int32 rprice = Convert.ToInt32(price);
                Boolean errorRoom = false;

                if ((oldroom != room) && dataGridView1.CurrentRow.Cells[9].Value.ToString() == "finished")
                {
                    MessageBox.Show("Can Not Change Room For Finished Reservation", "Room Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    errorRoom = true;
                }
                else if (oldroom != room)
                {
                    Boolean clearRoom = rsv.clearRoom(oldroom);
                    Boolean addRoom = rsv.addRoom(rid, room);

                    if (!clearRoom || !addRoom)
                    {
                        MessageBox.Show("Change Room Failed", "Room Change", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorRoom = true;
                    }
                }

                if (!errorRoom)
                {
                    Boolean updateRsv = rsv.updateRsv(rid, name, phone, address, room, checkin, checkout, rdeposit, rprice, status);

                    if (updateRsv)
                    {
                        dataGridView1.DataSource = rsv.getRsv();
                        MessageBox.Show("Reservation Updated Successfully", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Reservation Not Updated", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // memilih data reservasi dari data grid view
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxId.ReadOnly = true;
            textBoxName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxPhone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBoxAddress.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxRoom.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dateTimeCheckin.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[5].Value.ToString());
            dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            dateTimeCheckout.Value = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[6].Value.ToString());
            String status = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            if (status == "booked")
            {
                radioButtonBooked.Checked = true;
            }
            else if (status == "finished")
            {
                radioButtonFinished.Checked = true;
            }
            textBoxDeposit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBoxPrice.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void dateTimeCheckin_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonFinished.Checked == true)
            {
                textBoxPrice.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
            }
        }

        private void dateTimeCheckout_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonFinished.Checked == true)
            {
                textBoxPrice.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
            }
        }

        private void radioButtonBooked_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = "";
        }

        private void radioButtonFinished_CheckedChanged(object sender, EventArgs e)
        {

            textBoxPrice.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            String id = textBoxId.Text;
            if (id.Trim().Equals(""))
            {
                MessageBox.Show("Please Insert Reservation Data ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                comboBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                radioButtonBooked.Checked = false;
                radioButtonFinished.Checked = false;
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            else if (rsv.checkRsv(Convert.ToInt32(id)))
            {
                MessageBox.Show("This Reservation ID Is Not Found", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                comboBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                radioButtonBooked.Checked = false;
                radioButtonFinished.Checked = false;
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            else
            {
                Int32 rid = Convert.ToInt32(id);
                dataGridView1.DataSource = rsv.getRsvId(rid);
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                comboBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                radioButtonBooked.Checked = false;
                radioButtonFinished.Checked = false;
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rsv.getRsv();
            textBoxId.Text = "";
            textBoxId.ReadOnly = false;
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            comboBoxRoom.Text = "";
            dateTimeCheckin.Text = DateTime.Now.ToString();
            dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
            radioButtonBooked.Checked = false;
            radioButtonFinished.Checked = false;
            textBoxDeposit.Text = "";
            textBoxPrice.Text = "";
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells[9].Value.ToString() == "booked")
            {
                MessageBox.Show("Reservation Must Finished First", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Boolean deleteRsv = rsv.deleteRsv(Convert.ToInt32(textBoxId.Text));

                if (deleteRsv)
                {
                    dataGridView1.DataSource = rsv.getRsv();
                    textBoxId.Text = "";
                    textBoxId.ReadOnly = false;
                    textBoxName.Text = "";
                    textBoxPhone.Text = "";
                    textBoxAddress.Text = "";
                    comboBoxRoom.Text = "";
                    dateTimeCheckin.Text = DateTime.Now.ToString();
                    dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
                    dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                    radioButtonBooked.Checked = false;
                    radioButtonFinished.Checked = false;
                    textBoxDeposit.Text = "";
                    textBoxPrice.Text = "";
                    MessageBox.Show("Reservation Deleted Successfully", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Reservation Not Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBooked_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rsv.getbookedRsv();
        }

        private void buttonFinished_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rsv.getfinishedRsv();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintReport frm2 = new PrintReport();
            frm2.ShowDialog();
        }
    }
}

// DONE