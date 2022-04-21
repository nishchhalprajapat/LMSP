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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void My_Rent_Btn(object sender, RoutedEventArgs e)
        {
            BookRentPage bookRentPage = new BookRentPage();
            bookRentPage.Show();
        }
        private void Rent_Book_Btn(object sender, RoutedEventArgs e)
        {
            RentPage bookRentPage = new RentPage();
            bookRentPage.ShowDialog();
        }
    }
}
