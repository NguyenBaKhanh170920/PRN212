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
    /// Interaction logic for ProductManagement.xaml
    /// </summary>
    public partial class ProductManagement : Window
    {
        MyStockContext context;
        public ProductManagement()
        {
            InitializeComponent();
            context = new MyStockContext();
            Product product1 = new Product
            {
                ProductId = 1,
                ProductName = "San pham 1",
                CategoryId = 1,
                UnitPrice = 1,

            };
            context.Products.Add(product1);
            Product product2 = new Product
            {
                ProductId = 2,
                ProductName = "San pham 2",
                CategoryId = 2,
                UnitPrice = 2,

            };
            context.Products.Add(product2);
            context.SaveChanges();
            lsProduct.ItemsSource = context.Products.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int productId = int.Parse(txtProductId.Text);
                if (context.Products.Any(p => p.ProductId == productId))
                {
                    MessageBox.Show("Product with the same ID already exists!");
                    return;
                }
                Product Product = new Product
                {
                    ProductId = int.Parse(txtProductId.Text),
                    ProductName = txtProductName.Text,
                    CategoryId = int.Parse(txtCategoryId.Text),
                    UnitPrice = int.Parse(txtUnitPrice.Text),
                };

                context.Products.Add(Product);
                context.SaveChanges();
                MessageBox.Show("Added!");
                lsProduct.ItemsSource = context.Products.OrderBy(x => x.ProductId).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            int ProductId = int.Parse(txtProductId.Text);
            Product Product = context.Products.Find(ProductId);
            Product.ProductName = txtProductName.Text;
            Product.CategoryId = int.Parse(txtCategoryId.Text);
            Product.UnitPrice = int.Parse(txtUnitPrice.Text);
            try
            {
                context.Products.Update(Product);
                context.SaveChanges();
                MessageBox.Show("Updated!");
                lsProduct.ItemsSource = context.Products.OrderBy(x => x.ProductId).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            int ProductId = int.Parse(txtProductId.Text);
            Product Product = context.Products.Find(ProductId);
            try
            {

                context.Products.Remove(Product);
                context.SaveChanges();
                MessageBox.Show("Deleted!");
                lsProduct.ItemsSource = context.Products.OrderBy(x => x.ProductId).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string searchProductName = txtSearchProductName.Text.Trim();
            string searchUnitPriceText = txtSearchUnitPrice.Text.Trim();

            decimal searchUnitPrice;
            bool isUnitPriceValid = decimal.TryParse(searchUnitPriceText, out searchUnitPrice);

            var filteredProducts = context.Products.Where(p =>
                (string.IsNullOrEmpty(searchProductName) || p.ProductName.Contains(searchProductName, StringComparison.OrdinalIgnoreCase)) &&
                (string.IsNullOrEmpty(searchUnitPriceText) || (isUnitPriceValid && p.UnitPrice == searchUnitPrice))
            ).ToList();

            lsProduct.ItemsSource = filteredProducts;
        }
    }
}
