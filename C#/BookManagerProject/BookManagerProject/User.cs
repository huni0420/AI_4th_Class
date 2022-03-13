using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManagerProject
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Pgge { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public bool isBorrowed { get; set; }
        public DateTime BorrowedAt { get; set; }
    }
}
