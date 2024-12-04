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
using static System.Reflection.Metadata.BlobBuilder;

namespace SE1852_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for ListOfBooks.xaml
    /// </summary>
    public partial class ListOfBooks : Window
    {
        private Prn212ProjectContext con = new Prn212ProjectContext();
        public ListOfBooks()
        {
            InitializeComponent();
            Loadlist();
        }

        public void Loadlist()
        {
            //lvBook.ItemsSource = con.Books.
            //    Join(con.Books, BookCate => BookCate.CategoryId,
            //    Cate => Cate.CategoryId,
            //    (BookCate, Cate) => new { Book = BookCate, Categories = Cate}).ToList();

            var books = con.Books.ToList();
            var categories = con.Categories.ToList();

            lvBook.ItemsSource = from book in books
                                         join category in categories on book.CategoryId equals category.Id
                                         select new
                                         {
                                             Id = book.Id,
                                             Title = book.Title,
                                             Quantity = book.Quantity,
                                             Publisher = book.Publisher,
                                             Price = book.Price,
                                             CategoryName = category.Name
                                         }   ;
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            var books = con.Books.ToList();
            var categories = con.Categories.ToList();
            if (e.Key == Key.Enter)
            {
                String searchKeyword = txtKeyword.Text;
                if (rbCategory.IsChecked==true)
                {
                    lvBook.ItemsSource = from book in books
                                         join category in categories on book.CategoryId equals category.Id
                                         where category.Name.ToLower().Contains(searchKeyword.ToLower())
                                         select new
                                         {
                                             Id = book.Id,
                                             Title = book.Title,
                                             Quantity = book.Quantity,
                                             Publisher = book.Publisher,
                                             Price = book.Price,
                                             CategoryName = category.Name
                                         };
                }
                else if (rbPrice.IsChecked == true)
                {
                    lvBook.ItemsSource = from book in books
                                         join category in categories on book.CategoryId equals category.Id
                                         where book.Price.ToString().Contains(searchKeyword)
                                         select new
                                         {
                                             Id = book.Id,
                                             Title = book.Title,
                                             Quantity = book.Quantity,
                                             Publisher = book.Publisher,
                                             Price = book.Price,
                                             CategoryName = category.Name
                                         };
                }
                else if (rbPublisher.IsChecked == true)
                {
                    lvBook.ItemsSource = from book in books
                                         join category in categories on book.CategoryId equals category.Id
                                         where book.Publisher.ToLower().Contains(searchKeyword.ToLower())
                                         select new
                                         {
                                             Id = book.Id,
                                             Title = book.Title,
                                             Quantity = book.Quantity,
                                             Publisher = book.Publisher,
                                             Price = book.Price,
                                             CategoryName = category.Name
                                         };
                }
                else if (rbtitle.IsChecked == true)
                {
                    lvBook.ItemsSource = from book in books
                                         join category in categories on book.CategoryId equals category.Id
                                         where book.Title.ToLower().Contains(searchKeyword.ToLower())
                                         select new
                                         {
                                             Id = book.Id,
                                             Title = book.Title,
                                             Quantity = book.Quantity,
                                             Publisher = book.Publisher,
                                             Price = book.Price,
                                             CategoryName = category.Name
                                         };
                }
            }
        }
    }
}
