namespace Exercise3
{
    partial class ForgotPassword
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
            lbConfirm = new Label();
            LB_InvalidEmail = new Label();
            LB_EmailExist = new Label();
            LB_CautionEmail = new Label();
            TB_Email = new TextBox();
            lbDetail = new Label();
            BT_Send = new Button();
            SuspendLayout();
            // 
            // lbConfirm
            // 
            lbConfirm.AutoSize = true;
            lbConfirm.BackColor = Color.Transparent;
            lbConfirm.Font = new Font("Montserrat", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbConfirm.ForeColor = Color.Black;
            lbConfirm.Location = new Point(140, 19);
            lbConfirm.Name = "lbConfirm";
            lbConfirm.Size = new Size(376, 61);
            lbConfirm.TabIndex = 2;
            lbConfirm.Text = "Reset Password";
            // 
            // LB_InvalidEmail
            // 
            LB_InvalidEmail.AutoSize = true;
            LB_InvalidEmail.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_InvalidEmail.ForeColor = Color.Red;
            LB_InvalidEmail.Location = new Point(120, 198);
            LB_InvalidEmail.Name = "LB_InvalidEmail";
            LB_InvalidEmail.Size = new Size(155, 18);
            LB_InvalidEmail.TabIndex = 16;
            LB_InvalidEmail.Text = "* Invalid email address";
            LB_InvalidEmail.Visible = false;
            // 
            // LB_EmailExist
            // 
            LB_EmailExist.AutoSize = true;
            LB_EmailExist.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_EmailExist.ForeColor = Color.Red;
            LB_EmailExist.Location = new Point(120, 198);
            LB_EmailExist.Name = "LB_EmailExist";
            LB_EmailExist.Size = new Size(139, 18);
            LB_EmailExist.TabIndex = 17;
            LB_EmailExist.Text = "* Email already exist";
            LB_EmailExist.Visible = false;
            // 
            // LB_CautionEmail
            // 
            LB_CautionEmail.AutoSize = true;
            LB_CautionEmail.Font = new Font("Montserrat", 7.79999971F, FontStyle.Italic, GraphicsUnit.Point, 163);
            LB_CautionEmail.ForeColor = Color.Red;
            LB_CautionEmail.Location = new Point(120, 198);
            LB_CautionEmail.Name = "LB_CautionEmail";
            LB_CautionEmail.Size = new Size(93, 18);
            LB_CautionEmail.TabIndex = 18;
            LB_CautionEmail.Text = "* Enter Email";
            LB_CautionEmail.Visible = false;
            // 
            // TB_Email
            // 
            TB_Email.BackColor = Color.White;
            TB_Email.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            TB_Email.Location = new Point(120, 163);
            TB_Email.Name = "TB_Email";
            TB_Email.Size = new Size(420, 32);
            TB_Email.TabIndex = 15;
            // 
            // lbDetail
            // 
            lbDetail.AutoSize = true;
            lbDetail.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lbDetail.Location = new Point(52, 91);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(570, 27);
            lbDetail.TabIndex = 14;
            lbDetail.Text = "Please enter your email address to reset your password.\r\n";
            // 
            // BT_Send
            // 
            BT_Send.BackColor = Color.FromArgb(64, 112, 244);
            BT_Send.Font = new Font("Montserrat", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 163);
            BT_Send.ForeColor = Color.White;
            BT_Send.Location = new Point(191, 259);
            BT_Send.Name = "BT_Send";
            BT_Send.Size = new Size(266, 52);
            BT_Send.TabIndex = 19;
            BT_Send.Text = "Send";
            BT_Send.UseVisualStyleBackColor = false;
            BT_Send.Click += BT_Send_Click;
            // 
            // ForgotPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 372);
            Controls.Add(BT_Send);
            Controls.Add(LB_InvalidEmail);
            Controls.Add(LB_EmailExist);
            Controls.Add(LB_CautionEmail);
            Controls.Add(TB_Email);
            Controls.Add(lbDetail);
            Controls.Add(lbConfirm);
            Name = "ForgotPassword";
            Text = "ForgotPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbConfirm;
        private Label LB_InvalidEmail;
        private Label LB_EmailExist;
        private Label LB_CautionEmail;
        private TextBox TB_Email;
        private Label lbDetail;
        private Button BT_Send;
    }
}