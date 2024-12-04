using Microsoft.EntityFrameworkCore;
using SE1825_GROUP2_PROJECT.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SE1825_GROUP2_PROJECT
{
    /// <summary>
    /// Interaction logic for Record.xaml
    /// </summary>
    public partial class Record : Window
    {
        public User user { get; set; }
        private readonly Prn212ProjectContext _context;

        public event PropertyChangedEventHandler? PropertyChanged;

        public Record()
        {
            _context = new Prn212ProjectContext();
            InitializeComponent();
        }

        private void btnAddToList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnRequest(object sender, RoutedEventArgs e)
        {
            try
            {
                BorrowRecord record = new BorrowRecord();
                record.BorrowerId = user.Id;
                record.BookId = int.Parse(cbBookRequest.SelectedValue.ToString());
                record.StartDate = DateTime.Now;
                record.EndDate = dpEnd_date.SelectedDate;
                record.Quantity = int.Parse(txtQuantity.Text);
                record.Status = "Borrowing";

                if (record.StartDate >= (DateTime)record.EndDate)
                {
                    MessageBox.Show("End date cant be earlier than start date");
                    return;
                }
                var book = _context.Books.FirstOrDefault(x => x.Id == record.BookId);
                if (book != null)
                {
                    if (record.Quantity <= book.Quantity)
                    {
                        book.Quantity -= record.Quantity;
                        _context.Add(record);
                        _context.SaveChanges();
                        Load();
                    }
                    else
                    {
                        MessageBox.Show("Not enoungh copy, please check your quantity");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReturn(object sender, RoutedEventArgs e)
        {
            try
            {
                var id = int.Parse(cbBookReturn.SelectedValue.ToString());
                //tim record theo userId co book id = id, chuyen trang thai
                var bookRe = _context.BorrowRecords.Where(x => x.BorrowerId == user.Id).ToList();//doi thanh user id
                if (bookRe.Count() == 0)
                {
                    MessageBox.Show("No borrow record found for the selected book.");
                    return;
                }
                foreach (var record in bookRe)
                {
                    if (record.BookId == id && record.Status == "Borrowing")
                    {
                        record.ReturnDate = DateTime.Now;
                        if ((DateTime)record.EndDate <= DateTime.Now)
                        {
                            record.Status = "Late";
                        }
                        else
                        {
                            record.Status = "In time";
                        }
                        var book=_context.Books.FirstOrDefault(x=>x.Id == id);
                        if (book != null)
                        {
                            book.Quantity += record.Quantity;
                        }
                        _context.SaveChanges();
                        Load();
                        MessageBox.Show("Return book complete");
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lvData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }
        void Load()
        {
            var list = _context.BorrowRecords.Include(x => x.Borrower).Include(x => x.Book).Where(x=>x.BorrowerId==user.Id).ToList();
            lvData.ItemsSource = null;
            lvData.ItemsSource = list;

            var allBook = _context.Books.ToList();
            cbBookRequest.ItemsSource = allBook;
            cbBookRequest.DisplayMemberPath = "Title";
            cbBookRequest.SelectedValuePath = "Id";

            txtStart_date.Text = DateTime.Now.ToString("MM/dd/yyyy");

            var returnBook = _context.BorrowRecords
    .Include(x => x.Book)
    .Where(x => x.BorrowerId == user.Id && x.Status == "Borrowing")
    .GroupBy(x => x.BookId)
    .Select(g => g.First()) 
    .ToList();

            cbBookReturn.ItemsSource = returnBook;
            cbBookReturn.DisplayMemberPath = "Book.Title";
            cbBookReturn.SelectedValuePath = "BookId";
        }
        private void Cb_OnPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            cbBookRequest.IsDropDownOpen = true;
        }

    }
}
