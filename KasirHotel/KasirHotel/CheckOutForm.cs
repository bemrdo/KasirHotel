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
    public partial class CheckOutForm : Form
    {
        Reservation rsv = new Reservation();

        public CheckOutForm()
        {
            InitializeComponent();
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
                textBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = DateTime.Today.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
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
                textBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = DateTime.Today.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            else if (rsv.getRsvId(Convert.ToInt32(id)).Rows[0]["status"].ToString() == "finished")
            {
                MessageBox.Show("This Reservation ID Already Checked Out", "Reservation Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                textBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = DateTime.Today.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            else
            {
                Int32 rid = Convert.ToInt32(id);
                textBoxName.Text = rsv.getRsvId(rid).Rows[0]["name"].ToString();
                textBoxPhone.Text = rsv.getRsvId(rid).Rows[0]["phone"].ToString();
                textBoxRoom.Text = rsv.getRsvId(rid).Rows[0]["room"].ToString();
                textBoxAddress.Text = rsv.getRsvId(rid).Rows[0]["address"].ToString();
                dateTimeCheckin.Text = rsv.getRsvId(rid).Rows[0]["checkin"].ToString();
                dateTimeCheckout.Text = rsv.getRsvId(rid).Rows[0]["checkout"].ToString();
                textBoxDeposit.Text = rsv.getRsvId(rid).Rows[0]["deposit"].ToString();
                textBoxPrice.Text = (Convert.ToInt32((Convert.ToDateTime(rsv.getRsvId(rid).Rows[0]["checkout"]) - Convert.ToDateTime(rsv.getRsvId(rid).Rows[0]["checkin"])).TotalDays) * 500000).ToString();
                textBoxId.ReadOnly = true;
                dateTimeCheckout.MinDate = dateTimeCheckin.Value.AddDays(1);
            }
        }

        private void dateTimeCheckout_ValueChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
        }

        private void dateTimeCheckin_ValueChanged(object sender, EventArgs e)
        {
            textBoxPrice.Text = (Convert.ToInt32((dateTimeCheckout.Value - dateTimeCheckin.Value).TotalDays) * 500000).ToString();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String id = textBoxId.Text;
            String name = textBoxName.Text;
            String phone = textBoxPhone.Text;
            String address = textBoxAddress.Text;
            String room = textBoxRoom.Text;
            DateTime checkin = dateTimeCheckin.Value;
            DateTime checkout = dateTimeCheckout.Value;
            String deposit = textBoxDeposit.Text;
            String price = textBoxPrice.Text;
            String status = "finished";

            if (id.Trim().Equals("") || name.Trim().Equals("") || phone.Trim().Equals("") || address.Trim().Equals("") || room.Trim().Equals("") || deposit.Trim().Equals("") || status.Trim().Equals(""))
            {
                MessageBox.Show("Please Select Or Search Reservation Data ID", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxId.Text = "";
                textBoxName.Text = "";
                textBoxPhone.Text = "";
                textBoxAddress.Text = "";
                textBoxRoom.Text = "";
                dateTimeCheckin.Text = DateTime.Now.ToString();
                dateTimeCheckout.MinDate = DateTime.Today.AddDays(1);
                dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
                textBoxDeposit.Text = "";
                textBoxPrice.Text = "";
            }
            // if else (Int32.Parse(room.Text) > 20)
            else
            {
                Int32 rid = Convert.ToInt32(id);
                Int32 rdeposit = Convert.ToInt32(deposit);
                Int32 rprice = Convert.ToInt32(price);

                Boolean updateRsv = rsv.updateRsv(rid, name, phone, address, room, checkin, checkout, rdeposit, rprice, status);
                Boolean clearRoom = rsv.clearRoom(room);

                if (updateRsv && clearRoom)
                {
                    MessageBox.Show("Reservation Check Out Successfully", "Check Out Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (!clearRoom)
                {
                    MessageBox.Show("Reservation ID And Room Does Not Relate", "Room Clearing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("ERROR - Reservation Check Out Not Updated", "Check Out Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxPhone.Text = "";
            textBoxAddress.Text = "";
            textBoxRoom.Text = "";
            dateTimeCheckin.Text = DateTime.Now.ToString();
            dateTimeCheckout.MinDate = DateTime.Today.AddDays(1);
            dateTimeCheckout.Text = DateTime.Now.AddDays(1).ToString();
            textBoxDeposit.Text = "";
            textBoxPrice.Text = "";
            textBoxId.ReadOnly = false;
        }
    }
}

// DONE