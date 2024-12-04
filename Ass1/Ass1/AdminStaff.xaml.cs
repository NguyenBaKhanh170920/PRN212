using Ass1.Models;
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

namespace Ass1
{
    /// <summary>
    /// Interaction logic for AdminStaff.xaml
    /// </summary>
    public partial class AdminStaff : Window
    {
        private readonly MyStoreContext context;
        public List<Staff> AllStaff;
        public AdminStaff()
        {
            InitializeComponent();
            this.DataContext = this;
            context = new MyStoreContext();
            LoadAllStaff();
        }
        public void LoadAllStaff()
        {
            using (var db = new MyStoreContext())
            {
                AllStaff = db.Staffs.ToList();//chuyen
                lvStaff.ItemsSource = AllStaff;
            }
        }

        private void txtStaffId_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("Name cannot be empty");
                return;
            }
            Staff staff = new Staff//them id
            {
                Name = txtStaffName.Text,
                Password = txtPassword.Text,
                Role = CheckRole(txtRole.Text)
            };

            context.Staffs.Add(staff);//chuyen
            context.SaveChanges();
            LoadAllStaff();
            MessageBox.Show("Staff added successfully");
            txtStaffName.Text = "";
            txtPassword.Text = "";
            txtRole.Text = "";
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffName.Text))
            {
                MessageBox.Show("Name can't empty");
                return;
            }
            try
            {
                Staff staff = context.Staffs.FirstOrDefault(x => x.StaffId == int.Parse(txtStaffId.Text));//chuyen
                if (staff != null)
                {
                    staff.Name = txtStaffName.Text;
                    staff.Password = txtPassword.Text;
                    staff.Role = CheckRole(txtRole.Text);
                    context.Staffs.Update(staff);//chuyen
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Update successful");
                        LoadAllStaff();
                        // Select the updated staff in the ListView
                        lvStaff.SelectedItem = staff;
                    }
                }
                else
                {
                    MessageBox.Show("Do not change ID of staff");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the staff: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStaffId.Text))
            {
                MessageBox.Show("Invalid staff ID");
                return;
            }
            try
            {
                Staff staff = context.Staffs.FirstOrDefault(x => x.StaffId == int.Parse(txtStaffId.Text));//chuyen
                if (staff != null)
                {
                    context.Staffs.Remove(staff);//chuyen
                    if (context.SaveChanges() > 0)
                    {
                        MessageBox.Show("Staff deleted successfully");
                        txtStaffName.Text = "";
                        txtPassword.Text = "";
                        txtRole.Text = "";
                    }
                    LoadAllStaff();
                }
                else
                {
                    MessageBox.Show("Staff does not exist");
                }
            }
            catch (System.Exception)
            {
                MessageBox.Show("Invalid staff ID");
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchText = txtSearchStaff.Text;
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter a staff name to search for.");
                return;
            }

            List<Staff> list = context.Staffs
                    .Where(x => x.Name.IndexOf(searchText) >= 0)
                    .ToList();

            if (list.Count > 0)
            {
                lvStaff.ItemsSource = list;
            }
            else
            {
                MessageBox.Show("No staff found.");
            }
        }

        private void lvStaff_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string role;
            if (lvStaff.SelectedItem is Staff selectedStaff)
            {
                txtStaffId.Text = selectedStaff.StaffId.ToString();
                txtStaffName.Text = selectedStaff.Name;
                txtPassword.Text = selectedStaff.Password;
                foreach (ComboBoxItem item in txtRole.Items)
                {
                    if (item.Tag.ToString() == selectedStaff.Role.ToString())
                    {
                       txtRole.SelectedItem = item;
                        break;
                    }
                }
            }
        }

        private void txtStaffName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtRole_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtSearchStaff_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private int CheckRole(string role)
        {
            if (role == "Admin")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
