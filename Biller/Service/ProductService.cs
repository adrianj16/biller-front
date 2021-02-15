using Biller.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biller.Service
{
    public class ProductService
    {
        public static Product CreateProduct(Product product) 
        {
            return APIService.Send<Product>("products", "POST", product);
        }

        public static List<Product> GetProducts()
        {
            return APIService.Send<List<Product>>("products", "GET");
        }

        public static Product GetProduct(int productID)
        {
            return APIService.Send<Product>("products/"+productID.ToString(), "GET");
        }
    }
}
