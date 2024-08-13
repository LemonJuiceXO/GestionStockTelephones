
using GS.ViewModels;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace GS.UI
{

    public partial class ProductsPage : Page
    {
        private ObservableCollection<ProductModel> products = new();
        public ProductsPage()
        {
            InitializeComponent();
            list.ItemsSource = products;
       
            DataContext = this;

           

        }
        public void itemAdded(ProductModel product)
        {
            products.Add(product);
        }
        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            AddItem add = new AddItem();
            add.itemAdded += itemAdded;
            Grid.SetColumnSpan(add, 2);
            Grid.SetRowSpan(add, 2);
            mainPanel.Children.Add(add);

            add.ExitEvent += () =>
            {
                mainPanel.Children.Remove(add);
            };
        }

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("هل تريد حذف السلعة ؟", "",MessageBoxButton.YesNo);

            if (result == MessageBoxResult.Yes) {
                products.RemoveAt(list.SelectedIndex);
            }
        
        }
    }
}
