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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BA_Dashboard
{
    /// <summary>
    /// row_0_col_0_Left.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_0_col_0_Left : UserControl
    {
        public string Gauge1_Error_To { get; set; }
        public string Gauge1_Error_Value { get; set; }
        public row_0_col_0_Left()
        {
            InitializeComponent();
            Gauge1_Error_To = ChartData.Total_Error_Ratio_PieChart_Total_Count.ToString();
            Gauge1_Error_Value = ChartData.Total_Error_Ratio_PieChart_Total_Error_Count.ToString();
            DataContext = this;
        }
    }
}
