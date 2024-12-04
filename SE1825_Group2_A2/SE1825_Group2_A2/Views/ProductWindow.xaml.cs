﻿using Microsoft.EntityFrameworkCore;
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
using SE1825_Group2_A2.Models;

namespace SE1825_Group2_A2
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        private IDBRepository _repository;
        public ProductWindow(IDBRepository dBRepository)
        {
            InitializeComponent();
            _repository = dBRepository;
            LoadDeafaaultData();
        }
        private void LoadDeafaaultData()
        {
            var products = _repository.Context.Set<Product>().ToList();
            lvProducts.ItemsSource = products;
            cbCategories.ItemsSource = _repository.Context.Set<Category>().ToList();
        }

        private async void CreateProduct(object sender, RoutedEventArgs e)
        {
            Category selectedCategory = cbCategories.SelectedItem as Category;
            var name = txtProductName.Text;
            var categoryId = selectedCategory.CategoryId;
            var price = txtUnitPrice.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            if ( !int.TryParse(price, out int UnitPriceParsed))
            {
                MessageBox.Show("Please enter valid number");
                return;
            }
            var product = new Product
            {
                ProductName = name,
                CategoryId = categoryId,
                UnitPrice = UnitPriceParsed
            };
            await _repository.AddAsync(product);
            await _repository.SaveChangesAsync();
            LoadDeafaaultData();
            MessageBox.Show("Add success");

        }

        private async void UpdateProduct(object sender, RoutedEventArgs e)
        {
            Category selectedCategory = cbCategories.SelectedItem as Category;
            var id = txtProductId.Text;
            var name = txtProductName.Text;
            var categoryId = selectedCategory.CategoryId;
            var price = txtUnitPrice.Text;
            if (string.IsNullOrEmpty(id) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(price))
            {
                MessageBox.Show("Please fill all fields");
                return;
            }
            if (!int.TryParse(id, out int IdParsed) || !int.TryParse(price, out int UnitPriceParsed))
            {
                MessageBox.Show("Please enter valid number");
                return;
            }
            //check product id exists
            var productExists = await _repository.Context.Set<Product>().Where(x => x.ProductId == IdParsed).FirstOrDefaultAsync();
            if (productExists == null)
            {
                MessageBox.Show("Product not Found");
                return;
            }
            productExists.ProductId = IdParsed;
            productExists.ProductName = name;
            productExists.CategoryId = categoryId;
            productExists.UnitPrice = UnitPriceParsed;
            await _repository.SaveChangesAsync();
            LoadDeafaaultData();
            MessageBox.Show("Update success");

            ClearForm();

        }

        private async void SearchProduct(object sender, RoutedEventArgs e)
        {
            var unitPrice = txtSearchUnitPrice.Text;
            var ProductName = txtSearchName.Text;
            if (!string.IsNullOrEmpty(unitPrice))
            {
                if (!int.TryParse(unitPrice, out int unitParsed))
                {
                    MessageBox.Show("Unit Price must be number");
                    return;
                }
            }
            IQueryable<Product> products = _repository.Context.Set<Product>();
            if (!string.IsNullOrEmpty(ProductName))
            {
                products = products.Where(x => x.ProductName.Contains(ProductName));
            }
            if (!string.IsNullOrEmpty(unitPrice))
            {
                products = products.Where(x => x.UnitPrice == int.Parse(unitPrice));
            }

            lvProducts.ItemsSource = await products.ToListAsync();
        }

        private async void DeleteProduct(object sender, RoutedEventArgs e)
        {
            var id = txtProductId.Text;

            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Please fill ProductId fields");
                return;
            }
            if (!int.TryParse(id, out int IdParsed))
            {
                MessageBox.Show("Please enter valid number");
                return;
            }
            // Check if the product exists
            var productExists = await _repository.Context.Set<Product>().Where(x => x.ProductId == IdParsed).FirstOrDefaultAsync();
            if (productExists == null)
            {
                MessageBox.Show("Product not Found");
                return;
            }

            // Show confirmation dialog
            var result = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Delete", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if (result == MessageBoxResult.Yes)
            {
                // Proceed with deletion
                _repository.Delete(productExists);
                await _repository.SaveChangesAsync();
                LoadDeafaaultData();
                MessageBox.Show("Delete success");
            }
        }

        private void lvProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedProduct = lvProducts.SelectedItem as Product;
            if (selectedProduct != null) {
                var category = selectedProduct.Category;
                cbCategories.SelectedItem = category;
            }
           
        }

        private void ClearForm()
        {
            lvProducts.SelectedItem = null;
            cbCategories.SelectedItem = null;
        }
    }
}
