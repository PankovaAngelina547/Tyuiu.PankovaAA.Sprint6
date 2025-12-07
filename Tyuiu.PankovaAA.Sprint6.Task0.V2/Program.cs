using System;
using System.Windows.Forms;
using Tyuiu.PankovaAA.Sprint6.Task0.V2;

namespace Tyutu.PankovaAA.Sprint6.Task0.V2
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}