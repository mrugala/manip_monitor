using System;
using System.Timers;

namespace Manipulator
{
    public class CantReadCOM : Exception
    {
        public CantReadCOM()
        {
        }

        public CantReadCOM(string message)
            : base(message)
        {
        }
    }

    public class CantWriteToCOM : Exception
    {
        public CantWriteToCOM()
        {
        }

        public CantWriteToCOM(string message)
            : base(message)
        {
        }
    }

    class COMPort
    {
        public COMPort(string COMName, int BaudRate)
        {
            serialPort = new System.IO.Ports.SerialPort();
            serialPort.BaudRate = BaudRate;
            serialPort.DataBits = 8;
            serialPort.Parity = System.IO.Ports.Parity.None;
            serialPort.PortName = COMName;
            serialPort.StopBits = System.IO.Ports.StopBits.One;

            logger = new Logger("SerialPort");
            aTimer = new System.Timers.Timer(2000);
        }

        public bool IsOpen()
        {
            return serialPort.IsOpen;
        }

        public string GetName()
        {
            return serialPort.PortName;
        }

        public void OpenPort()
        {
            try
            {
                serialPort.Open();
            }
            catch(System.UnauthorizedAccessException)
            {
                logger.Error("Niedozwolony dostęp do portu COM.");
            }
        }

        public void ClosePort()
        {
            if (serialPort.IsOpen == true)
                serialPort.Close();
        }

        public string ReadLine()
        {
            try
            {
                aTimer.Elapsed += TimeoutEvent;
                aTimer.Enabled = true;
                string line = serialPort.ReadLine();
                aTimer.Enabled = false;

                return line;
            }
            catch (System.IO.IOException)
            {
                throw new CantReadCOM(String.Format("Odczyt {0} zakończony niepowodzeniem.", GetName()));
            }
            catch (System.UnauthorizedAccessException)
            {
                throw new CantReadCOM("Niedozwolony dostęp do portu COM.");
            }
            catch (System.InvalidOperationException)
            {
                throw new CantReadCOM("Niedozwolona operacja.");
            }
        }

        public void WriteLine(string line)
        {
            try
            {
                aTimer.Elapsed += TimeoutEvent;
                aTimer.Enabled = true;
                serialPort.WriteLine(line);
                aTimer.Enabled = false;
            }
            catch (System.IO.IOException)
            {
                throw new CantWriteToCOM(String.Format("Zapis do {0} zakończony niepowodzeniem.", GetName()));
            }
            catch (System.UnauthorizedAccessException)
            {
                throw new CantWriteToCOM("Niedozwolony dostęp do portu COM.");
            }
            catch (System.InvalidOperationException)
            {
                throw new CantWriteToCOM("Niedozwolona operacja.");
            }
        }

        private void TimeoutEvent(Object source, ElapsedEventArgs e)
        {
            logger.Warning("Czas oczekiwania na dane przekroczony.");
            aTimer.Dispose();
            try
            {
                ClosePort();
                logger.Info("Port szeregowy został zamknięty.");
            }
            catch (System.UnauthorizedAccessException)
            {
                logger.Error("Niedozwolony dostęp do portu COM.");
            }
        }

        private System.IO.Ports.SerialPort serialPort;
        private Logger logger;
        private static System.Timers.Timer aTimer;
    }
}
