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

namespace Biller.View
{
    /// <summary>
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : UserControl
    {
        public Clients()
        {
            InitializeComponent();
            CargarType_Document();
            CargarType_Client();

        }


        private void CargarType_Document()
        {

            List<Type_Document> type_Documents = new List<Type_Document>();
            for (int i = 0; i <= 10; i++)
            {
                type_Documents.Add(new Type_Document() { Id = i, Status = 1, Title = "E" + i });
            }
            TypeDocument.ItemsSource = type_Documents;
            TypeDocument.DisplayMemberPath = "Title";
            TypeDocument.SelectedValuePath = "Id";
        }



        private void CargarType_Client()
        {

            List<Type_Client> type_Client = new List<Type_Client>();
            for (int i = 0; i <= 10; i++)
            {
                type_Client.Add(new Type_Client() { Id = i, Status = 1, Title = "PRUEBA" + i });
            }
            TypeClient.ItemsSource = type_Client;
            TypeClient.DisplayMemberPath = "Title";
            TypeClient.SelectedValuePath = "Id";
        }

        private void Create_BTN_Click(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Type_Client_Id = TypeClient.SelectedIndex;
            client.Type_Doc_Id = TypeDocument.SelectedIndex;
            client.Name = Name.Text;
            client.Status = 1;
            client.Document = Document.Text;
            client.Adress = Address.Text;

            if (client.Document != null || client.Document != null)
            {
                MessageBox.Show("Added successfully", "Alert", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

    }


 
}
