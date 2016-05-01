using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Manipulator
{
    public partial class Diagnostics : Form
    {
        public Diagnostics()
        {
            InitializeComponent();

            logger = new Logger("Diagnostics");
        }

        private void Diagnostics_FormClosing(Object sender, FormClosingEventArgs e)
        {
            logger.Warning("Okno zostało zamknięte.");
        }

        public void UpdateADCCharts(string[] serialData)
        {
            try
            {
                switch (int.Parse(serialData[0]))
                {
                    case 0:
                        voltage.Series["V1"].Points.AddXY(0, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        voltage.Series["V6"].Points.AddXY(5, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C9"].Points.AddXY(8, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp5"].Points.AddXY(4, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 1:
                        voltage.Series["V2"].Points.AddXY(1, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        voltage.Series["V7"].Points.AddXY(6, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C2"].Points.AddXY(1, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp2"].Points.AddXY(1, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 2:
                        voltage.Series["V3"].Points.AddXY(2, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        voltage.Series["V8"].Points.AddXY(7, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C3"].Points.AddXY(2, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp6"].Points.AddXY(5, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 3:
                        voltage.Series["V4"].Points.AddXY(3, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        voltage.Series["V9"].Points.AddXY(8, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C6"].Points.AddXY(5, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp3"].Points.AddXY(2, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 4:
                        voltage.Series["V5"].Points.AddXY(4, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        current.Series["C7"].Points.AddXY(6, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C1"].Points.AddXY(0, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp4"].Points.AddXY(3, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 5:
                        voltage.Series["OPAMPSUP"].Points.AddXY(9, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        current.Series["CIN"].Points.AddXY(9, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        temperature.Series["Temp10"].Points.AddXY(9, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp7"].Points.AddXY(6, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 6:
                        voltage.Series["PANELSUP"].Points.AddXY(10, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        current.Series["C5"].Points.AddXY(4, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        temperature.Series["Temp1"].Points.AddXY(0, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp9"].Points.AddXY(8, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                    case 7:
                        voltage.Series["VIN"].Points.AddXY(11, Double.Parse(serialData[7], CultureInfo.InvariantCulture));
                        current.Series["C8"].Points.AddXY(7, Double.Parse(serialData[8], CultureInfo.InvariantCulture));
                        current.Series["C4"].Points.AddXY(3, Double.Parse(serialData[9], CultureInfo.InvariantCulture));
                        temperature.Series["Temp8"].Points.AddXY(7, Double.Parse(serialData[10], CultureInfo.InvariantCulture));
                        break;
                }
            }
            catch(System.NullReferenceException)
            {
                logger.Error("Okno wyłączone.");
            }
        }

        public void SetSerialDataBox(string serialData)
        {
            serialDataReceived.Text = serialData;
        }

        public string GetSerialDataBox()
        {
            return serialDataReceived.Text;
        }

        private Logger logger;

        private void COMCheck_Click(object sender, EventArgs e)
        {
            COM_Port_list.Items.Clear();
            List<String> lista = GetAllPorts();
            foreach (string l in lista)
                COM_Port_list.Items.Add(l);
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
    }
}
