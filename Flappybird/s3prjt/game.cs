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
    public partial class game : Form
    {
        int pipespeed = 3;
        int gravity = 8;
        int score = 0;

       
        public game()
        {
            InitializeComponent();
        }

        private void game_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {

            flappyBird.Top += gravity;
            PipeBottom.Left -= pipespeed;
            Pipetop.Left -= pipespeed;

            Scoretxt.Text = "score:" + scr.Text;
            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }
            if (Pipetop.Left < -180)
            {
                Pipetop.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Pipetop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }
            if (score > 2)
            {
                pipespeed = 8;


            }
            else if (score > 4)
            {
                pipespeed = 12;
            }
            else if (score > 7)
            {
                pipespeed = 15;
            }
            scr.Text = "" + score;
        }

        private void endGame()
        {
            gameTimer.Stop();
            gmov.Text += "Game over!!!";
        }
            private void gameKeyIsDown(object sender, KeyEventArgs e)
        {

        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

    }
}


/*using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace project2
{
    public partial class game : Form
    {

        int pipespeed = 3;
        int gravity = 8;
        int score = 0;

        public game()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            PipeBottom.Left -= pipespeed;
            Pipetop.Left -= pipespeed;

            Scoretxt.Text = "score:" + scr.Text;
            if (PipeBottom.Left < -150)
            {
                PipeBottom.Left = 800;
                score++;
            }
            if (Pipetop.Left < -180)
            {
                Pipetop.Left = 950;
                score++;
            }
            if (flappyBird.Bounds.IntersectsWith(PipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(Pipetop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }
            if (score > 2)
            {
                pipespeed = 8;


            }
            else if (score > 4)
            {
                pipespeed = 12;
            }
            else if (score > 7)
            {
                pipespeed = 15;
            }
            scr.Text = "" + score;
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }
        private void endGame()
        {
            gameTimer.Stop();
            gmov.Text += "Game over!!!";

            SqlConnection con = new SqlConnection(@"Data Source=ASHVIN\SQLEXPRESS;Initial Catalog=project2;Integrated Security=True");
            con.Open();
            SqlCommand cmd;
            cmd = new SqlCommand("INSERT INTO tbl_game(score) VALUES('" + scr.Text + "') WHERE username=jithu ", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {


            new formlogin().Show();
            this.Hide();
        }

        private void refresh_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score = 0;
            this.Controls.Clear();
            this.InitializeComponent();

        }

        private void game_Load(object sender, EventArgs e)
        {
            *//*   ImageCombo1.Items.Add(new ImageComboItem("Select an Item", -1));
               ImageCombo1.Items.Add(new ImageComboItem("Item1", 0));
               ImageCombo1.Items.Add(new ImageComboItem("Item2", 1, true));
               ImageCombo1.Items.Add(new ImageComboItem("Item3", 2, false,
                  Color.Red));
               ImageComboList1.Items.Add(new ImageComboItem("Item4", 3));

               ImageComboList1.Items.Add(new ImageComboItem("Select an Item",
                  -1));
               ImageComboList1.Items.Add(new ImageComboItem("Item1", 0));
               ImageComboList1.Items.Add(new ImageComboItem("Item2", 1, true));
               ImageComboList1.Items.Add(new ImageComboItem("Item3", 2, false,
                  Color.Green));
               ImageComboList1.Items.Add(new ImageComboItem("Item4", 3));

               ImageCombo1.SelectedIndex = 0;
               ImageComboList1.SelectedIndex = 0;*//*
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flappyBird_Click(object sender, EventArgs e)
        {

        }
    }
}
*/
