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
    public partial class Reports : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        private int numberOfItemsPerPage = 0;
        private int numberOfItemsPrintedSoFar = 0;

        public Reports()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Demos\Library_System\Database1.mdf;Integrated Security=True");
            loadDataGrid();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
               
        }
        private void loadDataGrid()
        {
            cn.Open();
            cmd = new SqlCommand("Select * from ReportsTable order by Date desc", cn);
            cmd.ExecuteNonQuery();

            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            cn.Close();

        }

        private void searchtxtbox_TextChanged(object sender, EventArgs e)
        {
            cn.Open();
            cmd = new SqlCommand("Select * from ReportsTable where Date like'%" + searchtxtbox.Text + "%' OR Status like '%" + searchtxtbox.Text + "%' OR Firstname like '%" + searchtxtbox.Text + "%' OR Lastname like '%" + searchtxtbox.Text + "%' Or Title like '%" + searchtxtbox.Text + "%'", cn);
            cmd.ExecuteNonQuery();


            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable tab = new DataTable();

            adap.Fill(tab);
            dataGridView1.DataSource = tab;

            cn.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string curdhead = "LIBRARY REPORTS";
            e.Graphics.DrawString(curdhead, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 350, 50);

            string l1 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 100);

            string g1 = "Report ID";
            e.Graphics.DrawString(g1, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 40, 140);

            string g2 = "Status";
            e.Graphics.DrawString(g2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 150, 140);

            string g3 = "Date";
            e.Graphics.DrawString(g3, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 270, 140);

            string g4 = "First Name";
            e.Graphics.DrawString(g4, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 370, 140);

            string g5 = "Last Name";
            e.Graphics.DrawString(g5, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 500, 140);

            string g6 = "Book ID";
            e.Graphics.DrawString(g6, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 600, 140);

            string g7 = "Title";
            e.Graphics.DrawString(g7, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 680, 140);

            string l2 = "---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
            e.Graphics.DrawString(l2, new System.Drawing.Font("Book Antiqua", 9, FontStyle.Bold), Brushes.Black, 0, 160);

            int height = 165;
            for (int l = numberOfItemsPrintedSoFar; l < dataGridView1.Rows.Count; l++)
            {
                numberOfItemsPerPage = numberOfItemsPerPage + 1;
                if (numberOfItemsPerPage <= 50)
                {
                    numberOfItemsPrintedSoFar++;

                    if (numberOfItemsPrintedSoFar <= dataGridView1.Rows.Count)
                    {

                        height += dataGridView1.Rows[0].Height;
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[0].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(60, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[1].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(140, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[2].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(240, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[3].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(370, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[4].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(500, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[5].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(620, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                        e.Graphics.DrawString(dataGridView1.Rows[l].Cells[6].FormattedValue.ToString(), dataGridView1.Font = new Font("Book Antiqua", 7), Brushes.Black, new RectangleF(680, height, dataGridView1.Columns[0].Width, dataGridView1.Rows[0].Height));
                    }
                    else
                    {
                        e.HasMorePages = false;
                    }

                }
                else
                {
                    numberOfItemsPerPage = 0;
                    e.HasMorePages = true;
                    return;

                }


            }
            numberOfItemsPerPage = 0;
            numberOfItemsPrintedSoFar = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.PrintDialog PrintDialog1 = new PrintDialog();
            PrintDialog1.AllowSomePages = true;
            PrintDialog1.ShowHelp = true;
            PrintDialog1.Document = printDocument1;
            DialogResult result = PrintDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
