namespace EntryLevel6Database
{
    partial class SignIn
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
            this.LogInbtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailLogin = new System.Windows.Forms.TextBox();
            this.txtPWLogin = new System.Windows.Forms.TextBox();
            this.lblCreateAccount = new System.Windows.Forms.Label();
            this.ExitCustomerSignbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogInbtn
            // 
            this.LogInbtn.Location = new System.Drawing.Point(194, 216);
            this.LogInbtn.Name = "LogInbtn";
            this.LogInbtn.Size = new System.Drawing.Size(95, 36);
            this.LogInbtn.TabIndex = 10;
            this.LogInbtn.Text = "Login";
            this.LogInbtn.UseVisualStyleBackColor = true;
            this.LogInbtn.Click += new System.EventHandler(this.LogInbtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(58, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Password:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Customer Login";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtEmailLogin
            // 
            this.txtEmailLogin.Location = new System.Drawing.Point(194, 113);
            this.txtEmailLogin.Name = "txtEmailLogin";
            this.txtEmailLogin.Size = new System.Drawing.Size(342, 22);
            this.txtEmailLogin.TabIndex = 11;
            this.txtEmailLogin.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtPWLogin
            // 
            this.txtPWLogin.AcceptsReturn = true;
            this.txtPWLogin.Location = new System.Drawing.Point(194, 164);
            this.txtPWLogin.Name = "txtPWLogin";
            this.txtPWLogin.Size = new System.Drawing.Size(342, 22);
            this.txtPWLogin.TabIndex = 12;
            this.txtPWLogin.UseSystemPasswordChar = true;
            // 
            // lblCreateAccount
            // 
            this.lblCreateAccount.AutoSize = true;
            this.lblCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAccount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblCreateAccount.Location = new System.Drawing.Point(424, 383);
            this.lblCreateAccount.Name = "lblCreateAccount";
            this.lblCreateAccount.Size = new System.Drawing.Size(203, 18);
            this.lblCreateAccount.TabIndex = 13;
            this.lblCreateAccount.Text = "Create Your Free Account";
            this.lblCreateAccount.Click += new System.EventHandler(this.lblCreateAccount_Click);
            // 
            // ExitCustomerSignbtn
            // 
            this.ExitCustomerSignbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExitCustomerSignbtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExitCustomerSignbtn.Location = new System.Drawing.Point(12, 383);
            this.ExitCustomerSignbtn.Name = "ExitCustomerSignbtn";
            this.ExitCustomerSignbtn.Size = new System.Drawing.Size(68, 35);
            this.ExitCustomerSignbtn.TabIndex = 14;
            this.ExitCustomerSignbtn.Text = "Exit";
            this.ExitCustomerSignbtn.UseVisualStyleBackColor = false;
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 430);
            this.Controls.Add(this.ExitCustomerSignbtn);
            this.Controls.Add(this.lblCreateAccount);
            this.Controls.Add(this.txtPWLogin);
            this.Controls.Add(this.txtEmailLogin);
            this.Controls.Add(this.LogInbtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Name = "SignIn";
            this.Text = "SignIn";
            this.Load += new System.EventHandler(this.SignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogInbtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailLogin;
        private System.Windows.Forms.TextBox txtPWLogin;
        private System.Windows.Forms.Label lblCreateAccount;
        private System.Windows.Forms.Button ExitCustomerSignbtn;
    }
}