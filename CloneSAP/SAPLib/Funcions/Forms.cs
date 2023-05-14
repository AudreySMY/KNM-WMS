using System.Windows.Forms;

namespace SAPLib.Funcions
{
    public class Forms
    {
        public static void RomoveAllControl(Control contConteiner)
        {
            
            foreach (Control control in contConteiner.Controls) 
            {
                contConteiner.Controls.Remove(control);
                control.Dispose();
            }
        }
        public static void RomoveGroupControl(Control contConteiner)
        {

            foreach (GroupBox control in contConteiner.Controls)
            {
                contConteiner.Controls.Remove(control);
                control.Dispose();
            }
        }
    }
}
