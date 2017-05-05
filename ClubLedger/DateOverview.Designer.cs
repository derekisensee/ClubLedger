namespace ClubLedger
{
    partial class DateOverview
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
            this.headers = new System.Windows.Forms.Label();
            this.data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headers
            // 
            this.headers.AutoSize = true;
            this.headers.Location = new System.Drawing.Point(12, 9);
            this.headers.Name = "headers";
            this.headers.Size = new System.Drawing.Size(20, 13);
            this.headers.TabIndex = 0;
            this.headers.Text = "TYPE   DATE    SPENT   EARNED  NOTES";
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Location = new System.Drawing.Point(12, 22);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(87, 13);
            this.data.TabIndex = 1;
            this.data.Text = "data goes here!!!";
            // 
            // DateOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 314);
            this.Controls.Add(this.data);
            this.Controls.Add(this.headers);
            this.Name = "DateOverview";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headers;
        private System.Windows.Forms.Label data;
    }
}