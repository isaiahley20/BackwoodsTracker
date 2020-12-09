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
    public partial class MainWindow : Window
    {
        Control control = new Control();
        public MainWindow()
        {
            InitializeComponent();
            DisplayMostRecentSapOverSyrupRatio();
            DisplayExpectedNextSapOverSyrupRatio();
            DisplayEmptyJarsAvailable();
        }

        //moves to production screen
        private void Button_Click_Production(object sender, RoutedEventArgs e)
        {
            Production productionScreen = new Production();
            productionScreen.Show();
            this.Close();
        }

        //moves to financials screen
        private void Button_Click_Financials(object sender, RoutedEventArgs e)
        {
            FinancialsScreen financialsScreen = new FinancialsScreen();
            financialsScreen.Show();
            this.Close();
        }

        //moves to inventory screen
        private void Button_Click_Inventory(object sender, RoutedEventArgs e)
        {
            InventoryScreen inventoryScreen = new InventoryScreen();
            inventoryScreen.Show();
            this.Close();
        }

        //displays most recent sap over syrup ratio
        private void DisplayMostRecentSapOverSyrupRatio()
        {
            string mostRecentSapOverSyrup = control.MostRecentSapOverSyrupRatio();
            currentlyLabel.Content = mostRecentSapOverSyrup;
        }

        //displays the expected next sap over syrup ratio
        private void DisplayExpectedNextSapOverSyrupRatio()
        {
            string expectedNextRatio = control.CalcExpectedNextSapOverSyrupRatio();
            nextLabel.Content = expectedNextRatio;
        }

        //displays the total number of jars avail
        private void DisplayEmptyJarsAvailable()
        {
            int bottlesAvail = control.GetPintBottlesAvail() + control.GetQuartBottlesAvail() + control.GetHalfPintBottlesAvail();
            jarsAvailLabel.Content = bottlesAvail;
        }
    }
}
