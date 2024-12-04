using Microsoft.EntityFrameworkCore;
using SE1825_GROUP2_PROJECT.Models;
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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        private readonly Prn212ProjectContext _projectContext;
        User user;
        public LoginWindow()
        {
            _projectContext = new Prn212ProjectContext();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string name = txtName.Text;
            string password = txtPassword.Password.ToString();
            var login = _projectContext.Users.FirstOrDefault(s => s.FullName == name);
            if (login != null)
            {
                if (login.Password == password)
                {
                    if (login.Role == 0)
                    {
                        MainWindow staffWindow = new MainWindow()
                        {
                            user = login
                        };
                        staffWindow.Show();
                    }
                    else
                    {
                        BorrowerWindow borrowerWindow = new BorrowerWindow()
                        {
                            user = login
                        };
                        borrowerWindow.Show();
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong password");
                }
            }
            else
            {
                MessageBox.Show("User not found");
            }
        }
    }
}
