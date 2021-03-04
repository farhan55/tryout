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
using System.Data.SqlClient;


namespace WindowsFormsApplication1
{
    
    public partial class eggandcheeseperkalian : Form
    {
        SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
        public SqlCommand cmd;
        public eggandcheeseperkalian()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            cmd = new SqlCommand("insert into datapesanan values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')", conn);

            cmd.ExecuteNonQuery();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
