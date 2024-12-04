using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Security.Cryptography;
using Exercise3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Exercise3
{
    public partial class ChangePassword : Form
    {
        private string tcpServerIp = "localhost"; // IP server
        private int tcpServerPort = 3080;         // Port server
        public ChangePassword()
        {
            InitializeComponent();
        }
        private void BT_Confirm_Click(object sender, EventArgs e)
        {
            LB_CautionConfirmNewPass.Visible = false;
            LB_CautionNewPass.Visible = false;
            LB_DidntMatch.Visible = false;
            LB_WrongPassword.Visible = false;
            LB_CautionUserName.Visible = false;

            bool validSignUp = true;
            if (TB_UserName.Text == "")
            {
                LB_CautionUserName.Visible = true;
                validSignUp = false;
            }
            if (TB_Pass.Text == "")
            {
                LB_WrongPassword.Visible = true;
                validSignUp = false;
            }
            if (TB_NewPass.Text == "")
            {
                LB_CautionNewPass.Visible = true;
                validSignUp = false;
            }
            if (TB_ConfirmPass.Text == "")
            {
                LB_CautionConfirmNewPass.Visible = true;
                validSignUp = false;
            }
            if (IsConfirmPassSame(TB_NewPass.Text, TB_ConfirmPass.Text) == false)
            {
                LB_DidntMatch.Visible = true;
                validSignUp = false;
            }
            if (!validSignUp) return;
            
            string username = TB_UserName.Text;
            string oldPass = TB_Pass.Text;
            string newPass = TB_NewPass.Text;
            string hashedOldPass = HashPassword(oldPass);
            string hashedNewPass = HashPassword(newPass);

            string changePasswordCommand = $"CHANGEPASSWORD|{username}|{hashedOldPass}|{hashedNewPass}";
            string response = SendRequestToServer(changePasswordCommand);

            if (response == "Password changed successfully")
            {
                MessageBox.Show("Password has been changed successfully.", "Success");
                this.Close();
            }
            else
            {
                MessageBox.Show(response, "Error");
            }
        }
        private bool IsConfirmPassSame(string pass, string confirmPass)
        {
            return pass == confirmPass;
        }
        private string HashPassword(string password)
        {
            byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(password));
            return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
        }
        private string SendRequestToServer(string request)
        {
            using TcpClient client = new TcpClient(tcpServerIp, tcpServerPort);
            using NetworkStream stream = client.GetStream();

            byte[] data = Encoding.UTF8.GetBytes(request);
            stream.Write(data, 0, data.Length);

            // Nhận dữ liệu từ server
            byte[] buffer = new byte[1024];
            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            string response = Encoding.UTF8.GetString(buffer, 0, bytesRead);
            return response;
        }
    }
}
