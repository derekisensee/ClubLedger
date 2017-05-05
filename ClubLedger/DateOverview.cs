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
            SQLiteConnection c = new SQLiteConnection("Data Source=ledger");
            c.Open();
            InitializeComponent();
            try
            {
                SQLiteCommand com = new SQLiteCommand("SELECT * FROM transactions", c);
                SQLiteDataReader r = com.ExecuteReader();

                InitializeComponent();
                while (r.Read())
                {
                    label1.Text += r["type"].ToString();
                }
            }
            catch (Exception e)
            {
                label1.Text = "ERROR!!!!!!!!" + e.ToString();
            }

            //label1.Text = startDate + " " + endDate;
            //label1.Text += c.ToString();
        }
    }
}