using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace ClubLedger
{
    public partial class DateOverview : Form
    {
        private string insertTransactions = "INSERT INTO transaction(type, date, spent, earned, notes) VALUES (?, ?, ?, ?, ?)";

        public DateOverview(string startDate, string endDate)
        {
            InitializeComponent();
            label1.Text = startDate + " " + endDate;
        }
    }
}