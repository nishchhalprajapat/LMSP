using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class BookImpl : IBookInterface
    {
        
        public List<BookResponseDo> getbookDetails()
        {
            List<BookResponseDo> bookList = new List<BookResponseDo>();
            string path = @"C:\Users\Bhawna Rathor\Desktop\LibBookData.csv";
            string[] part=System.IO.File.ReadAllLines(path);
            foreach (string line in part)
            {
                string[] parts = line.Split(",");
                foreach(string s in parts)
                {
                    BookResponseDo bookobj=new BookResponseDo();
                    bookobj.BookId = Convert.ToInt32(s[0]);
                    bookobj.BookName = Convert.ToString(s[1]);
                    bookobj.AuthorName = Convert.ToString(s[2]);
                    bookobj.IssuedDate = Convert.ToDateTime(s[3]);
                    bookobj.ReturnDate = Convert.ToDateTime(s[4]);
                    bookobj.ISBNNumber = Convert.ToInt32(s[5]);
                    bookobj.Status=Convert.ToString(s[6]);
                    bookobj.BookType = Convert.ToString(s[7]);
                    bookList.Add(bookobj);
                }
            }
            return bookList;

        }
        
    }
}
