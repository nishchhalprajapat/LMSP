using LibraryManagementProject.LibraryMS.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMs.Interfaces
{
    public interface IUserInterface
    {
        public Boolean signInUser(LoginRequestDo obj);
        public Boolean signUpUser(UserRequestDo obj);
    }
}
