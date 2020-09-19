using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlatformGame
{
    public partial class Form1 : Form
    {
        bool goRight, goLeft, Jump, force;
        int speed = 7;
        int goingDown = 20;
        int jumpSpeed = 40;
        int Counter = 0;

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Space) Jump = true;
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Space) Jump = false;
        }

        private void MainTimer(object sender, EventArgs e)
        {
            movement();
            GoingDown();
            collectCoins();
            winthegame();
        }
        private void movement()
        {
            if (goRight == true) Ninja.Left += speed;
            if (goLeft == true) Ninja.Left += -speed;
            if (Jump == true) Ninja.Top += -jumpSpeed;
        }
        private void GoingDown()
        {
            if (Ninja.Top > this.Height - Ninja.Height - 40)
            {
                force = false;
            }
            else
            {
                force = true;
            }
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "platform")
                    {
                        if (Ninja.Bounds.IntersectsWith(x.Bounds))
                            force = false;
                    }
                }
            }
            if (force) Ninja.Top += goingDown;
        }
        private void collectCoins()
        {
            foreach (Control item in this.Controls)
            {
                if (item is PictureBox)
                {
                    if ((string)item.Tag == "Coin")
                    {
                        if (Ninja.Bounds.IntersectsWith(item.Bounds))
                        {
                            item.Visible = false;
                            item.Enabled = false;
                            Counter++;
                            label1.Text = ("Coin: " + Counter);
                        }
                    }
                }
            }
        }

        private void restartgame_Click(object sender, EventArgs e)
        {
            Counter = 0;
            timer1.Enabled = true;
            Ninja.Location = new Point(0, 414);
            restartgame.Visible = false;
        }

        private void winthegame()
        {
            if (Ninja.Bounds.IntersectsWith(mainlove.Bounds))
            {
                goRight = false;
                goLeft = false;
                Jump = false;
                force = false;
                timer1.Enabled = false;
                finish.Visible = true;
            }
        }
        public Form1()
        {
            InitializeComponent();
            finish.Visible = false;
        }

        //nagavi
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
