﻿namespace ClubLedger
{
    partial class MainForm
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.LedgerButton = new System.Windows.Forms.Button();
            this.ViewDateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(375, 131);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // LedgerButton
            // 
            this.LedgerButton.Location = new System.Drawing.Point(12, 12);
            this.LedgerButton.Name = "LedgerButton";
            this.LedgerButton.Size = new System.Drawing.Size(75, 23);
            this.LedgerButton.TabIndex = 1;
            this.LedgerButton.Text = "Ledger";
            this.LedgerButton.UseVisualStyleBackColor = true;
            this.LedgerButton.Click += new System.EventHandler(this.LedgerButton_Click);
            // 
            // ViewDateButton
            // 
            this.ViewDateButton.Location = new System.Drawing.Point(375, 305);
            this.ViewDateButton.Name = "ViewDateButton";
            this.ViewDateButton.Size = new System.Drawing.Size(227, 23);
            this.ViewDateButton.TabIndex = 2;
            this.ViewDateButton.Text = "View Selected Date";
            this.ViewDateButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 340);
            this.Controls.Add(this.ViewDateButton);
            this.Controls.Add(this.LedgerButton);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button LedgerButton;
        private System.Windows.Forms.Button ViewDateButton;
    }
}

