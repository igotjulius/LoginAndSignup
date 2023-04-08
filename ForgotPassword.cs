using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginAndSignup
{
    public partial class ForgotPassword : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        string hash = "f0xle@rn";//Create a hash key

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Demos\Library_System\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select password from LoginTable where username='" + username_tb.Text + "'", cn);
            dr = cmd.ExecuteReader();
            string encrypt = "";

            if (dr.Read())
            {
                encrypt = dr.GetValue(0).ToString();
                byte[] data = Convert.FromBase64String(encrypt);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                                                                                    //Decrypt data by hash key
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateDecryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        password_tb.Text = UTF8Encoding.UTF8.GetString(results);
                    }
                }
            }
            else
            {
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            username_tb.Text = "";
            password_tb.Text = "";
        }


        //------------------------------CHANGE PASSWORD----------------------------------------

        private void changepass_btn_Click(object sender, EventArgs e)
        {
            if(username2_tb.Text != string.Empty && oldpass_tb.Text != string.Empty && newpass_tb.Text != string.Empty && confirmnewpass_tb.Text != string.Empty)
            {
                if (newpass_tb.TextLength <= 8)
                {
                    MessageBox.Show("Password must have more than 8 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (newpass_tb.Text == confirmnewpass_tb.Text)
                {
                    cmd = new SqlCommand("select password from LoginTable where username='" + username2_tb.Text + "'", cn);
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        string pass = dr.GetValue(0).ToString();
                        string decrypt;

                        byte[] data = Convert.FromBase64String(pass);
                        using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                        {
                            byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                                                                                            //Decrypt data by hash key
                            using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                            {
                                ICryptoTransform transform = tripDes.CreateDecryptor();
                                byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                                decrypt = UTF8Encoding.UTF8.GetString(results);
                            }
                        }
                            if (oldpass_tb.Text == decrypt) 
                            {
                                dr.Close();
                                string new_encrypt;

                                data = UTF8Encoding.UTF8.GetBytes(newpass_tb.Text);
                                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                                {
                                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                                                                                                    //Encrypt data by hash key
                                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                                    {
                                        ICryptoTransform transform = tripDes.CreateEncryptor();
                                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                                        new_encrypt = Convert.ToBase64String(results, 0, results.Length);
                                    }
                                }
                            cmd = new SqlCommand("Update LoginTable set Password = '" + new_encrypt + "' where Username = '" + username2_tb.Text +"'", cn);
                            dr = cmd.ExecuteReader();
                            dr.Close();
                            cleartb();
                            MessageBox.Show("Password Changed Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                            else
                            {
                                dr.Close();
                                MessageBox.Show("Old Password Mismatch", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                    }
                    else
                    {
                        dr.Close();
                        MessageBox.Show("Username not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter same passwords ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                oldpass_tb.UseSystemPasswordChar = false;
                newpass_tb.UseSystemPasswordChar = false;
                confirmnewpass_tb.UseSystemPasswordChar = false;
            }
            else
            {
                oldpass_tb.UseSystemPasswordChar = true;
                newpass_tb.UseSystemPasswordChar = true;
                confirmnewpass_tb.UseSystemPasswordChar = true;
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            cleartb();
        }
        private void cleartb()
        {
            username2_tb.Text = "";
            oldpass_tb.Text = "";
            newpass_tb.Text = "";
            confirmnewpass_tb.Text = "";
        }
    }
}
