namespace DevOps
{
    partial class Screen_Books_Load
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
            btnback = new Button();
            button1 = new Button();
            button2 = new Button();
            dtgBooksLoad = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgBooksLoad).BeginInit();
            SuspendLayout();
            // 
            // btnback
            // 
            btnback.BackColor = Color.Black;
            btnback.Cursor = Cursors.Hand;
            btnback.FlatStyle = FlatStyle.Flat;
            btnback.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnback.ForeColor = Color.White;
            btnback.Location = new Point(88, 465);
            btnback.Name = "btnback";
            btnback.Size = new Size(196, 39);
            btnback.TabIndex = 9;
            btnback.Text = "REGISTER";
            btnback.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(517, 465);
            button1.Name = "button1";
            button1.Size = new Size(196, 39);
            button1.TabIndex = 10;
            button1.Text = "DELETE";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(302, 465);
            button2.Name = "button2";
            button2.Size = new Size(196, 39);
            button2.TabIndex = 11;
            button2.Text = "UPDATE";
            button2.UseVisualStyleBackColor = false;
            // 
            // dtgBooksLoad
            // 
            dtgBooksLoad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgBooksLoad.Location = new Point(88, 12);
            dtgBooksLoad.Name = "dtgBooksLoad";
            dtgBooksLoad.RowHeadersWidth = 51;
            dtgBooksLoad.Size = new Size(625, 423);
            dtgBooksLoad.TabIndex = 12;
            dtgBooksLoad.CellContentClick += dtgBooksLoad_CellContentClick;
            // 
            // Screen_Books_Load
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(793, 530);
            Controls.Add(dtgBooksLoad);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(btnback);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Screen_Books_Load";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen_Books_Load";
            Load += Screen_Books_Load_Load;
            ((System.ComponentModel.ISupportInitialize)dtgBooksLoad).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnback;
        private Button button1;
        private Button button2;
        private DataGridView dtgBooksLoad;
    }
}