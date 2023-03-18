namespace LoginAndSignup
{
    partial class Transaction
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lname_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fname_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.brID_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.qty_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.author_tb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.title_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookID_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.borrow_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.clearbr_btn = new System.Windows.Forms.Button();
            this.clearbooks_btn = new System.Windows.Forms.Button();
            this.clearall_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat Subrayada", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(411, 34);
            this.label3.TabIndex = 5;
            this.label3.Text = "Borrow / Return Books";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lname_tb);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fname_tb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.brID_tb);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 175);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrower";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(69, 137);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Retrieve Borrower";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lname_tb
            // 
            this.lname_tb.Location = new System.Drawing.Point(86, 100);
            this.lname_tb.Name = "lname_tb";
            this.lname_tb.ReadOnly = true;
            this.lname_tb.Size = new System.Drawing.Size(159, 20);
            this.lname_tb.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Last Name";
            // 
            // fname_tb
            // 
            this.fname_tb.Location = new System.Drawing.Point(86, 65);
            this.fname_tb.Name = "fname_tb";
            this.fname_tb.ReadOnly = true;
            this.fname_tb.Size = new System.Drawing.Size(159, 20);
            this.fname_tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "First Name";
            // 
            // brID_tb
            // 
            this.brID_tb.Location = new System.Drawing.Point(87, 32);
            this.brID_tb.Name = "brID_tb";
            this.brID_tb.Size = new System.Drawing.Size(158, 20);
            this.brID_tb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Borrower ID";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.qty_tb);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.author_tb);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.title_tb);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.bookID_tb);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.search_tb);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(646, 248);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books";
            // 
            // qty_tb
            // 
            this.qty_tb.Location = new System.Drawing.Point(64, 189);
            this.qty_tb.Name = "qty_tb";
            this.qty_tb.ReadOnly = true;
            this.qty_tb.Size = new System.Drawing.Size(153, 20);
            this.qty_tb.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search/View Books";
            // 
            // author_tb
            // 
            this.author_tb.Location = new System.Drawing.Point(64, 149);
            this.author_tb.Name = "author_tb";
            this.author_tb.ReadOnly = true;
            this.author_tb.Size = new System.Drawing.Size(153, 20);
            this.author_tb.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Author";
            // 
            // title_tb
            // 
            this.title_tb.Location = new System.Drawing.Point(64, 109);
            this.title_tb.Name = "title_tb";
            this.title_tb.ReadOnly = true;
            this.title_tb.Size = new System.Drawing.Size(153, 20);
            this.title_tb.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Title";
            // 
            // bookID_tb
            // 
            this.bookID_tb.Location = new System.Drawing.Point(64, 70);
            this.bookID_tb.Name = "bookID_tb";
            this.bookID_tb.ReadOnly = true;
            this.bookID_tb.Size = new System.Drawing.Size(153, 20);
            this.bookID_tb.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Book ID";
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(233, 34);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(394, 20);
            this.search_tb.TabIndex = 1;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(233, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(394, 164);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // borrow_btn
            // 
            this.borrow_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrow_btn.Location = new System.Drawing.Point(371, 75);
            this.borrow_btn.Name = "borrow_btn";
            this.borrow_btn.Size = new System.Drawing.Size(88, 40);
            this.borrow_btn.TabIndex = 8;
            this.borrow_btn.Text = "BORROW";
            this.borrow_btn.UseVisualStyleBackColor = true;
            this.borrow_btn.Click += new System.EventHandler(this.borrow_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.return_btn.Location = new System.Drawing.Point(513, 75);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(88, 40);
            this.return_btn.TabIndex = 9;
            this.return_btn.Text = "RETURN";
            this.return_btn.UseVisualStyleBackColor = true;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // clearbr_btn
            // 
            this.clearbr_btn.Location = new System.Drawing.Point(436, 166);
            this.clearbr_btn.Name = "clearbr_btn";
            this.clearbr_btn.Size = new System.Drawing.Size(105, 23);
            this.clearbr_btn.TabIndex = 10;
            this.clearbr_btn.Text = "Clear Borrower";
            this.clearbr_btn.UseVisualStyleBackColor = true;
            this.clearbr_btn.Click += new System.EventHandler(this.clearbr_btn_Click);
            // 
            // clearbooks_btn
            // 
            this.clearbooks_btn.Location = new System.Drawing.Point(436, 202);
            this.clearbooks_btn.Name = "clearbooks_btn";
            this.clearbooks_btn.Size = new System.Drawing.Size(105, 23);
            this.clearbooks_btn.TabIndex = 11;
            this.clearbooks_btn.Text = "Clear Books";
            this.clearbooks_btn.UseVisualStyleBackColor = true;
            this.clearbooks_btn.Click += new System.EventHandler(this.clearbooks_btn_Click);
            // 
            // clearall_btn
            // 
            this.clearall_btn.Location = new System.Drawing.Point(436, 129);
            this.clearall_btn.Name = "clearall_btn";
            this.clearall_btn.Size = new System.Drawing.Size(105, 23);
            this.clearall_btn.TabIndex = 12;
            this.clearall_btn.Text = "Clear ALL";
            this.clearall_btn.UseVisualStyleBackColor = true;
            this.clearall_btn.Click += new System.EventHandler(this.clearall_btn_Click);
            // 
            // Transaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 506);
            this.Controls.Add(this.clearall_btn);
            this.Controls.Add(this.clearbooks_btn);
            this.Controls.Add(this.clearbr_btn);
            this.Controls.Add(this.return_btn);
            this.Controls.Add(this.borrow_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "Transaction";
            this.Text = "Transaction";
            this.Load += new System.EventHandler(this.Transaction_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox lname_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fname_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox brID_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox qty_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox author_tb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox title_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookID_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button borrow_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button clearbr_btn;
        private System.Windows.Forms.Button clearbooks_btn;
        private System.Windows.Forms.Button clearall_btn;
        private System.Windows.Forms.Button button1;
    }
}