using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOutGame
{
    public partial class Form1 : Form
    {
        bool goLeft;
        bool goRight;
        bool isGameOver;

        int score;
        int ballx;
        int bally;
        int playerSpeed;

        Random rnd = new Random();

        PictureBox[] blockArray;

        public Form1()
        {
            InitializeComponent();

            PlaceBlocks();
        }

        private void setupGame()
        {
            isGameOver = false;
            score = 0;
            ballx = 5;
            bally = 5;
            playerSpeed = 12;
            txtScore.Text = "Score: " + score;


            hammer.Left = 220;
            hammer.Top = 250;

            plyer.Left = 220;

            gameTimer.Start();

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    x.BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                }
            }

        }
        private void gameOver(string message)
        {
            isGameOver = true;
            gameTimer.Stop();

            txtScore.Text = "Score: " + score + " " + message;
        }

        private void PlaceBlocks()
        {
            blockArray = new PictureBox[15];

            int a = 0;
            int top = 50;
            int left = 60;

            for(int i = 0; i < blockArray.Length; i++)
            {
                blockArray[i] = new PictureBox();
                blockArray[i].Height = 56;
                blockArray[i].Width = 42;
                blockArray[i].Image = Properties.Resources.___burned;
                blockArray[i].Tag = "blocks";
                blockArray[i].BackColor = Color.White;
                blockArray[i].SizeMode = PictureBoxSizeMode.StretchImage;

                if (a == 5)
                {
                    top = top + 60;
                    left = 60;
                    a = 0;
                }
                if (a < 5)
                {
                    a++;
                    blockArray[i].Left = left;
                    blockArray[i].Top = top;
                    this.Controls.Add(blockArray[i]);
                    left = left + 80;
                }
            }

            setupGame();
        }

        private void removeBlocks()
        {
            foreach (PictureBox x in blockArray)
            {
                this.Controls.Remove(x);
            }
        }

        private void mainGame(object sender, EventArgs e)
        {
            txtScore.Text = "Score: " + score;

            if (goLeft == true && plyer.Left>0)
            {
                plyer.Left -= playerSpeed;
            }
            if (goRight == true && plyer.Left < 450)
            {
                plyer.Left += playerSpeed;
            }

            hammer.Left += ballx;
            hammer.Top += bally;

            if(hammer.Left < 0 || hammer.Left > 485)
            {
                ballx = -ballx;
            }
            if (hammer.Top < 0)
            {
                bally = -bally;
            }
            if (hammer.Bounds.IntersectsWith(plyer.Bounds))
            {
                hammer.Top = 300;

                bally = rnd.Next(5, 12) * -1;

                if(ballx < 0)
                {
                    ballx = rnd.Next(5, 12) * -1;
                }
                else
                {
                    ballx = rnd.Next(5, 12) ;
                }
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "blocks")
                {
                    if (hammer.Bounds.IntersectsWith(x.Bounds))
                    {
                        score += 1;
                        bally = -bally;
                        this.Controls.Remove(x);
                    }
                }
            }

            if(score == 15)
            {
                gameOver("You Win !! Press Enter to Play Again");
            }
            if(hammer.Top > 400)
            {
                gameOver("You lose !!Press Enter to Try Again");
            }


        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                removeBlocks();
                PlaceBlocks();
            }
        }
    }
}
