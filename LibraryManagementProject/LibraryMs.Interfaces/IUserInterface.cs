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
        public UserResponseDo signInUser(LoginRequestDo obj);
        public UserResponseDo signUpUser(UserRequestDo obj);
    }
}
