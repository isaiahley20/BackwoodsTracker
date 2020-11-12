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

namespace BackwoodsMapleTracker
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

        private void Button_Click_Production(object sender, RoutedEventArgs e)
        {
            Production prod = new Production();
            prod.Show();
        }

        private void Button_Click_Financials(object sender, RoutedEventArgs e)
        {
            FinancialsScreen fin = new FinancialsScreen();
            fin.Show();
        }

        private void Button_Click_Inventory(object sender, RoutedEventArgs e)
        {
            InventoryScreen inven = new InventoryScreen();
            inven.Show();
        }

    }
}
