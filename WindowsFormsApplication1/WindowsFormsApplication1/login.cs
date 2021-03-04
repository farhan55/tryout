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
    public partial class login : Form
    {
        SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
        public SqlCommand cmd;
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" && txt_password.Text == "")
            {
                MessageBox.Show("Harap Isi Username Dan Password");
            }
            else
            {
                

                
                    SqlConnection conn = new SqlConnection(WindowsFormsApplication1.Properties.Resources.conn.ToString());
                    conn.Open();
                    String username = txt_user.Text;
                    String password = txt_password.Text;
                    SqlCommand da = new SqlCommand("select * from [dbo].[users] where username ='" + txt_user.Text + "' and password='" + txt_password.Text + "'", conn);
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
                        if (role == "customer")
                        {
                            this.Hide();
                            home2 parse = new home2();
                            parse.Show();
                        }
                        
                          else if (role == "admin")
                        {
                            this.Hide();
                            Adminprofil parse = new Adminprofil();
                            parse.Show();
                        }
                         
                        else if (role == "kurir")
                        {
                            this.Hide();
                            profilgojek parse = new profilgojek();
                            parse.Show();
                        }

                        else if (role == "gojek")
                    {
                        this.Hide();
                        detailpesanangojek parse = new detailpesanangojek();
                        parse.Show();
                    }
                        

                        

                    }

                    else
                    {
                        MessageBox.Show("Username Atau Password Tidak Ditemukan");
                    }
               

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            signupakun parse = new signupakun();
            parse.Show();
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
