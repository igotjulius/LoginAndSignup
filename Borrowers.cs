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
    public partial class Borrowers : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;

        public Borrowers()
        {
            InitializeComponent();
        }

        private void Borrowers_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\LoginAndSignup_new\LoginAndSignup\Database1.mdf;Integrated Security=True");
            cn.Open();
        }
        private void loadDataGrid()
        {
            cmd = new SqlCommand("Select * from BorrowersTable order by Id asc", cn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            EmptyTextBox();
        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * from BorrowersTable where Firstname like'%" + searchtxtbox.Text + "%'", cn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (lnametxtbox.Text != string.Empty || fnametxtbox.Text != string.Empty)
            {
                cmd = new SqlCommand("select * from BorrowersTable where Firstname='" + fnametxtbox.Text + "' AND Lastname='" + lnametxtbox.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    MessageBox.Show("Borrower details are already in the library. Try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    
                    dr.Close();
                    cmd = new SqlCommand("insert into BorrowersTable values(@Firstname,@Lastname)", cn);
                    cmd.Parameters.AddWithValue("Firstname", fnametxtbox.Text);
                    cmd.Parameters.AddWithValue("Lastname", lnametxtbox.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Borrower is added in the Library.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (lnametxtbox.Text != string.Empty || fnametxtbox.Text != string.Empty)
            {
                int num;
                num = int.Parse(idtxtbox.Text);

                cmd = new SqlCommand("Update BorrowersTable SET Firstname= '" + fnametxtbox.Text + "', Lastname='" + lnametxtbox.Text + "' where Id= '" + num + "'", cn);
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
            if (lnametxtbox.Text != string.Empty || fnametxtbox.Text != string.Empty)
            {
                string num = idtxtbox.Text;
                DialogResult drs = MessageBox.Show("Are you sure you want to delete this?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drs == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete from BorrowersTable where ID= '" + num + "'", cn);
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
            fnametxtbox.Text = "";
            lnametxtbox.Text = "";
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            idtxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            fnametxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Firstname"].Value.ToString();
            lnametxtbox.Text = dataGridView1.Rows[e.RowIndex].Cells["Lastname"].Value.ToString();
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            EmptyTextBox();
        }
    }
}

