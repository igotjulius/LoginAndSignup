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
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        String decrypted;
        string hash = "f0xle@rn";//Create a hash key

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\LoginAndSignup_new\LoginAndSignup\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtpassword.Text != string.Empty || txtusername.Text != string.Empty)
            {
                byte[] data = UTF8Encoding.UTF8.GetBytes(txtpassword.Text);
                using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
                {
                    byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                    using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                    {
                        ICryptoTransform transform = tripDes.CreateEncryptor();
                        byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                        decrypted = Convert.ToBase64String(results, 0, results.Length);
                    }
                }
                cmd = new SqlCommand("select * from LoginTable where username='" + txtusername.Text + "' and password='" + decrypted + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtpassword.UseSystemPasswordChar= false;
            }    
            else
            {
                txtpassword.UseSystemPasswordChar= true;
            }
        }
    }
}
