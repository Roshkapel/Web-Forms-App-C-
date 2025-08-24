namespace EntryLevel6Database
{
    partial class Commmand_Build_Form
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Operationbtn = new System.Windows.Forms.Button();
            this.Select = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.socialNetworkDataSet = new EntryLevel6Database.SocialNetworkDataSet();
            this.socialNetworkDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Listcombobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(956, 278);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // Operationbtn
            // 
            this.Operationbtn.Location = new System.Drawing.Point(205, 333);
            this.Operationbtn.Name = "Operationbtn";
            this.Operationbtn.Size = new System.Drawing.Size(240, 29);
            this.Operationbtn.TabIndex = 1;
            this.Operationbtn.Text = "Perform Operation";
            this.Operationbtn.UseVisualStyleBackColor = true;
            this.Operationbtn.Click += new System.EventHandler(this.Operationbtn_Click);
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(498, 333);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(88, 28);
            this.Select.TabIndex = 2;
            this.Select.Text = "select";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click_1);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(649, 360);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(341, 84);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // socialNetworkDataSet
            // 
            this.socialNetworkDataSet.DataSetName = "SocialNetworkDataSet";
            this.socialNetworkDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // socialNetworkDataSetBindingSource
            // 
            this.socialNetworkDataSetBindingSource.DataSource = this.socialNetworkDataSet;
            this.socialNetworkDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(916, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Listcombobox
            // 
            this.Listcombobox.FormattingEnabled = true;
            this.Listcombobox.Location = new System.Drawing.Point(6, 333);
            this.Listcombobox.Name = "Listcombobox";
            this.Listcombobox.Size = new System.Drawing.Size(121, 24);
            this.Listcombobox.TabIndex = 6;
            // 
            // Commmand_Build_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 583);
            this.Controls.Add(this.Listcombobox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Select);
            this.Controls.Add(this.Operationbtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Commmand_Build_Form";
            this.Text = "Commmand_Build_Form";
            this.Load += new System.EventHandler(this.Commmand_Build_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.socialNetworkDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Operationbtn;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.ListBox listBox1;
        private SocialNetworkDataSet socialNetworkDataSet;
        private System.Windows.Forms.BindingSource socialNetworkDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Listcombobox;
    }
}