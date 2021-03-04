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

namespace ukom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Harap Isi Username Dan Password");
            }
            else
            {

                SqlConnection conn = new SqlConnection(ukom.Properties.Resources.conn.ToString());
                conn.Open();
                String username = txt_user.Text;
                String Password = txt_password.Text;
                SqlCommand da = new SqlCommand("select * from [dbo].[user] where namauser ='" + txt_user.Text + "' and password='" + txt_password.Text + "'", conn);
                DataTable dt = new DataTable();
                SqlDataReader myReader;
                myReader = da.ExecuteReader();
                int count = 0;
                string role = string.Empty;
                while (myReader.Read())
                {
                    count = count + 1;
                    role = myReader["role"].ToString();
                }
                if (count == 1)
                {
                    MessageBox.Show("Username Dan Password . . . Benar", "Pesan Konfirmasi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    this.Hide();

                    //admin with generated key
                    if (role == "admin")
                    {
                        this.Hide();
                        admin parse = new admin(username);
                        parse.Show();
                    }
                    else if (role == "waiter")
                    {
                        this.Hide();
                        waiter parse = new waiter(username);
                        parse.Show();
                    }
                    else if (role == "kasir")
                    {
                        this.Hide();
                        kasir parse = new kasir(username);
                        parse.Show();
                    }
                    else if (role == "owner")
                    {
                        this.Hide();
                        owner parse = new owner(username);
                        parse.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Username Atau Password Tidak Ditemukan");
                }


                }
            }
        }
    
}
