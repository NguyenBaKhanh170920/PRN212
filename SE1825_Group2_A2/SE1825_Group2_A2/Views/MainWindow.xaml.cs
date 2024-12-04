﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SE1825_Group2_A2.Common;
using SE1825_Group2_A2.Models;
using SE1825_Group2_A2.Services;
using SE1825_Group2_A2.State;
using SE1825_Group2_A2.Views;

namespace SE1825_Group2_A2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IDBRepository _repository;
        private readonly IAuthenticator _authenticator;
        private readonly IStaffServices _staffServices;
        private bool isShow = false;
        public MainWindow(IDBRepository repository, IAuthenticator authenticator, IStaffServices staffServices)
        {
            InitializeComponent();
            _repository = repository;
            _authenticator = authenticator;

            gridDetails.Visibility = Visibility.Hidden;
            _staffServices = staffServices;
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);

            if (App.AccountStore == null)
            {
                //Login login = new Login(_authenticator, _repository);
                //login.ShowDialog();
            }
            else
            {
                tbUsername.Text = App.AccountStore.Username;
                tbRole.Text = (App.AccountStore.role == 1) ? StaffRole.Admin.ToString() : StaffRole.Staff.ToString();
                gridDetails.Visibility = Visibility.Visible;
            }
        }
        protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
        {
            base.OnPropertyChanged(e);
        }
        protected override void OnClosed(EventArgs e)
        {
            App.AccountStore = null;
            gridDetails.Visibility = Visibility.Hidden;
            base.OnClosed(e);
        }

        private void Report_Click(object sender, RoutedEventArgs e)
        {
            Report report = new Report(_repository);
            report.ShowDialog();

        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            if (App.AccountStore.role == (int)StaffRole.Admin)
            {
                ProductWindow productWindow = new ProductWindow(_repository);

                productWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature");
                return;
            }
        }

        private void btnAddOrders_Click(object sender, RoutedEventArgs e)
        {
            if (App.AccountStore.role == (int)StaffRole.Admin)
            {
                OrderWindow orderWindow = new OrderWindow(_repository);

                orderWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature.");
            }
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            App.AccountStore = null;
            Login login = new Login(_authenticator, _repository, _staffServices);
            login.Show();
            this.Close();
        }

        private void btnStaff_Click(object sender, RoutedEventArgs e)
        {
            if (App.AccountStore.role != (int)StaffRole.Admin)
            {
                StaffWindow staffWindow = new StaffWindow();

                staffWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature.");
            }
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            if (App.AccountStore.role != (int)StaffRole.Admin)
            {
                ProductWindow productWindow = new ProductWindow(_repository);

                productWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature");
                return;
            }
        }

        private void btnChangePass_Click(object sender, RoutedEventArgs e)
        {
            isShow = !isShow;
            if (isShow)
            {
                spChangePass.Visibility = Visibility.Visible;
            }
            else
            {
                spChangePass.Visibility = Visibility.Hidden;

            }
        }

        private void btnOrder_Click(object sender, RoutedEventArgs e)
        {
            if (App.AccountStore.role == (int)StaffRole.Admin)
            {
                OrderWindow orderWindow = new OrderWindow(_repository);
                orderWindow.ShowDialog();
            }
            else
            {
                MessageBox.Show("You do not have permission to access this feature");
                return;
            }
        }
        private async void btnConfirmChangePass_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPass.Text) || string.IsNullOrEmpty(tbConfirm.Text))
            {
                MessageBox.Show("Can not empty");
            }

            var confirmChange = MessageBox.Show("Change Password ?", "Change Password", MessageBoxButton.YesNo);
            if (confirmChange == MessageBoxResult.Yes)
            {
                var result = await _authenticator.ChangePass(tbPass.Text, tbConfirm.Text);
                if (result)
                {
                    MessageBox.Show("Successfully!");
                    tbPass.Text = tbConfirm.Text = "";
                    spChangePass.Visibility = Visibility.Hidden;
                }
                else
                {
                    MessageBox.Show("Can't change, try again!");
                }
            }
        }
    }
}