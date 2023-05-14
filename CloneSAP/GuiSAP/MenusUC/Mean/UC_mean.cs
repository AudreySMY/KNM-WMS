using GuiSAP.MenusUC;
using SAPLib.Funcions;
using SAPLib.Functions;
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
    public partial class UC_mean : UserControl
    {
        public UC_mean()
        {   
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

        }
        bool control = false;
        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            string material = txb_materialDe.Text;
            string grid = txb_gridDe.Text;
            int RowCount = int.Parse(Txb_RowCount.Text);
            Forms.RomoveGroupControl(this);

            UC_ResultMean resultMean= new UC_ResultMean(material, grid,RowCount);
            Pnl_query.Controls.Add(resultMean);
            

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void UC_mean_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
