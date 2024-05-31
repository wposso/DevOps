namespace DevOps
{
    partial class Screen_Books_Update
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
            lblUicon = new Label();
            label5 = new Label();
            txtBUid = new TextBox();
            lblUbookerror = new Label();
            lblUbooksaved = new Label();
            panel1 = new Panel();
            btnBUback = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtBUauthor = new TextBox();
            btnBUsave = new Button();
            txtBUtittle = new TextBox();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblUicon
            // 
            lblUicon.AutoSize = true;
            lblUicon.FlatStyle = FlatStyle.Flat;
            lblUicon.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUicon.ForeColor = Color.Red;
            lblUicon.Location = new Point(174, 421);
            lblUicon.Name = "lblUicon";
            lblUicon.Size = new Size(33, 23);
            lblUicon.TabIndex = 30;
            lblUicon.Text = "⚠";
            lblUicon.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 97);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 29;
            label5.Text = "ID";
            // 
            // txtBUid
            // 
            txtBUid.BackColor = SystemColors.ScrollBar;
            txtBUid.BorderStyle = BorderStyle.None;
            txtBUid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBUid.Location = new Point(137, 123);
            txtBUid.Name = "txtBUid";
            txtBUid.Size = new Size(245, 36);
            txtBUid.TabIndex = 28;
            // 
            // lblUbookerror
            // 
            lblUbookerror.AutoSize = true;
            lblUbookerror.FlatStyle = FlatStyle.Flat;
            lblUbookerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUbookerror.ForeColor = Color.Red;
            lblUbookerror.Location = new Point(203, 421);
            lblUbookerror.Name = "lblUbookerror";
            lblUbookerror.Size = new Size(138, 23);
            lblUbookerror.TabIndex = 27;
            lblUbookerror.Text = "Book not update";
            lblUbookerror.Visible = false;
            // 
            // lblUbooksaved
            // 
            lblUbooksaved.AutoSize = true;
            lblUbooksaved.FlatStyle = FlatStyle.Flat;
            lblUbooksaved.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUbooksaved.ForeColor = Color.LimeGreen;
            lblUbooksaved.Location = new Point(156, 421);
            lblUbooksaved.Name = "lblUbooksaved";
            lblUbooksaved.Size = new Size(207, 23);
            lblUbooksaved.TabIndex = 26;
            lblUbooksaved.Text = "✓ Book updated sucessful";
            lblUbooksaved.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnBUback);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 72);
            panel1.TabIndex = 25;
            // 
            // btnBUback
            // 
            btnBUback.BackColor = Color.White;
            btnBUback.Cursor = Cursors.Hand;
            btnBUback.FlatStyle = FlatStyle.Flat;
            btnBUback.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBUback.ForeColor = Color.Black;
            btnBUback.Location = new Point(473, 10);
            btnBUback.Name = "btnBUback";
            btnBUback.Size = new Size(42, 29);
            btnBUback.TabIndex = 3;
            btnBUback.Text = "↩";
            btnBUback.UseVisualStyleBackColor = false;
            btnBUback.Click += btnBUback_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Black;
            label4.Font = new Font("Segoe UI Light", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(3, 20);
            label4.Name = "label4";
            label4.Size = new Size(55, 38);
            label4.TabIndex = 2;
            label4.Text = "💡";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 27);
            label3.Name = "label3";
            label3.Size = new Size(337, 28);
            label3.TabIndex = 1;
            label3.Text = "In this section you can update a book";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(137, 252);
            label2.Name = "label2";
            label2.Size = new Size(102, 23);
            label2.TabIndex = 24;
            label2.Text = "New Author";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(137, 171);
            label1.Name = "label1";
            label1.Size = new Size(87, 23);
            label1.TabIndex = 23;
            label1.Text = "New Tittle";
            // 
            // txtBUauthor
            // 
            txtBUauthor.BackColor = SystemColors.ScrollBar;
            txtBUauthor.BorderStyle = BorderStyle.None;
            txtBUauthor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBUauthor.Location = new Point(137, 278);
            txtBUauthor.Name = "txtBUauthor";
            txtBUauthor.Size = new Size(245, 36);
            txtBUauthor.TabIndex = 22;
            // 
            // btnBUsave
            // 
            btnBUsave.BackColor = Color.Black;
            btnBUsave.Cursor = Cursors.Hand;
            btnBUsave.FlatStyle = FlatStyle.Flat;
            btnBUsave.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBUsave.ForeColor = Color.White;
            btnBUsave.Location = new Point(137, 357);
            btnBUsave.Name = "btnBUsave";
            btnBUsave.Size = new Size(245, 39);
            btnBUsave.TabIndex = 21;
            btnBUsave.Text = "SAVE";
            btnBUsave.UseVisualStyleBackColor = false;
            btnBUsave.Click += btnBUsave_Click;
            // 
            // txtBUtittle
            // 
            txtBUtittle.BackColor = SystemColors.ScrollBar;
            txtBUtittle.BorderStyle = BorderStyle.None;
            txtBUtittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBUtittle.Location = new Point(137, 197);
            txtBUtittle.Name = "txtBUtittle";
            txtBUtittle.Size = new Size(245, 36);
            txtBUtittle.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(162, 359);
            label6.Name = "label6";
            label6.Size = new Size(49, 35);
            label6.TabIndex = 31;
            label6.Text = "📋";
            // 
            // Screen_Books_Update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(label6);
            Controls.Add(lblUicon);
            Controls.Add(label5);
            Controls.Add(txtBUid);
            Controls.Add(lblUbookerror);
            Controls.Add(lblUbooksaved);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBUauthor);
            Controls.Add(btnBUsave);
            Controls.Add(txtBUtittle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Books_Update";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen_Books_Update";
            Load += Screen_Books_Update_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUicon;
        private Label label5;
        private TextBox txtBUid;
        private Label lblUbookerror;
        private Label lblUbooksaved;
        private Panel panel1;
        private Button btnBUback;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBUauthor;
        private Button btnBUsave;
        private TextBox txtBUtittle;
        private Label label6;
    }
}