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

            data.Text = "";
            try
            {
                if (startDate.Equals(endDate))
                {
                    SQLiteCommand com = new SQLiteCommand("SELECT * FROM transactions WHERE date ='" + startDate + "'", c);
                    SQLiteDataReader r = com.ExecuteReader();

                    while (r.Read())
                    {
                        data.Text += r["type"].ToString();
                        DateTime day = (DateTime)r["date"];
                        data.Text += day.ToShortDateString();
                        data.Text += "-" + r["spent"].ToString();
                        data.Text += "+" + r["earned"].ToString();
                        data.Text += r["notes"].ToString();
                    }
                }
                else
                {
                    SQLiteCommand com = new SQLiteCommand("SELECT * FROM transactions WHERE date >='" + startDate + "' AND date <= '" + endDate + "'", c);
                    SQLiteDataReader r = com.ExecuteReader();

                    while (r.Read())
                    {
                        headers.Text += r["type"].ToString();
                    }
                }
            }
            catch (SQLiteException e)
            {
                headers.Text = "ERROR!!!!!!!!" + e.ToString();
            }
        }
    }
}