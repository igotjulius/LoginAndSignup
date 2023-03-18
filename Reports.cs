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

        public Reports()
        {
            InitializeComponent();
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Downloads\LoginAndSignup_new\LoginAndSignup\Database1.mdf;Integrated Security=True");
            loadDataGrid();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
               
        }
        private void loadDataGrid()
        {
            cn.Open();
            cmd = new SqlCommand("Select * from ReportsTable order by ReportID asc", cn);
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
    }
}
