namespace DevOps
{
    partial class Screen_Reload
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
            pnlreload = new Panel();
            txtpassword = new Label();
            label1 = new Label();
            chpasswordreload = new CheckBox();
            txtemailreload = new TextBox();
            txtpasswordreload = new TextBox();
            btnloginreload = new Button();
            pnlreload.SuspendLayout();
            SuspendLayout();
            // 
            // pnlreload
            // 
            pnlreload.BackColor = Color.White;
            pnlreload.Controls.Add(txtpassword);
            pnlreload.Controls.Add(label1);
            pnlreload.Controls.Add(chpasswordreload);
            pnlreload.Controls.Add(txtemailreload);
            pnlreload.Controls.Add(txtpasswordreload);
            pnlreload.Controls.Add(btnloginreload);
            pnlreload.Location = new Point(0, 1);
            pnlreload.Name = "pnlreload";
            pnlreload.Size = new Size(401, 443);
            pnlreload.TabIndex = 10;
            pnlreload.Paint += pnlreload_Paint;
            // 
            // txtpassword
            // 
            txtpassword.AutoSize = true;
            txtpassword.Location = new Point(73, 143);
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
            // chpasswordreload
            // 
            chpasswordreload.AutoSize = true;
            chpasswordreload.Cursor = Cursors.Hand;
            chpasswordreload.Location = new Point(198, 215);
            chpasswordreload.Name = "chpasswordreload";
            chpasswordreload.Size = new Size(132, 24);
            chpasswordreload.TabIndex = 3;
            chpasswordreload.Text = "Show Password";
            chpasswordreload.UseVisualStyleBackColor = true;
            chpasswordreload.CheckedChanged += chpasswordreload_CheckedChanged;
            // 
            // txtemailreload
            // 
            txtemailreload.BackColor = SystemColors.ScrollBar;
            txtemailreload.BorderStyle = BorderStyle.None;
            txtemailreload.Cursor = Cursors.IBeam;
            txtemailreload.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtemailreload.Location = new Point(73, 95);
            txtemailreload.Name = "txtemailreload";
            txtemailreload.Size = new Size(257, 31);
            txtemailreload.TabIndex = 2;
            // 
            // txtpasswordreload
            // 
            txtpasswordreload.BackColor = SystemColors.ScrollBar;
            txtpasswordreload.BorderStyle = BorderStyle.None;
            txtpasswordreload.Cursor = Cursors.IBeam;
            txtpasswordreload.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtpasswordreload.Location = new Point(73, 166);
            txtpasswordreload.Name = "txtpasswordreload";
            txtpasswordreload.PasswordChar = '•';
            txtpasswordreload.Size = new Size(257, 31);
            txtpasswordreload.TabIndex = 1;
            // 
            // btnloginreload
            // 
            btnloginreload.Cursor = Cursors.Hand;
            btnloginreload.FlatAppearance.BorderSize = 3;
            btnloginreload.FlatStyle = FlatStyle.Flat;
            btnloginreload.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnloginreload.ForeColor = Color.MidnightBlue;
            btnloginreload.Location = new Point(73, 370);
            btnloginreload.Name = "btnloginreload";
            btnloginreload.Size = new Size(257, 44);
            btnloginreload.TabIndex = 0;
            btnloginreload.Text = "LOGIN";
            btnloginreload.UseVisualStyleBackColor = true;
            btnloginreload.Click += btnloginreload_Click;
            // 
            // Screen_Reload
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(402, 446);
            Controls.Add(pnlreload);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Reload";
            Text = "Screen_Reload";
            pnlreload.ResumeLayout(false);
            pnlreload.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlreload;
        private Label txtpassword;
        private Label label1;
        private CheckBox chpasswordreload;
        private TextBox txtemailreload;
        private TextBox txtpasswordreload;
        private Button btnloginreload;
    }
}