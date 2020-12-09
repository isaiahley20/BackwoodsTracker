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
    public partial class FinancialsScreen : Window
    {
        public SeriesCollection GraphLines { get; set; }
        public string[] Dates { get; set; }
        public Func<double, string> YFormatter { get; set; }

        Control control = new Control();
        public FinancialsScreen()
        {
            InitializeComponent();
            //gets the data to put into the data grid
            ObservableCollection<DailyCostRecord> dailyCostsList = control.GetDailyCostList();
            DataGrid.DataContext = dailyCostsList;

            //retrieves the values to be put into the chart
            DailyCostRecord oneDailyCostRecordForChart;
            var costRecordsYAxis = new ChartValues<double>();
            Dates = new string[dailyCostsList.Count()];
            double totalExpense = 0;
            for (int i = 0; i < dailyCostsList.Count(); i++)
            {
                oneDailyCostRecordForChart = dailyCostsList.ElementAt<DailyCostRecord>(i);
                totalExpense = totalExpense + oneDailyCostRecordForChart.cost;
                //gets the expense amount
                costRecordsYAxis.Add(totalExpense);
                //gets the date of the expense
                Dates[i] = oneDailyCostRecordForChart.date;
            }
            GraphLines = new SeriesCollection(){
                new LineSeries
                {
                    Title = "Cumulative Expenses",
                    Values = costRecordsYAxis
                }/*,
                new LineSeries
                {
                    Title = "profit",
                    Values = new ChartValues<double> { 6, 7, 3, 4, 6 },
                }*/
            };

            YFormatter = yAxisValues => yAxisValues.ToString("C");
            DataContext = this;
        }

        //moves to production screen
        private void Btn_Click_Production(object sender, RoutedEventArgs e)
        {
            Production productionScreen = new Production();
            productionScreen.Show();
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
            if(Chart.Visibility == Visibility.Visible)
            {
                Chart.Visibility = Visibility.Hidden;
                DataGrid.Margin = new Thickness(425, 70, 0, 0);
                DataGrid.Height = 320;
            } else
            {
                Chart.Visibility = Visibility.Visible;
                DataGrid.Margin = new Thickness(425, 263, 0, 0);
                DataGrid.Height = 132;
            }
        }

        //allows user to create new entry
        private void Btn_Click_New_Entry(object sender, RoutedEventArgs e)
        {
            LabelDate.Visibility = Visibility.Visible;
            LabelName.Visibility = Visibility.Visible;
            LabelCost.Visibility = Visibility.Visible;
            DateTxtBox.Visibility = Visibility.Visible;
            NameTxtBox.Visibility = Visibility.Visible;
            CostTxtBox.Visibility = Visibility.Visible;
            ConfirmBtn.Visibility = Visibility.Visible;
            CancelBtn.Visibility = Visibility.Visible;
            NewEntryBtn.Visibility = Visibility.Hidden;
            DataGrid.Margin = new Thickness(425, 263, 0, 0);
        }

        //confirm button for the new entry
        private void Btn_Click_Confirm(object sender, RoutedEventArgs e)
        {
            try
            {
                string newDate = DateTxtBox.Text;
                string newName = NameTxtBox.Text;
                double newCost = double.Parse(CostTxtBox.Text);
                if (newCost < 0)
                {
                    throw new Exception("Invalid Data.");
                }
                DailyCostRecord temp = new DailyCostRecord(newDate, newName, newCost);

                DateTxtBox.Text = "";
                NameTxtBox.Text = "";
                CostTxtBox.Text = "";
                LabelDate.Visibility = Visibility.Hidden;
                LabelName.Visibility = Visibility.Hidden;
                LabelCost.Visibility = Visibility.Hidden;
                DateTxtBox.Visibility = Visibility.Hidden;
                NameTxtBox.Visibility = Visibility.Hidden;
                CostTxtBox.Visibility = Visibility.Hidden;
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
            DateTxtBox.Text = "";
            NameTxtBox.Text = "";
            CostTxtBox.Text = "";
            LabelDate.Visibility = Visibility.Hidden;
            LabelName.Visibility = Visibility.Hidden;
            LabelCost.Visibility = Visibility.Hidden;
            DateTxtBox.Visibility = Visibility.Hidden;
            NameTxtBox.Visibility = Visibility.Hidden;
            CostTxtBox.Visibility = Visibility.Hidden;
            ConfirmBtn.Visibility = Visibility.Hidden;
            CancelBtn.Visibility = Visibility.Hidden;
            NewEntryBtn.Visibility = Visibility.Visible;
            DataGrid.Margin = new Thickness(260, 263, 0, 0);
        }
    }
}
