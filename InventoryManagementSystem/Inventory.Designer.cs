namespace InventoryManagementSystem
{
    partial class Inventory
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            label1 = new Label();
            groupBox1 = new GroupBox();
            date6 = new DateTimePicker();
            panel3 = new Panel();
            label12 = new Label();
            label9 = new Label();
            panel2 = new Panel();
            label13 = new Label();
            label10 = new Label();
            panel1 = new Panel();
            label11 = new Label();
            label8 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            price6 = new TextBox();
            qnt6 = new TextBox();
            cname6 = new TextBox();
            pname6 = new TextBox();
            pid6 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            pid = new DataGridViewTextBoxColumn();
            pname = new DataGridViewTextBoxColumn();
            cname = new DataGridViewTextBoxColumn();
            qnty = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            date = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(548, 9);
            label1.Margin = new Padding(7, 0, 7, 0);
            label1.Name = "label1";
            label1.Size = new Size(182, 32);
            label1.TabIndex = 0;
            label1.Text = "INVENTORY";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkSlateGray;
            groupBox1.Controls.Add(date6);
            groupBox1.Controls.Add(panel3);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(panel1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(price6);
            groupBox1.Controls.Add(qnt6);
            groupBox1.Controls.Add(cname6);
            groupBox1.Controls.Add(pname6);
            groupBox1.Controls.Add(pid6);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 57);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1185, 380);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventory Details";
            // 
            // date6
            // 
            date6.CustomFormat = "dd/MM/yy";
            date6.Format = DateTimePickerFormat.Custom;
            date6.Location = new Point(221, 259);
            date6.Name = "date6";
            date6.Size = new Size(299, 34);
            date6.TabIndex = 17;
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label9);
            panel3.Location = new Point(919, 33);
            panel3.Name = "panel3";
            panel3.Size = new Size(225, 149);
            panel3.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(119, 23);
            label12.Name = "label12";
            label12.Size = new Size(24, 25);
            label12.TabIndex = 1;
            label12.Text = "0";
            label12.Click += label12_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(31, 23);
            label9.Name = "label9";
            label9.Size = new Size(91, 25);
            label9.TabIndex = 0;
            label9.Text = "Orders:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(label13);
            panel2.Controls.Add(label10);
            panel2.Location = new Point(776, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(225, 148);
            panel2.TabIndex = 15;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.Black;
            label13.Location = new Point(143, 29);
            label13.Name = "label13";
            label13.Size = new Size(24, 25);
            label13.TabIndex = 1;
            label13.Text = "0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(21, 29);
            label10.Name = "label10";
            label10.Size = new Size(108, 25);
            label10.TabIndex = 0;
            label10.Text = "Quantity:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label8);
            panel1.Location = new Point(612, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(225, 149);
            panel1.TabIndex = 14;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(135, 20);
            label11.Name = "label11";
            label11.Size = new Size(24, 25);
            label11.TabIndex = 1;
            label11.Text = "0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(29, 20);
            label8.Name = "label8";
            label8.Size = new Size(111, 25);
            label8.TabIndex = 0;
            label8.Text = "Products:";
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(377, 314);
            button3.Name = "button3";
            button3.Size = new Size(116, 52);
            button3.TabIndex = 13;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(196, 314);
            button2.Name = "button2";
            button2.Size = new Size(115, 52);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(15, 314);
            button1.Name = "button1";
            button1.Size = new Size(122, 52);
            button1.TabIndex = 2;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // price6
            // 
            price6.Location = new Point(221, 214);
            price6.Name = "price6";
            price6.Size = new Size(299, 34);
            price6.TabIndex = 10;
            // 
            // qnt6
            // 
            qnt6.Location = new Point(221, 169);
            qnt6.Name = "qnt6";
            qnt6.Size = new Size(299, 34);
            qnt6.TabIndex = 9;
            // 
            // cname6
            // 
            cname6.Location = new Point(221, 126);
            cname6.Name = "cname6";
            cname6.Size = new Size(299, 34);
            cname6.TabIndex = 8;
            // 
            // pname6
            // 
            pname6.Location = new Point(221, 81);
            pname6.Name = "pname6";
            pname6.Size = new Size(299, 34);
            pname6.TabIndex = 7;
            // 
            // pid6
            // 
            pid6.Location = new Point(221, 38);
            pid6.Name = "pid6";
            pid6.Size = new Size(299, 34);
            pid6.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(15, 265);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 5;
            label7.Text = "Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(15, 222);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 4;
            label6.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(15, 177);
            label5.Name = "label5";
            label5.Size = new Size(100, 25);
            label5.TabIndex = 3;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(15, 134);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 2;
            label4.Text = "Customer Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(15, 89);
            label3.Name = "label3";
            label3.Size = new Size(159, 25);
            label3.TabIndex = 1;
            label3.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(15, 46);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 0;
            label2.Text = "Product Id";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { pid, pname, cname, qnty, price, date });
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            dataGridView1.Location = new Point(12, 455);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1160, 180);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // pid
            // 
            pid.HeaderText = "Product Id";
            pid.MinimumWidth = 6;
            pid.Name = "pid";
            // 
            // pname
            // 
            pname.HeaderText = "Product Name";
            pname.MinimumWidth = 6;
            pname.Name = "pname";
            // 
            // cname
            // 
            cname.HeaderText = "Customer Name";
            cname.MinimumWidth = 6;
            cname.Name = "cname";
            // 
            // qnty
            // 
            qnty.HeaderText = "Quantity";
            qnty.MinimumWidth = 6;
            qnty.Name = "qnty";
            // 
            // price
            // 
            price.HeaderText = "Price";
            price.MinimumWidth = 6;
            price.Name = "price";
            // 
            // date
            // 
            date.HeaderText = "Date";
            date.MinimumWidth = 6;
            date.Name = "date";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(18F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RosyBrown;
            ClientSize = new Size(1191, 652);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(7, 5, 7, 5);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox price6;
        private TextBox qnt6;
        private TextBox cname6;
        private TextBox pname6;
        private TextBox pid6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel1;
        private Label label12;
        private Label label9;
        private Label label13;
        private Label label10;
        private Label label11;
        private Label label8;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn pid;
        private DataGridViewTextBoxColumn pname;
        private DataGridViewTextBoxColumn cname;
        private DataGridViewTextBoxColumn qnty;
        private DataGridViewTextBoxColumn price;
        private DataGridViewTextBoxColumn date;
        private DateTimePicker date6;
    }
}