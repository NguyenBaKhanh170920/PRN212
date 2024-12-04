
using Microsoft.EntityFrameworkCore;
using Question2.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Question2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly PePrn24sumB1Context _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new PePrn24sumB1Context();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            Course c=new Course();
            c.CourseId=int.Parse(txtId.Text);
            var old=_context.Courses.FirstOrDefault(x=>x.CourseId==c.CourseId);
            old.Title=txtTitle.Text;
            old.Description=txtDescription.Text;
            old.InstructorId = int.Parse(cbIntr.SelectedValue.ToString());
            if (old!=null)
            {
                _context.Courses.Update(old);
                _context.SaveChanges();
                var id = int.Parse(cbUser.SelectedValue.ToString());
                var listData = _context.Enrollments.Include(x => x.Course).ThenInclude(x => x.Instructor).Where(x => x.UserId == id).ToList();
                lvData.ItemsSource = null;
                lvData.ItemsSource = listData;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var listUser = _context.Users.ToList();
            cbUser.ItemsSource = listUser;
            cbUser.DisplayMemberPath = "Username";
            cbUser.SelectedValuePath = "UserId";
            cbUser.SelectedIndex = 0;
            var listIntr=_context.Instructors.ToList();
            cbIntr.ItemsSource = listIntr;
            cbIntr.DisplayMemberPath = "Name";
            cbIntr.SelectedValuePath= "InstructorId";
            cbIntr.SelectedIndex = 0;
            var id = int.Parse(cbUser.SelectedValue.ToString());
            var listData=_context.Enrollments.Include(x=>x.Course).ThenInclude(x=>x.Instructor).Where(x=>x.UserId==id).ToList();
            lvData.ItemsSource = listData;
        }

        private void cbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var id = int.Parse(cbUser.SelectedValue.ToString());
            var listData = _context.Enrollments.Include(x => x.Course).ThenInclude(x => x.Instructor).Where(x => x.UserId == id).ToList();
            lvData.ItemsSource = null;
            lvData.ItemsSource = listData;
        }
    }
}