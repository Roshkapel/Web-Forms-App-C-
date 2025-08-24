namespace EntryLevel6Database
{
    partial class Homepage
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
            this.txtHCountry = new System.Windows.Forms.ComboBox();
            this.txtHEmail = new System.Windows.Forms.TextBox();
            this.txtHPW = new System.Windows.Forms.TextBox();
            this.txtHName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Updatebtn = new System.Windows.Forms.Button();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.HpageName = new System.Windows.Forms.Label();
            this.Setbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHCountry
            // 
            this.txtHCountry.FormattingEnabled = true;
            this.txtHCountry.Items.AddRange(new object[] {
            "France",
            "Pakistan",
            "Germany",
            "Poland"});
            this.txtHCountry.Location = new System.Drawing.Point(127, 180);
            this.txtHCountry.Name = "txtHCountry";
            this.txtHCountry.Size = new System.Drawing.Size(295, 24);
            this.txtHCountry.TabIndex = 18;
            // 
            // txtHEmail
            // 
            this.txtHEmail.Location = new System.Drawing.Point(127, 124);
            this.txtHEmail.Name = "txtHEmail";
            this.txtHEmail.Size = new System.Drawing.Size(295, 22);
            this.txtHEmail.TabIndex = 17;
            // 
            // txtHPW
            // 
            this.txtHPW.Location = new System.Drawing.Point(127, 152);
            this.txtHPW.Name = "txtHPW";
            this.txtHPW.Size = new System.Drawing.Size(295, 22);
            this.txtHPW.TabIndex = 16;
            this.txtHPW.UseSystemPasswordChar = true;
            this.txtHPW.TextChanged += new System.EventHandler(this.txtPW_TextChanged);
            // 
            // txtHName
            // 
            this.txtHName.Location = new System.Drawing.Point(127, 96);
            this.txtHName.Name = "txtHName";
            this.txtHName.Size = new System.Drawing.Size(295, 22);
            this.txtHName.TabIndex = 15;
            this.txtHName.TextChanged += new System.EventHandler(this.txtHName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Country:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // Updatebtn
            // 
            this.Updatebtn.BackColor = System.Drawing.Color.Azure;
            this.Updatebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.Location = new System.Drawing.Point(12, 301);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(131, 45);
            this.Updatebtn.TabIndex = 19;
            this.Updatebtn.Text = "Update Account Info";
            this.Updatebtn.UseVisualStyleBackColor = false;
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Deletebtn
            // 
            this.Deletebtn.BackColor = System.Drawing.Color.LightGray;
            this.Deletebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(496, 400);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(131, 38);
            this.Deletebtn.TabIndex = 20;
            this.Deletebtn.Text = "Delete Account";
            this.Deletebtn.UseVisualStyleBackColor = false;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Account Settings";
            // 
            // HpageName
            // 
            this.HpageName.AutoSize = true;
            this.HpageName.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HpageName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.HpageName.Location = new System.Drawing.Point(346, 22);
            this.HpageName.Name = "HpageName";
            this.HpageName.Size = new System.Drawing.Size(67, 25);
            this.HpageName.TabIndex = 22;
            this.HpageName.Text = "...........";
            // 
            // Setbtn
            // 
            this.Setbtn.BackColor = System.Drawing.Color.Azure;
            this.Setbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Setbtn.Location = new System.Drawing.Point(12, 352);
            this.Setbtn.Name = "Setbtn";
            this.Setbtn.Size = new System.Drawing.Size(131, 43);
            this.Setbtn.TabIndex = 23;
            this.Setbtn.Text = "View Profile";
            this.Setbtn.UseVisualStyleBackColor = false;
            this.Setbtn.Click += new System.EventHandler(this.Setbtn_Click);
            // 
            // Homepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::EntryLevel6Database.Properties.Resources.tick_icon;
            this.ClientSize = new System.Drawing.Size(661, 450);
            this.Controls.Add(this.Setbtn);
            this.Controls.Add(this.HpageName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.txtHCountry);
            this.Controls.Add(this.txtHEmail);
            this.Controls.Add(this.txtHPW);
            this.Controls.Add(this.txtHName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Homepage";
            this.Text = "Homepage";
            this.Load += new System.EventHandler(this.Homepage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtHCountry;
        private System.Windows.Forms.TextBox txtHEmail;
        private System.Windows.Forms.TextBox txtHPW;
        private System.Windows.Forms.TextBox txtHName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Updatebtn;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HpageName;
        private System.Windows.Forms.Button Setbtn;
    }
}