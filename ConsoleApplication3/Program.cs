﻿using System.Windows.Forms;

namespace Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SelectCOM());
        }
    }
}
