using Microcharts;

namespace AppMicroCharts.Data
{
    public class ExampleChartItem
    {
        public Chart Chart { get; set; }
        public string ChartType { get => Chart?.GetType()?.Name ?? "Unknown"; }
        public string ExampleName { get; set; }
        public string ExampleDescription { get; set; }
        public ExampleChartType ExampleChartType { get; set; }
        public bool IsSimple => ExampleChartType == ExampleChartType.Simple;
        public bool IsSeries => ExampleChartType == ExampleChartType.Series;
    }

    public enum ExampleChartType
    {
        Simple,
        Series
    }
}
