using LibraryManagementProject.LibraryMs.InterfaceImpl;
using LibraryManagementProject.LibraryMS.Entities;
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

namespace LibraryManagementProject
{
    /// <summary>
    /// Interaction logic for RentPage.xaml
    /// </summary>
    public partial class RentPage : Window
    {
        public RentPage()
        {
            InitializeComponent();
        }

        
        public void Rent_Book(object sender, RoutedEventArgs e)
        {
            BookRentRequestDo bookRentDetails = new BookRentRequestDo();
            bookRentDetails.BookName = RentBookName.Text;
            bookRentDetails.IssueDate = RentIssuedDate.Text;
            bookRentDetails.ReturnDate = RentReturnDate.Text;
            bookRentDetails.Status = "Not Return";
            MessageBox.Show("new");
            BookRentImpl bookRentImpl = new BookRentImpl(); 
           bool result= bookRentImpl.createBookRentDetails(bookRentDetails);
            BrandName.Content = result;
            MessageBox.Show("new");
        }
    }
}
