using System.Net.Sockets;
using System.Text;
using System;
using System.Windows.Forms;

namespace Exercise3
{
    public partial class SignInSuccess : Form
    {
        private string serverIp = "localhost"; // Địa chỉ IP của server
        private int serverPort = 3080;          // Cổng của server

        public SignInSuccess(string username)
        {
            InitializeComponent();
            LoadUserInfo(username);
        }

        private async void LoadUserInfo(string username)
        {
            try
            {
                using TcpClient client = new(serverIp, serverPort);
                using NetworkStream stream = client.GetStream();

                // Gửi yêu cầu lấy thông tin người dùng
                string request = $"GETINFO|{username}";
                byte[] data = Encoding.UTF8.GetBytes(request);
                await stream.WriteAsync(data, 0, data.Length);

                // Nhận phản hồi từ server
                byte[] responseBuffer = new byte[1024];
                int bytesRead = await stream.ReadAsync(responseBuffer);
                string response = Encoding.UTF8.GetString(responseBuffer, 0, bytesRead);

                Console.WriteLine(response);

                // Xử lý phản hồi
                string[] userInfo = response.Split('|');
                if (userInfo.Length == 4) // Giả định phản hồi có 4 phần: Fullname, Username, Email, Birthday
                {
                    TB_FullName.Text = userInfo[0];
                    TB_Username.Text = userInfo[1];
                    TB_Email.Text = userInfo[2];
                    TB_Birthday.Text = userInfo[3].Split(' ').Take(1).First(); // Lấy ngày sinh
                }
                else
                {
                    MessageBox.Show("User not found or invalid response.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}