using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manipulator
{
    public partial class ManipulatorControl : Form
    {
        public ManipulatorControl(string COM)
        {
            InitializeComponent();

            InitData();

            COM_Port = new COMPort(COM, 115200);

            logger = new Logger("ManipulatorControl");

            if (COM_Port.GetName() != "Żŏdyn")
            {
                foreach (String portName in System.IO.Ports.SerialPort.GetPortNames())
                {
                    try
                    {
                        if (portName == COM_Port.GetName())
                            COM_Port.OpenPort();
                    }
                    catch (System.IO.IOException)
                    {
                        logger.Warning("{0} zajęty przez inną aplikację.", COM_Port.GetName());
                    }
                }
            }
            else
            {
                logger.Warning("COM port nie ustawiony.");
            }

            diag = new Diagnostics();
            this.Closed += (s, args) => diag.Close();
            diag.Show();
        }

        private void InitData()
        {
            roll = Roll.Value.ToString(CultureInfo.InvariantCulture);
            pitch = Pitch.Value.ToString(CultureInfo.InvariantCulture);
            yaw = Yaw.Value.ToString(CultureInfo.InvariantCulture);
            RollText.Text = roll;
            PitchText.Text = pitch;
            YawText.Text = yaw;
            x = X.Value.ToString(CultureInfo.InvariantCulture);
            y = Y.Value.ToString(CultureInfo.InvariantCulture);
            z = Z.Value.ToString(CultureInfo.InvariantCulture);
            string data = String.Format("{0} {1} {2} {3} {4} {5}", roll, pitch, yaw, x, y, z);
            dataToSend.Text = data;
        }

        private COMPort COM_Port;
        private Logger logger;
        private Diagnostics diag;
        private string roll, pitch, yaw;
        private string x, y, z;

        private void Roll_Scroll(object sender, EventArgs e)
        {
            roll = Roll.Value.ToString(CultureInfo.InvariantCulture);
            RollText.Text = roll;
        }

        private void Pitch_Scroll(object sender, EventArgs e)
        {
            pitch = Pitch.Value.ToString(CultureInfo.InvariantCulture);
            PitchText.Text = pitch;
        }

        private void Yaw_Scroll(object sender, EventArgs e)
        {
            yaw = Yaw.Value.ToString(CultureInfo.InvariantCulture);
            YawText.Text = yaw;
        }

        private void X_ValueChanged(object sender, EventArgs e)
        {
            x = X.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void Y_ValueChanged(object sender, EventArgs e)
        {
            y = Y.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void Z_ValueChanged(object sender, EventArgs e)
        {
            z = Z.Value.ToString(CultureInfo.InvariantCulture);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = String.Format("{0} {1} {2} {3} {4} {5}", roll, pitch, yaw, x, y, z);
            dataToSend.Text = data;

            if (COM_Port.IsOpen() == true)
            {
                try
                {
                    COM_Port.WriteLine(data);
                }
                catch(CantWriteToCOM ex)
                {
                    logger.Error("{0}", ex.Message);
                    logger.Error("Zapis do {0} zakończony niepowodzeniem.", COM_Port.GetName());
                }
            }
        }
    }
}
