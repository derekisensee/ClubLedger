namespace ClubLedger
{
    partial class NewEntryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.notesLabel = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.insertDataButton = new System.Windows.Forms.Button();
            this.earnedLabel = new System.Windows.Forms.Label();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.spentLabel = new System.Windows.Forms.Label();
            this.spentUpDown = new System.Windows.Forms.NumericUpDown();
            this.earnedUpDown = new System.Windows.Forms.NumericUpDown();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.endDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.spentUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.earnedUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Ticket Sales",
            "Raffles",
            "Cotton Candy Sales",
            "Snow Cone Sales",
            "Pancake Breakfast-Coffee Sales",
            "Other Sales",
            "Homecoming Dance",
            "Jeans Day",
            "Food Night"});
            this.typeComboBox.Location = new System.Drawing.Point(50, 10);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(358, 21);
            this.typeComboBox.TabIndex = 0;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(9, 13);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 1;
            this.typeLabel.Text = "Type";
            // 
            // notesLabel
            // 
            this.notesLabel.AutoSize = true;
            this.notesLabel.Location = new System.Drawing.Point(9, 92);
            this.notesLabel.Name = "notesLabel";
            this.notesLabel.Size = new System.Drawing.Size(35, 13);
            this.notesLabel.TabIndex = 2;
            this.notesLabel.Text = "Notes";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(67, 147);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(340, 20);
            this.dateTimePicker.TabIndex = 3;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(50, 89);
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(357, 20);
            this.notesTextBox.TabIndex = 4;
            // 
            // insertDataButton
            // 
            this.insertDataButton.Location = new System.Drawing.Point(12, 240);
            this.insertDataButton.Name = "insertDataButton";
            this.insertDataButton.Size = new System.Drawing.Size(75, 23);
            this.insertDataButton.TabIndex = 5;
            this.insertDataButton.Text = "Insert Date";
            this.insertDataButton.UseVisualStyleBackColor = true;
            this.insertDataButton.Click += new System.EventHandler(this.insertDataButton_Click);
            // 
            // earnedLabel
            // 
            this.earnedLabel.AutoSize = true;
            this.earnedLabel.Location = new System.Drawing.Point(9, 65);
            this.earnedLabel.Name = "earnedLabel";
            this.earnedLabel.Size = new System.Drawing.Size(41, 13);
            this.earnedLabel.TabIndex = 6;
            this.earnedLabel.Text = "Earned";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Location = new System.Drawing.Point(67, 173);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(340, 20);
            this.endDateTimePicker.TabIndex = 7;
            // 
            // spentLabel
            // 
            this.spentLabel.AutoSize = true;
            this.spentLabel.Location = new System.Drawing.Point(9, 39);
            this.spentLabel.Name = "spentLabel";
            this.spentLabel.Size = new System.Drawing.Size(35, 13);
            this.spentLabel.TabIndex = 8;
            this.spentLabel.Text = "Spent";
            // 
            // spentUpDown
            // 
            this.spentUpDown.DecimalPlaces = 2;
            this.spentUpDown.Location = new System.Drawing.Point(50, 37);
            this.spentUpDown.Name = "spentUpDown";
            this.spentUpDown.Size = new System.Drawing.Size(358, 20);
            this.spentUpDown.TabIndex = 9;
            this.spentUpDown.ThousandsSeparator = true;
            // 
            // earnedUpDown
            // 
            this.earnedUpDown.DecimalPlaces = 2;
            this.earnedUpDown.Location = new System.Drawing.Point(50, 63);
            this.earnedUpDown.Name = "earnedUpDown";
            this.earnedUpDown.Size = new System.Drawing.Size(357, 20);
            this.earnedUpDown.TabIndex = 10;
            this.earnedUpDown.ThousandsSeparator = true;
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(9, 153);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(55, 13);
            this.startDateLabel.TabIndex = 11;
            this.startDateLabel.Text = "Start Date";
            // 
            // endDateLabel
            // 
            this.endDateLabel.AutoSize = true;
            this.endDateLabel.Location = new System.Drawing.Point(9, 179);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(52, 13);
            this.endDateLabel.TabIndex = 12;
            this.endDateLabel.Text = "End Date";
            // 
            // NewEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 275);
            this.Controls.Add(this.endDateLabel);
            this.Controls.Add(this.startDateLabel);
            this.Controls.Add(this.earnedUpDown);
            this.Controls.Add(this.spentUpDown);
            this.Controls.Add(this.spentLabel);
            this.Controls.Add(this.endDateTimePicker);
            this.Controls.Add(this.earnedLabel);
            this.Controls.Add(this.insertDataButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.notesLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.typeComboBox);
            this.MinimizeBox = false;
            this.Name = "NewEntryForm";
            this.ShowInTaskbar = false;
            this.Text = "NewEntryForm";
            ((System.ComponentModel.ISupportInitialize)(this.spentUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.earnedUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label notesLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button insertDataButton;
        private System.Windows.Forms.Label earnedLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.Label spentLabel;
        private System.Windows.Forms.NumericUpDown spentUpDown;
        private System.Windows.Forms.NumericUpDown earnedUpDown;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label endDateLabel;
    }
}