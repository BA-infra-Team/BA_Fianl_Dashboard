using System.Windows;
using System.Windows.Controls;


namespace BA_Dashboard
{
    /// <summary>
    /// row_0_col_1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class row_0_col_1 : UserControl
    {
        public row_0_col_1()
        {
            InitializeComponent();
        }

        private void ComboBox1_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox1.Items.Add("Total Files");
            ComboBox1.Items.Add("2022_02_08");
            ComboBox1.Items.Add("2022_02_09");
            ComboBox1.Items.Add("2022_02_10");
            ComboBox1.Items.Add("2022_02_11");
            ComboBox1.Items.Add("2022_02_12");
            ComboBox1.Items.Add("2022_02_13");
            ComboBox1.Items.Add("2022_02_14");
            ComboBox1.Items.Add("2022_02_15");
            ComboBox1.SelectedIndex = 0;
        }

        // Total File Count ComboBox
        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox1.Text = ComboBox1.SelectedItem.ToString();

            if (ComboBox1.SelectedIndex == 0)
            {
                textbox1.Text = ChartData.File_Statistics_PieChart_Total_File_Size.ToString();
            }
            else if (ComboBox1.SelectedIndex == 1)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_08_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 2)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_09_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 3)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_10_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 4)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_11_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 5)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_12_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 6)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_13_Count.ToString();
            }
            else if (ComboBox1.SelectedIndex == 7)
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_14_Count.ToString();
            }
            else
            {
                textbox1.Text = ChartData.Total_File_Size_LineChart_2022_02_15_Count.ToString();
            }
        }

        // Error Count 
        private void ComboBox2_Loaded(object sender, RoutedEventArgs e)
        {
            ComboBox2.Items.Add("Total Errors");
            ComboBox2.Items.Add("2022_02_08");
            ComboBox2.Items.Add("2022_02_09");
            ComboBox2.Items.Add("2022_02_10");
            ComboBox2.Items.Add("2022_02_11");
            ComboBox2.Items.Add("2022_02_12");
            ComboBox2.Items.Add("2022_02_13");
            ComboBox2.Items.Add("2022_02_14");
            ComboBox2.Items.Add("2022_02_15");
            ComboBox2.SelectedIndex = 0;
        }

        private void ComboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            textbox2.Text = ComboBox2.SelectedItem.ToString();

            if (ComboBox2.SelectedIndex == 0)
            {
                textbox2.Text = ChartData.Total_Error_Ratio_PieChart_Total_Error_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 1)
            {
                textbox2.Text = ChartData.Error_02_08_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 2)
            {
                textbox2.Text = ChartData.Error_02_09_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 3)
            {
                textbox2.Text = ChartData.Error_02_10_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 4)
            {
                textbox2.Text = ChartData.Error_02_11_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 5)
            {
                textbox2.Text = ChartData.Error_02_12_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 6)
            {
                textbox2.Text = ChartData.Error_02_13_Count.ToString();
            }
            else if (ComboBox2.SelectedIndex == 7)
            {
                textbox2.Text = ChartData.Error_02_14_Count.ToString();
            }
            else
            {
                textbox2.Text = ChartData.Error_02_15_Count.ToString();
            }
        }
    }
}
