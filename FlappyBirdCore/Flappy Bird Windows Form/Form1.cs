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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ClientSize = new Size(600, 746);
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            initMenu();
        }

        private void initMenu()
        {
            this.pipeBottom.Visible = false;
            this.pipeTop.Visible = false;
            this.flappyBird.Visible = false;
            this.ground.Visible = false;
            this.scoreText.Visible = true;
            this.cloudy.Visible = false;

            this.lblNewGame.Visible = true;
            this.lblHelp.Visible = true;
            this.lblAbout.Visible = true;
            this.lblExit.Visible = true;

        }
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
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
            if (e.KeyCode == Keys.Enter || gameOver == true)
            {
                overGameText.Visible = false;
              RestartGame();
            }


        }

        private void endGame()
        {
            gameTimer.Stop();
            overGameText.Text = "Game over!!!";
            overGameText.Text += " Press 'Enter'or 'Space'to play again !";
            gameOver = true;

        }

        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(69, 200);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score : 0";
            gameTimer.Start();

        }

        private void initStartGame()
        {
            this.pipeBottom.Visible = true;
            this.pipeTop.Visible = true;
            this.flappyBird.Visible = true;
            this.ground.Visible = true;
            this.scoreText.Visible = true;
            this.cloudy.Visible = true;

            this.lblNewGame.Visible = false;
            this.lblHelp.Visible = false;
            this.lblAbout.Visible = false;
            this.lblExit.Visible = false;
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

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            initStartGame();
            gameTimer.Start();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Nhấn Space để điều khiển chim để tránh các chướng ngại vật \n" +
                "2) Nhấn R để bắt đầu lại trò chơi \n" +
                "3) Nhấn esc để thoát ");
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giới thiệu\n" +
                "Made By : Nguyễn Văn Cường \n" +
                "Bài tập Lớn : Đề tài phát triển game với WindowsForm\n" +
                "");
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn muốn rời game ?", "Xác nhận", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult rs = MessageBox.Show("Bạn muốn rời game ?", "Xác nhận", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    this.Close();
                }
            }
        }

        private void picPause_Click(object sender, EventArgs e)
        {
            if (!gameTimer.Enabled)
            {
                gameTimer.Start();
                initStartGame();

            }
            else
            {
                gameTimer.Stop();
                initMenu();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
