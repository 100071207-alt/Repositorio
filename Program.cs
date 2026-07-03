using System;
using System.Windows.Forms;

namespace REGISTRO_DE_ALMACEN
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmReportes());
        }
    }
}