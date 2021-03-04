using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class detailpesanangojek : Form
    {
        public detailpesanangojek()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void tampil()
        {
            try
            {
                SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                SqlCommand cmd = new SqlCommand(@"SELECT * from deliveryaddress", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        void tampill()
        {
            try
            {
                SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                SqlCommand cmd = new SqlCommand(@"SELECT * from datapesanan2", conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void detailpesanangojek_Load(object sender, EventArgs e)
        {
            tampil();
            tampill();
        }
    }
}
