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
            insert.Parameters.Add(typeComboBox.Text); // System.InvalidCastException: 'Unable to cast object of type 'System.String' to type 'System.Data.SQLite.SQLiteParameter'.'
            insert.Parameters.Add(selectedStartDate);
            insert.Parameters.Add(selectedEndDate);
            insert.Parameters.Add(spentUpDown.Value);
            insert.Parameters.Add(earnedUpDown.Value);
            insert.Parameters.Add(notesTextBox.Text);
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.Value = dateTimePicker.Value;
        }
    }
}
