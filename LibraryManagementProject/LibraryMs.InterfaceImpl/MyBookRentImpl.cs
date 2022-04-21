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
<<<<<<< HEAD
            List<BookResponseDo> myBookProfileList = new List<BookResponseDo>();

            return myBookProfileList;
=======
            throw new NotImplementedException();
>>>>>>> f2c7058e1071659c34b6820c610b469a9687a55b
        }
    }
}
