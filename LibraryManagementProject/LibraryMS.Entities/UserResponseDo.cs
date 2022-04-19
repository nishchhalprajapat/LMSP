using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMS.Entities
{
    public class UserResponseDo:UserRequestDo
    {
        public string Token { get; set; }

    }
}
