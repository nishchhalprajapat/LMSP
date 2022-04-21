using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class CommonFeatureImpl : ICommonFeatureInterface
    {
        public BookResponseDo searchBar(string str)
        {
            BookResponseDo bookResponse = new BookResponseDo();
            List<BookResponseDo> allBooks = getBooks();   
           foreach (BookResponseDo bookResponseDo in allBooks)
            {
                if (str.ToLower() == bookResponseDo.BookName.ToLower())
                {
                    return bookResponseDo;
                }
            }
           bookResponse.BookName = "book not found";
            return bookResponse;
        }
        
    }
}
