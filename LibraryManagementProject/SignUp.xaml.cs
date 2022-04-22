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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        public SignUp()
        {
            InitializeComponent();
        }
        private void go_to_book_Detail_page(object sender, RoutedEventArgs e) 
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Close();
        }
        private void sign_up(object sender, RoutedEventArgs e)
        {
            UserRequestDo userReqDoObj=new UserRequestDo();
            userReqDoObj.UserName = User_Name.Text;
            userReqDoObj.UserEmail=Email_id.Text;
            userReqDoObj.UserPassWord=Pass_Word.Text;
            UserImpl userImpObj=new UserImpl();
            userImpObj.signUpUser(userReqDoObj);

        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
