using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace KasirHotel
{
    public partial class PrintSelection : Form
    {
        public PrintSelection()
        {
            InitializeComponent();
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            ReportDocument myDataReport = new ReportDocument();
            myDataReport.Load(@"C:\Users\bemrdo\Desktop\KasirHotel-master\KasirHotel\KasirHotel\report.rpt");
            myDataReport.SetParameterValue("Awal", dateTimeStart.Value.ToString());
            myDataReport.SetParameterValue("Akhir", dateTimeStart.Value.ToString());
            PrintReport frm2 = new PrintReport();
            frm2.Show();
        }
    }
}