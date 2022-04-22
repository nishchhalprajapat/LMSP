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
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void go_to_MyRentprofile_page(object sender, RoutedEventArgs e)
        {
            BookRentPage bookRentPage = new BookRentPage();
            bookRentPage.Show();
            this.Close();
        }
        private void go_to_rent_page(object sender, RoutedEventArgs e)
        {
            RentPage rentPage = new RentPage();
            rentPage.Show();
            this.Close();
        }
        private void go_to_signin_page(object sender, RoutedEventArgs e)
        {
            Login login=new Login();
            login.Show();
            this.Close();
        }
        private void Rent_Book_Btn(object sender, RoutedEventArgs e)
        {
            RentPage bookRentPage = new RentPage();
            bookRentPage.Show();
        }
        private void Filter_Btn(object sender, RoutedEventArgs e)
        {
            List<string> filters = new List<string>();
            if (FictionBooks.IsChecked==true)
            {
                filters.Add(FictionBooks.Name);
            }
            if (NonFictionBooks.IsChecked == false)
            {
                filters.Add(NonFictionBooks.Name);
            }
        }
        private void Search_Btn(object sender, RoutedEventArgs e)
        {
            string searchText=SearchBar.Text;
            searchText = searchText.Trim();
            searchText = searchText.ToLower();
            CommonFeatureImpl  commonFeatureImpl = new CommonFeatureImpl();
            BookResponseDo bookDetails=commonFeatureImpl.searchBar(searchText);
        }
    }
}
