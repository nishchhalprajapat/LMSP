using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementProject.LibraryMS.Entities
{
    public class BookRentRequestDo
    {
        public int userId { get; set; }
        public string BookName{ get; set; }    
        public string IssueDate { get; set; }
		public string ReturnDate { get; set; }
        public string Status { get; set; }
    }
}
