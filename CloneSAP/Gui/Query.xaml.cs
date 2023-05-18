using SAPLib.Functions;
using SAPLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gui
{
    /// <summary>
    /// Interação lógica para Query.xam
    /// </summary>
    public partial class Query : UserControl
    {
        string material;
        string grid;
        public Query(string materialq,string gridq)
        {
            InitializeComponent();
            material = materialq;
            grid = gridq;
            
        }

        private async void datagrid_Loaded(object sender, RoutedEventArgs e)
        {
            var stockIDs = await Request.getStockID(material, grid);
            datagrid.ItemsSource = stockIDs;
        }
    }
}
