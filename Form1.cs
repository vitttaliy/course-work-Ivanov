using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        List<int > userinput = new List<int>();
        List<int> generated = new List<int>();
        int score = 0, maxscore = 0;

        public void generate_sequence()
        {
            userinput.Clear();
            generated.Clear();
            Random rnd = new Random();
            int curr = rnd.Next(0, 6);
            for (int i = 0; i<score+2; ++i)
            {
                generated.Add(curr);
                switch (curr)
                {
                    case 0:
                        mainpicture.Image = Properties.Resources.apple;
                        this.Update();
                        Thread.Sleep(1000);
                        break; 
                    case 1:
                        mainpicture.Image = Properties.Resources.banana;
                        this.Update();
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        mainpicture.Image = Properties.Resources.grape;
                        this.Update();
                        Thread.Sleep(1000);
                        break; 
                    case 3:
                        mainpicture.Image = Properties.Resources.orange;
                        this.Update();
                        Thread.Sleep(1000);
                        break; 
                    case 4:
                        mainpicture.Image = Properties.Resources.plum;
                        this.Update();
                        Thread.Sleep(1000);
                        break; 
                    case 5:
                        mainpicture.Image = Properties.Resources.watermelon;
                        this.Update();
                        Thread.Sleep(1000);
                        break; 
                    default: 
                        this.Close();
                        break;
                }
                int next = rnd.Next(0, 5);
                curr = next<curr ? next: next+1;
            }
            mainpicture.Visible = false;
            startlabel.Enabled = false;
            startlabel.Visible = true;
            startlabel.Text = "Repeat";
            this.Update();
            apple.Enabled = true;
            banana.Enabled = true;
            plum.Enabled = true;
            grape.Enabled = true;
            orange.Enabled = true;
            watermelon.Enabled = true;
        }

        public void UpdateForm()
        {
            if (userinput.ToArray().Length == generated.ToArray().Length)
            {
                apple.Enabled = false;
                banana.Enabled = false;
                plum.Enabled = false;
                grape.Enabled = false;
                orange.Enabled = false;
                watermelon.Enabled = false;
                if (Enumerable.SequenceEqual(userinput.ToArray(), generated.ToArray()))
                {
                    startlabel.Text = "Correct";
                    score += 1;
                    label3.Text = score.ToString();
                    if (score > maxscore)
                    {
                        maxscore = score;
                        label4.Text = maxscore.ToString();
                    }
                    this.BackColor = Color.FromArgb(0, 255, 128);
                    this.Update();
                    Thread.Sleep(1000);
                    this.BackColor = Color.WhiteSmoke;
                    this.Update();
                    startlabel.Text = "Next round";
                    startlabel.Enabled = true;
                }
                else
                {
                    startlabel.Text = "Wrong";
                    if (score > maxscore) 
                    {
                        maxscore = score;
                        label4.Text = maxscore.ToString();
                    }
                    score = 0;
                    label3.Text = score.ToString();
                    this.BackColor = Color.FromArgb(225, 100, 100);
                    this.Update();
                    Thread.Sleep(1000);
                    this.BackColor = Color.WhiteSmoke;
                    this.Update();
                    startlabel.Text = "New game";
                    startlabel.Enabled = true;
                }
            }
            else
            {
                startlabel.Text = (generated.ToArray().Length - userinput.ToArray().Length).ToString() + " left";
            }
            this.Update();
        }
        public Form1()
        {
            InitializeComponent();
            apple.Enabled = false;
            banana.Enabled = false;
            plum.Enabled = false;
            grape.Enabled = false;
            orange.Enabled = false;
            watermelon.Enabled = false;
        }

        private void startlabel_Click(object sender, EventArgs e)
        {
            startlabel.Text = "3";
            this.Update();
            Thread.Sleep(1000);
            startlabel.Text = "2";
            this.Update();
            Thread.Sleep(1000);
            startlabel.Text = "1";
            this.Update();
            Thread.Sleep(1000);
            startlabel.Visible = false;
            mainpicture.Visible = true;
            this.Update();
            generate_sequence();
        }

        private void apple_Click(object sender, EventArgs e)
        {
            userinput.Add(0);
            UpdateForm();
        }

        private void banana_Click(object sender, EventArgs e)
        {
            userinput.Add(1);
            UpdateForm();
        }

        private void grape_Click(object sender, EventArgs e)
        {
            userinput.Add(2);
            UpdateForm();
        }

        private void orange_Click(object sender, EventArgs e)
        {
            userinput.Add(3);
            UpdateForm();
        }

        private void plum_Click(object sender, EventArgs e)
        {
            userinput.Add(4);
            UpdateForm();
        }

        private void watermelon_Click(object sender, EventArgs e)
        {
            userinput.Add(5);
            UpdateForm();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
