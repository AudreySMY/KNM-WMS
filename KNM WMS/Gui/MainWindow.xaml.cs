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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void RemoveUC()
        {
            canvas_UserC.Children.Clear();
        }
        public void AddUC(UserControl UC)
        {
            canvas_UserC.Children.Add(UC);
        }
        private void HomeItem_Click(object sender, RoutedEventArgs e)
        {
            canvas_UserC.Children.Clear();
            Home home = new Home();
            canvas_UserC.Children.Add(home);
        }
        private void MeanItem_Click(object sender, RoutedEventArgs e)
        {
            canvas_UserC.Children.Clear();
            Mean Mean = new Mean(this);
            canvas_UserC.Children.Add(Mean);
        }
        
        
    }
}
