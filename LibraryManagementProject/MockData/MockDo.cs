using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.MockData
{
    public class MockDo
    {
        public List<BookResponseDo> getMockData()
        {
            List<BookResponseDo> bookList = new List<BookResponseDo>();
            //bookList.Add(new BookResponseDo(101,"The great gatsBy","henry",05/04/2022,));

            return bookList;
        }
    }
}
