using SE1825_GROUP2_PROJECT.Models;
using SE1852_GROUP2_PROJECT;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SE1825_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public User user { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AllBooks_Click(object sender, RoutedEventArgs e)
        {
            ListOfBooks win= new ListOfBooks();
            win.Show();
        }

        private void btnBook_Click(object sender, RoutedEventArgs e)
        {
            ManageBook win = new ManageBook();
            win.Show();
        }

        private void btnUser_Click(object sender, RoutedEventArgs e)
        {
            ManageUser win = new ManageUser();
            win.Show();
        }

        private void btncate_Click(object sender, RoutedEventArgs e)
        {
            Categories win = new Categories();
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbUsername.Text="Username: "+user.FullName;
            tbAddress.Text="Address: "+user.Address;
            if (user.Role == 0)
            {
                tbRole.Text ="Role: Admin";
            }
            else
            {
                tbRole.Text = "Role: Borrower";
            }
        }
    }
}