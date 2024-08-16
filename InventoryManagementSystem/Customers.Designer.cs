namespace InventoryManagementSystem
{
    partial class Customers
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            contact = new TextBox();
            label5 = new Label();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            cadd = new TextBox();
            cname = new TextBox();
            cid = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            cid4 = new DataGridViewTextBoxColumn();
            cname4 = new DataGridViewTextBoxColumn();
            cadd4 = new DataGridViewTextBoxColumn();
            contact4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(327, 9);
            label1.Name = "label1";
            label1.Size = new Size(141, 32);
            label1.TabIndex = 0;
            label1.Text = "Customers";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(contact);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(cadd);
            groupBox1.Controls.Add(cname);
            groupBox1.Controls.Add(cid);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 303);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Customer Details";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // contact
            // 
            contact.Location = new Point(233, 176);
            contact.Name = "contact";
            contact.Size = new Size(508, 34);
            contact.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(22, 185);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 9;
            label5.Text = "Contact No";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(300, 229);
            button2.Name = "button2";
            button2.Size = new Size(141, 52);
            button2.TabIndex = 7;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(24, 229);
            button1.Name = "button1";
            button1.Size = new Size(141, 52);
            button1.TabIndex = 6;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(571, 229);
            button3.Name = "button3";
            button3.Size = new Size(141, 52);
            button3.TabIndex = 8;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // cadd
            // 
            cadd.Location = new Point(233, 125);
            cadd.Name = "cadd";
            cadd.Size = new Size(508, 34);
            cadd.TabIndex = 5;
            // 
            // cname
            // 
            cname.Location = new Point(233, 77);
            cname.Name = "cname";
            cname.Size = new Size(508, 34);
            cname.TabIndex = 4;
            // 
            // cid
            // 
            cid.Location = new Point(233, 30);
            cid.Name = "cid";
            cid.Size = new Size(508, 34);
            cid.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 134);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 86);
            label3.Name = "label3";
            label3.Size = new Size(176, 25);
            label3.TabIndex = 1;
            label3.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 39);
            label2.Name = "label2";
            label2.Size = new Size(139, 25);
            label2.TabIndex = 0;
            label2.Text = "Customer Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.ActiveBorder;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cid4, cname4, cadd4, contact4 });
            dataGridView1.Location = new Point(12, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 192);
            dataGridView1.TabIndex = 2;
            // 
            // cid4
            // 
            cid4.HeaderText = "Customer Id";
            cid4.MinimumWidth = 6;
            cid4.Name = "cid4";
            // 
            // cname4
            // 
            cname4.HeaderText = "Customer Name";
            cname4.MinimumWidth = 6;
            cname4.Name = "cname4";
            // 
            // cadd4
            // 
            cadd4.HeaderText = "Address";
            cadd4.MinimumWidth = 6;
            cadd4.Name = "cadd4";
            // 
            // contact4
            // 
            contact4.HeaderText = "Contact No";
            contact4.MinimumWidth = 6;
            contact4.Name = "contact4";
            // 
            // Customers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(800, 576);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Customers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customers";
            Load += Customers_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox cadd;
        private TextBox cname;
        private TextBox cid;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button3;
        private TextBox contact;
        private Label label5;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cid4;
        private DataGridViewTextBoxColumn cname4;
        private DataGridViewTextBoxColumn cadd4;
        private DataGridViewTextBoxColumn contact4;
    }
}