using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            bool validSignUp = true;
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
        }
    }
    private bool IsConfirmPassSame(string pass, string confirmPass)
    {
        return pass == confirmPass;
    }

    }
}
