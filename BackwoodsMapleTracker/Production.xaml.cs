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
using System.Windows.Shapes;
using LiveCharts;
using LiveCharts.Wpf;
using System.Data;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BackwoodsMapleTracker
{
    public partial class Production : Window
    {
        public SeriesCollection GraphLines { get; set; }
        public string[] Dates { get; set; }
        public Func<double, string> YFormatter { get; set; }

        Control control = new Control();
        public Production()
        {
            InitializeComponent();
            
            //gets the data to put into the data grid
            ObservableCollection<DailySyrupProductionRecord> dailyProductionRecords = control.GetDailySyrupProducedList();
            DataGrid.DataContext = dailyProductionRecords;

            //retrieves the values to be put into the chart
            DailySyrupProductionRecord oneSyrupProductionRecordForChart;
            var pintsProducedYAxis = new ChartValues<double>();
            Dates = new string[dailyProductionRecords.Count()];
            for (int i = 0; i < dailyProductionRecords.Count(); i++)
            {
                oneSyrupProductionRecordForChart = dailyProductionRecords.ElementAt<DailySyrupProductionRecord>(i);
                //gets the syrup made
                pintsProducedYAxis.Add(oneSyrupProductionRecordForChart.syrupMadePints);
                //gets the date that syrup was made
                Dates[i] = oneSyrupProductionRecordForChart.date;
            }

            GraphLines = new SeriesCollection(){
                new LineSeries
                {
                    Title = "Cumulative Pints Produced",
                    Values = pintsProducedYAxis
                }
            };
            YFormatter = yAxisValues => yAxisValues.ToString("N");
            DataContext = this;
        }

        //moves to financial screen
        private void Btn_Click_Financials(object sender, RoutedEventArgs e)
        {
            FinancialsScreen financialsScreen = new FinancialsScreen();
            financialsScreen.Show();
            this.Close();
        }

        //moves to inventory screen
        private void Btn_Click_Inventory(object sender, RoutedEventArgs e)
        {
            InventoryScreen inventoryScreen = new InventoryScreen();
            inventoryScreen.Show();
            this.Close();
        }

        //toggles the chart from visible to not
        private void Btn_Click_Toggle(object sender, RoutedEventArgs e)
        {
            if (Chart.Visibility == Visibility.Visible)
            {
                Chart.Visibility = Visibility.Hidden;
                DataGrid.Margin = new Thickness(425, 70, 0, 0);
                DataGrid.Height = 320;
                image.Visibility = Visibility.Visible;
            }
            else
            {
                image.Visibility = Visibility.Hidden;
                Chart.Visibility = Visibility.Visible;
                DataGrid.Margin = new Thickness(425, 263, 0, 0);
                DataGrid.Height = 132;
            }
        }

        //allows user to create new entry
        private void Btn_Click_New_Entry(object sender, RoutedEventArgs e)
        {
            DataGrid.Margin = new Thickness(425, 263, 0, 0);
            LabelDate.Visibility = Visibility.Visible;
            LabelSapCollected.Visibility = Visibility.Visible;
            LabelSyrupProd.Visibility = Visibility.Visible;
            DateTxtBox.Visibility = Visibility.Visible;
            ProducedTxtBox.Visibility = Visibility.Visible;
            CollectedTxtBox.Visibility = Visibility.Visible;
            ConfirmBtn.Visibility = Visibility.Visible;
            CancelBtn.Visibility = Visibility.Visible;
            NewEntryBtn.Visibility = Visibility.Hidden;
        }

        //confirm button for the new entry
        private void Btn_Click_Confirm(object sender, RoutedEventArgs e)
        {
            try
            {
                string newDate = DateTxtBox.Text;
                double newSyrupProdNum = double.Parse(ProducedTxtBox.Text);
                double newSapCollected = double.Parse(CollectedTxtBox.Text);
                if(newSyrupProdNum < 0)
                {
                    throw new Exception("Invalid Data.");
                }
                if(newSapCollected < 0)
                {
                    throw new Exception("Invalid Data.");
                }
                DailySyrupProductionRecord newDailySyrupProductionRecord = new DailySyrupProductionRecord(newDate, newSyrupProdNum, newSapCollected);

                DateTxtBox.Text = "";
                ProducedTxtBox.Text = "";
                CollectedTxtBox.Text = "";
                LabelDate.Visibility = Visibility.Hidden;
                LabelSapCollected.Visibility = Visibility.Hidden;
                LabelSyrupProd.Visibility = Visibility.Hidden;
                DateTxtBox.Visibility = Visibility.Hidden;
                ProducedTxtBox.Visibility = Visibility.Hidden;
                CollectedTxtBox.Visibility = Visibility.Hidden;
                ConfirmBtn.Visibility = Visibility.Hidden;
                CancelBtn.Visibility = Visibility.Hidden;
                NewEntryBtn.Visibility = Visibility.Visible;
                DataGrid.Margin = new Thickness(260, 263, 0, 0);
            }
            catch
            {
                MessageBox.Show("Invalid data entry.");
            }

        }

        //cancel button for the new entry
        private void Btn_Click_Cancel(object sender, RoutedEventArgs e)
        {
            DataGrid.Margin = new Thickness(260, 263, 0, 0);
            DateTxtBox.Text = "";
            ProducedTxtBox.Text = "";
            CollectedTxtBox.Text = "";
            LabelDate.Visibility = Visibility.Hidden;
            LabelSapCollected.Visibility = Visibility.Hidden;
            LabelSyrupProd.Visibility = Visibility.Hidden;
            DateTxtBox.Visibility = Visibility.Hidden;
            ProducedTxtBox.Visibility = Visibility.Hidden;
            CollectedTxtBox.Visibility = Visibility.Hidden;
            ConfirmBtn.Visibility = Visibility.Hidden;
            CancelBtn.Visibility = Visibility.Hidden;
            NewEntryBtn.Visibility = Visibility.Visible;
        }
    }
}
