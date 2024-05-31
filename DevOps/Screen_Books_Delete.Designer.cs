namespace DevOps
{
    partial class Screen_Books_Delete
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
            panel1 = new Panel();
            btnBDback = new Button();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            lblUicon = new Label();
            label5 = new Label();
            txtBDid = new TextBox();
            lblDbookerror = new Label();
            lblDbooksaved = new Label();
            btnBDsave = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btnBDback);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 72);
            panel1.TabIndex = 33;
            // 
            // btnBDback
            // 
            btnBDback.BackColor = Color.White;
            btnBDback.Cursor = Cursors.Hand;
            btnBDback.FlatStyle = FlatStyle.Flat;
            btnBDback.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBDback.ForeColor = Color.Black;
            btnBDback.Location = new Point(473, 10);
            btnBDback.Name = "btnBDback";
            btnBDback.Size = new Size(42, 29);
            btnBDback.TabIndex = 3;
            btnBDback.Text = "↩";
            btnBDback.UseVisualStyleBackColor = false;
            btnBDback.Click += btnBDback_Click;
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
            label3.Size = new Size(329, 28);
            label3.TabIndex = 1;
            label3.Text = "In this section you can delete a book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Black;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(163, 359);
            label6.Name = "label6";
            label6.Size = new Size(49, 35);
            label6.TabIndex = 39;
            label6.Text = "🗑️";
            // 
            // lblUicon
            // 
            lblUicon.AutoSize = true;
            lblUicon.FlatStyle = FlatStyle.Flat;
            lblUicon.Font = new Font("Segoe UI Light", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUicon.ForeColor = Color.Red;
            lblUicon.Location = new Point(175, 421);
            lblUicon.Name = "lblUicon";
            lblUicon.Size = new Size(33, 23);
            lblUicon.TabIndex = 38;
            lblUicon.Text = "⚠";
            lblUicon.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(143, 149);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 37;
            label5.Text = "Book ID";
            // 
            // txtBDid
            // 
            txtBDid.BackColor = SystemColors.ScrollBar;
            txtBDid.BorderStyle = BorderStyle.None;
            txtBDid.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBDid.Location = new Point(143, 175);
            txtBDid.Name = "txtBDid";
            txtBDid.Size = new Size(245, 36);
            txtBDid.TabIndex = 36;
            // 
            // lblDbookerror
            // 
            lblDbookerror.AutoSize = true;
            lblDbookerror.FlatStyle = FlatStyle.Flat;
            lblDbookerror.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDbookerror.ForeColor = Color.Red;
            lblDbookerror.Location = new Point(204, 421);
            lblDbookerror.Name = "lblDbookerror";
            lblDbookerror.Size = new Size(138, 23);
            lblDbookerror.TabIndex = 35;
            lblDbookerror.Text = "Book not update";
            lblDbookerror.Visible = false;
            // 
            // lblDbooksaved
            // 
            lblDbooksaved.AutoSize = true;
            lblDbooksaved.FlatStyle = FlatStyle.Flat;
            lblDbooksaved.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDbooksaved.ForeColor = Color.LimeGreen;
            lblDbooksaved.Location = new Point(157, 421);
            lblDbooksaved.Name = "lblDbooksaved";
            lblDbooksaved.Size = new Size(207, 23);
            lblDbooksaved.TabIndex = 34;
            lblDbooksaved.Text = "✓ Book updated sucessful";
            lblDbooksaved.Visible = false;
            // 
            // btnBDsave
            // 
            btnBDsave.BackColor = Color.Black;
            btnBDsave.Cursor = Cursors.Hand;
            btnBDsave.FlatStyle = FlatStyle.Flat;
            btnBDsave.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBDsave.ForeColor = Color.White;
            btnBDsave.Location = new Point(138, 357);
            btnBDsave.Name = "btnBDsave";
            btnBDsave.Size = new Size(245, 39);
            btnBDsave.TabIndex = 32;
            btnBDsave.Text = "DELETE";
            btnBDsave.UseVisualStyleBackColor = false;
            btnBDsave.Click += btnBDsave_Click;
            // 
            // Screen_Books_Delete
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(lblUicon);
            Controls.Add(label5);
            Controls.Add(txtBDid);
            Controls.Add(lblDbookerror);
            Controls.Add(lblDbooksaved);
            Controls.Add(btnBDsave);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Books_Delete";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen_Books_Delete";
            Load += Screen_Books_Delete_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnBDback;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label lblUicon;
        private Label label5;
        private TextBox txtBDid;
        private Label lblDbookerror;
        private Label lblDbooksaved;
        private Button btnBDsave;
    }
}