using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMS.Entities
{
    public class BookResponseDo
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public DateTime IssuedDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int ISBNNumber { get; set; }
        public string BookType { get; set; }

        public BookResponseDo(int bookId,string bookName,string authorName,System.DateTime issuedDate,System.DateTime returnDate,int isbnNumber,string status,string bookType) {
            BookId = bookId;
            BookName = bookName;
            AuthorName = authorName;
            IssuedDate = issuedDate;
            ReturnDate = returnDate;
            ISBNNumber = isbnNumber;
            BookType = bookType;
        }

        public BookResponseDo() { }

 
    }

}
