using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginAndSignup
{
    public partial class Transaction : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from BorrowersTable where Id='" + brID_tb.Text + "'", cn);
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                fname_tb.Text = dr.GetValue(1).ToString();
                lname_tb.Text = dr.GetValue(2).ToString();
                dr.Close();
            }
            else
            {
                dr.Close();
                MessageBox.Show("Borrower ID Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void clearbooks()
        {
            bookID_tb.Text = "";
            title_tb.Text = "";
            author_tb.Text = "";
            qty_tb.Text = "";
        }

        private void search_tb_TextChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from BooksTable where title like'%" + search_tb.Text + "%'", cn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bookID_tb.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            title_tb.Text = dataGridView1.Rows[e.RowIndex].Cells["Title"].Value.ToString();
            author_tb.Text = dataGridView1.Rows[e.RowIndex].Cells["Author"].Value.ToString();
            qty_tb.Text = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
        }

        private void clearall_btn_Click(object sender, EventArgs e)
        {
            clearbooks();
            brID_tb.Text = "";
            fname_tb.Text = "";
            lname_tb.Text = "";
        }

        private void clearbr_btn_Click(object sender, EventArgs e)
        {
            brID_tb.Text = "";
            fname_tb.Text = "";
            lname_tb.Text = "";
        }

        private void clearbooks_btn_Click(object sender, EventArgs e)
        {
            clearbooks();
        }

        private void borrow_btn_Click(object sender, EventArgs e)
        {
            if (brID_tb.Text != string.Empty && qty_tb.Text != string.Empty)
            {
                int temp, num;
                temp = int.Parse(qty_tb.Text);
                num = int.Parse(bookID_tb.Text);

                temp--;
                cmd = new SqlCommand("Update BooksTable SET quantity= '" + temp + "' where Id= '" + num + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                
                MessageBox.Show("Book BORROWED Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGrid();
                clearbooks();
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    

        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (brID_tb.Text != string.Empty && qty_tb.Text != string.Empty)
            {
                int temp, num;
                temp = int.Parse(qty_tb.Text);
                num = int.Parse(bookID_tb.Text);

                temp++;
                cmd = new SqlCommand("Update BooksTable SET quantity= '" + temp + "' where Id= '" + num + "'", cn);
                dr = cmd.ExecuteReader();
                dr.Close();
                
                MessageBox.Show("Book RETURNED Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadDataGrid();
                clearbooks();
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
