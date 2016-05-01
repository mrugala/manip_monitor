namespace Manipulator
{
    partial class DataView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.wykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.angles = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.fi1 = new System.Windows.Forms.TextBox();
            this.fi2 = new System.Windows.Forms.TextBox();
            this.fi4 = new System.Windows.Forms.TextBox();
            this.fi3 = new System.Windows.Forms.TextBox();
            this.fi5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.angles)).BeginInit();
            this.SuspendLayout();
            // 
            // wykres
            // 
            chartArea1.Name = "ChartArea1";
            this.wykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.wykres.Legends.Add(legend1);
            this.wykres.Location = new System.Drawing.Point(558, 12);
            this.wykres.Name = "wykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "X";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Y";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Z";
            this.wykres.Series.Add(series1);
            this.wykres.Series.Add(series2);
            this.wykres.Series.Add(series3);
            this.wykres.Size = new System.Drawing.Size(530, 300);
            this.wykres.TabIndex = 3;
            this.wykres.Text = "wspolrzedne";
            // 
            // angles
            // 
            chartArea2.Name = "ChartArea1";
            this.angles.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.angles.Legends.Add(legend2);
            this.angles.Location = new System.Drawing.Point(12, 12);
            this.angles.Name = "angles";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Roll";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Pitch";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Yaw";
            this.angles.Series.Add(series4);
            this.angles.Series.Add(series5);
            this.angles.Series.Add(series6);
            this.angles.Size = new System.Drawing.Size(530, 300);
            this.angles.TabIndex = 4;
            this.angles.Text = "angles";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fi1
            // 
            this.fi1.Location = new System.Drawing.Point(1117, 86);
            this.fi1.Name = "fi1";
            this.fi1.Size = new System.Drawing.Size(90, 20);
            this.fi1.TabIndex = 7;
            // 
            // fi2
            // 
            this.fi2.Location = new System.Drawing.Point(1117, 123);
            this.fi2.Name = "fi2";
            this.fi2.Size = new System.Drawing.Size(90, 20);
            this.fi2.TabIndex = 14;
            // 
            // fi4
            // 
            this.fi4.Location = new System.Drawing.Point(1117, 199);
            this.fi4.Name = "fi4";
            this.fi4.Size = new System.Drawing.Size(90, 20);
            this.fi4.TabIndex = 16;
            // 
            // fi3
            // 
            this.fi3.Location = new System.Drawing.Point(1117, 162);
            this.fi3.Name = "fi3";
            this.fi3.Size = new System.Drawing.Size(90, 20);
            this.fi3.TabIndex = 15;
            // 
            // fi5
            // 
            this.fi5.Location = new System.Drawing.Point(1117, 237);
            this.fi5.Name = "fi5";
            this.fi5.Size = new System.Drawing.Size(90, 20);
            this.fi5.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1117, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "fi1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1117, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "fi2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1117, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "fi4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1117, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "fi3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1117, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "fi5";
            // 
            // DataView
            // 
            this.ClientSize = new System.Drawing.Size(1230, 320);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fi5);
            this.Controls.Add(this.fi4);
            this.Controls.Add(this.fi3);
            this.Controls.Add(this.fi2);
            this.Controls.Add(this.fi1);
            this.Controls.Add(this.angles);
            this.Controls.Add(this.wykres);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SensorData";
            ((System.ComponentModel.ISupportInitialize)(this.wykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.angles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart wykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart angles;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox fi1;
        private System.Windows.Forms.TextBox fi2;
        private System.Windows.Forms.TextBox fi4;
        private System.Windows.Forms.TextBox fi3;
        private System.Windows.Forms.TextBox fi5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}