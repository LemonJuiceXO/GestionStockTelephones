
using GS.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace GS.UI
{

    public partial class Page1 : Page
    {
        private ObservableCollection<ProductModel> products = new();
        public Page1()
        {
            InitializeComponent();
            list.ItemsSource = products;
       
            DataContext = this;

            products.Add(new ProductModel()
            {
                ProductName = "Test",
                ProductType="azeaz",
                Model="adeqsd",
                ProductSellPrice=1500,
                ProductBuyPrice=80000
            });

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
    }
}
