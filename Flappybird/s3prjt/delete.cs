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
    public partial class delete : Form
    {
        public delete()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
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

        private void label5_Click(object sender, EventArgs e)
        {
            new delete().Show();
            this.Hide();
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
    }
}
