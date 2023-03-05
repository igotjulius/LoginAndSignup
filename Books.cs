using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndSignup
{
    public partial class Books : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\LoginAndSignup_new\LoginAndSignup\Database1.mdf;Integrated Security=True");
            cn.Open();
        }

        private void loadDataGrid()
        {
            cmd = new SqlCommand("Select * from BooksTable order by Id asc", cn);
            dr = cmd.ExecuteReader();
            dr.Close();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            EmptyTextBox();
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {

            cmd = new SqlCommand("Select * from BooksTable where title like'%" + titletxtbox.Text + "%'", cn);
            dr = cmd.ExecuteReader();
            dr.Close();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (authortxtbox.Text != string.Empty || titletxtbox.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from BooksTable where Title='" + titletxtbox.Text + "' AND Author='" + authortxtbox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Book is already in the library. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dr.Close();
                    cmd = new SqlCommand("insert into BooksTable values(@title,@author)", cn);
                    cmd.Parameters.AddWithValue("title", titletxtbox.Text);
                    cmd.Parameters.AddWithValue("author", authortxtbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book is added in the Library.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadDataGrid();
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (authortxtbox.Text != string.Empty || titletxtbox.Text != string.Empty)
            {
                int num;
                num = int.Parse(idtxtbox.Text);

                cmd = new SqlCommand("Update BooksTable SET title= '" + titletxtbox.Text + "', author='" + authortxtbox.Text + "' where Id= '" + num + "'", cn);
                dr = cmd.ExecuteReader();

                MessageBox.Show("Successfully Updated!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dr.Close();
                loadDataGrid();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            if (authortxtbox.Text != string.Empty || titletxtbox.Text != string.Empty)
            {
                string num = idtxtbox.Text;
                DialogResult drs = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete from BooksTable where ID= '" + num + "'", cn);
                    dr = cmd.ExecuteReader();

                    MessageBox.Show("Successfully Deleted!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("CANCELLED!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dr.Close();
                loadDataGrid();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EmptyTextBox()
        {
            idtxtbox.Text = "";
            titletxtbox.Text = "";
            authortxtbox.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idtxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            titletxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            authortxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Author"].Value.ToString();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }
    }
}
