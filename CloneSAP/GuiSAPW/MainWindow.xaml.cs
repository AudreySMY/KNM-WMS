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

namespace GuiSAPW
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

        private void MeanClick(object sender, RoutedEventArgs e)
        {
            canvas_UserC.Children.Clear();
            Mean mean = new Mean();
            canvas_UserC.Children.Add(mean);
        }
        private void HomeClick(object sender, RoutedEventArgs e)
        {
            canvas_UserC.Children.Clear();
            Home home = new Home();
            canvas_UserC.Children.Add(home);
        }
    }
}
