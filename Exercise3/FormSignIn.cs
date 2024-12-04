using Exercise3;
using System.Net.Sockets;
using System.Security.Cryptography;
using System.Text;


namespace Exercise3;

public partial class FormSignIn : Form
{
    private string tcpServerIp = "localhost"; // IP của server
    private int tcpServerPort = 3080;         // Port server
    public FormSignIn()
    {
        InitializeComponent();
    }

    private void BT_SignIn_Click(object sender, EventArgs e)
    {
        string username = TB_UserName.Text;
        string pass = TB_Pass.Text;

        // hash the password with sha 256
        byte[] hashedBytes = SHA256.HashData(Encoding.UTF8.GetBytes(pass));
        string hashedpass = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        string loginCommand = $"LOGIN|{username}|{hashedpass}";

        //gửi yêu cầu đến TCP server
        string respond = SendRequestToServer(loginCommand);
        if (respond == "Login successful")
        {
            TimSach timSach = new TimSach();
            timSach.Show();
            timSach.FormClosed += (_, _) => this.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Login failed");
        }
    }

    private string SendRequestToServer(string request)
    {
        using TcpClient client = new TcpClient(tcpServerIp, tcpServerPort);
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

    private void LB_SignUp_Click(object sender, EventArgs e)
    {
        FormSignUp formSignUp = new FormSignUp();
        formSignUp.Show();
        formSignUp.FormClosed += (_, _) => this.Show();
        formSignUp.OnSignInClicked += (_, _) => this.Show();
        this.Hide();
    }
    private void LB_SignUp_MouseEnter(object sender, EventArgs e)
    {
        LB_SignUp.ForeColor = Color.FromArgb(34, 84, 72);
    }

    private void LB_SignUp_MouseLeave(object sender, EventArgs e)
    {
        LB_SignUp.ForeColor = Color.FromArgb(76, 192, 165);
    }

    private void lbForgotPassword_Click(object sender, EventArgs e)
    {
        ForgotPassword forgotPassword = new ForgotPassword();
        forgotPassword.Show();
        forgotPassword.FormClosed += (_, _) => this.Show();
        this.Hide();
    }
    private void lbForgotPassword_MouseEnter(object sender, EventArgs e)
    {
        lbForgotPassword.ForeColor = Color.FromArgb(76, 192, 165);
    }
    private void lbForgotPassword_MouseLeave(object sender, EventArgs e)
    {
        lbForgotPassword.ForeColor = Color.FromArgb(0, 0, 0);
    }
    private void lbChangePassword_Click(object sender, EventArgs e)
    {
        ChangePassword changePassword = new ChangePassword();
        changePassword.Show();
        changePassword.FormClosed += (_, _) => this.Show();
        this.Hide();
    }
}

