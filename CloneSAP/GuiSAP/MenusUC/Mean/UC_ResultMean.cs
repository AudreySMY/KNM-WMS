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

namespace GuiSAP.MenusUC
{
    public partial class UC_ResultMean : UserControl
    {
        string material;
        string grid;
        int RowCount;
        public UC_ResultMean(string materialQ,string gridQ,int rowCountQ)
        {
            InitializeComponent();
            Dv_mean.RowCount = rowCountQ;
            material = materialQ;
            grid = gridQ;
            RowCount= rowCountQ;
            
        }

        private void Dv_mean_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void UC_ResultMean_Load(object sender, EventArgs e)
        {
            var stockIDs = await Request.getStockID(material, grid);
            foreach(var stockID in stockIDs)
            {
                Dv_mean.Rows.Add(stockID.material.material,stockID.grid.gridCod, stockID.stockIDn);
            }
            Dv_mean.Visible= true;
        }

        private async void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dv_mean.Rows.Clear();
            var stockIDs = await Request.getStockID(material, grid);
            foreach (var stockID in stockIDs)
            {
                Dv_mean.Rows.Add(stockID.material.material, stockID.grid.gridCod, stockID.stockIDn);
            }
        }
    }
}
