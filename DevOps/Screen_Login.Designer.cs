namespace DevOps
{
    partial class Screen_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblgetstarted = new Label();
            lblregister = new Label();
            lblloginhere = new Label();
            label5 = new Label();
            pnlload = new Panel();
            lblerrorcredentials2 = new Label();
            lblerrorcredentials1 = new Label();
            txtpassword = new Label();
            label1 = new Label();
            chshowpassword = new CheckBox();
            txtemail = new TextBox();
            txtpasswordL = new TextBox();
            btnlogin = new Button();
            lblaccount = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            label9 = new Label();
            btnexit = new Button();
            button3 = new Button();
            btnminimized = new Button();
            panel1.SuspendLayout();
            pnlload.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblgetstarted);
            panel1.Controls.Add(lblregister);
            panel1.Controls.Add(lblloginhere);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(pnlload);
            panel1.Controls.Add(lblaccount);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(717, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(505, 618);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lblgetstarted
            // 
            lblgetstarted.AutoSize = true;
            lblgetstarted.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblgetstarted.Location = new Point(112, 24);
            lblgetstarted.Name = "lblgetstarted";
            lblgetstarted.Size = new Size(276, 62);
            lblgetstarted.TabIndex = 13;
            lblgetstarted.Text = "Get Started";
            // 
            // lblregister
            // 
            lblregister.AutoSize = true;
            lblregister.FlatStyle = FlatStyle.Flat;
            lblregister.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblregister.Location = new Point(157, 24);
            lblregister.Name = "lblregister";
            lblregister.Size = new Size(195, 60);
            lblregister.TabIndex = 12;
            lblregister.Text = "Register";
            lblregister.Visible = false;
            // 
            // lblloginhere
            // 
            lblloginhere.AutoSize = true;
            lblloginhere.Cursor = Cursors.Hand;
            lblloginhere.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblloginhere.ForeColor = Color.Teal;
            lblloginhere.Location = new Point(280, 574);
            lblloginhere.Name = "lblloginhere";
            lblloginhere.Size = new Size(82, 20);
            lblloginhere.TabIndex = 11;
            lblloginhere.Text = "Login here";
            lblloginhere.Visible = false;
            lblloginhere.Click += lblloginhere_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(162, 574);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 10;
            label5.Text = "Already a menber";
            label5.Visible = false;
            // 
            // pnlload
            // 
            pnlload.Controls.Add(lblerrorcredentials2);
            pnlload.Controls.Add(lblerrorcredentials1);
            pnlload.Controls.Add(txtpassword);
            pnlload.Controls.Add(label1);
            pnlload.Controls.Add(chshowpassword);
            pnlload.Controls.Add(txtemail);
            pnlload.Controls.Add(txtpasswordL);
            pnlload.Controls.Add(btnlogin);
            pnlload.Location = new Point(58, 128);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(401, 443);
            pnlload.TabIndex = 9;
            pnlload.Paint += pnlload_Paint;
            // 
            // lblerrorcredentials2
            // 
            lblerrorcredentials2.AutoSize = true;
            lblerrorcredentials2.Font = new Font("Segoe UI", 7.8F);
            lblerrorcredentials2.ForeColor = Color.Red;
            lblerrorcredentials2.Location = new Point(73, 201);
            lblerrorcredentials2.Name = "lblerrorcredentials2";
            lblerrorcredentials2.Size = new Size(117, 17);
            lblerrorcredentials2.TabIndex = 7;
            lblerrorcredentials2.Text = "*Invalid credentials";
            lblerrorcredentials2.Visible = false;
            // 
            // lblerrorcredentials1
            // 
            lblerrorcredentials1.AutoSize = true;
            lblerrorcredentials1.Font = new Font("Segoe UI", 7.8F);
            lblerrorcredentials1.ForeColor = Color.Red;
            lblerrorcredentials1.Location = new Point(73, 127);
            lblerrorcredentials1.Name = "lblerrorcredentials1";
            lblerrorcredentials1.Size = new Size(117, 17);
            lblerrorcredentials1.TabIndex = 6;
            lblerrorcredentials1.Text = "*Invalid credentials";
            lblerrorcredentials1.Visible = false;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(73, 147);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(70, 20);
            txtpassword.TabIndex = 5;
            txtpassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 72);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 4;
            label1.Text = "Email";
            // 
            // chshowpassword
            // 
            chshowpassword.AutoSize = true;
            chshowpassword.Cursor = Cursors.Hand;
            chshowpassword.Location = new Point(198, 219);
            chshowpassword.Name = "chshowpassword";
            chshowpassword.Size = new Size(132, 24);
            chshowpassword.TabIndex = 3;
            chshowpassword.Text = "Show Password";
            chshowpassword.UseVisualStyleBackColor = true;
            chshowpassword.CheckedChanged += chshowpassword_CheckedChanged;
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ScrollBar;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(73, 95);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(257, 31);
            txtemail.TabIndex = 2;
            txtemail.TextChanged += txtemail_TextChanged;
            // 
            // txtpasswordL
            // 
            txtpasswordL.BackColor = SystemColors.ScrollBar;
            txtpasswordL.BorderStyle = BorderStyle.None;
            txtpasswordL.Cursor = Cursors.IBeam;
            txtpasswordL.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasswordL.Location = new Point(73, 170);
            txtpasswordL.Name = "txtpasswordL";
            txtpasswordL.Size = new Size(257, 31);
            txtpasswordL.TabIndex = 1;
            txtpasswordL.TextChanged += txtpasswordL_TextChanged;
            // 
            // btnlogin
            // 
            btnlogin.BackColor = Color.Teal;
            btnlogin.Cursor = Cursors.Hand;
            btnlogin.FlatAppearance.BorderSize = 3;
            btnlogin.FlatStyle = FlatStyle.Flat;
            btnlogin.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnlogin.ForeColor = Color.White;
            btnlogin.Location = new Point(73, 370);
            btnlogin.Name = "btnlogin";
            btnlogin.Size = new Size(257, 44);
            btnlogin.TabIndex = 0;
            btnlogin.Text = "LOGIN";
            btnlogin.UseVisualStyleBackColor = false;
            btnlogin.Click += btnlogin_Click;
            // 
            // lblaccount
            // 
            lblaccount.AutoSize = true;
            lblaccount.Cursor = Cursors.Hand;
            lblaccount.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblaccount.ForeColor = Color.Teal;
            lblaccount.Location = new Point(280, 570);
            lblaccount.Name = "lblaccount";
            lblaccount.Size = new Size(72, 20);
            lblaccount.TabIndex = 8;
            lblaccount.Text = "Account?";
            lblaccount.Click += lblaccount_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(185, 570);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 7;
            label4.Text = "Don't have an ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(72, 407);
            label6.Name = "label6";
            label6.Size = new Size(307, 60);
            label6.TabIndex = 9;
            label6.Text = "WELCOME TO";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(10, 6);
            label7.Name = "label7";
            label7.Size = new Size(166, 31);
            label7.TabIndex = 9;
            label7.Text = "my proyect C#";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label7);
            panel2.Location = new Point(234, 459);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 43);
            panel2.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.White;
            label8.Location = new Point(72, 607);
            label8.Name = "label8";
            label8.Size = new Size(304, 20);
            label8.TabIndex = 9;
            label8.Text = "The purpose of this project is for me to learn";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.White;
            label9.Location = new Point(185, 626);
            label9.Name = "label9";
            label9.Size = new Size(340, 20);
            label9.TabIndex = 11;
            label9.Text = "to program in the Csharp programming language.";
            // 
            // btnexit
            // 
            btnexit.Cursor = Cursors.Hand;
            btnexit.FlatStyle = FlatStyle.Flat;
            btnexit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnexit.ForeColor = Color.White;
            btnexit.Location = new Point(1230, 12);
            btnexit.Name = "btnexit";
            btnexit.Size = new Size(39, 33);
            btnexit.TabIndex = 12;
            btnexit.Text = "X";
            btnexit.UseVisualStyleBackColor = true;
            btnexit.Click += btnexit_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(1183, 12);
            button3.Name = "button3";
            button3.Size = new Size(39, 33);
            button3.TabIndex = 13;
            button3.Text = "O";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnminimized
            // 
            btnminimized.Cursor = Cursors.Hand;
            btnminimized.FlatStyle = FlatStyle.Flat;
            btnminimized.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnminimized.ForeColor = Color.White;
            btnminimized.Location = new Point(1136, 12);
            btnminimized.Name = "btnminimized";
            btnminimized.Size = new Size(39, 33);
            btnminimized.TabIndex = 14;
            btnminimized.Text = "--";
            btnminimized.UseVisualStyleBackColor = true;
            btnminimized.Click += btnminimized_Click;
            // 
            // Screen_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Teal;
            ClientSize = new Size(1307, 770);
            Controls.Add(btnminimized);
            Controls.Add(button3);
            Controls.Add(btnexit);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Login";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            pnlload.ResumeLayout(false);
            pnlload.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CheckBox chshowpassword;
        private TextBox txtemail;
        private TextBox txtpasswordL;
        private Button btnlogin;
        private Label label4;
        private Label txtpassword;
        private Label label1;
        private Label lblaccount;
        private Label label6;
        private Label label7;
        private Panel panel2;
        private Label label8;
        private Label label9;
        private Button btnexit;
        private Button button3;
        private Button btnminimized;
        private Panel pnlload;
        private Label lblloginhere;
        private Label label5;
        private Label lblerrorcredentials2;
        private Label lblerrorcredentials1;
        private Label lblregister;
        private Label lblgetstarted;
    }
}
