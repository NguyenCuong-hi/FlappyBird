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

        public Form1()
        {
            InitializeComponent();
            flappyBird.Visible = false;
            pipeBottom.Visible = false;
            pipeTop.Visible = false;
            ground.Visible = false;
            lblS.Visible = true;
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

        }

        private void endGame()
        {
            gameTimer.Stop();
            scoreText.Text += " Game over!!!";
            lblS.Visible = true;
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Visible = true;
            pipeBottom.Visible = true;
            pipeTop.Visible = true;
            ground.Visible = true;
            lblStart.Visible = false;
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

        private void lblS_Click(object sender, EventArgs e)
        {
            gameTimer.Start();
            lblS.Visible = false;
        }
    }
}
