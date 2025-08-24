namespace EntryLevel6Database
{
    partial class Customer_Processing
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
            this.lblCustName = new System.Windows.Forms.Label();
            this.FixedBtn = new System.Windows.Forms.RadioButton();
            this.NonFixedbtn = new System.Windows.Forms.RadioButton();
            this.Processbtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Uploadbtn = new System.Windows.Forms.Button();
            this.ProUploadBackbtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textMeterRead = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AtxtCurrentCharge = new System.Windows.Forms.TextBox();
            this.lblbal = new System.Windows.Forms.Label();
            this.txtcurrentCharges = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AtxtPrevbalance = new System.Windows.Forms.TextBox();
            this.Atxtpayments = new System.Windows.Forms.TextBox();
            this.AtxtBalances = new System.Windows.Forms.TextBox();
            this.AtxtAmountDue = new System.Windows.Forms.TextBox();
            this.AtxtDueDate = new System.Windows.Forms.TextBox();
            this.AtxtPayDate = new System.Windows.Forms.TextBox();
            this.AccCustomer = new System.Windows.Forms.Label();
            this.AccgroupBox = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.AtxtStatement = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AtxtAddress = new System.Windows.Forms.TextBox();
            this.AHoldertxt = new System.Windows.Forms.TextBox();
            this.AccNotxt = new System.Windows.Forms.TextBox();
            this.APremisetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtProcessingSearch = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SearchBtn.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.AccgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(26, 29);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(78, 25);
            this.lblCustName.TabIndex = 0;
            this.lblCustName.Text = "...........";
            this.lblCustName.Click += new System.EventHandler(this.lblCustName_Click);
            // 
            // FixedBtn
            // 
            this.FixedBtn.AutoSize = true;
            this.FixedBtn.Location = new System.Drawing.Point(11, 358);
            this.FixedBtn.Name = "FixedBtn";
            this.FixedBtn.Size = new System.Drawing.Size(121, 20);
            this.FixedBtn.TabIndex = 1;
            this.FixedBtn.TabStop = true;
            this.FixedBtn.Text = "Fixed Customer";
            this.FixedBtn.UseVisualStyleBackColor = true;
            this.FixedBtn.CheckedChanged += new System.EventHandler(this.FixedBtn_CheckedChanged);
            // 
            // NonFixedbtn
            // 
            this.NonFixedbtn.AutoSize = true;
            this.NonFixedbtn.Location = new System.Drawing.Point(11, 311);
            this.NonFixedbtn.Name = "NonFixedbtn";
            this.NonFixedbtn.Size = new System.Drawing.Size(89, 20);
            this.NonFixedbtn.TabIndex = 2;
            this.NonFixedbtn.TabStop = true;
            this.NonFixedbtn.Text = "Non Fixed";
            this.NonFixedbtn.UseVisualStyleBackColor = true;
            this.NonFixedbtn.CheckedChanged += new System.EventHandler(this.NonFixedbtn_CheckedChanged);
            // 
            // Processbtn
            // 
            this.Processbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Processbtn.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Processbtn.FlatAppearance.BorderSize = 6;
            this.Processbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Processbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Processbtn.Location = new System.Drawing.Point(693, 470);
            this.Processbtn.Name = "Processbtn";
            this.Processbtn.Size = new System.Drawing.Size(297, 34);
            this.Processbtn.TabIndex = 3;
            this.Processbtn.Text = "Process Information";
            this.Processbtn.UseVisualStyleBackColor = true;
            this.Processbtn.Click += new System.EventHandler(this.Processbtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.Uploadbtn);
            this.panel1.Controls.Add(this.ProUploadBackbtn);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.textMeterRead);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.FixedBtn);
            this.panel1.Controls.Add(this.NonFixedbtn);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(321, 510);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Uploadbtn
            // 
            this.Uploadbtn.Location = new System.Drawing.Point(30, 468);
            this.Uploadbtn.Name = "Uploadbtn";
            this.Uploadbtn.Size = new System.Drawing.Size(231, 34);
            this.Uploadbtn.TabIndex = 11;
            this.Uploadbtn.Text = "Upload Data";
            this.Uploadbtn.UseVisualStyleBackColor = true;
            this.Uploadbtn.Click += new System.EventHandler(this.Uploadbtn_Click);
            // 
            // ProUploadBackbtn
            // 
            this.ProUploadBackbtn.Location = new System.Drawing.Point(25, 11);
            this.ProUploadBackbtn.Name = "ProUploadBackbtn";
            this.ProUploadBackbtn.Size = new System.Drawing.Size(78, 33);
            this.ProUploadBackbtn.TabIndex = 0;
            this.ProUploadBackbtn.Text = "Prev.";
            this.ProUploadBackbtn.Click += new System.EventHandler(this.ProUploadBackbtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(284, 32);
            this.label11.TabIndex = 10;
            this.label11.Text = "Enter Meter Reading.\r\nSelect \'Process Information\' To Process";
            // 
            // textMeterRead
            // 
            this.textMeterRead.Location = new System.Drawing.Point(11, 230);
            this.textMeterRead.Multiline = true;
            this.textMeterRead.Name = "textMeterRead";
            this.textMeterRead.Size = new System.Drawing.Size(170, 29);
            this.textMeterRead.TabIndex = 8;
            this.textMeterRead.TextChanged += new System.EventHandler(this.textMeterRead_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 428);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(231, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "View Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Meter Reading";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(386, 23);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(64, 16);
            this.Customer.TabIndex = 5;
            this.Customer.Text = "Customer";
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchBtn.Controls.Add(this.SearchButton);
            this.SearchBtn.Controls.Add(this.label14);
            this.SearchBtn.Controls.Add(this.txtProcessingSearch);
            this.SearchBtn.Controls.Add(this.groupBox1);
            this.SearchBtn.Controls.Add(this.AccCustomer);
            this.SearchBtn.Controls.Add(this.Customer);
            this.SearchBtn.Controls.Add(this.AccgroupBox);
            this.SearchBtn.Location = new System.Drawing.Point(328, 72);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(1098, 377);
            this.SearchBtn.TabIndex = 6;
            this.SearchBtn.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.AtxtCurrentCharge);
            this.groupBox1.Controls.Add(this.lblbal);
            this.groupBox1.Controls.Add(this.txtcurrentCharges);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.AtxtPrevbalance);
            this.groupBox1.Controls.Add(this.Atxtpayments);
            this.groupBox1.Controls.Add(this.AtxtBalances);
            this.groupBox1.Controls.Add(this.AtxtAmountDue);
            this.groupBox1.Controls.Add(this.AtxtDueDate);
            this.groupBox1.Controls.Add(this.AtxtPayDate);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(534, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 307);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Payments & Balances";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(40, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 19);
            this.label13.TabIndex = 14;
            this.label13.Text = "Previous balance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Payments";
            // 
            // AtxtCurrentCharge
            // 
            this.AtxtCurrentCharge.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtCurrentCharge.Location = new System.Drawing.Point(275, 147);
            this.AtxtCurrentCharge.Name = "AtxtCurrentCharge";
            this.AtxtCurrentCharge.Size = new System.Drawing.Size(241, 27);
            this.AtxtCurrentCharge.TabIndex = 12;
            this.AtxtCurrentCharge.TextChanged += new System.EventHandler(this.AtxtCurrentCharge_TextChanged);
            // 
            // lblbal
            // 
            this.lblbal.AutoSize = true;
            this.lblbal.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbal.Location = new System.Drawing.Point(40, 112);
            this.lblbal.Name = "lblbal";
            this.lblbal.Size = new System.Drawing.Size(194, 19);
            this.lblbal.TabIndex = 11;
            this.lblbal.Text = "Balances Brought Forward";
            // 
            // txtcurrentCharges
            // 
            this.txtcurrentCharges.AutoSize = true;
            this.txtcurrentCharges.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcurrentCharges.Location = new System.Drawing.Point(40, 150);
            this.txtcurrentCharges.Name = "txtcurrentCharges";
            this.txtcurrentCharges.Size = new System.Drawing.Size(122, 19);
            this.txtcurrentCharges.TabIndex = 10;
            this.txtcurrentCharges.Text = "Current Charges";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 189);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Total Amount Due";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Due date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Payment Date";
            // 
            // AtxtPrevbalance
            // 
            this.AtxtPrevbalance.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtPrevbalance.Location = new System.Drawing.Point(275, 31);
            this.AtxtPrevbalance.Name = "AtxtPrevbalance";
            this.AtxtPrevbalance.Size = new System.Drawing.Size(241, 27);
            this.AtxtPrevbalance.TabIndex = 6;
            this.AtxtPrevbalance.TextChanged += new System.EventHandler(this.AtxtPrevbalance_TextChanged);
            // 
            // Atxtpayments
            // 
            this.Atxtpayments.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atxtpayments.Location = new System.Drawing.Point(275, 66);
            this.Atxtpayments.Name = "Atxtpayments";
            this.Atxtpayments.Size = new System.Drawing.Size(241, 27);
            this.Atxtpayments.TabIndex = 5;
            this.Atxtpayments.TextChanged += new System.EventHandler(this.Atxtpayments_TextChanged);
            // 
            // AtxtBalances
            // 
            this.AtxtBalances.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtBalances.Location = new System.Drawing.Point(275, 104);
            this.AtxtBalances.Name = "AtxtBalances";
            this.AtxtBalances.Size = new System.Drawing.Size(241, 27);
            this.AtxtBalances.TabIndex = 4;
            this.AtxtBalances.TextChanged += new System.EventHandler(this.AtxtBalances_TextChanged);
            // 
            // AtxtAmountDue
            // 
            this.AtxtAmountDue.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtAmountDue.Location = new System.Drawing.Point(275, 189);
            this.AtxtAmountDue.Name = "AtxtAmountDue";
            this.AtxtAmountDue.Size = new System.Drawing.Size(241, 27);
            this.AtxtAmountDue.TabIndex = 3;
            this.AtxtAmountDue.TextChanged += new System.EventHandler(this.AtxtAmountDue_TextChanged);
            // 
            // AtxtDueDate
            // 
            this.AtxtDueDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtDueDate.Location = new System.Drawing.Point(275, 228);
            this.AtxtDueDate.Name = "AtxtDueDate";
            this.AtxtDueDate.Size = new System.Drawing.Size(241, 27);
            this.AtxtDueDate.TabIndex = 2;
            this.AtxtDueDate.TextChanged += new System.EventHandler(this.AtxtDueDate_TextChanged);
            // 
            // AtxtPayDate
            // 
            this.AtxtPayDate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtPayDate.Location = new System.Drawing.Point(275, 264);
            this.AtxtPayDate.Name = "AtxtPayDate";
            this.AtxtPayDate.Size = new System.Drawing.Size(241, 27);
            this.AtxtPayDate.TabIndex = 1;
            this.AtxtPayDate.TextChanged += new System.EventHandler(this.AtxtPayDate_TextChanged);
            // 
            // AccCustomer
            // 
            this.AccCustomer.AutoSize = true;
            this.AccCustomer.Location = new System.Drawing.Point(607, 23);
            this.AccCustomer.Name = "AccCustomer";
            this.AccCustomer.Size = new System.Drawing.Size(43, 16);
            this.AccCustomer.TabIndex = 6;
            this.AccCustomer.Text = "............";
            // 
            // AccgroupBox
            // 
            this.AccgroupBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.AccgroupBox.Controls.Add(this.label12);
            this.AccgroupBox.Controls.Add(this.AtxtStatement);
            this.AccgroupBox.Controls.Add(this.label1);
            this.AccgroupBox.Controls.Add(this.label4);
            this.AccgroupBox.Controls.Add(this.label5);
            this.AccgroupBox.Controls.Add(this.label6);
            this.AccgroupBox.Controls.Add(this.AtxtAddress);
            this.AccgroupBox.Controls.Add(this.AHoldertxt);
            this.AccgroupBox.Controls.Add(this.AccNotxt);
            this.AccgroupBox.Controls.Add(this.APremisetxt);
            this.AccgroupBox.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccgroupBox.Location = new System.Drawing.Point(4, 88);
            this.AccgroupBox.Name = "AccgroupBox";
            this.AccgroupBox.Size = new System.Drawing.Size(524, 276);
            this.AccgroupBox.TabIndex = 0;
            this.AccgroupBox.TabStop = false;
            this.AccgroupBox.Text = "Account Information";
            this.AccgroupBox.Enter += new System.EventHandler(this.AccgroupBox_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(36, 233);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 19);
            this.label12.TabIndex = 13;
            this.label12.Text = "Account Statement Date";
            // 
            // AtxtStatement
            // 
            this.AtxtStatement.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtStatement.Location = new System.Drawing.Point(269, 225);
            this.AtxtStatement.Name = "AtxtStatement";
            this.AtxtStatement.Size = new System.Drawing.Size(249, 27);
            this.AtxtStatement.TabIndex = 12;
            this.AtxtStatement.TextChanged += new System.EventHandler(this.AtxtStatement_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Account Holder\'s Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account Holder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 19);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account No.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "Premise No.";
            // 
            // AtxtAddress
            // 
            this.AtxtAddress.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtxtAddress.Location = new System.Drawing.Point(269, 178);
            this.AtxtAddress.Name = "AtxtAddress";
            this.AtxtAddress.Size = new System.Drawing.Size(249, 27);
            this.AtxtAddress.TabIndex = 3;
            this.AtxtAddress.TextChanged += new System.EventHandler(this.AtxtAddress_TextChanged);
            // 
            // AHoldertxt
            // 
            this.AHoldertxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AHoldertxt.Location = new System.Drawing.Point(269, 131);
            this.AHoldertxt.Name = "AHoldertxt";
            this.AHoldertxt.Size = new System.Drawing.Size(249, 27);
            this.AHoldertxt.TabIndex = 2;
            this.AHoldertxt.TextChanged += new System.EventHandler(this.AHoldertxt_TextChanged);
            // 
            // AccNotxt
            // 
            this.AccNotxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccNotxt.Location = new System.Drawing.Point(269, 88);
            this.AccNotxt.Name = "AccNotxt";
            this.AccNotxt.Size = new System.Drawing.Size(249, 27);
            this.AccNotxt.TabIndex = 1;
            this.AccNotxt.TextChanged += new System.EventHandler(this.AccNotxt_TextChanged);
            // 
            // APremisetxt
            // 
            this.APremisetxt.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APremisetxt.Location = new System.Drawing.Point(269, 46);
            this.APremisetxt.Name = "APremisetxt";
            this.APremisetxt.Size = new System.Drawing.Size(249, 27);
            this.APremisetxt.TabIndex = 0;
            this.APremisetxt.TextChanged += new System.EventHandler(this.APremisetxt_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(329, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(244, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Processing Page";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.ExitBtn.Location = new System.Drawing.Point(1361, 478);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(78, 33);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // txtProcessingSearch
            // 
            this.txtProcessingSearch.Location = new System.Drawing.Point(4, 48);
            this.txtProcessingSearch.Multiline = true;
            this.txtProcessingSearch.Name = "txtProcessingSearch";
            this.txtProcessingSearch.Size = new System.Drawing.Size(213, 34);
            this.txtProcessingSearch.TabIndex = 8;
            this.txtProcessingSearch.TextChanged += new System.EventHandler(this.txtProcessingSearch_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(4, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(137, 18);
            this.label14.TabIndex = 9;
            this.label14.Text = "Search Database";
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.Color.Navy;
            this.SearchButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchButton.Location = new System.Drawing.Point(223, 50);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(95, 32);
            this.SearchButton.TabIndex = 10;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // Customer_Processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1466, 523);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Processbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCustName);
            this.Name = "Customer_Processing";
            this.Text = "Customer_Processing";
            this.Load += new System.EventHandler(this.Customer_Processing_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchBtn.ResumeLayout(false);
            this.SearchBtn.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AccgroupBox.ResumeLayout(false);
            this.AccgroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.RadioButton FixedBtn;
        private System.Windows.Forms.RadioButton NonFixedbtn;
        private System.Windows.Forms.Button Processbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Customer;
        private System.Windows.Forms.Panel SearchBtn;
        private System.Windows.Forms.Label AccCustomer;
        private System.Windows.Forms.GroupBox AccgroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblbal;
        private System.Windows.Forms.Label txtcurrentCharges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AtxtPrevbalance;
        private System.Windows.Forms.TextBox Atxtpayments;
        private System.Windows.Forms.TextBox AtxtBalances;
        private System.Windows.Forms.TextBox AtxtAmountDue;
        private System.Windows.Forms.TextBox AtxtDueDate;
        private System.Windows.Forms.TextBox AtxtPayDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AtxtAddress;
        private System.Windows.Forms.TextBox AHoldertxt;
        private System.Windows.Forms.TextBox AccNotxt;
        private System.Windows.Forms.TextBox APremisetxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox AtxtCurrentCharge;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMeterRead;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox AtxtStatement;
        private System.Windows.Forms.Button ProUploadBackbtn;
        private System.Windows.Forms.Button Uploadbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtProcessingSearch;
        private System.Windows.Forms.Button SearchButton;
    }
}