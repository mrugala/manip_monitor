namespace Manipulator
{
    partial class ManipulatorControl
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
            this.Roll = new System.Windows.Forms.TrackBar();
            this.Pitch = new System.Windows.Forms.TrackBar();
            this.Yaw = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fi5 = new System.Windows.Forms.TextBox();
            this.fi4 = new System.Windows.Forms.TextBox();
            this.fi3 = new System.Windows.Forms.TextBox();
            this.fi2 = new System.Windows.Forms.TextBox();
            this.fi1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.X = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Y = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.Z = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataToSend = new System.Windows.Forms.TextBox();
            this.RollText = new System.Windows.Forms.TextBox();
            this.PitchText = new System.Windows.Forms.TextBox();
            this.YawText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Roll
            // 
            this.Roll.Location = new System.Drawing.Point(207, 51);
            this.Roll.Maximum = 180;
            this.Roll.Minimum = -180;
            this.Roll.Name = "Roll";
            this.Roll.Size = new System.Drawing.Size(300, 45);
            this.Roll.TabIndex = 0;
            this.Roll.TickFrequency = 10;
            this.Roll.Scroll += new System.EventHandler(this.Roll_Scroll);
            // 
            // Pitch
            // 
            this.Pitch.Location = new System.Drawing.Point(207, 118);
            this.Pitch.Maximum = 180;
            this.Pitch.Minimum = -180;
            this.Pitch.Name = "Pitch";
            this.Pitch.Size = new System.Drawing.Size(300, 45);
            this.Pitch.TabIndex = 1;
            this.Pitch.TickFrequency = 10;
            this.Pitch.Scroll += new System.EventHandler(this.Pitch_Scroll);
            // 
            // Yaw
            // 
            this.Yaw.Location = new System.Drawing.Point(207, 185);
            this.Yaw.Maximum = 180;
            this.Yaw.Minimum = -180;
            this.Yaw.Name = "Yaw";
            this.Yaw.Size = new System.Drawing.Size(300, 45);
            this.Yaw.TabIndex = 2;
            this.Yaw.TickFrequency = 10;
            this.Yaw.Scroll += new System.EventHandler(this.Yaw_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "fi5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "fi4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "fi3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "fi2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "fi1";
            // 
            // fi5
            // 
            this.fi5.Location = new System.Drawing.Point(21, 182);
            this.fi5.Name = "fi5";
            this.fi5.Size = new System.Drawing.Size(90, 20);
            this.fi5.TabIndex = 27;
            // 
            // fi4
            // 
            this.fi4.Location = new System.Drawing.Point(21, 144);
            this.fi4.Name = "fi4";
            this.fi4.Size = new System.Drawing.Size(90, 20);
            this.fi4.TabIndex = 26;
            // 
            // fi3
            // 
            this.fi3.Location = new System.Drawing.Point(21, 107);
            this.fi3.Name = "fi3";
            this.fi3.Size = new System.Drawing.Size(90, 20);
            this.fi3.TabIndex = 25;
            // 
            // fi2
            // 
            this.fi2.Location = new System.Drawing.Point(21, 68);
            this.fi2.Name = "fi2";
            this.fi2.Size = new System.Drawing.Size(90, 20);
            this.fi2.TabIndex = 24;
            // 
            // fi1
            // 
            this.fi1.Location = new System.Drawing.Point(21, 31);
            this.fi1.Name = "fi1";
            this.fi1.Size = new System.Drawing.Size(90, 20);
            this.fi1.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Roll";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Pitch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Yaw";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 45);
            this.button1.TabIndex = 36;
            this.button1.Text = "Move to position";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // X
            // 
            this.X.DecimalPlaces = 1;
            this.X.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.X.Location = new System.Drawing.Point(38, 57);
            this.X.Name = "X";
            this.X.Size = new System.Drawing.Size(80, 20);
            this.X.TabIndex = 37;
            this.X.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.X.ValueChanged += new System.EventHandler(this.X_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(35, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Y";
            // 
            // Y
            // 
            this.Y.DecimalPlaces = 1;
            this.Y.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Y.Location = new System.Drawing.Point(38, 100);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(80, 20);
            this.Y.TabIndex = 39;
            this.Y.ValueChanged += new System.EventHandler(this.Y_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 124);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Z";
            // 
            // Z
            // 
            this.Z.DecimalPlaces = 1;
            this.Z.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.Z.Location = new System.Drawing.Point(38, 144);
            this.Z.Name = "Z";
            this.Z.Size = new System.Drawing.Size(80, 20);
            this.Z.TabIndex = 41;
            this.Z.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.Z.ValueChanged += new System.EventHandler(this.Z_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.fi2);
            this.panel1.Controls.Add(this.fi1);
            this.panel1.Controls.Add(this.fi3);
            this.panel1.Controls.Add(this.fi4);
            this.panel1.Controls.Add(this.fi5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(534, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(133, 218);
            this.panel1.TabIndex = 43;
            // 
            // dataToSend
            // 
            this.dataToSend.Location = new System.Drawing.Point(231, 249);
            this.dataToSend.Name = "dataToSend";
            this.dataToSend.Size = new System.Drawing.Size(266, 20);
            this.dataToSend.TabIndex = 44;
            // 
            // RollText
            // 
            this.RollText.Location = new System.Drawing.Point(156, 49);
            this.RollText.Name = "RollText";
            this.RollText.Size = new System.Drawing.Size(45, 20);
            this.RollText.TabIndex = 45;
            // 
            // PitchText
            // 
            this.PitchText.Location = new System.Drawing.Point(156, 117);
            this.PitchText.Name = "PitchText";
            this.PitchText.Size = new System.Drawing.Size(45, 20);
            this.PitchText.TabIndex = 46;
            // 
            // YawText
            // 
            this.YawText.Location = new System.Drawing.Point(156, 185);
            this.YawText.Name = "YawText";
            this.YawText.Size = new System.Drawing.Size(45, 20);
            this.YawText.TabIndex = 47;
            // 
            // ManipulatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 320);
            this.Controls.Add(this.YawText);
            this.Controls.Add(this.PitchText);
            this.Controls.Add(this.RollText);
            this.Controls.Add(this.dataToSend);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Z);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.X);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Yaw);
            this.Controls.Add(this.Pitch);
            this.Controls.Add(this.Roll);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManipulatorControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ManipulatorControl";
            ((System.ComponentModel.ISupportInitialize)(this.Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Yaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Z)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar Roll;
        private System.Windows.Forms.TrackBar Pitch;
        private System.Windows.Forms.TrackBar Yaw;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fi5;
        private System.Windows.Forms.TextBox fi4;
        private System.Windows.Forms.TextBox fi3;
        private System.Windows.Forms.TextBox fi2;
        private System.Windows.Forms.TextBox fi1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown X;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown Y;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Z;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox dataToSend;
        private System.Windows.Forms.TextBox RollText;
        private System.Windows.Forms.TextBox PitchText;
        private System.Windows.Forms.TextBox YawText;
    }
}