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
using SE1825_Group2_A2.Common;
using SE1825_Group2_A2.Services;
using SE1825_Group2_A2.State;

namespace SE1825_Group2_A2.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly IAuthenticator _authenticator;
        private readonly IDBRepository _repository;
        private readonly IStaffServices _staffServices;

        public Login(IAuthenticator authenticator, IDBRepository dBRepository, IStaffServices staffServices)
        {
            InitializeComponent();
            _authenticator = authenticator;
            _repository = dBRepository;
            _staffServices = staffServices;
        }

        private async void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            var result = await _authenticator.Login(txtUsername.Text, txtPassword.Password.ToString());
            if(result)
            {
                MainWindow mainWindow = new MainWindow(_repository, _authenticator, _staffServices);
                mainWindow.Show();
                this.Close();
            }else
            {
            }
            btnLogin.IsEnabled = true;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
        }
    }
}
