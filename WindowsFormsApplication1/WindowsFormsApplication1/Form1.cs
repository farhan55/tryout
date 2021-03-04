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
                
                this.Hide();
                WindowsFormsApplication1.home pindah = new WindowsFormsApplication1.home();
                pindah.Show();
                }
            }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            WindowsFormsApplication1.signupakun parse = new WindowsFormsApplication1.signupakun();
            parse.Show();
        }
    }
    
}
