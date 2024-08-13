using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace GS.UI
{
    /// <summary>
    /// Interaction logic for StatisticsPage.xaml
    /// </summary>
    public partial class StatisticsPage : Page
    {
        public StatisticsPage()
        {
            InitializeComponent();
            series = new SeriesCollection();
            series.Add(new PieSeries()
            {
                Title = "الزنطيط",
                Values = new ChartValues<ObservableValue> { new ObservableValue(50) },
                DataLabels = true
            });

            series.Add(new PieSeries()
            {
                Title = "الكلب المائي",
                Values = new ChartValues<ObservableValue> { new ObservableValue(20) },
                DataLabels = true
            });

            DataContext = this;

        }

        public SeriesCollection series { get; set; }
    }

    
}
