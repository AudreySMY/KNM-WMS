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
using SAPLib.Funcions;

namespace GuiSAP
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }
        private void menuChange(string menu)
        {
            
            switch (menu)
            {
                case "MB11":
                    Forms.RomoveAllControl(Pnl_menu);

                    break;
                case "MB51":
                    Forms.RomoveAllControl(Pnl_menu); ;
                    UC_mb51 mb51 = new UC_mb51();
                    Pnl_menu.Controls.Add(mb51);
                    break;
                case "LT27":
                    Forms.RomoveAllControl(Pnl_menu); ;
                    break;
                case "MB24":
                    Forms.RomoveAllControl(Pnl_menu); ;
                    break;
                case "MEAN":
                    Forms.RomoveAllControl(Pnl_menu); ;
                    UC_mean mean = new UC_mean();
                    Pnl_menu.Controls.Add(mean);
                    break;
                case "LQUA":
                    Forms.RomoveAllControl(Pnl_menu); ;
                    break;
                default:
                    Forms.RomoveAllControl(Pnl_menu); ;
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

        private void Frm_Home_Load(object sender, EventArgs e)
        {

        }
    }
}
