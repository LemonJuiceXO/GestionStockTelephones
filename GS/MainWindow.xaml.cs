using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml;

namespace GS
{
    
    public partial class MainWindow : Window
    {
  

        public MainWindow()
        {
            InitializeComponent();
            LoadPage("UI/ProductsPage.xaml");
        }

        private void  HandleClicks(object sender, RoutedEventArgs e)
        {
            
            var buttonId = (RadioButton)sender;
         
         
            if (buttonId.Name.Equals("products"))
            {
                LoadPage("UI/ProductsPage.xaml");
            }
            else if (buttonId.Name.Equals("clients"))
            {
                LoadPage("UI/ClientsPage.xaml");
            }
            else if(buttonId.Name.Equals("stats"))
            {
                LoadPage("UI/StatisticsPage.xaml");
            }
            else if (buttonId.Name.Equals("suppliers"))
            {
                LoadPage("UI/SuppliersPage.xaml");

            }

        }

        private void LoadPage(string pageUri)
        {
            try
            {
                Frame.Navigate(new Uri(pageUri, UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading page: {ex.Message}");
            }
        }


    }
}