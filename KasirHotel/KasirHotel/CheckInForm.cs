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
            textBoxRoom.Text = "";
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            String name = textBoxName.Text;
            String phone = textBoxPhone.Text;
            String address = textBoxAddress.Text;
            String room = textBoxRoom.Text;
            date
            Boolean insertRsv = rsv.insertRsv("","","","","","","");
        }
    }
}
