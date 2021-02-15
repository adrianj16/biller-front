using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Model
{
  public  class Access_User
    {
        public int Id { get; set; }
        public int User_Id { get; set; }
        public  int Access_Id { get; set; }
        public DateTime Date_Register { get; set; }
        public DateTime User_Register { get; set; }
        public int Status { get; set; }
        public virtual Users Users { get; set; }
        public virtual Access Access { get; set; }


    }
}
