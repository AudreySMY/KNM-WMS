using GuiSAP.MenusUC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuiSAP
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }
        private void desableUC(Panel panel)
        {
            foreach (Control control in panel.Controls) 
            {
                if (control is UserControl) 
                {
                    panel.Controls.Remove(control);
                }
            }
        }
        private void menuChange(string menu)
        {
            
            switch (menu)
            {
                case "MB11":
                    desableUC(Pnl_menu);
                    break;
                case "MB51":
                    desableUC(Pnl_menu);
                    UC_mb51 mb51 = new UC_mb51();
                    Pnl_menu.Controls.Add(mb51);
                    break;
                case "LT27":
                    desableUC(Pnl_menu);
                    break;
                case "MB24":
                    desableUC(Pnl_menu);
                    break;
                case "MEAN":
                    desableUC(Pnl_menu);
                    UC_mean mean = new UC_mean();
                    Pnl_menu.Controls.Add(mean);
                    
                    break;
                case "LQUA":
                    desableUC(Pnl_menu);
                    break;
                default:
                    desableUC(Pnl_menu);
                    Pnl_menu.Visible = true;
                    break;

            }
        }
        private void tv_menu_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode selectedNode = e.Node;
            MessageBox.Show(selectedNode.Text);
        }

        private void Txb_menu_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter) 
            {
                e.SuppressKeyPress = true;
                string menu = Txb_menu.Text.ToUpper();
                menuChange(menu);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            string menu = Txb_menu.Text.ToUpper();
            menuChange(menu);
        }

    }
}
