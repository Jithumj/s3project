using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace s3prjt
{
    public partial class admin_ : Form
    {
        public admin_()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            new ADMINus().Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new admin_().Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new delete().Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            new UPDATE().Show();
            this.Hide();
        }
    }
}
