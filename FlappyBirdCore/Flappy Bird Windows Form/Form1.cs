using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Form
{
    public partial class Form1 : Form
    {

        int pipeSpeed = 5;
        int cloudySpeed = 5;
        int gravity = 5; 
        int score = 0;
        bool gameOver = false;

        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }

        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
            if(e.KeyCode == Keys.Enter && gameOver)
            {
                RestartGame();
            }

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
            scoreText.Text += " PRESS 'R' to play again !";
            gameOver = true;
           
            
        }

        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(69,200);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score : 0";
            gameTimer.Start();

        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
                flappyBird.Top += gravity;
                pipeBottom.Left -= pipeSpeed;
                pipeTop.Left -= pipeSpeed;
                cloudy.Left -= cloudySpeed;
                scoreText.Text = "Score: " + score;
                if (pipeBottom.Left < -150)
                {
                    pipeBottom.Left = 800;
                    cloudy.Left = 800;
                    score++;
                }
                if (pipeTop.Left < -180)
                {
                    pipeTop.Left = 950;
                    cloudy.Left = 950;
                    score++;
                }

                if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                    flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                    )
                {
                    endGame();
                }

                if (score > 5)
                {
                    pipeSpeed = 15;
                }
        }

        private void clickReset(object sender, EventArgs e)
        {
            ResetAllControl(this);

        }
        public static void ResetAllControl(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is PictureBox)
                {
                    PictureBox picture = (PictureBox)control;
                    picture.Visible = false;
                }

                if (control is Label)
                {
                    Label label = (Label)control;
                    label.Visible = false;
                }
            }
        }


    }
}
