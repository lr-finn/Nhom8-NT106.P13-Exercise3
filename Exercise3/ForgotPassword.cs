using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Net.Sockets;

namespace Exercise3
{
    public partial class ForgotPassword : Form
    {
        private string tcpServerIp = "localhost"; // IP server
        private int tcpServerPort = 3080;         // Port server

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void BT_Send_Click(object sender, EventArgs e)
        {
            LB_CautionEmail.Visible = false;
            LB_EmailExist.Visible = false;

            if (TB_Email.Text == "")
            {
                LB_CautionEmail.Visible = true;
                return;
            }
            if (IsValidEmail(TB_Email.Text) == false)
            {
                LB_InvalidEmail.Visible = true;
                return;
            }
            if (IsEmailExist(TB_Email.Text) == false)
            {
                MessageBox.Show("Email does not existed.");
                return;
            }

            string email = TB_Email.Text.Trim();
            string forgotpasswordCommand = $"RESETPASSWORD|{email}";

            //gửi yêu cầu đến TCP server
            string respond = SendRequestToServer(forgotpasswordCommand);
            if (respond == "Email not found")
            {
                LB_EmailExist.Visible = true;
            }
            else
            {
                MessageBox.Show("Password has been sent to your email");
            }
        }
        private string SendRequestToServer(string request)
        {
            using TcpClient client = new(tcpServerIp, tcpServerPort);
            using NetworkStream stream = client.GetStream();

            // gửi dữ liệu đến server
            byte[] data = Encoding.UTF8.GetBytes(request);
            stream.Write(data, 0, data.Length);

            // nhận dữ liệu từ server
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string respond = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            stream.Close();
            client.Close();
            return respond;
        }
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
        private bool IsEmailExist(string email)
        {
            string response = SendRequestToServer($"CHECKEMAIL|{email}");
            if (response == "Email existed")
            {
                return true;
            }
            return false;
        }
    }
}
