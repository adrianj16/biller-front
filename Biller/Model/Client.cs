using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Model
{
   public class Client
    {
        public int Id { get; set; }
        public int Type_Doc_Id { get; set; }
        public string Document { get; set; }
        public string Name { get; set; }

        public string Adress { get; set; }
        public DateTime User_Register { get; set; }
        public int Type_Client_Id { get; set; }
        public int Status { get; set; }
        public virtual Type_Client Type_Client { get; set; }
        public virtual Type_Document Type_Document{ get; set; }
    }
}
