namespace Exercise3
{
    partial class ChangePassword
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
            BT_Confirm = new Button();
            LB_DidntMatch = new Label();
            LB_CautionConfirmNewPass = new Label();
            LB_CautionNewPass = new Label();
            TB_ConfirmPass = new TextBox();
            LB_Confirm = new Label();
            TB_NewPass = new TextBox();
            LB_Pass = new Label();
            TB_Pass = new TextBox();
            label2 = new Label();
            lbChange = new Label();
            LB_WrongPassword = new Label();
            SuspendLayout();
            // 
            // BT_Confirm
            // 
            BT_Confirm.BackColor = Color.FromArgb(64, 112, 244);
            BT_Confirm.Font = new Font("Microsoft Sans Serif", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
            BT_Confirm.ForeColor = Color.White;
            BT_Confirm.Location = new Point(223, 476);
            BT_Confirm.Name = "BT_Confirm";
            BT_Confirm.Size = new Size(190, 52);
            BT_Confirm.TabIndex = 20;
            BT_Confirm.Text = "Confirm";
            BT_Confirm.UseVisualStyleBackColor = false;
            BT_Confirm.Click += BT_Confirm_Click;
            // 
            // LB_DidntMatch
            // 
            LB_DidntMatch.AutoSize = true;
            LB_DidntMatch.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_DidntMatch.ForeColor = Color.Red;
            LB_DidntMatch.Location = new Point(113, 403);
            LB_DidntMatch.Name = "LB_DidntMatch";
            LB_DidntMatch.Size = new Size(263, 16);
            LB_DidntMatch.TabIndex = 25;
            LB_DidntMatch.Text = "* Those passwords didn’t match. Try again.";
            LB_DidntMatch.Visible = false;
            // 
            // LB_CautionConfirmNewPass
            // 
            LB_CautionConfirmNewPass.AutoSize = true;
            LB_CautionConfirmNewPass.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_CautionConfirmNewPass.ForeColor = Color.Red;
            LB_CautionConfirmNewPass.Location = new Point(113, 405);
            LB_CautionConfirmNewPass.Name = "LB_CautionConfirmNewPass";
            LB_CautionConfirmNewPass.Size = new Size(154, 16);
            LB_CautionConfirmNewPass.TabIndex = 26;
            LB_CautionConfirmNewPass.Text = "* Confirm Your Password";
            LB_CautionConfirmNewPass.Visible = false;
            // 
            // LB_CautionNewPass
            // 
            LB_CautionNewPass.AutoSize = true;
            LB_CautionNewPass.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_CautionNewPass.ForeColor = Color.Red;
            LB_CautionNewPass.Location = new Point(114, 296);
            LB_CautionNewPass.Name = "LB_CautionNewPass";
            LB_CautionNewPass.Size = new Size(274, 16);
            LB_CautionNewPass.TabIndex = 27;
            LB_CautionNewPass.Text = "* Use 8 characters or more for your password";
            LB_CautionNewPass.Visible = false;
            // 
            // TB_ConfirmPass
            // 
            TB_ConfirmPass.BackColor = Color.White;
            TB_ConfirmPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TB_ConfirmPass.Location = new Point(113, 370);
            TB_ConfirmPass.Name = "TB_ConfirmPass";
            TB_ConfirmPass.PasswordChar = '*';
            TB_ConfirmPass.Size = new Size(420, 30);
            TB_ConfirmPass.TabIndex = 23;
            // 
            // LB_Confirm
            // 
            LB_Confirm.AutoSize = true;
            LB_Confirm.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            LB_Confirm.Location = new Point(113, 329);
            LB_Confirm.Name = "LB_Confirm";
            LB_Confirm.Size = new Size(171, 25);
            LB_Confirm.TabIndex = 21;
            LB_Confirm.Text = "Confirm Password";
            // 
            // TB_NewPass
            // 
            TB_NewPass.BackColor = Color.White;
            TB_NewPass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TB_NewPass.Location = new Point(113, 263);
            TB_NewPass.Name = "TB_NewPass";
            TB_NewPass.PasswordChar = '*';
            TB_NewPass.Size = new Size(420, 30);
            TB_NewPass.TabIndex = 24;
            // 
            // LB_Pass
            // 
            LB_Pass.AutoSize = true;
            LB_Pass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            LB_Pass.Location = new Point(113, 222);
            LB_Pass.Name = "LB_Pass";
            LB_Pass.Size = new Size(142, 25);
            LB_Pass.TabIndex = 22;
            LB_Pass.Text = "New Password";
            // 
            // TB_Pass
            // 
            TB_Pass.BackColor = Color.White;
            TB_Pass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TB_Pass.Location = new Point(114, 147);
            TB_Pass.Name = "TB_Pass";
            TB_Pass.PasswordChar = '*';
            TB_Pass.Size = new Size(420, 30);
            TB_Pass.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(114, 106);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 28;
            label2.Text = "Password";
            // 
            // lbChange
            // 
            lbChange.AutoSize = true;
            lbChange.BackColor = Color.Transparent;
            lbChange.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbChange.ForeColor = Color.Black;
            lbChange.Location = new Point(140, 25);
            lbChange.Name = "lbChange";
            lbChange.Size = new Size(378, 52);
            lbChange.TabIndex = 31;
            lbChange.Text = "Change Password";
            // 
            // LB_WrongPassword
            // 
            LB_WrongPassword.AutoSize = true;
            LB_WrongPassword.Font = new Font("Microsoft Sans Serif", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_WrongPassword.ForeColor = Color.Red;
            LB_WrongPassword.Location = new Point(113, 182);
            LB_WrongPassword.Name = "LB_WrongPassword";
            LB_WrongPassword.Size = new Size(118, 16);
            LB_WrongPassword.TabIndex = 30;
            LB_WrongPassword.Text = "* Wrong Password";
            LB_WrongPassword.Visible = false;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 566);
            Controls.Add(lbChange);
            Controls.Add(LB_WrongPassword);
            Controls.Add(TB_Pass);
            Controls.Add(label2);
            Controls.Add(LB_DidntMatch);
            Controls.Add(LB_CautionConfirmNewPass);
            Controls.Add(LB_CautionNewPass);
            Controls.Add(TB_ConfirmPass);
            Controls.Add(LB_Confirm);
            Controls.Add(TB_NewPass);
            Controls.Add(LB_Pass);
            Controls.Add(BT_Confirm);
            Name = "ChangePassword";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BT_Confirm;
        private Label LB_DidntMatch;
        private Label LB_CautionConfirmNewPass;
        private Label LB_CautionNewPass;
        private TextBox TB_ConfirmPass;
        private Label LB_Confirm;
        private TextBox TB_NewPass;
        private Label LB_Pass;
        private TextBox TB_Pass;
        private Label label2;
        private Label lbChange;
        private Label LB_WrongPassword;
    }
}