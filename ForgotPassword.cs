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
        String decrypted;
        string hash = "f0xle@rn";//Create a hash key

        public ForgotPassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\LoginAndSignup_new\LoginAndSignup\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select password from LoginTable where username='" + username_tb.Text + "'", cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                encrypt_tb.Text = dr.GetValue(0).ToString();
            }
            else
            {
                MessageBox.Show("Username not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = Convert.FromBase64String(encrypt_tb.Text);
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

        private void button3_Click(object sender, EventArgs e)
        {
            username_tb.Text = "";
            encrypt_tb.Text = "";
            password_tb.Text = "";
        }
    }
}
