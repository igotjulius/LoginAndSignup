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
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Demos\Library_System\Database1.mdf;Integrated Security=True");
            cn.Open();
            loadDataGrid();
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
            cmd = new SqlCommand("select * from BorrowersTable where Id ='" + brID_tb.Text + "'", cn);
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
            maxqtxtbox.Text = "";
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
            maxqtxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["MaxQuantity"].Value.ToString();
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
                int temp, num, brID;
                brID = int.Parse(brID_tb.Text);
                temp = int.Parse(qty_tb.Text);
                num = int.Parse(bookID_tb.Text);
                string title = title_tb.Text;
                DateTime dt = DateTime.Now;
                string sqlFormattedDate = dt.ToString("yyyy-MM-dd HH:mm:ss.fff");
                string b = "BORROWED";

                cmd = new SqlCommand("Select BorrowerId, BookID from TransactionTable where BorrowerID = '" + brID + "' AND BookID = '" + num + "'",cn);
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Borrow Error. Borrower already borrowed this Book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (temp > 0)
                    {
                        dr.Close();
                        temp--;

                        cmd = new SqlCommand("Update BooksTable SET quantity= '" + temp + "' where Id= '" + num + "'", cn);
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        MessageBox.Show("Book BORROWED Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGrid();
                        clearbooks();

                        cmd = new SqlCommand("insert into ReportsTable values(@status,@date,@firstname,@lastname,@bookID,@Title)", cn);
                        cmd.Parameters.AddWithValue("status", b);
                        cmd.Parameters.AddWithValue("date", sqlFormattedDate);
                        cmd.Parameters.AddWithValue("firstname", fname_tb.Text);
                        cmd.Parameters.AddWithValue("lastname", lname_tb.Text);
                        cmd.Parameters.AddWithValue("bookId", num);
                        cmd.Parameters.AddWithValue("Title", title);
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        cmd = new SqlCommand("Insert into TransactionTable values(@BorrowerID, @BookID)", cn);
                        cmd.Parameters.AddWithValue("BorrowerID", brID);
                        cmd.Parameters.AddWithValue("BookID", num);
                        dr = cmd.ExecuteReader();
                        dr.Close();

                    }


                    else
                    {
                        MessageBox.Show("Book currently unavailable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


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
                int temp, num, max, brID;
                brID = int.Parse(brID_tb.Text);
                temp = int.Parse(qty_tb.Text);
                num = int.Parse(bookID_tb.Text);
                max = int.Parse(maxqtxtbox.Text);
                DateTime dt = DateTime.Now;
                string sqlFormattedDate = dt.ToString("yyyy-MMMM-dd HH:mm:ss.fff");
                string r = "RETURNED";
                string title = title_tb.Text;

                cmd = new SqlCommand("Select BorrowerId, BookID from TransactionTable where BorrowerID = '" + brID + "' AND BookID = '" + num + "'",cn);
                dr = cmd.ExecuteReader();

                if(dr.Read())
                {   
                    if (temp < max)
                    {
                        dr.Close();

                        temp++;
                        cmd = new SqlCommand("Update BooksTable SET quantity= '" + temp + "' where Id= '" + num + "'", cn);
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        MessageBox.Show("Book RETURNED Successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadDataGrid();
                        clearbooks();

                        cmd = new SqlCommand("insert into ReportsTable values(@status,@date,@firstname,@lastname,@bookID,@Title)", cn);
                        cmd.Parameters.AddWithValue("status", r);
                        cmd.Parameters.AddWithValue("date", sqlFormattedDate);
                        cmd.Parameters.AddWithValue("firstname", fname_tb.Text);
                        cmd.Parameters.AddWithValue("lastname", lname_tb.Text);
                        cmd.Parameters.AddWithValue("bookId", num);
                        cmd.Parameters.AddWithValue("Title", title);
                        dr = cmd.ExecuteReader();
                        dr.Close();

                        cmd = new SqlCommand("Delete from TransactionTable where BorrowerID = '" + brID + "' AND BookID = '" + num + "'", cn);
                        dr = cmd.ExecuteReader();
                        dr.Close();
                    }
                    else
                    {
                        MessageBox.Show("Book Unborrowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("Return Error. Borrower did not borrow this Book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    
            }
            else
            {
                MessageBox.Show("Please complete all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
