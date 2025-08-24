namespace EntryLevel6Database
{
    partial class CustomersProfile
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.Button();
            this.DBtxtSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Finalisebtn = new System.Windows.Forms.Button();
            this.inforefresh = new System.Windows.Forms.Button();
            this.InfotxtBack = new System.Windows.Forms.Button();
            this.Addallbtn = new System.Windows.Forms.Button();
            this.removeallbtn = new System.Windows.Forms.Button();
            this.Removebtn = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(608, 370);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(614, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 411);
            this.panel1.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(442, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(369, 44);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customer Database";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.DBtxtSearch);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.Finalisebtn);
            this.panel2.Controls.Add(this.inforefresh);
            this.panel2.Controls.Add(this.InfotxtBack);
            this.panel2.Controls.Add(this.Addallbtn);
            this.panel2.Controls.Add(this.removeallbtn);
            this.panel2.Controls.Add(this.Removebtn);
            this.panel2.Controls.Add(this.Addbtn);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Location = new System.Drawing.Point(5, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(603, 411);
            this.panel2.TabIndex = 18;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.DarkBlue;
            this.txtSearch.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.txtSearch.FlatAppearance.BorderSize = 5;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.AliceBlue;
            this.txtSearch.Location = new System.Drawing.Point(12, 5);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(96, 35);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Text = "Search";
            this.txtSearch.UseVisualStyleBackColor = false;
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            // 
            // DBtxtSearch
            // 
            this.DBtxtSearch.Location = new System.Drawing.Point(106, 5);
            this.DBtxtSearch.Multiline = true;
            this.DBtxtSearch.Name = "DBtxtSearch";
            this.DBtxtSearch.Size = new System.Drawing.Size(238, 35);
            this.DBtxtSearch.TabIndex = 28;
            this.DBtxtSearch.TextChanged += new System.EventHandler(this.DBtxtSearch_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 264);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 142);
            this.button2.TabIndex = 27;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(281, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 94);
            this.button1.TabIndex = 26;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Finalisebtn
            // 
            this.Finalisebtn.Location = new System.Drawing.Point(291, 367);
            this.Finalisebtn.Name = "Finalisebtn";
            this.Finalisebtn.Size = new System.Drawing.Size(299, 39);
            this.Finalisebtn.TabIndex = 25;
            this.Finalisebtn.Text = "Sync Data";
            this.Finalisebtn.UseVisualStyleBackColor = true;
            this.Finalisebtn.Click += new System.EventHandler(this.Finalisebtn_Click_1);
            // 
            // inforefresh
            // 
            this.inforefresh.Location = new System.Drawing.Point(93, 367);
            this.inforefresh.Name = "inforefresh";
            this.inforefresh.Size = new System.Drawing.Size(87, 39);
            this.inforefresh.TabIndex = 24;
            this.inforefresh.Text = "Refresh";
            this.inforefresh.UseVisualStyleBackColor = true;
            this.inforefresh.Click += new System.EventHandler(this.inforefresh_Click_1);
            // 
            // InfotxtBack
            // 
            this.InfotxtBack.Location = new System.Drawing.Point(190, 367);
            this.InfotxtBack.Name = "InfotxtBack";
            this.InfotxtBack.Size = new System.Drawing.Size(85, 39);
            this.InfotxtBack.TabIndex = 23;
            this.InfotxtBack.Text = "Back";
            this.InfotxtBack.UseVisualStyleBackColor = true;
            this.InfotxtBack.Click += new System.EventHandler(this.InfotxtBack_Click_1);
            // 
            // Addallbtn
            // 
            this.Addallbtn.Location = new System.Drawing.Point(408, 264);
            this.Addallbtn.Name = "Addallbtn";
            this.Addallbtn.Size = new System.Drawing.Size(182, 39);
            this.Addallbtn.TabIndex = 22;
            this.Addallbtn.Text = "Add All";
            this.Addallbtn.UseVisualStyleBackColor = true;
            this.Addallbtn.Click += new System.EventHandler(this.Addallbtn_Click_1);
            // 
            // removeallbtn
            // 
            this.removeallbtn.Location = new System.Drawing.Point(408, 309);
            this.removeallbtn.Name = "removeallbtn";
            this.removeallbtn.Size = new System.Drawing.Size(182, 39);
            this.removeallbtn.TabIndex = 21;
            this.removeallbtn.Text = "Remove All";
            this.removeallbtn.UseVisualStyleBackColor = true;
            this.removeallbtn.Click += new System.EventHandler(this.removeallbtn_Click);
            // 
            // Removebtn
            // 
            this.Removebtn.Location = new System.Drawing.Point(93, 309);
            this.Removebtn.Name = "Removebtn";
            this.Removebtn.Size = new System.Drawing.Size(182, 39);
            this.Removebtn.TabIndex = 20;
            this.Removebtn.Text = "Remove";
            this.Removebtn.UseVisualStyleBackColor = true;
            this.Removebtn.Click += new System.EventHandler(this.Removebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(93, 264);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(182, 39);
            this.Addbtn.TabIndex = 19;
            this.Addbtn.Text = "Add";
            this.Addbtn.UseVisualStyleBackColor = true;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(304, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(286, 196);
            this.listBox2.TabIndex = 18;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(286, 196);
            this.listBox1.TabIndex = 17;
            // 
            // CustomersProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1272, 488);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CustomersProfile";
            this.Text = "CustomersProfile";
            this.Load += new System.EventHandler(this.CustomersProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button txtSearch;
        private System.Windows.Forms.TextBox DBtxtSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Finalisebtn;
        private System.Windows.Forms.Button inforefresh;
        private System.Windows.Forms.Button InfotxtBack;
        private System.Windows.Forms.Button Addallbtn;
        private System.Windows.Forms.Button removeallbtn;
        private System.Windows.Forms.Button Removebtn;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
    }
}