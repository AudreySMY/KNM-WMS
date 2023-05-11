using System;
using System.Windows.Forms;

namespace GuiSAP
{
    internal static class Program
    {   


        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Frm_Login());
        }
    }
}


