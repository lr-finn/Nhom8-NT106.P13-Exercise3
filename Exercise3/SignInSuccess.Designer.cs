using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using Font = System.Drawing.Font;
using Image = System.Drawing.Image;

namespace Exercise3;

partial class SignInSuccess
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInSuccess));
        LB_Welcome = new Label();
        LB_Greet = new Label();
        TB_Email = new TextBox();
        TB_Username = new TextBox();
        TB_Birthday = new TextBox();
        TB_FullName = new TextBox();
        SuspendLayout();
        // 
        // LB_Welcome
        // 
        LB_Welcome.AutoSize = true;
        LB_Welcome.BackColor = Color.Transparent;
        LB_Welcome.Font = new Font("Montserrat", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Welcome.ForeColor = Color.Black;
        LB_Welcome.Location = new Point(79, 130);
        LB_Welcome.Name = "LB_Welcome";
        LB_Welcome.Size = new Size(368, 61);
        LB_Welcome.TabIndex = 2;
        LB_Welcome.Text = "Welcome back,";
        // 
        // LB_Greet
        // 
        LB_Greet.AutoSize = true;
        LB_Greet.BackColor = Color.Transparent;
        LB_Greet.Font = new Font("Montserrat", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
        LB_Greet.ForeColor = Color.Black;
        LB_Greet.Location = new Point(79, 428);
        LB_Greet.Name = "LB_Greet";
        LB_Greet.Size = new Size(258, 39);
        LB_Greet.TabIndex = 2;
        LB_Greet.Text = "Have a great day.";
        // 
        // TB_Email
        // 
        TB_Email.BackColor = Color.FromArgb(231, 239, 242);
        TB_Email.BorderStyle = BorderStyle.None;
        TB_Email.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Email.ForeColor = Color.Black;
        TB_Email.Location = new Point(95, 298);
        TB_Email.Multiline = true;
        TB_Email.Name = "TB_Email";
        TB_Email.ReadOnly = true;
        TB_Email.ShortcutsEnabled = false;
        TB_Email.Size = new Size(336, 41);
        TB_Email.TabIndex = 3;
        TB_Email.TabStop = false;
        // 
        // TB_Username
        // 
        TB_Username.BackColor = Color.FromArgb(231, 239, 242);
        TB_Username.BorderStyle = BorderStyle.None;
        TB_Username.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Username.ForeColor = Color.Black;
        TB_Username.Location = new Point(95, 251);
        TB_Username.Multiline = true;
        TB_Username.Name = "TB_Username";
        TB_Username.ReadOnly = true;
        TB_Username.ShortcutsEnabled = false;
        TB_Username.Size = new Size(336, 41);
        TB_Username.TabIndex = 3;
        TB_Username.TabStop = false;
        // 
        // TB_Birthday
        // 
        TB_Birthday.BackColor = Color.FromArgb(231, 239, 242);
        TB_Birthday.BorderStyle = BorderStyle.None;
        TB_Birthday.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_Birthday.ForeColor = Color.Black;
        TB_Birthday.Location = new Point(95, 345);
        TB_Birthday.Multiline = true;
        TB_Birthday.Name = "TB_Birthday";
        TB_Birthday.ReadOnly = true;
        TB_Birthday.ShortcutsEnabled = false;
        TB_Birthday.Size = new Size(336, 41);
        TB_Birthday.TabIndex = 4;
        TB_Birthday.TabStop = false;
        // 
        // TB_FullName
        // 
        TB_FullName.BackColor = Color.FromArgb(231, 239, 242);
        TB_FullName.BorderStyle = BorderStyle.None;
        TB_FullName.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
        TB_FullName.ForeColor = Color.Black;
        TB_FullName.Location = new Point(95, 204);
        TB_FullName.Multiline = true;
        TB_FullName.Name = "TB_FullName";
        TB_FullName.ReadOnly = true;
        TB_FullName.ShortcutsEnabled = false;
        TB_FullName.Size = new Size(336, 41);
        TB_FullName.TabIndex = 5;
        TB_FullName.TabStop = false;
        // 
        // SignInSuccess
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
        BackgroundImageLayout = ImageLayout.Stretch;
        ClientSize = new Size(534, 638);
        Controls.Add(TB_Birthday);
        Controls.Add(TB_FullName);
        Controls.Add(TB_Email);
        Controls.Add(TB_Username);
        Controls.Add(LB_Greet);
        Controls.Add(LB_Welcome);
        MaximumSize = new Size(552, 685);
        Name = "SignInSuccess";
        Text = "FormLoginSuccess";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label LB_Welcome;
    private Label LB_Greet;
    private TextBox TB_Email;
    private TextBox TB_Username;
    private TextBox TB_Birthday;
    private TextBox TB_FullName;
}