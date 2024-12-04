using SE1825_GROUP2_PROJECT.Models;
using SE1852_GROUP2_PROJECT;
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

namespace SE1825_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for BorrowerWindow.xaml
    /// </summary>
    public partial class BorrowerWindow : Window
    {
        public User user { get; set; }
        public BorrowerWindow()
        {
            InitializeComponent();
        }

        private void AllBooks_Click(object sender, RoutedEventArgs e)
        {
            ListOfBooks win = new ListOfBooks();
            win.Show();
        }

        private void btnRecord_Click(object sender, RoutedEventArgs e)
        {
            Record win = new Record()
            {
                user = user,
            };
            win.Show();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow win = new LoginWindow();
            this.Close();
            win.Show();
        }
    }
}
