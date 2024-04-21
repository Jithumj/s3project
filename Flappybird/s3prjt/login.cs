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

namespace s3prjt
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text= string.Empty;
            textBox2.Text= string.Empty;
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox2.Text=="")
            {
                MessageBox.Show("please enter user name");
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("please enter user password");
            }
            else if (textBox1.TextLength > 10)
            {
                MessageBox.Show("password should only contain less than ten character");
            }
            else if(textBox2.Text=="admin" && textBox1.Text == "admin@12")
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9FEN7POE;Initial Catalog=prjts3;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from game where user_name=@username and Password=@password ", con);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    new ADMINus().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                con.Close();

                
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9FEN7POE;Initial Catalog=prjts3;Integrated Security=True");

                con.Open();
                SqlCommand cmd = new SqlCommand("select * from game where user_name=@username and Password=@password ", con);
                cmd.Parameters.AddWithValue("@username", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    new game().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
                con.Close();
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();

        }
    }
}
