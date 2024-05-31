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
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBtittle
            // 
            txtBtittle.BackColor = SystemColors.ScrollBar;
            txtBtittle.BorderStyle = BorderStyle.None;
            txtBtittle.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBtittle.Location = new Point(144, 127);
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
            btnBsave.Location = new Point(162, 354);
            btnBsave.Name = "btnBsave";
            btnBsave.Size = new Size(196, 39);
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
            txtBauthor.Location = new Point(144, 208);
            txtBauthor.Name = "txtBauthor";
            txtBauthor.Size = new Size(245, 36);
            txtBauthor.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(144, 101);
            label1.Name = "label1";
            label1.Size = new Size(48, 23);
            label1.TabIndex = 12;
            label1.Text = "Tittle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(144, 182);
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
            label3.Location = new Point(50, 27);
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
            label4.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(14, 20);
            label4.Name = "label4";
            label4.Size = new Size(42, 38);
            label4.TabIndex = 2;
            label4.Text = "☼";
            // 
            // lblbooksaved
            // 
            lblbooksaved.AutoSize = true;
            lblbooksaved.FlatStyle = FlatStyle.Flat;
            lblbooksaved.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbooksaved.ForeColor = Color.LimeGreen;
            lblbooksaved.Location = new Point(168, 418);
            lblbooksaved.Name = "lblbooksaved";
            lblbooksaved.Size = new Size(190, 23);
            lblbooksaved.TabIndex = 15;
            lblbooksaved.Text = "✓ Book saved sucessful";
            lblbooksaved.Visible = false;
            // 
            // lblbookerror
            // 
            lblbookerror.AutoSize = true;
            lblbookerror.FlatStyle = FlatStyle.Flat;
            lblbookerror.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbookerror.ForeColor = Color.Red;
            lblbookerror.Location = new Point(198, 418);
            lblbookerror.Name = "lblbookerror";
            lblbookerror.Size = new Size(143, 23);
            lblbookerror.TabIndex = 16;
            lblbookerror.Text = "🇽 Book not saved";
            lblbookerror.Visible = false;
            // 
            // Screen_Books_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(522, 450);
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
    }
}