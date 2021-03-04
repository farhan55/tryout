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
    public partial class home2 : Form
    {
        public home2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String jml = jumlahbarangtxt.Text;
            String nama = namabarangtxt.Text;
            String harga = hargabarangtxt.Text;
            if (jumlahbarangtxt.Text == String.Empty || hargabarangtxt.Text == String.Empty)
            {
                MessageBox.Show("Harap Pilih Barang Yang Ingin Dibeli");
            }
            else
            {

                int jum = int.Parse(harga) * int.Parse(jml);
                int tot = int.Parse(jml);

                if (tot <= 0)
                {
                    MessageBox.Show("Jumlah Barang Harus Lebih Dari 0");
                }
                else
                {
                    int x = dataGridView2.Rows.Add();
                    dataGridView2.Rows[x].Cells[0].Value = namabarangtxt.Text;
                    dataGridView2.Rows[x].Cells[1].Value = jumlahbarangtxt.Text;
                    dataGridView2.Rows[x].Cells[2].Value = jum.ToString();
                    double tes = getTotal();
                    hargatotal.Text = tes.ToString();
                }
            }
        }

        void tampil()
        {
            try
            {
                SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                SqlCommand cmd = new SqlCommand(@"SELECT * from datapesanan2", conn);
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
        double getTotal()
        {
            int total = 0;

                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    total += int.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());

                }

            
            
            
            return total;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                String hr = hargatotal.Text;
                String br = txtbayar.Text;
                int harga = int.Parse(hr);
                int bayar = int.Parse(br);
                int kembalian = bayar - harga;
                if (bayar < harga || txtbayar.Text == String.Empty || br == String.Empty)
                {
                    MessageBox.Show("Harap Bayar Sesuai Dengan Yang Tertera");
                }
                else
                {
                    txtkembali.Text = kembalian.ToString();
                }
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void home2_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void jumlahbarangtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            delivery pp = new delivery();
            pp.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            namabarangtxt.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            hargabarangtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void hargabarangtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
