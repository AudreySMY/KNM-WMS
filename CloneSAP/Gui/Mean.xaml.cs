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
        string model;
        string grid ;
        string Upc;
        public Mean(MainWindow main)
        {   
            InitializeComponent();
            model = Txb_model.Text;
            grid = Txb_Grid.Text;
            Upc = Txb_upc.Text;
            
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            ((MainWindow)Application.Current.MainWindow).RemoveUC();
            Query query= new Query(model,grid);
            ((MainWindow)Application.Current.MainWindow).AddUC(query);
        }
    }
}
