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
using System.Xml.Linq;

namespace SE1825_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for ManageBook.xaml
    /// </summary>
    public partial class ManageBook : Window
    {
        private readonly Prn212ProjectContext _projectContext;

        public ManageBook()
        {
            _projectContext = new Prn212ProjectContext();
            InitializeComponent();
        }

        private void btnAdd(object sender, RoutedEventArgs e)
        {
            try
            {
                Book bok = GetUi();
                _projectContext.Books.Add(bok);
                _projectContext.SaveChanges();
                Load();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnEdit(object sender, RoutedEventArgs e)
        {
            try
            {
                Book bok = GetUi();
                bok.Id = int.Parse(txtBookId.Text);
                var old = _projectContext.Books.FirstOrDefault(x => x.Id == bok.Id);
                if(old != null)
                {
                    old.Title = bok.Title;
                    old.Price = bok.Price;
                    old.Quantity = bok.Quantity;
                    old.CategoryId = bok.CategoryId;
                    old.Publisher = bok.Publisher;
                    _projectContext.SaveChanges();
                    Load();
                    MessageBox.Show("Update successfully!");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete(object sender, RoutedEventArgs e)
        {
            //xoa het record-> xoa book
            var id= int.Parse(txtBookId.Text);
            var deleteRecord = _projectContext.BorrowRecords.Where(x => x.BookId == id);
            if (deleteRecord.Any())
            {
                _projectContext.RemoveRange(deleteRecord);
            }
            var deleteBook= _projectContext.Books.FirstOrDefault(x=>x.Id == id);
            _projectContext.Remove(deleteBook);
            _projectContext.SaveChanges();
            MessageBox.Show("Delete successfully!");
            Load();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }
        void Load()
        {
            var allBook = _projectContext.Books.Include(x => x.Category).ToList();
            lvData.ItemsSource = null;
            lvData.ItemsSource = allBook;

            var allCate=_projectContext.Categories.ToList();
            cbCate.ItemsSource = allCate;
            cbCate.DisplayMemberPath = "Name";
            cbCate.SelectedValuePath = "Id";
        }
        Book GetUi()
        {
            try
            {
                Book bok = new Book();
                bok.Title = txtTitle.Text;
                bok.Quantity = int.Parse(txtQuantity.Text);
                bok.Publisher = txtPub.Text;
                bok.Price = int.Parse(txtPrice.Text);
                bok.CategoryId = int.Parse(cbCate.SelectedValue.ToString());
                return bok;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        private void lvData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(lvData.SelectedItem is Book selected)
            {
                txtBookId.Text = selected.Id.ToString();
                txtTitle.Text = selected.Title.ToString();
                txtQuantity.Text = selected.Quantity.ToString();
                txtPub.Text= selected.Publisher.ToString();
                txtPrice.Text = selected.Price.ToString();
            }
        }
    }
}
