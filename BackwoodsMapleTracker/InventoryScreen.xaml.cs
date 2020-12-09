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

namespace BackwoodsMapleTracker
{
    public partial class InventoryScreen : Window
    {
        Control control = new Control();
        public int pintBottlesAvail, halfPintBottlesAvail, quartBottlesAvail;
        public bool editMode;
        public InventoryScreen()
        {
            InitializeComponent();
            DisplayEmptyPintBottlesAvail();
            DisplayEmptyHalfPintBottlesAvail();
            DisplayEmptyQuartBottlesAvail();
            editMode = false;
        }

        //edits button for pints
        private void Btn_Click_Pints_Edit(object sender, RoutedEventArgs e)
        {
            if(editMode == false)
            {
                pintsEditTxtBox.Visibility = Visibility.Visible;
                pintsEditTxtBox.Text = pintBottlesAvail.ToString();
                pintsLabel.Visibility = Visibility.Hidden;
                EditPints.Content = "Confirm";
                EditPints.Width = 70;
                editMode = true;
            } else
            {
                try
                {
                    pintBottlesAvail = int.Parse(pintsEditTxtBox.Text);
                    pintsEditTxtBox.Visibility = Visibility.Hidden;
                    pintsLabel.Content = pintBottlesAvail.ToString();
                    pintsLabel.Visibility = Visibility.Visible;
                    EditPints.Content = "Edit";
                    EditPints.Width = 57;
                    editMode = false;
                }
                catch
                {
                    MessageBox.Show("Invalid data entry.  Must be a integer value.");
                }
            }
        }

        //edit button for quarts
        private void Btn_Click_Quarts_Edit(object sender, RoutedEventArgs e)
        {
            if (editMode == false)
            {
                quartsEditTxtBox.Visibility = Visibility.Visible;
                quartsEditTxtBox.Text = quartBottlesAvail.ToString();
                quartsLabel.Visibility = Visibility.Hidden;
                EditQuarts.Content = "Confirm";
                EditQuarts.Width = 70;
                editMode = true;
            }
            else
            {
                try
                {
                    quartBottlesAvail = int.Parse(quartsEditTxtBox.Text);
                    quartsEditTxtBox.Visibility = Visibility.Hidden;
                    quartsLabel.Content = quartBottlesAvail.ToString();
                    quartsLabel.Visibility = Visibility.Visible;
                    EditQuarts.Content = "Edit";
                    EditQuarts.Width = 57;
                    editMode = false;
                }
                catch
                {
                    MessageBox.Show("Invalid data entry.  Must be a integer value.");
                }
            }
        }

        //edit button for half pints
        private void Btn_Click_Half_Pints_Edit(object sender, RoutedEventArgs e)
        {
            if(editMode == false)
            {
                halfPintsEditTxtBox.Visibility = Visibility.Visible;
                halfPintsEditTxtBox.Text = halfPintBottlesAvail.ToString();
                halfPintsLabel.Visibility = Visibility.Hidden;
                EditHalfPints.Content = "Confirm";
                EditHalfPints.Width = 70;
                editMode = true;
            } else
            {
                try
                {
                    halfPintBottlesAvail = int.Parse(halfPintsEditTxtBox.Text);
                    halfPintsEditTxtBox.Visibility = Visibility.Hidden;
                    halfPintsLabel.Content = halfPintBottlesAvail.ToString();
                    halfPintsLabel.Visibility = Visibility.Visible;
                    EditHalfPints.Content = "Edit";
                    EditHalfPints.Width = 57;
                    editMode = false;
                }
                catch
                {
                    MessageBox.Show("Invalid data entry.  Must be a integer value.");
                }
            }
        }

        private void Btn_Click_Pints_Plus_12(object sender, RoutedEventArgs e)
        {
            pintBottlesAvail = pintBottlesAvail + 12;
            pintsLabel.Content = pintBottlesAvail;
        }

        private void Btn_Click_Pints_Plus_1(object sender, RoutedEventArgs e)
        {
            pintBottlesAvail++;
            pintsLabel.Content = pintBottlesAvail;
        }

        private void Btn_Click_Pints_Minus_1(object sender, RoutedEventArgs e)
        {
            pintBottlesAvail--;
            pintsLabel.Content = pintBottlesAvail;
        }

        private void Btn_Click_Quarts_Plus_12(object sender, RoutedEventArgs e)
        {
            quartBottlesAvail = quartBottlesAvail + 12;
            quartsLabel.Content = quartBottlesAvail;
        }

        private void Btn_Click_Quarts_Plus_1(object sender, RoutedEventArgs e)
        {
            quartBottlesAvail++;
            quartsLabel.Content = quartBottlesAvail;
        }

        private void Btn_Click_Quarts_Minus_1(object sender, RoutedEventArgs e)
        {
            quartBottlesAvail--;
            quartsLabel.Content = quartBottlesAvail;
        }

        private void Btn_Click_Half_Pints_Plus_12(object sender, RoutedEventArgs e)
        {
            halfPintBottlesAvail = halfPintBottlesAvail + 12;
            halfPintsLabel.Content = halfPintBottlesAvail;
        }

        private void Btn_Click_Half_Pints_Plus_1(object sender, RoutedEventArgs e)
        {
            halfPintBottlesAvail++;
            halfPintsLabel.Content = halfPintBottlesAvail;
        }

        private void Btn_Click_Half_Pints_Minus_1(object sender, RoutedEventArgs e)
        {
            halfPintBottlesAvail--;
            halfPintsLabel.Content = halfPintBottlesAvail;
        }

        //moves to production screen
        private void Btn_Click_Production(object sender, RoutedEventArgs e)
        {
            SetNewAvailValues();
            Production prod = new Production();
            prod.Show();
            this.Close();
        }

        //moves to financials screen
        private void Btn_Click_Financials(object sender, RoutedEventArgs e)
        {
            SetNewAvailValues();
            FinancialsScreen fin = new FinancialsScreen();
            fin.Show();
            this.Close();
        }

        //displays empty pint bottles avail
        private void DisplayEmptyPintBottlesAvail()
        {
            pintBottlesAvail = control.GetPintBottlesAvail();
            pintsLabel.Content = pintBottlesAvail;
        }

        //displays empty half pint bottles avail
        private void DisplayEmptyHalfPintBottlesAvail()
        {
            halfPintBottlesAvail = control.GetHalfPintBottlesAvail();
            halfPintsLabel.Content = halfPintBottlesAvail;
        }

        //displays empty quart bottles avail
        private void DisplayEmptyQuartBottlesAvail()
        {
            quartBottlesAvail = control.GetQuartBottlesAvail();
            quartsLabel.Content = quartBottlesAvail;
        }

        //sets all the new values of pints, half pints, and quarts back to control
        private void SetNewAvailValues()
        {
            control.SetHalfPintBottlesAvail(halfPintBottlesAvail);
            control.SetPintBottlesAvail(pintBottlesAvail);
            control.SetQuartBottlesAvail(quartBottlesAvail);
        }
    }
}
