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
            LB_CautionConfirmPass.Visible = false;
            LB_CautionPass.Visible = false;
            LB_DidntMatch.Visible = false;
            LB_WrongPassword.Visible = false;
        }
    }
}
