using Biller.Model;
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
    /// <summary>
    /// Lógica de interacción para Product_Item.xaml
    /// </summary>
    public partial class Product_Item : UserControl
    {
        public Product_Item(Product product)
        {
            InitializeComponent();
            DataContext = product == null ? new Product() : product;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product_Detail product_detail = new Product_Detail((Product)DataContext);
            Main.global.products.Principal.Children.Clear();
            Main.global.products.Principal.Children.Add(product_detail);
        }
    }
}
