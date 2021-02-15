using Biller.Model;
using Biller.Service;
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

namespace Biller.View.Prod_Controls
{
    public partial class Product_Detail : UserControl
    {
        public Product_Detail(Product item)
        {
            InitializeComponent();
            DataContext = item == null ? new Product() : item;
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            ////Product product = ProductService.CreateProduct((Product)DataContext);
            Product product = (Product)DataContext;
            Guardar(product);
            MessageBox.Show("Producto Creado Id: "+product.Id.ToString(), "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            Main.global.products.Search_Click(sender, e);
        }

        private void Guardar(Product product)
        {
            if(product.Id == 0)
            {
                Main.global.products.items.Add(product);
            }
            else
            {
                Main.global.products.items[Main.global.products.items.FindIndex(p => p.Id == product.Id)] = product;
            }
        }
    }
}
