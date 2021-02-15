using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Barcode { get; set; }
        public int? Brand_Id { get; set; }
        public bool Multi_Product { get; set; }
        public int Status { get; set; }
    }
}
