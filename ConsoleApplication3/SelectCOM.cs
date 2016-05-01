using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Manipulator
{
    public partial class SelectCOM : Form
    {
        public SelectCOM()
        {
            InitializeComponent();
            foreach(String portName in GetAllPorts())
                comboBox1.Items.Add(portName);
            comboBox1.Items.Add("Żŏdyn");
        }

        public List<string> GetAllPorts()
        {
            List<String> allPorts = new List<String>();
            foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                allPorts.Add(portName);
            }
            return allPorts;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            COM_Name = comboBox1.SelectedItem.ToString();
        }

        private string COM_Name = "Żŏdyn";

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dv = new DataView(COM_Name);
            dv.Closed += (s, args) => this.Close();
            dv.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var mc = new ManipulatorControl(COM_Name);
            mc.Closed += (s, args) => this.Close();
            mc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            foreach (String portName in GetAllPorts())
                comboBox1.Items.Add(portName);
            comboBox1.Items.Add("Żŏdyn");
        }
    }
}
