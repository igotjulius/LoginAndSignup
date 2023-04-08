namespace LoginAndSignup
{
    partial class ForgotPassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.username_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.oldpass_tb = new System.Windows.Forms.TextBox();
            this.username2_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.newpass_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.confirmnewpass_tb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.changepass_btn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::LoginAndSignup.Properties.Resources.forgot;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(97, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 52);
            this.label4.TabIndex = 9;
            this.label4.Text = "Forgot Password";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 89);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(399, 233);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.password_tb);
            this.tabPage1.Controls.Add(this.username_tb);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(391, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Retrieve Password";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Controls.Add(this.clear_btn);
            this.tabPage2.Controls.Add(this.changepass_btn);
            this.tabPage2.Controls.Add(this.confirmnewpass_tb);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.newpass_tb);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.oldpass_tb);
            this.tabPage2.Controls.Add(this.username2_tb);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Password";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(237, 139);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(74, 25);
            this.button3.TabIndex = 17;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(100, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 25);
            this.button1.TabIndex = 13;
            this.button1.Text = "Retrieve Password";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // password_tb
            // 
            this.password_tb.Location = new System.Drawing.Point(86, 96);
            this.password_tb.Name = "password_tb";
            this.password_tb.ReadOnly = true;
            this.password_tb.Size = new System.Drawing.Size(265, 20);
            this.password_tb.TabIndex = 12;
            // 
            // username_tb
            // 
            this.username_tb.Location = new System.Drawing.Point(86, 47);
            this.username_tb.Name = "username_tb";
            this.username_tb.Size = new System.Drawing.Size(265, 20);
            this.username_tb.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Username";
            // 
            // oldpass_tb
            // 
            this.oldpass_tb.Location = new System.Drawing.Point(133, 49);
            this.oldpass_tb.Name = "oldpass_tb";
            this.oldpass_tb.Size = new System.Drawing.Size(234, 20);
            this.oldpass_tb.TabIndex = 19;
            this.oldpass_tb.UseSystemPasswordChar = true;
            // 
            // username2_tb
            // 
            this.username2_tb.Location = new System.Drawing.Point(133, 17);
            this.username2_tb.Name = "username2_tb";
            this.username2_tb.Size = new System.Drawing.Size(234, 20);
            this.username2_tb.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Old Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Username";
            // 
            // newpass_tb
            // 
            this.newpass_tb.Location = new System.Drawing.Point(133, 79);
            this.newpass_tb.Name = "newpass_tb";
            this.newpass_tb.Size = new System.Drawing.Size(234, 20);
            this.newpass_tb.TabIndex = 21;
            this.newpass_tb.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "New Password";
            // 
            // confirmnewpass_tb
            // 
            this.confirmnewpass_tb.Location = new System.Drawing.Point(133, 109);
            this.confirmnewpass_tb.Name = "confirmnewpass_tb";
            this.confirmnewpass_tb.Size = new System.Drawing.Size(234, 20);
            this.confirmnewpass_tb.TabIndex = 23;
            this.confirmnewpass_tb.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Confirm New Password";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(223, 166);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(74, 25);
            this.clear_btn.TabIndex = 25;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // changepass_btn
            // 
            this.changepass_btn.Location = new System.Drawing.Point(93, 166);
            this.changepass_btn.Name = "changepass_btn";
            this.changepass_btn.Size = new System.Drawing.Size(111, 25);
            this.changepass_btn.TabIndex = 24;
            this.changepass_btn.Text = "Change Password";
            this.changepass_btn.UseVisualStyleBackColor = true;
            this.changepass_btn.Click += new System.EventHandler(this.changepass_btn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(261, 136);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Show Passwords";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 334);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label4);
            this.Name = "ForgotPassword";
            this.Text = "Forgot Password";
            this.Load += new System.EventHandler(this.ForgotPassword_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.TextBox username_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox confirmnewpass_tb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox newpass_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox oldpass_tb;
        private System.Windows.Forms.TextBox username2_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button changepass_btn;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}