using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class BookRentImpl : IBookRentInterface
    {
        public bool createBookRentDetails(BookRentRequestDo bookRentRequestDo)
        {
            string fileName = @"Files\BookRent.csv";
            string bookRentDetails = bookRentRequestDo.userId + "," + bookRentRequestDo.BookName + "," + bookRentRequestDo.IssueDate + "," + bookRentRequestDo.ReturnDate;
            File.AppendAllText(fileName, bookRentDetails);
            return true;
        }
    }
}
