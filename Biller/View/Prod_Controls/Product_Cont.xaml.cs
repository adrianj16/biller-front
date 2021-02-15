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
    /// Lógica de interacción para Product_Cont.xaml
    /// </summary>
    public partial class Product_Cont : UserControl
    {
        public Product_Cont(List<Product> products)
        {
            InitializeComponent();
            for (int i = 0; i < products.Count; i++)
            {
                Principal.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(60) });
                var prod = new Product_Item(products[i]);
                Principal.Children.Add(prod);
                Grid.SetRow(prod, i);
            }
            DataContext = this;
        }
    }
}
