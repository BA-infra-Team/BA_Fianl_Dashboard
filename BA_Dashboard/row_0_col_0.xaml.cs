using System.Windows.Controls;


namespace BA_Dashboard
{ 
    /// <summary>
    /// row_0_col_0.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_0_col_0 : UserControl
    {
        public string Gauge1_Error_To { get; set; }
        public string Gauge1_Error_Value { get; set; }
        public string Gauge2_Files_To { get; set; }
        public string Gauge2_Files_Value { get; set; }

        public row_0_col_0()
        {
            Gauge1_Error_To = ChartData.Total_Error_Ratio_PieChart_Total_Count.ToString();
            Gauge1_Error_Value = ChartData.Total_Error_Ratio_PieChart_Total_Error_Count.ToString();
            Gauge2_Files_To = ChartData.File_Statistics_PieChart_Total_File_Size.ToString();
            Gauge2_Files_Value = ChartData.File_Statistics_PieChart_Total_Write_Size.ToString();
            DataContext = this;
            InitializeComponent();
        }
    }
}
