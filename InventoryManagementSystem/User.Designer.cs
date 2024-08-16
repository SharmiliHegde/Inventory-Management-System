namespace InventoryManagementSystem
{
    partial class User
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            upos8 = new TextBox();
            uphone8 = new TextBox();
            uadd8 = new TextBox();
            uname8 = new TextBox();
            uid8 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            uid = new DataGridViewTextBoxColumn();
            uname = new DataGridViewTextBoxColumn();
            addr = new DataGridViewTextBoxColumn();
            contact = new DataGridViewTextBoxColumn();
            post = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(401, 9);
            label1.Name = "label1";
            label1.Size = new Size(69, 32);
            label1.TabIndex = 0;
            label1.Text = "User";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(upos8);
            groupBox1.Controls.Add(uphone8);
            groupBox1.Controls.Add(uadd8);
            groupBox1.Controls.Add(uname8);
            groupBox1.Controls.Add(uid8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(861, 387);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Details";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(660, 305);
            button3.Name = "button3";
            button3.Size = new Size(144, 60);
            button3.TabIndex = 12;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(350, 305);
            button2.Name = "button2";
            button2.Size = new Size(144, 60);
            button2.TabIndex = 11;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(42, 305);
            button1.Name = "button1";
            button1.Size = new Size(144, 60);
            button1.TabIndex = 10;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // upos8
            // 
            upos8.Location = new Point(187, 243);
            upos8.Name = "upos8";
            upos8.Size = new Size(642, 34);
            upos8.TabIndex = 9;
            // 
            // uphone8
            // 
            uphone8.Location = new Point(187, 193);
            uphone8.Name = "uphone8";
            uphone8.Size = new Size(642, 34);
            uphone8.TabIndex = 8;
            // 
            // uadd8
            // 
            uadd8.Location = new Point(187, 144);
            uadd8.Name = "uadd8";
            uadd8.Size = new Size(642, 34);
            uadd8.TabIndex = 7;
            // 
            // uname8
            // 
            uname8.Location = new Point(187, 95);
            uname8.Name = "uname8";
            uname8.Size = new Size(642, 34);
            uname8.TabIndex = 6;
            // 
            // uid8
            // 
            uid8.Location = new Point(187, 45);
            uid8.Name = "uid8";
            uid8.Size = new Size(642, 34);
            uid8.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 252);
            label6.Name = "label6";
            label6.Size = new Size(91, 25);
            label6.TabIndex = 4;
            label6.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 202);
            label5.Name = "label5";
            label5.Size = new Size(128, 25);
            label5.TabIndex = 3;
            label5.Text = "Contact No";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 153);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 2;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 103);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 1;
            label3.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(24, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 0;
            label2.Text = "User Id";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { uid, uname, addr, contact, post });
            dataGridView1.Location = new Point(12, 452);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(861, 188);
            dataGridView1.TabIndex = 2;
            // 
            // uid
            // 
            uid.HeaderText = "User Id";
            uid.MinimumWidth = 6;
            uid.Name = "uid";
            // 
            // uname
            // 
            uname.HeaderText = "User Name";
            uname.MinimumWidth = 6;
            uname.Name = "uname";
            // 
            // addr
            // 
            addr.HeaderText = "Address";
            addr.MinimumWidth = 6;
            addr.Name = "addr";
            // 
            // contact
            // 
            contact.HeaderText = "Contact No";
            contact.MinimumWidth = 6;
            contact.Name = "contact";
            // 
            // post
            // 
            post.HeaderText = "Position";
            post.MinimumWidth = 6;
            post.Name = "post";
            // 
            // User
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(885, 652);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "User";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User";
            Load += User_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox upos8;
        private TextBox uphone8;
        private TextBox uadd8;
        private TextBox uname8;
        private TextBox uid8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn uid;
        private DataGridViewTextBoxColumn uname;
        private DataGridViewTextBoxColumn addr;
        private DataGridViewTextBoxColumn contact;
        private DataGridViewTextBoxColumn post;
    }
}