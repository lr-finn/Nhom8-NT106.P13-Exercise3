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

namespace Exercise3;

public partial class FormSignUp : Form
{
    private string tcpServerIp = "localhost"; // IP server
    private int tcpServerPort = 3080;         // Port server

    public FormSignUp()
    {
        InitializeComponent();
    }

    public event EventHandler OnSignInClicked;

    private void BT_SignUp_Click(object sender, EventArgs e)
    {
        LB_EnterBirthday.Visible = false;
        LB_EnterFullName.Visible = false;
        LB_CautionUserName.Visible = false;
        LB_CautionEmail.Visible = false;
        LB_CautionPass.Visible = false;
        LB_CautionConfirmPass.Visible = false;
        LB_UserNameExisted.Visible = false;
        LB_EmailExist.Visible = false;
        LB_InvalidEmail.Visible = false;
        LB_DidntMatch.Visible = false;

        bool validSignUp = true;
        if (TB_UserName.Text == "")
        {
            LB_CautionUserName.Visible = true; validSignUp = false;
        }
        if (TB_Email.Text == "")
        {
            LB_CautionEmail.Visible = true; validSignUp = false;
        }
        if (IsPasswordLong(TB_Pass.Text) == false)
        {
            LB_CautionPass.Visible = true; validSignUp = false;
        }
        if (TB_ConfirmPass.Text == "")
        {
            LB_CautionConfirmPass.Visible = true; validSignUp = false;
        }
        if (IsConfirmPassSame(TB_ConfirmPass.Text, TB_Pass.Text) == false)
        {
            LB_CautionConfirmPass.Visible = true; validSignUp = false;
        }
        if (IsUsernameExist(TB_UserName.Text) == true)
        {
            LB_UserNameExisted.Visible = true; validSignUp = false;
        }
        if (IsEmailExist(TB_Email.Text) == true)
        {
            LB_EmailExist.Visible = true; validSignUp = false;
        }
        if (IsValidEmail(TB_Email.Text) == false)
        {
            LB_InvalidEmail.Visible = true; validSignUp = false;
        }
        if (TB_ConfirmPass.Text != TB_Pass.Text)
        {
            LB_DidntMatch.Visible = true; validSignUp = false;
        }
        if (TB_FullName.Text == "")
        {
            LB_EnterFullName.Visible = true; validSignUp = false;
        }
        if (TB_Birthday.Text == "")
        {
            LB_EnterBirthday.Visible = true; validSignUp = false;
        }

        if (validSignUp == false) return;

        string username = TB_UserName.Text;
        string pass = TB_Pass.Text;
        string email = TB_Email.Text;
        string confirmPass = TB_ConfirmPass.Text;
        string fullName = TB_FullName.Text;
        string birthday = TB_Birthday.Text;

        // hash the password with sha 256
        byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(pass));
        string hashedpass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        string registerCommand = $"REGISTER|{fullName}|{username}|{email}|{birthday}|{hashedpass}";

        string respond = SendRequestToServer(registerCommand);

        if (respond == "Register successful")
        {
            MessageBox.Show("Register successful");
            OnSignInClicked(this, EventArgs.Empty);
            this.Close();
        }
        else
        {
            MessageBox.Show("Register failed");
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

    private bool IsUsernameExist(string username)
    {
        string response = SendRequestToServer($"CHECKUSERNAME|{username}");
        if (response == "Username existed")
        {
            return true;
        }
        return false;
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

    private bool IsConfirmPassSame(string pass, string confirmPass)
    {
        return pass == confirmPass;
    }

    private bool IsPasswordLong(string password)
    {
        if (password.Length < 8)
        {
            return false;
        }
        return true;
    }

    public static bool IsValidEmail(string email)
    {
        return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
    }


    private void LB_SignIn_Click(object sender, EventArgs e)
    {
        OnSignInClicked(this, EventArgs.Empty);
        this.Close();
    }

    private void LB_SignIn_MouseEnter(object sender, EventArgs e)
    {
        LB_SignIn.ForeColor = Color.FromArgb(14, 21, 94);
    }

    private void LB_SignIn_MouseLeave(object sender, EventArgs e)
    {
        LB_SignIn.ForeColor = Color.FromArgb(64, 112, 244);
    }
}