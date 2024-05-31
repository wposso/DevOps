namespace DevOps
{
    partial class Screen_Books_Register
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
            txtBtittle = new TextBox();
            btnBsave = new Button();
            txtBauthor = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            btnBback = new Button();
            label4 = new Label();
            lblbooksaved = new Label();
            lblbookerror = new Label();
            label5 = new Label();
            txtBid = new TextBox();
            lblicon = new Label();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBtittle
            // 
            txtBtittle.BackColor = SystemColors.ScrollBar;
            txtBtittle.BorderStyle = BorderStyle.None;
            txtBtittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBtittle.Location = new Point(136, 194);
            txtBtittle.Name = "txtBtittle";
            txtBtittle.Size = new Size(245, 36);
            txtBtittle.TabIndex = 1;
            // 
            // btnBsave
            // 
            btnBsave.BackColor = Color.Black;
            btnBsave.Cursor = Cursors.Hand;
            btnBsave.FlatStyle = FlatStyle.Flat;
            btnBsave.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBsave.ForeColor = Color.White;
            btnBsave.Location = new Point(136, 365);
            btnBsave.Name = "btnBsave";
            btnBsave.Size = new Size(245, 39);
            btnBsave.TabIndex = 10;
            btnBsave.Text = "SAVE";
            btnBsave.UseVisualStyleBackColor = false;
            btnBsave.Click += btnBsave_Click;
            // 
            // txtBauthor
            // 
            txtBauthor.BackColor = SystemColors.ScrollBar;
            txtBauthor.BorderStyle = BorderStyle.None;
            txtBauthor.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBauthor.Location = new Point(136, 275);
            txtBauthor.Name = "txtBauthor";
            txtBauthor.Size = new Size(245, 36);
            txtBauthor.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(136, 168);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 12;
            label1.Text = "Tittle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(136, 249);
            label2.Name = "label2";
            label2.Size = new Size(63, 23);
            label2.TabIndex = 13;
            label2.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(51, 27);
            label3.Name = "label3";
            label3.Size = new Size(341, 28);
            label3.TabIndex = 1;
            label3.Text = "In this section you can register a book";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnBback);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(-2, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 72);
            panel1.TabIndex = 14;
            // 
            // btnBback
            // 
            btnBback.BackColor = Color.White;
            btnBback.Cursor = Cursors.Hand;
            btnBback.FlatStyle = FlatStyle.Flat;
            btnBback.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBback.ForeColor = Color.Black;
            btnBback.Location = new Point(473, 10);
            btnBback.Name = "btnBback";
            btnBback.Size = new Size(42, 29);
            btnBback.TabIndex = 3;
            btnBback.Text = "↩";
            btnBback.UseVisualStyleBackColor = false;
            btnBback.Click += btnBback_Click;
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
            // lblbooksaved
            // 
            lblbooksaved.AutoSize = true;
            lblbooksaved.FlatStyle = FlatStyle.Flat;
            lblbooksaved.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblbooksaved.ForeColor = Color.LimeGreen;
            lblbooksaved.Location = new Point(163, 418);
            lblbooksaved.Name = "lblbooksaved";
            lblbooksaved.Size = new Size(186, 23);
            lblbooksaved.TabIndex = 15;
            lblbooksaved.Text = "✓ Book saved sucessful";
            lblbooksaved.Visible = false;
            // 
            // lblbookerror
            // 
            lblbookerror.AutoSize = true;
            lblbookerror.FlatStyle = FlatStyle.Flat;
            lblbookerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblbookerror.ForeColor = Color.Red;
            lblbookerror.Location = new Point(209, 418);
            lblbookerror.Name = "lblbookerror";
            lblbookerror.Size = new Size(127, 23);
            lblbookerror.TabIndex = 16;
            lblbookerror.Text = "Book not saved";
            lblbookerror.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 94);
            label5.Name = "label5";
            label5.Size = new Size(27, 23);
            label5.TabIndex = 18;
            label5.Text = "ID";
            // 
            // txtBid
            // 
            txtBid.BackColor = SystemColors.ScrollBar;
            txtBid.BorderStyle = BorderStyle.None;
            txtBid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBid.Location = new Point(136, 120);
            txtBid.Name = "txtBid";
            txtBid.Size = new Size(245, 36);
            txtBid.TabIndex = 17;
            // 
            // lblicon
            // 
            lblicon.AutoSize = true;
            lblicon.FlatStyle = FlatStyle.Flat;
            lblicon.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblicon.ForeColor = Color.Red;
            lblicon.Location = new Point(180, 418);
            lblicon.Name = "lblicon";
            lblicon.Size = new Size(33, 23);
            lblicon.TabIndex = 19;
            lblicon.Text = "⚠";
            lblicon.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(163, 366);
            label6.Name = "label6";
            label6.Size = new Size(49, 35);
            label6.TabIndex = 32;
            label6.Text = "📋";
            // 
            // Screen_Books_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
            Controls.Add(label6);
            Controls.Add(lblicon);
            Controls.Add(label5);
            Controls.Add(txtBid);
            Controls.Add(lblbookerror);
            Controls.Add(lblbooksaved);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBauthor);
            Controls.Add(btnBsave);
            Controls.Add(txtBtittle);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(807, 103);
            Name = "Screen_Books_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen_Books_Register";
            Load += Screen_Books_Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtBtittle;
        private Button btnBsave;
        private TextBox txtBauthor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private Button btnBback;
        private Label lblbooksaved;
        private Label lblbookerror;
        private Label label5;
        private TextBox txtBid;
        private Label lblicon;
        private Label label6;
    }
}