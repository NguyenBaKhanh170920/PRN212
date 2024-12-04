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
    public class UserViewModel
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Role { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
    }
    public partial class ManageUser : Window
    {
        public ManageUser()
        {
            InitializeComponent();
            load();
        }
        private void load()
        {
            using (var context = new Prn212ProjectContext())
            {
                var books = from b in context.Users
                            select new
                            {
                                UserID = b.Id,
                                UserName = b.FullName,
                                Role = b.Role,
                                Password = b.Password,
                                Address = b.Address
                            };

                UserList.ItemsSource = books.ToList();
            }
        }
        private void loadByName(String name)
        {
            using (var context = new Prn212ProjectContext())
            {
                var books = from b in context.Users
                            where b.FullName.Contains(name)
                            select new
                            {
                                UserID = b.Id,
                                UserName = b.FullName,
                                Role = b.Role,
                                Password = b.Password,
                                Address = b.Address
                            };

                UserList.ItemsSource = books.ToList();
            }
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void UserList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (UserList.SelectedItem != null)
            {
                dynamic selectedUser = UserList.SelectedItem;
                useridTxt.Content = selectedUser.UserID.ToString();
                fullnameTxt.Text = selectedUser.UserName.ToString();
                roleTxt.Text = selectedUser.Role.ToString();
                passwordTxt.Text = selectedUser.Password.ToString();
                addressTxt.Text = selectedUser.Address.ToString();

            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String name = nameTxt.Text.Trim();
            loadByName(name);

        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            using (var context = new Prn212ProjectContext())
            {

                Models.User u = new Models.User
                {
                    Role = int.Parse(roleTxt.Text.ToString()),
                    FullName = fullnameTxt.Text,
                    Password = passwordTxt.Text,
                    Address = addressTxt.Text
                };

                context.Users.Add(u);
                context.SaveChanges();
                load();
            }

        }

        private void editbtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(useridTxt.Content.ToString());
            int role = int.Parse(roleTxt.Text.ToString());
            String name = fullnameTxt.Text;
            String pass = passwordTxt.Text;
            String address = addressTxt.Text;
            using (var context = new Prn212ProjectContext())
            {

                Models.User u = context.Users.FirstOrDefault(u => u.Id == id);
                u.Role = role;
                u.Address = address;
                u.Password = pass;
                u.FullName = name;

                context.SaveChanges();
                load();
            }
        }

        private void removebtn_Click(object sender, RoutedEventArgs e)
        {
            int id = int.Parse(useridTxt.Content.ToString());

            using (var context = new Prn212ProjectContext())
            {

                Models.User u = context.Users.FirstOrDefault(u => u.Id == id);

                context.Users.Remove(u);
                context.SaveChanges();
                load();
            }
        }
    }
}
