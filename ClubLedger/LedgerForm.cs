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
    public partial class LedgerForm : Form
    {
        System.Collections.ArrayList dates;
        System.Collections.ArrayList earned;
        System.Collections.ArrayList lost;
        System.Collections.ArrayList net;

        public LedgerForm()
        {
            dates = new System.Collections.ArrayList();
            earned = new System.Collections.ArrayList();
            lost = new System.Collections.ArrayList();
            net = new System.Collections.ArrayList();

            InitializeComponent();            

            SQLiteConnection c = new SQLiteConnection("Data Source=ledger");
            c.Open();
            SQLiteCommand com = new SQLiteCommand("SELECT * FROM transactions", c);
            SQLiteDataReader r = com.ExecuteReader();
            while (r.Read())
            {
                dates.Add(r["startDate"].ToString());
                earned.Add(r.GetDecimal(5));
                lost.Add(r.GetDecimal(4));
                net.Add(r.GetDecimal(5) - r.GetDecimal(4)); // TODO: Does the order of subtraction matter?... I feel like it doesn't.
            }
            
        }

        private void LedgerForm_Load(object sender, EventArgs e)
        {
            //mainChart.Series["Earned"].Sort(System.Windows.Forms.DataVisualization.Charting.PointSortOrder.Ascending, "X");
            for (int i = 0; i < earned.Count; i++)
            {
                mainChart.Series["Earned"].Points.Add(double.Parse(earned[i].ToString()));
                mainChart.Series["Lost"].Points.Add(double.Parse(lost[i].ToString()));
                mainChart.Series["Net"].Points.Add(double.Parse(net[i].ToString()));
            }
        }

        private void toggleEarned_Click(object sender, EventArgs e)
        {
            mainChart.Series["Earned"].Enabled = !mainChart.Series["Earned"].Enabled;
        }

        private void toggleLost_Click(object sender, EventArgs e)
        {
            mainChart.Series["Lost"].Enabled = !mainChart.Series["Lost"].Enabled;
        }

        private void toggleNet_Click(object sender, EventArgs e)
        {
            mainChart.Series["Net"].Enabled = !mainChart.Series["Net"].Enabled;
        }
    }
}