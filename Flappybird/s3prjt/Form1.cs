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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox2.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("please enter user name");

            }
            else if (textBox1.Text == "" && textBox3.Text == "")
            {
                MessageBox.Show("please enter password");
            }
            else if ( textBox1.TextLength>10 && textBox3.TextLength<10)
            {
                MessageBox.Show("password should only contain less than ten character");
            }
            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-9FEN7POE;Initial Catalog=prjts3;Integrated Security=True");
                con.Open();
                SqlCommand cmd;
                cmd = new SqlCommand("INSERT INTO game(user_name,Password) VALUES('" + textBox2.Text + "','" + textBox1.Text + "')", con);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("registered successfully");
            

        }
    }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
