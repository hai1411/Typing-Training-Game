using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private int score;
        private Random random = new Random();
        private int count;
        private int rocketSpeed = 1;
        private int life;

        public Form1()
        {
            InitializeComponent();
            gameReset();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void gameTimerRun(object sender, EventArgs e)
        {
            if (count == 40)
            {
                generateRadomPanel();
                count = 0;
            }
            
            //p.Show();
            //p.Left -= 10;
            foreach (Control x in this.Controls)
            {
                if (x is Panel && (string)x.Tag == "Spaceship")
                {
                    x.Left -= rocketSpeed;

                    if (pbBlackHole.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        life--;
                    }    
                }
            }

            if (life == 2)
            {
                pbHeart1.Visible = false;
            }
            else if (life == 1)
            {
                pbHeart2.Visible = false;
            }
            else if (life == 0)
            {
                pbHeart3.Visible = false;
                foreach (Control x in this.Controls)
                {
                    if (x is Panel && (string)x.Tag == "Spaceship")
                    {
                        this.Controls.Remove(x);
                    }
                }
                gameTimer.Stop();
                DialogResult d = MessageBox.Show("YOUR SCORE IS " + score + ". DO YOU WANNA PLAY AGAIN?", "GAME OVER", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes)
                {
                    gameReset();
                    return;
                }
                else
                {
                    Environment.Exit(1);
                    return;
                }
            }

            count++;
        }

        private Point generateRandomLocation()
        {
            int Y = random.Next(pbBlackHole.Location.Y, pbBlackHole.Location.Y + pbBlackHole.Height - 50);
            return new Point(800, Y);
        }

        private void generateRadomPanel()
        {
            PictureBox pb = new PictureBox();
            pb.Location = new Point(5, 3);
            pb.Size = new Size(100,53);
            pb.Image = Properties.Resources.pngaaa1;
            Label l = new Label();
            l.Location = new Point(37, 59);
            //l.Size = new Size(35,13);
            l.Font = new Font("Arial", 10, FontStyle.Bold);

            string word = generateRandomString();
            l.Text = word;
                
            l.ForeColor = Color.White;
            Panel p = new Panel();

            p.Name = word;

            p.BackColor = Color.Transparent;
            p.Location = generateRandomLocation();

            p.Size = new Size(108, 82);
            p.Tag = "Spaceship";
            p.Controls.Add(l);
            p.Controls.Add(pb);
            this.Controls.Add(p);
        }

        private void gameReset()
        {
            pbHeart1.Visible = true;
            pbHeart2.Visible = true;
            pbHeart3.Visible = true;
            count = 40;
            life = 3;
            rocketSpeed = 5;
            score = 0;
            txtInput.Text = "";
            foreach (Control x in this.Controls)
            {
                if (x is Panel && (string)x.Tag == "Spaceship")
                {
                    this.Controls.Remove(x);
                }
            }
            gameTimer.Start();   
        }


        private string generateRandomString()
        {
            int length = 5;
            // creating a StringBuilder object()
            StringBuilder str_build = new StringBuilder();
            Random random = new Random();

            char letter;

            for (int i = 0; i < length; i++)
            {
                double flt = random.NextDouble();
                int shift = Convert.ToInt32(Math.Floor(25 * flt));
                letter = Convert.ToChar(shift + 65);
                str_build.Append(letter);
            }
            return str_build.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                //Console.WriteLine(txtInput.Text);

                foreach (Control x in this.Controls)
                {
                    if (x is Panel && (string)x.Tag == "Spaceship" && x.Name == txtInput.Text)
                    {
                        score++;
                        lblScore.Text = "Score: " + score;
                        this.Controls.Remove(x);
                    }
                }
                txtInput.Text = "";
                

                e.Handled = true;
                //e.SuppressKeyPress = true;
            }    
        }
    }
}
