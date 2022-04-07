using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;


namespace BA_Dashboard
{
    /// <summary>
    /// BackupMethod_Piechart.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class BackupMethod_Piechart : UserControl
    {
        public static int value1;
        public BackupMethod_Piechart()
        {
            InitializeComponent();
            PointLabel = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            DataContext = this;
        }
        public Func<ChartPoint, string> PointLabel { get; set; }

        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart)chartpoint.ChartView;

            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries)chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
    }
}
