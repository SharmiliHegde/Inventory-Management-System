namespace InventoryManagementSystem
{
    partial class Register
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            suname = new TextBox();
            spass = new TextBox();
            scpass = new TextBox();
            button1 = new Button();
            label5 = new Label();
            label6 = new Label();
            sid = new Label();
            usid = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(341, 32);
            label1.Name = "label1";
            label1.Size = new Size(276, 35);
            label1.TabIndex = 0;
            label1.Text = "Create Your Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(22, 159);
            label2.Name = "label2";
            label2.Size = new Size(124, 25);
            label2.TabIndex = 1;
            label2.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 215);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(22, 277);
            label4.Name = "label4";
            label4.Size = new Size(199, 25);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // suname
            // 
            suname.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            suname.Location = new Point(305, 156);
            suname.Name = "suname";
            suname.Size = new Size(386, 34);
            suname.TabIndex = 4;
            // 
            // spass
            // 
            spass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            spass.Location = new Point(305, 208);
            spass.Name = "spass";
            spass.Size = new Size(386, 34);
            spass.TabIndex = 5;
            // 
            // scpass
            // 
            scpass.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scpass.Location = new Point(305, 270);
            scpass.Name = "scpass";
            scpass.Size = new Size(386, 34);
            scpass.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(415, 334);
            button1.Name = "button1";
            button1.Size = new Size(162, 54);
            button1.TabIndex = 7;
            button1.Text = "SIGN UP";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(305, 409);
            label5.Name = "label5";
            label5.Size = new Size(204, 22);
            label5.TabIndex = 8;
            label5.Text = "Already have an account";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(553, 409);
            label6.Name = "label6";
            label6.Size = new Size(55, 22);
            label6.TabIndex = 9;
            label6.Text = "Login";
            label6.Click += label6_Click;
            // 
            // sid
            // 
            sid.AutoSize = true;
            sid.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sid.Location = new Point(22, 102);
            sid.Name = "sid";
            sid.Size = new Size(87, 25);
            sid.TabIndex = 10;
            sid.Text = "User Id";
            sid.Click += sid_Click;
            // 
            // usid
            // 
            usid.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usid.Location = new Point(305, 100);
            usid.Name = "usid";
            usid.Size = new Size(386, 34);
            usid.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(usid);
            Controls.Add(sid);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(scpass);
            Controls.Add(spass);
            Controls.Add(suname);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox suname;
        private TextBox spass;
        private TextBox scpass;
        private Button button1;
        private Label label5;
        private Label label6;
        private Label sid;
        private TextBox usid;
    }
}