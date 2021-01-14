using AppMicroCharts.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMicroCharts
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChartConfigurationPage : ContentPage
    {
        public ChartConfigurationPage(string chartType)
        {
            Items = AppMicroCharts.Data.Data.CreateXamarinExampleChartItem(chartType).ToList();
            InitializeComponent();
            Title = chartType;
        }

        public List<ExampleChartItem> Items { get; }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Frame frame = sender as Frame;
            ExampleChartItem exChartItem = frame.BindingContext as ExampleChartItem;
            Navigation.PushAsync(new ChartPage(exChartItem));
        }
    }
}
