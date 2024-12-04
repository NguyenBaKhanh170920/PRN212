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

namespace SE1825_FirstWPF
{
    /// <summary>
    /// Interaction logic for DockPanelWindow.xaml
    /// </summary>
    public partial class DockPanelWindow : Window
    {
        public DockPanelWindow()
        {
            InitializeComponent();
        }

        private void mnuShow_Click(object sender, RoutedEventArgs e)
        {
            CategoryWindow categoryWindow = new CategoryWindow();
            categoryWindow.ShowDialog();
        }

        private void mnuClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void mnuProduct_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuStaff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuOrder_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuProfile_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mnuLogin_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Activated(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Settings.Name))
            {
                mnuLogin.Header = "Login";
                mnuProduct.IsEnabled = false;
                mnuStaff.IsEnabled = false;
                mnuOrder.IsEnabled = false;
                mnuProfile.IsEnabled = false;
                mnuReport.IsEnabled = false;
            }
            else
            {
                mnuLogin.Header = $"Logout({Settings.Name})";
                if(Settings.Role == 1)
                {
                    mnuProduct.IsEnabled = true;
                    mnuStaff.IsEnabled = true;
                    mnuOrder.IsEnabled = false;
                    mnuProfile.IsEnabled = true;
                    mnuReport.IsEnabled = true;
                }
                else
                {
                    mnuProduct.IsEnabled = false;
                    mnuStaff.IsEnabled = false;
                    mnuOrder.IsEnabled = true;
                    mnuProfile.IsEnabled = true;
                    mnuReport.IsEnabled = true;


                }
            }

            
        }
    }
}
