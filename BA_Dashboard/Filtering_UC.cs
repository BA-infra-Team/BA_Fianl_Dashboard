using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace BA_Dashboard
{
    public partial class Filtering_UC : UserControl
    {
        public static Socket ClientSocket;
        public static string Job_Type { get; set; }
        public static int Filtering_Total_Count;
        public static string filepath { get; set; }
        public static string fileName { get; set; }
        public static string message { get; set; }
        public static string responseData { get; set; }
        public static int rev;
        public static byte[] Buffer { get; set; }
        public static byte[] data { get; set; }
        public static List<FilteringData> list = new List<FilteringData>();
        public static int index { get; set; }
        public static string BlankString { get; set; }

        public Filtering_UC()
        {
            InitializeComponent();
            // Set to details view.
            listView1.View = View.Details;
            //listView1.OwnerDraw = true;
            // 첫 번째 열은 가운데 정렬이 안되므로, 0으로 배치 
            listView1.Columns.Add("", 0, HorizontalAlignment.Center);
            listView1.Columns.Add("No", 100, HorizontalAlignment.Center);
            listView1.Columns.Add("Job_Status", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Job_Type", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Client", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Server", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Schedule", 200, HorizontalAlignment.Center);
            listView1.Columns.Add("Files", 200, HorizontalAlignment.Center);
            //listView1.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(listView1_DrawColumnHeader);
        }
        void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.DarkBlue, e.Bounds);
            e.DrawText();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            // 필터링데이터 리스트 초기화
            list.Clear();
            // 리스트뷰 내용 초기화 
            listView1.Items.Clear();

            // 접속 
            try
            {
                IPAddress ipAddress = IPAddress.Parse("192.168.0.12");
                int port = 7756;
                IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                ClientSocket.Connect(iPEndPoint);
                // 버퍼 
                Filtering_UC.Buffer = new byte[1024];


                Filtering_UC.responseData = String.Empty;
                Filtering_UC.rev = ClientSocket.Receive(Filtering_UC.Buffer);
                Filtering_UC.responseData = System.Text.Encoding.ASCII.GetString(Filtering_UC.Buffer, 0, rev);

                // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
                Filtering_UC.message = "Filtering_Data";
                Filtering_UC.data = System.Text.Encoding.ASCII.GetBytes(Filtering_UC.message);
                ClientSocket.Send(Filtering_UC.data);
            }
            catch
            {
                MessageBox.Show("Socket Connection Error");
            }
            byte[] Buffer = new byte[1024];

            // "Filtering_Enter" 메세지 받기  
            responseData = String.Empty;
            rev = 0;
            rev = ClientSocket.Receive(Buffer);
            if (rev < 0)
            {
                throw new SocketException();
            }
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

            // 텍스트박스에서 읽어온 고객이 검색한 Job_Type (검색기준)변수 
            Job_Type = SearchTextBox.Text;
            filepath = "C:\\Users\\BIT\\Desktop\\DownloadFromServer\\";
            message = string.Empty;

            // 서버에 필터링 기준 정보를 메세지로 보냄. 
            message = Job_Type;
            if(message == "File Backup" || message == "Informix Onbar Backup" || 
                message == "Mysql Backup" || message == "Oracle RMAN Backup" || 
                message == "Physical Backup" || message == "Vmware Backup")
            {
                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(data);

                Buffer = new byte[1024];
                rev = ClientSocket.Receive(Buffer, 0, 23, 0);
                if (rev < 0)
                {
                    throw new SocketException();
                }
                int fileNameLen = BitConverter.ToInt32(Buffer, 0);
                fileName = Encoding.ASCII.GetString(Buffer, 4, fileNameLen);
                int fileSize = BitConverter.ToInt32(Buffer, 4 + fileNameLen + 1);

                Buffer = new byte[4096];
                BinaryWriter bWrite = new BinaryWriter(File.Open(filepath + fileName,
                FileMode.Create, FileAccess.Write));

                rev = 0;
                for (int i = 0; i < fileSize; i += rev)
                {
                    Buffer = new byte[4096];
                    rev = ClientSocket.Receive(Buffer, 0);
                    if (rev < 0)
                    {
                        throw new SocketException();
                    }
                    bWrite.Write(Buffer, 0, rev);
                }
                bWrite.Close();

                // csv 파일 읽기
                ReadCSVFile();

                // 리스트뷰에 내용 추가 
                for (int i = 0; i < list.Count; i++)
                {
                    string[] strs = new string[] { list[i].Filtering_FirstBlankColumn,list[i].Filtering_index,list[i].Filtering_Job_Status,
                list[i].Filtering_Job_Type, list[i].Filtering_Client, list[i].Filtering_Server,
                list[i].Filtering_Schedule, list[i].Filtering_Files };
                    var item = new ListViewItem(strs);
                    listView1.Items.Add(item);
                }
            }

            else
            {
                MessageBox.Show("검색기준에 맞게 입력하세요.");
                ClientSocket.Close();
            }
        }

        static void ReadCSVFile()
        {
            index = 1;
            var lines = File.ReadAllLines(Filtering_UC.filepath + Filtering_UC.fileName);
            foreach (var line in lines)
            {
                var values = line.Split(',');
                var filteringdata = new FilteringData();
                filteringdata.Filtering_FirstBlankColumn = BlankString;
                filteringdata.Filtering_index = index.ToString();
                filteringdata.Filtering_Job_Status = values[0];
                filteringdata.Filtering_Job_Type = values[1];
                filteringdata.Filtering_Client = values[2];
                filteringdata.Filtering_Server = values[3];
                filteringdata.Filtering_Schedule = values[4];
                filteringdata.Filtering_Files = values[5];
                list.Add(filteringdata);
                index++;
            }
        }

        public class FilteringData
        {
            // 필터링 데이터 6개
            public string Filtering_FirstBlankColumn { get; set; }
            public string Filtering_index { get; set; }
            public string Filtering_Job_Status { get; set; }
            public string Filtering_Job_Type { get; set; }
            public string Filtering_Client { get; set; }
            public string Filtering_Server { get; set; }
            public string Filtering_Schedule { get; set; }
            public string Filtering_Files { get; set; }
        }

        // 엔터 입력시 검색버튼 클릭과 동일한 이벤트 
        private void SearchBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchBtn_Click(sender, e);
        }

        private void SearchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchTextBox.Text = (string)SearchComboBox.SelectedItem;
        }
    }
}
