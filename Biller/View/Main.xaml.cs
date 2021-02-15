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
using System.Windows.Shapes;

namespace Biller.View
{
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public static Global global;
        public Main()
        {
            global = new Global();
            InitializeComponent();
            Principal.Children.Clear();
            Principal.Children.Add(new Dashboard());
        }

        private void Dashboard_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Dashboard());
        }

        private void Orders_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Orders());
        }

        private void Products_BTN_Click(object sender, RoutedEventArgs e)
        {
            global.products = new Products();
            Principal.Children.Clear();
            Principal.Children.Add(global.products);
        }

        private void Inventory_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Inventory());
        }

        private void Tracking_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Tracking());
        }

        private void Reports_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Reports());
        }

        private void Shutdown_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Clients_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Clients());
        }

        private void Users_BTN_Click(object sender, RoutedEventArgs e)
        {
            Principal.Children.Clear();
            Principal.Children.Add(new Users());
        }
    }
}
