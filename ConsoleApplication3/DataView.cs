using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Manipulator
{
    public partial class DataView : Form
    {
        public DataView(string COM)
        {
            InitializeComponent();

            COM_Port = new COMPort(COM, 115200);

            logger = new Logger("SensorData");

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

            time = 0.0;
            timer1.Start();

            InitCharts();

            diag = new Diagnostics();
            this.Closed += (s, args) => diag.Close();
            diag.Show();
        }

        private void InitCharts()
        {
            wykres.Series["X"].ChartType = SeriesChartType.FastLine;
            wykres.Series["X"].Color = Color.Red;

            wykres.Series["Y"].ChartType = SeriesChartType.FastLine;
            wykres.Series["Y"].Color = Color.Blue;

            wykres.Series["Z"].ChartType = SeriesChartType.FastLine;
            wykres.Series["Z"].Color = Color.Green;

            angles.Series["Roll"].ChartType = SeriesChartType.FastLine;
            angles.Series["Roll"].Color = Color.Red;

            angles.Series["Pitch"].ChartType = SeriesChartType.FastLine;
            angles.Series["Pitch"].Color = Color.Blue;

            angles.Series["Yaw"].ChartType = SeriesChartType.FastLine;
            angles.Series["Yaw"].Color = Color.Green;
        }

        private void DataView_FormClosing(Object sender, FormClosingEventArgs e)
        {
            COM_Port.ClosePort();
        }

        private void KeepLast20Seconds()
        {
            if (time > 20)
            {
                wykres.Series["X"].Points.RemoveAt(0);
                wykres.Series["Y"].Points.RemoveAt(0);
                wykres.Series["Z"].Points.RemoveAt(0);
                wykres.ResetAutoValues();

                angles.Series["Roll"].Points.RemoveAt(0);
                angles.Series["Pitch"].Points.RemoveAt(0);
                angles.Series["Yaw"].Points.RemoveAt(0);
                angles.ResetAutoValues();
            }
        }

        private void ClearCharts()
        {
            wykres.Series["X"].Points.Clear();
            wykres.Series["Y"].Points.Clear();
            wykres.Series["Z"].Points.Clear();
            wykres.ResetAutoValues();

            angles.Series["Roll"].Points.Clear();
            angles.Series["Pitch"].Points.Clear();
            angles.Series["Yaw"].Points.Clear();
            angles.ResetAutoValues();

            time = 0.0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            char[] delimiterChars = { ' ', '\t' };

            if (COM_Port.IsOpen() == true)
            {
                try
                {
                    diag.SetSerialDataBox(COM_Port.ReadLine());

                    string[] serialData = diag.GetSerialDataBox().Split(delimiterChars);

                    UpdateData(serialData);

                    time += 0.1;
                    time = Math.Round(time, 1);

                    KeepLast20Seconds();

                    if (time > 500)
                        ClearCharts();
                }
                catch (System.IndexOutOfRangeException)
                {
                    logger.Error("Błędny odczyt {0}.", COM_Port.GetName());
                }
                catch (CantReadCOM ex)
                {
                    logger.Error("{0}", ex.Message);
                    logger.Error("Odczyt {0} zakończony niepowodzeniem.", COM_Port.GetName());
                }
            }
            else
            {
                string warn = (COM_Port.GetName() == "Żŏdyn" ? "Żŏdyn COM port" : COM_Port.GetName());
                diag.SetSerialDataBox(String.Format("Warning: {0} nie jest podłączony.", warn));
                logger.Warning("{0} nie jest podłączony.", warn);
                timer1.Dispose();
            }
        }

        private void UpdateData(string[] serialData)
        {
            try
            {
                UpdateXYZChart(serialData);
                UpdateRPYChart(serialData);
                if (!diag.IsDisposed)
                    diag.UpdateADCCharts(serialData);
                UptadeAngleBoxes(serialData);
            }
            catch(FormatException)
            {
                logger.Error("Format Exception.");
            }
        }

        private void UpdateRPYChart(string[] serialData)
        {
            angles.Series["Roll"].Points.AddXY(time, Double.Parse(serialData[1], CultureInfo.InvariantCulture));
            angles.Series["Pitch"].Points.AddXY(time, Double.Parse(serialData[2], CultureInfo.InvariantCulture));
            angles.Series["Yaw"].Points.AddXY(time, Double.Parse(serialData[3], CultureInfo.InvariantCulture));
        }

        private void UpdateXYZChart(string[] serialData)
        {
            wykres.Series["X"].Points.AddXY(time, Double.Parse(serialData[4], CultureInfo.InvariantCulture));
            wykres.Series["Y"].Points.AddXY(time, Double.Parse(serialData[5], CultureInfo.InvariantCulture));
            wykres.Series["Z"].Points.AddXY(time, Double.Parse(serialData[6], CultureInfo.InvariantCulture));
        }

        private void UptadeAngleBoxes(string[] serialData)
        {
            fi1.Text = serialData[11];
            fi2.Text = serialData[12];
            fi3.Text = serialData[13];
            fi4.Text = serialData[14];
            fi5.Text = serialData[15];
        }

        private double time;
        private COMPort COM_Port;
        private Logger logger;
        private Diagnostics diag;
    }
}
