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
    public partial class product : Form
    {
        SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
        public SqlCommand cmd;
        public product()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            home pindah = new home();
            pindah.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            keranjang pindah = new keranjang();
            pindah.Show();
        }
    }
}
