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
    public partial class NewEntryForm : Form
    {
        public NewEntryForm()
        {
            InitializeComponent();
        }

        private void insertDataButton_Click(object sender, EventArgs e)
        {
            string selectedStartDate = dateTimePicker.Value.ToShortDateString();
            string selectedEndDate = endDateTimePicker.Value.ToShortDateString();

            string[] splittedStartDate = selectedStartDate.Split('/');
            string[] splittedEndDate = selectedEndDate.Split('/');
            //HACK: Multiple dirty if-statements
            if (splittedStartDate[0].Length == 1 && splittedStartDate[1].Length == 1)
            {
                selectedStartDate = splittedStartDate[2] + "-" + "0" + splittedStartDate[0] + "-" + "0" + splittedStartDate[1];
            }
            else if (splittedStartDate[0].Length == 1)
            {
                selectedStartDate = splittedStartDate[2] + "-" + "0" + splittedStartDate[0] + "-" + splittedStartDate[1];
            }
            else if (splittedStartDate[1].Length == 1)
            {
                selectedStartDate = "0" + splittedStartDate[2] + "-" + splittedStartDate[0] + "-" + splittedStartDate[1];
            }
            else
            {
                selectedStartDate = splittedStartDate[2] + "-" + splittedStartDate[0] + "-" + splittedStartDate[1];
            }
            
            if (splittedEndDate[0].Length == 1 && splittedEndDate[1].Length == 1)
            {
                selectedEndDate = splittedEndDate[2] + "-" + "0" + splittedEndDate[0] + "-" + "0" + splittedEndDate[1];
            }
            else if (splittedEndDate[0].Length == 1)
            {
                selectedEndDate = splittedEndDate[2] + "-" + "0" + splittedEndDate[0] + "-" + splittedEndDate[1];
            }
            else if (splittedEndDate[1].Length == 1)
            {
                selectedEndDate = splittedEndDate[2] + "-" + splittedEndDate[0] + "-" + "0" + splittedEndDate[1];
            }
            else
            {
                selectedEndDate = splittedEndDate[2] + "-" + splittedEndDate[0] + "-" + splittedEndDate[1];
            }
            // end dirty hack

            earnedLabel.Text = selectedStartDate;

            SQLiteCommand insert = new SQLiteCommand("INSERT INTO transactions (type, startDate, endDate, spent, earned, notes) VALUES (?, ?, ?, ?, ?, ?)");
            //SQLiteCommand insert = new SQLiteCommand("INSERT INTO transactions (type) VALUES (?)");

            insert.Connection = new SQLiteConnection("Data Source=ledger");
            insert.Connection.Open();

            //SQLiteParameter type = new SQLiteParameter("@type", SqlDbType.Text) { Value = typeComboBox.Text };
            //SQLiteParameter startDate = new SQLiteParameter("@startDate", SqlDbType.Date) { Value = selectedStartDate };
            //SQLiteParameter endDate = new SQLiteParameter("@endDate", SqlDbType.Date) { Value = selectedEndDate };
            //SQLiteParameter spent = new SQLiteParameter("@spent", SqlDbType.Money) { Value = spentUpDown.Value };
            //SQLiteParameter earned = new SQLiteParameter("@earned", SqlDbType.Money) { Value = earnedUpDown.Value };
            //SQLiteParameter notes = new SQLiteParameter("@notes", SqlDbType.Text) { Value = notesTextBox.Text };
            
            insert.Parameters.AddWithValue("type", typeComboBox.Text);
            insert.Parameters.AddWithValue("startDate", selectedStartDate);
            insert.Parameters.AddWithValue("endDate", selectedEndDate);
            insert.Parameters.AddWithValue("spent", spentUpDown.Value);
            insert.Parameters.AddWithValue("earned", earnedUpDown.Value);
            insert.Parameters.AddWithValue("notes", notesTextBox.Text);

            insert.ExecuteNonQuery();
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.Value = dateTimePicker.Value;
        }
    }
}
