using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace Narivia
{
    static class Program
    {
        public static bool IsRunning = false;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Log.WriteLine(" |    *    |   | Narivia");
            Log.WriteLine("/\\____*____/\\  | v" + Application.ProductVersion.ToString());
            Log.WriteLine("\\__STARTED__/  | by Mlendea Horatiu\n");

            VersionChecker.CheckVersion(true);

            Options.Load();

            IsRunning = true;

            Application.Run(new frmMain());
            Log.WriteLine("* * * Closing * * *");
        }
    }
}
