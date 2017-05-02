using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubLedger
{
    public partial class MainForm : Form
    {
        private string singleSelectedDate;
        public MainForm()
        {
            InitializeComponent();
            singleSelectedDate = monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void LedgerButton_Click(object sender, EventArgs e)
        {
            DateOverview LF = new DateOverview(singleSelectedDate);
            LF.Show();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            SelectionRange s = monthCalendar1.SelectionRange;
            string startDate = s.ToString();
            string[] splitDate = startDate.Split(' ');

            startDate = splitDate[2];
            string endDate = splitDate[6];
            if (startDate.Equals(endDate))
            {
                singleSelectedDate = startDate;
            }
        }

        private void LedgerButton_Click_1(object sender, EventArgs e)
        {
            LedgerForm LF = new LedgerForm();
            LF.Show();
        }
    }
}