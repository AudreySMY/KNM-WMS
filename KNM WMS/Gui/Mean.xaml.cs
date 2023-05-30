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
    /// Interação lógica para Mean.xam
    /// </summary>
    public partial class Mean : UserControl
    {
        string model { get; set; }
        string grid { get; set; }
        string Upc { get; set; }
        string request { get; set; }
        public Mean(MainWindow main)
        {   
            InitializeComponent();

        }
        
        private void Search_Click(object sender, RoutedEventArgs e)
        {
            request = null;
            model = Txb_model.Text.ToUpper();
            grid = Txb_Grid.Text.ToUpper();
            Upc = Txb_upc.Text.ToUpper();


            if (model.Length < 1) model = null;
            if (grid.Length < 1) grid = null;
            if (Upc.Length < 1) Upc = null;



            if (model is not null && grid is not null)
            {
                if (model is not null)
                {
                    if (grid is not null)
                    {
                        request = ($"?model={Txb_model.Text}&grid={Txb_Grid.Text}");
                    }
                    else
                    {
                        request = ($"?model={Txb_model.Text}");
                    }
                }
                else if (grid is not null)
                {
                    request = ($"?grid={Txb_Grid.Text}");
                }
            }
            else { request = null; }
            model = null;
            grid = null;
            Upc = null;
            ((MainWindow)Application.Current.MainWindow).RemoveUC();
            Query query= new Query(request);
            ((MainWindow)Application.Current.MainWindow).AddUC(query);
        }
    }
}
