using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;

namespace Exercise3;

partial class FormSignUp
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LB_Regis = new Label();
        label3 = new Label();
        LB_SignIn = new Label();
        BT_SignUp = new Button();
        TB_Pass = new TextBox();
        LB_Pass = new Label();
        TB_UserName = new TextBox();
        LB_UserName = new Label();
        LB_Email = new Label();
        TB_Email = new TextBox();
        LB_Confirm = new Label();
        TB_ConfirmPass = new TextBox();
        LB_CautionUserName = new Label();
        LB_CautionEmail = new Label();
        LB_CautionPass = new Label();
        LB_CautionConfirmPass = new Label();
        LB_DidntMatch = new Label();
        LB_UserNameExisted = new Label();
        LB_EmailExist = new Label();
        LB_InvalidEmail = new Label();
        LB_EnterFullName = new Label();
        TB_FullName = new TextBox();
        LB_FullName = new Label();
        LB_EnterBirthday = new Label();
        TB_Birthday = new TextBox();
        LB_Birthday = new Label();
        SuspendLayout();
        // 
        // LB_Regis
        // 
        LB_Regis.AutoSize = true;
        LB_Regis.BackColor = Color.White;
        LB_Regis.Font = new Font("Montserrat", 36F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Regis.ForeColor = Color.Black;
        LB_Regis.Location = new Point(75, 31);
        LB_Regis.Name = "LB_Regis";
        LB_Regis.Size = new Size(399, 83);
        LB_Regis.TabIndex = 1;
        LB_Regis.Text = "Registration";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        label3.Location = new Point(630, 485);
        label3.Name = "label3";
        label3.Size = new Size(260, 27);
        label3.TabIndex = 12;
        label3.Text = "Already have an account";
        // 
        // LB_SignIn
        // 
        LB_SignIn.AutoSize = true;
        LB_SignIn.Font = new Font("Montserrat", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
        LB_SignIn.ForeColor = Color.FromArgb(64, 112, 244);
        LB_SignIn.Location = new Point(896, 485);
        LB_SignIn.Name = "LB_SignIn";
        LB_SignIn.Size = new Size(125, 27);
        LB_SignIn.TabIndex = 11;
        LB_SignIn.Text = "Login Now";
        LB_SignIn.Click += LB_SignIn_Click;
        LB_SignIn.MouseEnter += LB_SignIn_MouseEnter;
        LB_SignIn.MouseLeave += LB_SignIn_MouseLeave;
        // 
        // BT_SignUp
        // 
        BT_SignUp.BackColor = Color.FromArgb(64, 112, 244);
        BT_SignUp.Font = new Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
        BT_SignUp.ForeColor = Color.White;
        BT_SignUp.Location = new Point(682, 414);
        BT_SignUp.Name = "BT_SignUp";
        BT_SignUp.Size = new Size(266, 52);
        BT_SignUp.TabIndex = 10;
        BT_SignUp.Text = "Sign Up";
        BT_SignUp.UseVisualStyleBackColor = false;
        BT_SignUp.Click += BT_SignUp_Click;
        // 
        // TB_Pass
        // 
        TB_Pass.BackColor = Color.White;
        TB_Pass.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Pass.Location = new Point(76, 401);
        TB_Pass.Name = "TB_Pass";
        TB_Pass.PasswordChar = '*';
        TB_Pass.Size = new Size(420, 32);
        TB_Pass.TabIndex = 8;
        // 
        // LB_Pass
        // 
        LB_Pass.AutoSize = true;
        LB_Pass.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Pass.Location = new Point(76, 360);
        LB_Pass.Name = "LB_Pass";
        LB_Pass.Size = new Size(111, 27);
        LB_Pass.TabIndex = 6;
        LB_Pass.Text = "Password";
        // 
        // TB_UserName
        // 
        TB_UserName.BackColor = Color.White;
        TB_UserName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_UserName.Location = new Point(76, 189);
        TB_UserName.Name = "TB_UserName";
        TB_UserName.Size = new Size(420, 32);
        TB_UserName.TabIndex = 9;
        // 
        // LB_UserName
        // 
        LB_UserName.AutoSize = true;
        LB_UserName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_UserName.Location = new Point(76, 148);
        LB_UserName.Name = "LB_UserName";
        LB_UserName.Size = new Size(117, 27);
        LB_UserName.TabIndex = 7;
        LB_UserName.Text = "Username";
        // 
        // LB_Email
        // 
        LB_Email.AutoSize = true;
        LB_Email.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Email.Location = new Point(76, 252);
        LB_Email.Name = "LB_Email";
        LB_Email.Size = new Size(68, 27);
        LB_Email.TabIndex = 6;
        LB_Email.Text = "Email";
        // 
        // TB_Email
        // 
        TB_Email.BackColor = Color.White;
        TB_Email.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Email.Location = new Point(76, 293);
        TB_Email.Name = "TB_Email";
        TB_Email.Size = new Size(420, 32);
        TB_Email.TabIndex = 8;
        // 
        // LB_Confirm
        // 
        LB_Confirm.AutoSize = true;
        LB_Confirm.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Confirm.Location = new Point(76, 467);
        LB_Confirm.Name = "LB_Confirm";
        LB_Confirm.Size = new Size(198, 27);
        LB_Confirm.TabIndex = 6;
        LB_Confirm.Text = "Confirm Password";
        // 
        // TB_ConfirmPass
        // 
        TB_ConfirmPass.BackColor = Color.White;
        TB_ConfirmPass.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_ConfirmPass.Location = new Point(76, 508);
        TB_ConfirmPass.Name = "TB_ConfirmPass";
        TB_ConfirmPass.PasswordChar = '*';
        TB_ConfirmPass.Size = new Size(420, 32);
        TB_ConfirmPass.TabIndex = 8;
        // 
        // LB_CautionUserName
        // 
        LB_CautionUserName.AutoSize = true;
        LB_CautionUserName.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_CautionUserName.ForeColor = Color.Red;
        LB_CautionUserName.Location = new Point(76, 224);
        LB_CautionUserName.Name = "LB_CautionUserName";
        LB_CautionUserName.Size = new Size(129, 18);
        LB_CautionUserName.TabIndex = 13;
        LB_CautionUserName.Text = "* Enter User Name";
        LB_CautionUserName.Visible = false;
        // 
        // LB_CautionEmail
        // 
        LB_CautionEmail.AutoSize = true;
        LB_CautionEmail.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_CautionEmail.ForeColor = Color.Red;
        LB_CautionEmail.Location = new Point(76, 328);
        LB_CautionEmail.Name = "LB_CautionEmail";
        LB_CautionEmail.Size = new Size(93, 18);
        LB_CautionEmail.TabIndex = 13;
        LB_CautionEmail.Text = "* Enter Email";
        LB_CautionEmail.Visible = false;
        // 
        // LB_CautionPass
        // 
        LB_CautionPass.AutoSize = true;
        LB_CautionPass.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_CautionPass.ForeColor = Color.Red;
        LB_CautionPass.Location = new Point(75, 436);
        LB_CautionPass.Name = "LB_CautionPass";
        LB_CautionPass.Size = new Size(296, 18);
        LB_CautionPass.TabIndex = 13;
        LB_CautionPass.Text = "* Use 8 characters or more for your password";
        LB_CautionPass.Visible = false;
        // 
        // LB_CautionConfirmPass
        // 
        LB_CautionConfirmPass.AutoSize = true;
        LB_CautionConfirmPass.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_CautionConfirmPass.ForeColor = Color.Red;
        LB_CautionConfirmPass.Location = new Point(76, 543);
        LB_CautionConfirmPass.Name = "LB_CautionConfirmPass";
        LB_CautionConfirmPass.Size = new Size(167, 18);
        LB_CautionConfirmPass.TabIndex = 13;
        LB_CautionConfirmPass.Text = "* Confirm Your Password";
        LB_CautionConfirmPass.Visible = false;
        // 
        // LB_DidntMatch
        // 
        LB_DidntMatch.AutoSize = true;
        LB_DidntMatch.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_DidntMatch.ForeColor = Color.Red;
        LB_DidntMatch.Location = new Point(76, 543);
        LB_DidntMatch.Name = "LB_DidntMatch";
        LB_DidntMatch.Size = new Size(284, 18);
        LB_DidntMatch.TabIndex = 13;
        LB_DidntMatch.Text = "* Those passwords didn’t match. Try again.";
        LB_DidntMatch.Visible = false;
        // 
        // LB_UserNameExisted
        // 
        LB_UserNameExisted.AutoSize = true;
        LB_UserNameExisted.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_UserNameExisted.ForeColor = Color.Red;
        LB_UserNameExisted.Location = new Point(76, 224);
        LB_UserNameExisted.Name = "LB_UserNameExisted";
        LB_UserNameExisted.Size = new Size(139, 18);
        LB_UserNameExisted.TabIndex = 13;
        LB_UserNameExisted.Text = "* Username is taken";
        LB_UserNameExisted.Visible = false;
        // 
        // LB_EmailExist
        // 
        LB_EmailExist.AutoSize = true;
        LB_EmailExist.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_EmailExist.ForeColor = Color.Red;
        LB_EmailExist.Location = new Point(76, 328);
        LB_EmailExist.Name = "LB_EmailExist";
        LB_EmailExist.Size = new Size(139, 18);
        LB_EmailExist.TabIndex = 13;
        LB_EmailExist.Text = "* Email already exist";
        LB_EmailExist.Visible = false;
        // 
        // LB_InvalidEmail
        // 
        LB_InvalidEmail.AutoSize = true;
        LB_InvalidEmail.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_InvalidEmail.ForeColor = Color.Red;
        LB_InvalidEmail.Location = new Point(76, 328);
        LB_InvalidEmail.Name = "LB_InvalidEmail";
        LB_InvalidEmail.Size = new Size(155, 18);
        LB_InvalidEmail.TabIndex = 13;
        LB_InvalidEmail.Text = "* Invalid email address";
        LB_InvalidEmail.Visible = false;
        // 
        // LB_EnterFullName
        // 
        LB_EnterFullName.AutoSize = true;
        LB_EnterFullName.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_EnterFullName.ForeColor = Color.Red;
        LB_EnterFullName.Location = new Point(586, 224);
        LB_EnterFullName.Name = "LB_EnterFullName";
        LB_EnterFullName.Size = new Size(123, 18);
        LB_EnterFullName.TabIndex = 16;
        LB_EnterFullName.Text = "* Enter Full Name";
        LB_EnterFullName.Visible = false;
        // 
        // TB_FullName
        // 
        TB_FullName.BackColor = Color.White;
        TB_FullName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_FullName.Location = new Point(586, 189);
        TB_FullName.Name = "TB_FullName";
        TB_FullName.Size = new Size(420, 32);
        TB_FullName.TabIndex = 15;
        // 
        // LB_FullName
        // 
        LB_FullName.AutoSize = true;
        LB_FullName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_FullName.Location = new Point(586, 148);
        LB_FullName.Name = "LB_FullName";
        LB_FullName.Size = new Size(114, 27);
        LB_FullName.TabIndex = 14;
        LB_FullName.Text = "Full Name";
        // 
        // LB_EnterBirthday
        // 
        LB_EnterBirthday.AutoSize = true;
        LB_EnterBirthday.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
        LB_EnterBirthday.ForeColor = Color.Red;
        LB_EnterBirthday.Location = new Point(586, 328);
        LB_EnterBirthday.Name = "LB_EnterBirthday";
        LB_EnterBirthday.Size = new Size(112, 18);
        LB_EnterBirthday.TabIndex = 20;
        LB_EnterBirthday.Text = "* Enter Birthday";
        LB_EnterBirthday.Visible = false;
        // 
        // TB_Birthday
        // 
        TB_Birthday.BackColor = Color.White;
        TB_Birthday.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Birthday.Location = new Point(586, 293);
        TB_Birthday.Name = "TB_Birthday";
        TB_Birthday.Size = new Size(420, 32);
        TB_Birthday.TabIndex = 19;
        // 
        // LB_Birthday
        // 
        LB_Birthday.AutoSize = true;
        LB_Birthday.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Birthday.Location = new Point(586, 252);
        LB_Birthday.Name = "LB_Birthday";
        LB_Birthday.Size = new Size(99, 27);
        LB_Birthday.TabIndex = 18;
        LB_Birthday.Text = "Birthday";
        // 
        // FormSignUp
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(1092, 602);
        Controls.Add(LB_EnterBirthday);
        Controls.Add(TB_Birthday);
        Controls.Add(LB_Birthday);
        Controls.Add(LB_EnterFullName);
        Controls.Add(TB_FullName);
        Controls.Add(LB_FullName);
        Controls.Add(LB_DidntMatch);
        Controls.Add(LB_CautionConfirmPass);
        Controls.Add(LB_CautionPass);
        Controls.Add(LB_InvalidEmail);
        Controls.Add(LB_EmailExist);
        Controls.Add(LB_CautionEmail);
        Controls.Add(LB_UserNameExisted);
        Controls.Add(LB_CautionUserName);
        Controls.Add(label3);
        Controls.Add(LB_SignIn);
        Controls.Add(BT_SignUp);
        Controls.Add(TB_Email);
        Controls.Add(LB_Email);
        Controls.Add(TB_ConfirmPass);
        Controls.Add(LB_Confirm);
        Controls.Add(TB_Pass);
        Controls.Add(LB_Pass);
        Controls.Add(TB_UserName);
        Controls.Add(LB_UserName);
        Controls.Add(LB_Regis);
        Name = "FormSignUp";
        Text = "FormSignUp";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label LB_Regis;
    private Label label3;
    private Label LB_SignIn;
    private Button BT_SignUp;
    private TextBox TB_Pass;
    private Label LB_Pass;
    private TextBox TB_UserName;
    private Label LB_UserName;
    private Label LB_Email;
    private TextBox TB_Email;
    private Label LB_Confirm;
    private TextBox TB_ConfirmPass;
    private Label LB_CautionUserName;
    private Label LB_CautionEmail;
    private Label LB_CautionPass;
    private Label LB_CautionConfirmPass;
    private Label LB_DidntMatch;
    private Label LB_UserNameExisted;
    private Label LB_EmailExist;
    private Label LB_InvalidEmail;
    private Label LB_EnterFullName;
    private TextBox TB_FullName;
    private Label LB_FullName;
    private Label LB_EnterBirthday;
    private TextBox TB_Birthday;
    private Label LB_Birthday;
}