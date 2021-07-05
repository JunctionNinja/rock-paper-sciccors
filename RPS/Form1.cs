using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS
{
    public partial class Form1 : Form
    {
        int wins = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            if (randomNumber.Equals(1))
            {
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = "Draw";
                button1.Enabled = true;
            }
            else
            {
                if (randomNumber.Equals(2))
                {
                    pictureBox1.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox3.Visible = false;
                    pictureBox2.Visible = false;
                    label3.Text = "Bot Wins";
                    button1.Enabled = true;
                }
                else
                {
                    if (randomNumber.Equals(3))
                    {
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox3.Visible = false;
                        pictureBox2.Visible = false;
                        label3.Text = "You Win";
                        button1.Enabled = true;
                        wins++;
                        if (wins.Equals(1))
                        {
                            this.Text = "RPS - " + wins + " Win";
                        }
                        else
                        {
                            this.Text = "RPS - " + wins + " Wins";
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            pictureBox5.Visible = true;
            pictureBox4.Visible = true;
            pictureBox7.Visible = true;
            pictureBox3.Visible = true;
            pictureBox2.Visible = true;
            button1.Enabled = false;
            label3.Text = "Game in Progress";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            if (randomNumber.Equals(1))
            {
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                pictureBox5.Visible = false;
                pictureBox2.Visible = false;
                label3.Text = "You Win";
                button1.Enabled = true;
                wins++;
                if (wins.Equals(1))
                {
                    this.Text = "RPS - " + wins + " Win";
                }
                else
                {
                    this.Text = "RPS - " + wins + " Wins";
                }
            }
            else
            {
                if (randomNumber.Equals(2))
                {
                    pictureBox1.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox2.Visible = false;
                    label3.Text = "Draw";
                    button1.Enabled = true;
                }
                else
                {
                    if (randomNumber.Equals(3))
                    {
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox2.Visible = false;
                        label3.Text = "Bot Wins";
                        button1.Enabled = true;
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 4);
            if (randomNumber.Equals(1))
            {
                pictureBox4.Visible = false;
                pictureBox7.Visible = false;
                pictureBox5.Visible = false;
                pictureBox3.Visible = false;
                label3.Text = "Bot Wins";
                button1.Enabled = true;
            }
            else
            {
                if (randomNumber.Equals(2))
                {
                    pictureBox1.Visible = false;
                    pictureBox7.Visible = false;
                    pictureBox5.Visible = false;
                    pictureBox3.Visible = false;
                    label3.Text = "You Win";
                    button1.Enabled = true;
                    wins++;
                    if (wins.Equals(1))
                    {
                        this.Text = "RPS - " + wins + " Win";
                    }
                    else
                    {
                        this.Text = "RPS - " + wins + " Wins";
                    }
                }
                else
                {
                    if (randomNumber.Equals(3))
                    {
                        pictureBox4.Visible = false;
                        pictureBox1.Visible = false;
                        pictureBox5.Visible = false;
                        pictureBox3.Visible = false;
                        label3.Text = "Draw";
                        button1.Enabled = true;
                    }
                }
            }
        }
    }
}
