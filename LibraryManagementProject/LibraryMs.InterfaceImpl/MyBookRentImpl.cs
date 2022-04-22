using LibraryManagementProject.LibraryMs.Interfaces;
using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.InterfaceImpl
{
    public class MyBookRentImpl : IMyBookRentInterface
    {
        public List<BookResponseDo> myBookRentalDetails(int userId)
        {

            List<BookResponseDo> myBookProfileList = new List<BookResponseDo>();

            return myBookProfileList;

            throw new NotImplementedException();
        }
    }
}
