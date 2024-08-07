using GS.ViewModels;
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

namespace GS.UI
{
    /// <summary>
    /// Interaction logic for AddItem.xaml
    /// </summary>
    public partial class AddItem : StackPanel
    {
        public  delegate void ItemAddedEventHandler(ProductModel model);

        public event ItemAddedEventHandler itemAdded;

        public delegate void ExitAddItemHandler();

        public event ExitAddItemHandler ExitEvent;

        public AddItem()
        {

            InitializeComponent();
           
        }

        public async void addItem()
        {
          
            ProductModel model
            = new ProductModel()
            {
                ProductName= productName.Text,
                ProductType=productType.Text,
                Model=productCat.Text,
                ProductBuyPrice=float.Parse(buyPrice.Text),
                ProductSellPrice=float.Parse(sellPrice.Text)
            };

            itemAdded.Invoke(model);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            addItem();
        }

     

        private void ExitAddItem(object sender, RoutedEventArgs e)
        {
            ExitEvent.Invoke();
        }
    }
}
