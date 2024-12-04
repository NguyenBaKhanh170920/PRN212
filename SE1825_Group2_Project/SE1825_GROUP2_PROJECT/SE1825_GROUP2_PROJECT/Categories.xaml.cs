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

namespace SE1852_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for Categories.xaml
    /// </summary>
    public partial class Categories : Window
    {
        private Prn212ProjectContext con = new Prn212ProjectContext();
        public Categories()
        {
            InitializeComponent();
            loadlist();

        }

        public void loadlist()
        {
            lvCategory.ItemsSource = con.Categories.ToList();
        }

        private void btnRefresh_Click(object sender, RoutedEventArgs e)
        {
            clear();


        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {
                Category category = con.Categories.FirstOrDefault(p => p.Id == id);
                if (category != null)
                {
                    //DateOnly.TryParse(dpDob.SelectedDate.Value.ToString(), out DateOnly date);
                    category.Name = txtName.Text;


                    con.Categories.Update(category);
                    con.SaveChanges();
                    MessageBox.Show("Update thành công");
                    clear();
                    loadlist();


                }
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txtId.Text, out int id))
            {

                Category category = con.Categories.FirstOrDefault(p => p.Id == id);

                con.Categories.Remove(category);
                con.SaveChanges();
                MessageBox.Show("delete thành công");
                clear();
                loadlist();
            }
        }
        private void clear()
        {
            txtId.Text = "";
            txtName.Text = "";

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            Category category = new Category();
            category.Name = txtName.Text;

            con.Categories.Add(category);
            con.SaveChanges();
            MessageBox.Show("Add thành cổng", "alert", MessageBoxButton.OK, MessageBoxImage.Information);
            clear();
            loadlist();
        }

        private void lvCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lvCategory.SelectedItem is Category selected)
            {

                txtId.Text = selected.Id.ToString();
                txtName.Text = selected.Name;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SearchItems();
        }
        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                SearchItems();
            }
        }
        private void SearchItems()
        {
            String searchKeyword = txtKeyWord.Text;
            lvCategory.ItemsSource = con.Categories.Where(x => x.Name.Contains(searchKeyword.ToLower())).ToList();
        }
    }
}
