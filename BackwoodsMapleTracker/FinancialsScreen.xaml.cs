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
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace BackwoodsMapleTracker
{
    /// <summary>
    /// Interaction logic for FinancialsScreen.xaml
    /// </summary>
    public partial class FinancialsScreen : Window
    {
        public FinancialsScreen()
        {
            InitializeComponent();

            DailyCostRecord test = new DailyCostRecord("10/11/2020", "Liquid Propane", 150.57);
            DailyCostRecord test1 = new DailyCostRecord("10/12/2020", "Jars", 32.78);
            //gets the data to put into the data grid
            ObservableCollection<DailyCostRecord> syrupData = new ObservableCollection<DailyCostRecord>();
            syrupData.Add(test);
            syrupData.Add(test1);
            DataGrid.DataContext = syrupData;


            
            SeriesCollection = new SeriesCollection(){
                new LineSeries
                {
                    Title = "Profits",
                    Values = new ChartValues<double> { 5, 10, 15 }
                }/*,
                new LineSeries
                {
                    Title = "Series 2",
                    Values = new ChartValues<double> { 6, 7, 3, 4, 6 },
                    PointGeometry = null
                },
                new LineSeries
                {
                    Title = "Series 3",
                    Values = new ChartValues<double> { 4, 2, 7, 2, 7 },
                    PointGeometry = DefaultGeometries.Square,
                    PointGeometrySize = 15
                }*/
            };
            Labels = new[] { "10/11/2020", "10/12/2020", "10/13/2020", "10/14/2020" };
            YFormatter = value => value.ToString("N");
            //YFormatter = value => value.ToString("C"); for currency
            LineSeries temp = new LineSeries
            {
                Title = "Profits",
                Values = new ChartValues<double> { 0.01, 0.011, 0.012, 0.013, 0.014 },
                PointGeometrySize = 15
            };
            //something.Add(temp);
            //modifying the series collection will animate and update the chart
            /*SeriesCollection.Add(new LineSeries
            {
                Title = "Series 4",
                Values = new ChartValues<double> { 5, 3, 2, 4 },
                LineSmoothness = 0, //0: straight lines, 1: really smooth lines
                PointGeometry = Geometry.Parse("m 25 70.36218 20 -28 -20 22 -8 -6 z"),
                PointGeometrySize = 50,
                PointForeground = Brushes.Gray
            });*/

            //modifying any series values will also animate and update the chart
            SeriesCollection[0].Values.Add(20d);
            DataContext = this;
        }
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }

        private void Btn_Click_Production(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_Financials(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_Inventory(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_New_Entry(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Click_Toggle(object sender, RoutedEventArgs e)
        {

        }
    }
}
