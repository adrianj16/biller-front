using Biller.Model;
using Biller.Service;
using Biller.View.Prod_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Biller.View
{
    /// <summary>
    /// Lógica de interacción para Products.xaml
    /// </summary>
    public partial class Products : UserControl
    {
        public List<Product> items;
        public Products()
        {
            InitializeComponent();
            items = getProductsMocks();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            Product_Detail product_detail = new Product_Detail(null);
            Principal.Children.Clear();
            Principal.Children.Add(product_detail);
        }

        public void Search_Click(object sender, RoutedEventArgs e)
        {
            //Product_Cont product_cont = new Product_Cont(ProductService.GetProducts());
            Product_Cont product_cont = new Product_Cont(items);
            Principal.Children.Clear();
            Principal.Children.Add(product_cont);
        }

        private List<Product> getProductsMocks()
        {
            List<Product> list = new List<Product>();
            for (int i = 0; i < 10; i++){
                list.Add(
                    new Product() { 
                        Id = i,
                        Description = "Product "+ i.ToString(),
                        Barcode = "123456789",
                        Multi_Product = true,
                        Status = 1
                    }
                );
            }
            return list;
        }
    }
}
