using SE1825_FirstWPF.Models;
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
    /// Interaction logic for CategoryWindow.xaml
    /// </summary>
    public partial class CategoryWindow : Window
    {
        MyStockContext context;
        public CategoryWindow()
        {
            InitializeComponent();
            context = new MyStockContext();
            context.Categories.Add(new Category { CategoryId = 1, CategoryName = "Fruit" });
            context.Categories.Add(new Category { CategoryId = 2, CategoryName = "Meat" });

            context.SaveChanges();

            lsCategory.ItemsSource = context.Categories.ToList();
        }

        private void lsCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Category category = lsCategory.SelectedItem as Category;
            if (category == null) return;

            txtCategoryId.Text = category.CategoryId.ToString();
            txtCategoryName.Text = category.CategoryName;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Category category = new Category
                {
                    CategoryId = int.Parse(txtCategoryId.Text),
                    CategoryName = txtCategoryName.Text
                };

                context.Categories.Add(category);
                context.SaveChanges();


                MessageBox.Show("Added!");
                lsCategory.ItemsSource = context.Categories.ToList();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Category category = lsCategory.SelectedItem as Category;
            if (category == null) return;
            
            try
            {
                category = context.Categories.Find(int.Parse(txtCategoryId.Text));
                category.CategoryName = txtCategoryName.Text;

                context.Categories.Update(category);
                context.SaveChanges();

                MessageBox.Show("Edited!");
                lsCategory.ItemsSource = context.Categories.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            Category category = lsCategory.SelectedItem as Category;
            if (category == null) return;
            var dr = MessageBox.Show("Ypu want to delete?", "Confirm", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (dr == MessageBoxResult.No) return;

            try
            {
                category = context.Categories.Find(int.Parse(txtCategoryId.Text));
            
                context.Categories.Remove(category);
                context.SaveChanges();

                MessageBox.Show("Edited!");
                
                lsCategory.ItemsSource = context.Categories.ToList();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
