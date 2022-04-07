using System;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace BA_Dashboard
{
    public partial class LoginForm : Form
    {
        public static Socket ClientSocket;
        public static string message { get; set; }
        public static string responseData { get; set; }
        public static int rev { get; set; }
        public static byte[] Buffer { get; set; }
        public static byte[] data { get; set; }

        public LoginForm()
        {
            InitializeComponent();
            // 유저에게 보이는 비밀번호 *처리
            Pwd_textbox.PasswordChar = '*';
            // 비밀번호 최대 14자 설정 
            ID_textbox.MaxLength = 14;
            Pwd_textbox.MaxLength = 14;
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string UserName = ID_textbox.Text;
            string Password = Pwd_textbox.Text;

            try
            {
                IPAddress ipAddress = IPAddress.Parse("192.168.0.12");
                int port = 7756;
                IPEndPoint iPEndPoint = new IPEndPoint(ipAddress, port);
                ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                ClientSocket.Connect(iPEndPoint);

                // 버퍼 
                Buffer = new byte[1024];

                // 접속환영문구 수신
                rev = 0;
                responseData = String.Empty;
                rev = ClientSocket.Receive(Buffer);
                responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);


                // 클라이언트측에서 서버에게 "접속완료" 문구보냄.
                string message = "Login";
                byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(data);
            }

            catch
            {
                MessageBox.Show("소켓통신 연결 에러입니다.");
            }

            // 버퍼 
            Buffer = new byte[1024];

            // 로그인 엔터 수신, "Login_Enter"
            rev = 0;
            rev = ClientSocket.Receive(Buffer);
            responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, rev);

            if (UserName == String.Empty || Password == String.Empty)
            {
                MessageBox.Show("아이디 또는 비밀번호를 입력하세요.");
                ClientSocket.Close();
            }

            else
            {
                // 클라이언트측에서 서버에게 "아이디" 정보 보냄.
                message = string.Empty;
                message = UserName;
                data = System.Text.Encoding.ASCII.GetBytes(message);
                ClientSocket.Send(data);

                // 아이디 맞는지 체크
                responseData = String.Empty;
                rev = 0;
                rev = ClientSocket.Receive(Buffer);
                responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, 10);

                if (responseData == "ID_Correct")
                {
                    // 클라이언트측에서 서버에게 "비밀번호" 정보 보냄.
                    // 메세지, 바이트 초기화 
                    message = string.Empty;
                    Array.Clear(data, 0, data.Length);

                    message = Password;
                    data = System.Text.Encoding.ASCII.GetBytes(message);
                    ClientSocket.Send(data);

                    // 메세지 받기
                    responseData = String.Empty;
                    rev = 0;
                    rev = ClientSocket.Receive(Buffer);
                    responseData = System.Text.Encoding.ASCII.GetString(Buffer, 0, 13);


                    if (responseData == "Login_Success")
                    {
                        //var MainDashBoard = new Form1();
                        //MainDashBoard.Show();
                        //ClientSocket.Close();

                        Form1 MainDashBoard = new Form1();
                        this.Hide();
                        MainDashBoard.ShowDialog();
                        this.Close();
                        ClientSocket.Close();
                    }
                    // 비밀번호 틀림 
                    else
                    {
                        MessageBox.Show("아이디 또는 비밀번호가 틀립니다.");
                        ClientSocket.Close();
                    }
                }
                // 아이디 틀림 
                else
                {
                    MessageBox.Show("아이디 또는 비밀번호가 틀립니다.");
                    ClientSocket.Close();
                }
            }
        }
    }
}
