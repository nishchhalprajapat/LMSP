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
            bookList.Add(new BookResponseDo(101, "The great gatsBy", "henry", new DateTime(2022,03,10), new DateTime(2022,03,15), 123456, "return", "Fiction"));
            bookList.Add(new BookResponseDo(102, "Henry Miller", "andy", new DateTime(2022,04,10 ), new DateTime(2022,05,15), 87874838, "Not return", "NonFiction"));
            bookList.Add(new BookResponseDo(103, "Sarah water", "waltous", new DateTime(2022, 04, 15), new DateTime(2022, 04, 18), 964728, "return", "Historical"));
            bookList.Add(new BookResponseDo(104, "The vagetarian", "milan kudera", new DateTime(2022, 05, 15), new DateTime(2022, 05, 15), 7847984, "Non return", "Journal"));
            bookList.Add(new BookResponseDo(105, "All the light we can not see", "stifen king", new DateTime(2022, 04, 15), new DateTime(2022, 04, 18), 7463764, "return", "Fiction"));
            bookList.Add(new BookResponseDo(106, "Animal farm", "arthur golden", new DateTime(2022, 04, 10), new DateTime(2022, 05, 15), 344355, "Non return", "NonFiction"));
            bookList.Add(new BookResponseDo(107, "The bell jar", "ernest emigy", new DateTime(2022, 03, 10), new DateTime(2022, 03, 15), 746327, "return", "Historical"));
            bookList.Add(new BookResponseDo(108, "The Help", "leo tolstoy", new DateTime(2022, 04, 10), new DateTime(2022, 05, 15), 897859, "Non return", "Journal"));
            bookList.Add(new BookResponseDo(109, "Maus", "franz kafza", new DateTime(2022, 03, 10), new DateTime(2022, 03, 15), 6356216, "return", "Fiction"));
            bookList.Add(new BookResponseDo(110, "War and Peas", "cormac", new DateTime(2022, 04, 10), new DateTime(2022, 05, 15), 6476318, "Non return", "NonFiction"));

            return bookList;
        }
    }
}
