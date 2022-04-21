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
    /// Interaction logic for BookRentPage.xaml
    /// </summary>
    public partial class BookRentPage : Window
    {
        public BookRentPage()
        {
            InitializeComponent();
        }
        private void go_to_rent_page(object sender, RoutedEventArgs e)
        {
            RentPage rentPage = new RentPage();
            rentPage.Show();
            this.Close();
        }
        private void go_to_profile_page(object sender, RoutedEventArgs e)
        {
            HomePage homePage = new HomePage(); 
            homePage.Show();
            this.Close();
        }
    }
}
