namespace ClubLedger
{
    partial class LedgerForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toggleEarned = new System.Windows.Forms.Button();
            this.toggleLost = new System.Windows.Forms.Button();
            this.toggleNet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainChart
            // 
            chartArea2.Name = "ChartArea1";
            this.mainChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.mainChart.Legends.Add(legend2);
            this.mainChart.Location = new System.Drawing.Point(12, 12);
            this.mainChart.Name = "mainChart";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Green;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Earned";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Lost";
            series6.ChartArea = "ChartArea1";
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "Net";
            this.mainChart.Series.Add(series4);
            this.mainChart.Series.Add(series5);
            this.mainChart.Series.Add(series6);
            this.mainChart.Size = new System.Drawing.Size(679, 438);
            this.mainChart.TabIndex = 0;
            this.mainChart.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toggleNet);
            this.groupBox1.Controls.Add(this.toggleLost);
            this.groupBox1.Controls.Add(this.toggleEarned);
            this.groupBox1.Location = new System.Drawing.Point(697, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chart Controls";
            // 
            // toggleEarned
            // 
            this.toggleEarned.Location = new System.Drawing.Point(6, 19);
            this.toggleEarned.Name = "toggleEarned";
            this.toggleEarned.Size = new System.Drawing.Size(92, 23);
            this.toggleEarned.TabIndex = 0;
            this.toggleEarned.Text = "Toggle Earned";
            this.toggleEarned.UseVisualStyleBackColor = true;
            this.toggleEarned.Click += new System.EventHandler(this.toggleEarned_Click);
            // 
            // toggleLost
            // 
            this.toggleLost.Location = new System.Drawing.Point(6, 48);
            this.toggleLost.Name = "toggleLost";
            this.toggleLost.Size = new System.Drawing.Size(92, 23);
            this.toggleLost.TabIndex = 1;
            this.toggleLost.Text = "Toggle Lost";
            this.toggleLost.UseVisualStyleBackColor = true;
            this.toggleLost.Click += new System.EventHandler(this.toggleLost_Click);
            // 
            // toggleNet
            // 
            this.toggleNet.Location = new System.Drawing.Point(6, 77);
            this.toggleNet.Name = "toggleNet";
            this.toggleNet.Size = new System.Drawing.Size(92, 23);
            this.toggleNet.TabIndex = 2;
            this.toggleNet.Text = "Toggle Net";
            this.toggleNet.UseVisualStyleBackColor = true;
            this.toggleNet.Click += new System.EventHandler(this.toggleNet_Click);
            // 
            // LedgerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 555);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mainChart);
            this.Name = "LedgerForm";
            this.Text = "LedgerForm";
            this.Load += new System.EventHandler(this.LedgerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button toggleNet;
        private System.Windows.Forms.Button toggleLost;
        private System.Windows.Forms.Button toggleEarned;
    }
}