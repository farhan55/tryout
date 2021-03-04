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
    public partial class delivery : Form
    {
        SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
        public SqlCommand cmd;
        public delivery()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pembayaranberhasil mm = new pembayaranberhasil();
            mm.Show();

        }

        private void btdelivery_Click(object sender, EventArgs e)
        {
                try
                {
                   
                    SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                    SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[deliveryaddress]
           ([nama]
           ,[alamat])
     VALUES
           (@param1
           ,@param2)", conn);
                    cmd.Parameters.AddWithValue("@param1", txtpenerimanama.Text);
                    cmd.Parameters.AddWithValue("@param2", txtdelivery.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Insert Data Success");
                    tampil();
                    conn.Close();
                }
                catch (SqlException se)
                {
                    MessageBox.Show(se.Message);
                }


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
        private void txtpenerimanama_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delivery_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpenerimanama.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtdelivery.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
