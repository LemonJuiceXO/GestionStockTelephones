
using GS.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Controls;


namespace GS.UI
{

    public partial class Page1 : Page
    {
        private ObservableCollection<Page1Model> humans = new();
        public Page1()
        {
            InitializeComponent();
            list.ItemsSource = humans;
            humans.Add(new Page1Model()
            {
                name = "Name",
                lastName = "Name",
                age=15
            });

            humans.Add(new Page1Model()
            {
                name = "Namazedazde",
                lastName = "Namqsdqsde",
                age = 15
            });

            DataContext = this;

        }



    }
}
