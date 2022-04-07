using System;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System.ComponentModel;
using System.Windows;
using System.Globalization;
using System.Windows.Data;

namespace BA_Dashboard
{
    /// <summary>
    /// row_1_col_1.xaml에 대한 상호 작용 논리
    /// </summary>
    #region row_1_col_1 UserControl
    public partial class row_1_col_1 : UserControl, INotifyPropertyChanged
    {
        private ZoomingOptions _zoomingMode;    // Zooming - None, x, y, xy 

        #region 컨트롤생성자
        public row_1_col_1()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {

                new LineSeries
                {
                    Title = "File Size",
                    Values = new ChartValues<int> { ChartData.Total_File_Size_LineChart_2022_02_08_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_09_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_10_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_11_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_12_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_13_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_14_Count,
                                                        ChartData.Total_File_Size_LineChart_2022_02_15_Count
                    },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },
                 new LineSeries
                {
                    Title = "Write Size",
                    Values = new ChartValues<int> { ChartData.Total_Write_Size_LineChart_2022_02_08_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_09_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_10_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_11_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_12_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_13_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_14_Count,
                                                        ChartData.Total_Write_Size_LineChart_2022_02_15_Count
                    },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },

                  new LineSeries
                {
                    Title = "Transferred Data",
                    Values = new ChartValues<int> { ChartData.Total_Data_Transferred_LineChart_2022_02_08_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_09_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_10_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_11_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_12_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_13_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_14_Count,
                                                        ChartData.Total_Data_Transferred_LineChart_2022_02_15_Count
                    },
                    PointGeometry = DefaultGeometries.Circle,
                    PointGeometrySize = 10
                },


            };

            // X축 Zooming Mode 변수 
            ZoomingMode = ZoomingOptions.X;

            Labels = new[] { "22-02-08", "22-02-09", "22-02-10", "22-02-11", "22-02-12", "22-02-13", "22-02-14", "22-02-15" };
            // X축 포매터 
            //XFormatter = val => new DateTime((long)val).ToString("yy MM dd");
            YFormatter = value => value.ToString("N");
            DataContext = this;
        }
        #endregion

        #region 라이브차트 관련 변수선언 
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> YFormatter { get; set; }
        public Func<double, string> XFormatter { get; set; }

        // ZoomingMode를 프로퍼티가 변경되는 것에 따라서 set 설정됨 
        public ZoomingOptions ZoomingMode
        {
            get { return _zoomingMode; }
            set
            {
                _zoomingMode = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region 줌 모드 토글링 함수
        // ZoomingMode를 Toggleling 하는 함수 
        private void ToogleZoomingMode(object sender, RoutedEventArgs e)
        {
            // ZoomingMode 는 데이터타입이 enum 형식 (0,1,2,3) (None,X,Y,XY)
            switch (ZoomingMode)
            {
                case ZoomingOptions.None:
                    ZoomingMode = ZoomingOptions.X;
                    break;
                case ZoomingOptions.X:
                    ZoomingMode = ZoomingOptions.Y;
                    break;
                case ZoomingOptions.Y:
                    ZoomingMode = ZoomingOptions.Xy;
                    break;
                case ZoomingOptions.Xy:
                    ZoomingMode = ZoomingOptions.None;
                    break;

                // 기본 설정 ArgumentOutOfRangeException
                // 이 생성자는 새 Message 인스턴스의 속성을 "Nonnegative number required"와 같은 오류를 설명하는 시스템 제공 메시지로 초기화합니다.
                // 이 메시지는 현재 시스템 culture를 고려합니다.
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
        #endregion

        #region PropertChange 변수선언 및 OnPropertyChanged 함수 
        // public partial class UserControl1 : INotifyPropertyChanged  
        // INotifyPropertyChanged에 필요한 이벤트 변수 
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            // Invoke 함수
            // 요약:
            // 구성 요소에서 속성이 변경될 때 발생하는 System.ComponentModel.INotifyPropertyChanged.PropertyChanged
            // 이벤트를 처리할 메서드를 나타냅니다.
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        #region 리셋클릭 함수 
        // 줌모드 설정과 Zomming된 화면을 리셋(초기상태)로 돌리는 함수 
        private void ResetZoomOnClick(object sender, RoutedEventArgs e)
        {
            //Use the axis MinValue/MaxValue properties to specify the values to display.
            //use double.Nan to clear it.

            // Nan : 숫자가 아닌 값을 나타냅니다(NaN). 이 필드는 상수입니다.
            // 작업 결과가 정의 되지 않은 경우 메서드 또는 연산자가 Nan을 반환 합니다. 
            X.MinValue = double.NaN;
            X.MaxValue = double.NaN;
            Y.MinValue = double.NaN;
            Y.MaxValue = double.NaN;
        }
        #endregion

        #region Next 버튼 함수 (다음 차트화면으로 넘어감)
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Form1.Instance.row_1_col_1_panel.Controls.ContainsKey("row_1_col_1_Column_UC"))
            {
                row_1_col_1_Column_UC UCnext = new row_1_col_1_Column_UC();
                UCnext.Dock = System.Windows.Forms.DockStyle.Fill;
                Form1.Instance.row_1_col_1_panel.Controls.Add(UCnext);
            }
            Form1.Instance.row_1_col_1_panel.Controls["row_1_col_1_Column_UC"].BringToFront();
        }
        #endregion
    }
    #endregion
    #region 줌 모드 컨버터 
    public class ZoomingModeCoverter : IValueConverter
    {

        // Convert 함수 요약:
        //     값을 변환합니다.
        //
        // 매개 변수:
        //   value :
        //     바인딩 소스에서 생성한 값입니다.
        //
        //   targetType:
        //     바인딩 대상 속성의 형식입니다.
        //
        //   parameter:
        //     사용할 변환기 매개 변수입니다.
        //
        //   culture:
        //     변환기에서 사용할 문화권입니다.
        //
        // 반환 값:
        //     변환된 값입니다. 메서드에서 null을 반환하면 유효한 null 값이 사용됩니다.
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch ((ZoomingOptions)value)
            {
                case ZoomingOptions.None:
                    return "None";
                case ZoomingOptions.X:
                    return "X";
                case ZoomingOptions.Y:
                    return "Y";
                case ZoomingOptions.Xy:
                    return "XY";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        // 현재 코드에서 쓰이진 않음. 
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
    #endregion
}
