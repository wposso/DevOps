namespace DevOps
{
    partial class Screen_Register
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
            pnlload = new Panel();
            label3 = new Label();
            txtemail = new TextBox();
            label2 = new Label();
            txtfirstname = new TextBox();
            txtpassword = new Label();
            label1 = new Label();
            chshowpasswordR = new CheckBox();
            txtlastname = new TextBox();
            txtpasswordR = new TextBox();
            btnsave = new Button();
            pnlload.SuspendLayout();
            SuspendLayout();
            // 
            // pnlload
            // 
            pnlload.BackColor = Color.White;
            pnlload.Controls.Add(label3);
            pnlload.Controls.Add(txtemail);
            pnlload.Controls.Add(label2);
            pnlload.Controls.Add(txtfirstname);
            pnlload.Controls.Add(txtpassword);
            pnlload.Controls.Add(label1);
            pnlload.Controls.Add(chshowpasswordR);
            pnlload.Controls.Add(txtlastname);
            pnlload.Controls.Add(txtpasswordR);
            pnlload.Controls.Add(btnsave);
            pnlload.Location = new Point(0, 0);
            pnlload.Name = "pnlload";
            pnlload.Size = new Size(401, 443);
            pnlload.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 139);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 9;
            label3.Text = "Email";
            // 
            // txtemail
            // 
            txtemail.BackColor = SystemColors.ScrollBar;
            txtemail.BorderStyle = BorderStyle.None;
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemail.Location = new Point(73, 162);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(257, 31);
            txtemail.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 5);
            label2.Name = "label2";
            label2.Size = new Size(80, 20);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // txtfirstname
            // 
            txtfirstname.BackColor = SystemColors.ScrollBar;
            txtfirstname.BorderStyle = BorderStyle.None;
            txtfirstname.Cursor = Cursors.IBeam;
            txtfirstname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtfirstname.Location = new Point(73, 28);
            txtfirstname.Name = "txtfirstname";
            txtfirstname.Size = new Size(257, 31);
            txtfirstname.TabIndex = 6;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(73, 206);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(70, 20);
            txtpassword.TabIndex = 5;
            txtpassword.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 71);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 4;
            label1.Text = "Last Name";
            // 
            // chshowpasswordR
            // 
            chshowpasswordR.AutoSize = true;
            chshowpasswordR.Cursor = Cursors.Hand;
            chshowpasswordR.Location = new Point(198, 278);
            chshowpasswordR.Name = "chshowpasswordR";
            chshowpasswordR.Size = new Size(132, 24);
            chshowpasswordR.TabIndex = 3;
            chshowpasswordR.Text = "Show Password";
            chshowpasswordR.UseVisualStyleBackColor = true;
            chshowpasswordR.CheckedChanged += chshowpasswordR_CheckedChanged;
            // 
            // txtlastname
            // 
            txtlastname.BackColor = SystemColors.ScrollBar;
            txtlastname.BorderStyle = BorderStyle.None;
            txtlastname.Cursor = Cursors.IBeam;
            txtlastname.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtlastname.Location = new Point(73, 94);
            txtlastname.Name = "txtlastname";
            txtlastname.Size = new Size(257, 31);
            txtlastname.TabIndex = 2;
            // 
            // txtpasswordR
            // 
            txtpasswordR.BackColor = SystemColors.ScrollBar;
            txtpasswordR.BorderStyle = BorderStyle.None;
            txtpasswordR.Cursor = Cursors.IBeam;
            txtpasswordR.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasswordR.Location = new Point(73, 229);
            txtpasswordR.Name = "txtpasswordR";
            txtpasswordR.PasswordChar = '•';
            txtpasswordR.Size = new Size(257, 31);
            txtpasswordR.TabIndex = 1;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.Black;
            btnsave.Cursor = Cursors.Hand;
            btnsave.FlatAppearance.BorderSize = 3;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnsave.ForeColor = Color.White;
            btnsave.Location = new Point(73, 370);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(257, 44);
            btnsave.TabIndex = 0;
            btnsave.Text = "SAVE";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // Screen_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 443);
            Controls.Add(pnlload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Register";
            Text = "Screen_Register";
            pnlload.ResumeLayout(false);
            pnlload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlload;
        private Label label3;
        private TextBox txtemail;
        private Label label2;
        private TextBox txtfirstname;
        private Label txtpassword;
        private Label label1;
        private CheckBox chshowpasswordR;
        private TextBox txtlastname;
        private TextBox txtpasswordR;
        private Button btnsave;
    }
}