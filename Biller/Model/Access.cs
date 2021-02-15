using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Model
{
   public class Access
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Status { get; set; }

        public virtual ICollection<Access_User> Access_Users { get; set; }


    }
}
