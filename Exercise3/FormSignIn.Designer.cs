using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;
using Font = System.Drawing.Font;

namespace Exercise3;

partial class FormSignIn
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        LB_UserName = new Label();
        TB_UserName = new TextBox();
        LB_Pass = new Label();
        TB_Pass = new TextBox();
        BT_SignIn = new Button();
        LB_SignUp = new Label();
        label3 = new Label();
        LB_UserNameExisted = new Label();
        LB_CautionLogin = new Label();
        lbForgotPassword = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.White;
        label1.Font = new Font("Montserrat", 36F, FontStyle.Regular, GraphicsUnit.Point, 163);
        label1.ForeColor = Color.FromArgb(76, 192, 165);
        label1.Location = new Point(185, 9);
        label1.Name = "label1";
        label1.Size = new Size(205, 83);
        label1.TabIndex = 0;
        label1.Text = "Login";
        // 
        // LB_UserName
        // 
        LB_UserName.AutoSize = true;
        LB_UserName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_UserName.Location = new Point(64, 105);
        LB_UserName.Name = "LB_UserName";
        LB_UserName.Size = new Size(117, 27);
        LB_UserName.TabIndex = 1;
        LB_UserName.Text = "Username";
        // 
        // TB_UserName
        // 
        TB_UserName.BackColor = Color.White;
        TB_UserName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_UserName.Location = new Point(64, 146);
        TB_UserName.Name = "TB_UserName";
        TB_UserName.Size = new Size(420, 32);
        TB_UserName.TabIndex = 2;
        // 
        // LB_Pass
        // 
        LB_Pass.AutoSize = true;
        LB_Pass.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Pass.Location = new Point(64, 208);
        LB_Pass.Name = "LB_Pass";
        LB_Pass.Size = new Size(111, 27);
        LB_Pass.TabIndex = 1;
        LB_Pass.Text = "Password";
        // 
        // TB_Pass
        // 
        TB_Pass.BackColor = Color.White;
        TB_Pass.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Pass.Location = new Point(64, 249);
        TB_Pass.Name = "TB_Pass";
        TB_Pass.PasswordChar = '*';
        TB_Pass.Size = new Size(420, 32);
        TB_Pass.TabIndex = 2;
        // 
        // BT_SignIn
        // 
        BT_SignIn.BackColor = Color.FromArgb(76, 192, 165);
        BT_SignIn.Font = new Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
        BT_SignIn.ForeColor = Color.White;
        BT_SignIn.Location = new Point(148, 348);
        BT_SignIn.Name = "BT_SignIn";
        BT_SignIn.Size = new Size(266, 52);
        BT_SignIn.TabIndex = 3;
        BT_SignIn.Text = "Sign In";
        BT_SignIn.UseVisualStyleBackColor = false;
        BT_SignIn.Click += BT_SignIn_Click;
        // 
        // LB_SignUp
        // 
        LB_SignUp.AutoSize = true;
        LB_SignUp.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
        LB_SignUp.ForeColor = Color.FromArgb(104, 202, 167);
        LB_SignUp.Location = new Point(373, 419);
        LB_SignUp.Name = "LB_SignUp";
        LB_SignUp.Size = new Size(95, 27);
        LB_SignUp.TabIndex = 4;
        LB_SignUp.Text = "Sign Up";
        LB_SignUp.Click += LB_SignUp_Click;
        LB_SignUp.MouseEnter += LB_SignUp_MouseEnter;
        LB_SignUp.MouseLeave += LB_SignUp_MouseLeave;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        label3.Location = new Point(116, 419);
        label3.Name = "label3";
        label3.Size = new Size(251, 27);
        label3.TabIndex = 5;
        label3.Text = "Don't have an account?";
        // 
        // LB_UserNameExisted
        // 
        LB_UserNameExisted.AutoSize = true;
        LB_UserNameExisted.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_UserNameExisted.ForeColor = Color.Red;
        LB_UserNameExisted.Location = new Point(64, 181);
        LB_UserNameExisted.Name = "LB_UserNameExisted";
        LB_UserNameExisted.Size = new Size(0, 18);
        LB_UserNameExisted.TabIndex = 14;
        LB_UserNameExisted.Visible = false;
        // 
        // LB_CautionLogin
        // 
        LB_CautionLogin.AutoSize = true;
        LB_CautionLogin.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_CautionLogin.ForeColor = Color.Red;
        LB_CautionLogin.Location = new Point(64, 284);
        LB_CautionLogin.Name = "LB_CautionLogin";
        LB_CautionLogin.Size = new Size(341, 18);
        LB_CautionLogin.TabIndex = 14;
        LB_CautionLogin.Text = "* Incorrect username or password. Please try again.";
        LB_CautionLogin.Visible = false;
        // 
        // lbForgotPassword
        // 
        lbForgotPassword.AutoSize = true;
        lbForgotPassword.Font = new Font("Montserrat", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
        lbForgotPassword.ForeColor = Color.Black;
        lbForgotPassword.Location = new Point(275, 312);
        lbForgotPassword.Name = "lbForgotPassword";
        lbForgotPassword.Size = new Size(209, 24);
        lbForgotPassword.TabIndex = 15;
        lbForgotPassword.Text = "Forgot Your Password?";
        lbForgotPassword.Click += lbForgotPassword_Click;
        lbForgotPassword.MouseEnter += lbForgotPassword_MouseEnter;
        lbForgotPassword.MouseLeave += lbForgotPassword_MouseLeave;
        // 
        // FormSignIn
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        BackgroundImageLayout = ImageLayout.None;
        ClientSize = new Size(582, 503);
        Controls.Add(lbForgotPassword);
        Controls.Add(LB_CautionLogin);
        Controls.Add(LB_UserNameExisted);
        Controls.Add(label3);
        Controls.Add(LB_SignUp);
        Controls.Add(BT_SignIn);
        Controls.Add(TB_Pass);
        Controls.Add(LB_Pass);
        Controls.Add(TB_UserName);
        Controls.Add(LB_UserName);
        Controls.Add(label1);
        MaximumSize = new Size(600, 550);
        MinimumSize = new Size(600, 550);
        Name = "FormSignIn";
        Text = "FormSignIn";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label LB_UserName;
    private TextBox TB_UserName;
    private Label LB_Pass;
    private TextBox TB_Pass;
    private Button BT_SignIn;
    private Label LB_SignUp;
    private Label label3;
    private Label LB_UserNameExisted;
    private Label LB_CautionLogin;
    private Label lbForgotPassword;
}
