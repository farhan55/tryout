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
    public partial class signupakun : Form
    {
        public signupakun()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[users]
           ([username]
           ,[password]
            ,[role])
     VALUES
           (@param1
           ,@param2
            ,@param3)", conn);
                cmd.Parameters.AddWithValue("@param1", textBox1.Text);
                cmd.Parameters.AddWithValue("@param2", textBox2.Text);
                cmd.Parameters.AddWithValue("@param3", "customer");
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("daftar berhasil");
                conn.Close();
            }
            catch (SqlException se)
            {
                MessageBox.Show(se.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            login pindah = new login();
            pindah.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
