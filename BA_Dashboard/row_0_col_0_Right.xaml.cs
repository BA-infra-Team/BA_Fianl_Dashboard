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
    /// row_0_col_0_Right.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_0_col_0_Right : UserControl
    {
        public string Gauge2_Files_To { get; set; }
        public string Gauge2_Files_Value { get; set; }

        public row_0_col_0_Right()
        {
            Gauge2_Files_To = ChartData.File_Statistics_PieChart_Total_File_Size.ToString();
            Gauge2_Files_Value = ChartData.File_Statistics_PieChart_Total_Write_Size.ToString();
            DataContext = this;
            InitializeComponent();
        }
    }
}
