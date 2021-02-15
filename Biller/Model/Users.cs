using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Model
{
    public class Users
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Date_Register { get; set; }

        public int Role { get; set; }
        public int Status { get; set; }


        public virtual ICollection<Access_User> Access_Users { get; set; }
    }
}
