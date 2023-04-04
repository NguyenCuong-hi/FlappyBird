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
        int pipeSpeed;
        int cloudySpeed;
        int gravity = 5;
        int score = 0;
        bool gameOver = false;

        public int PipeSpeed { get => pipeSpeed; set => pipeSpeed = value; }

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
            this.cloudy.Visible = false;

            this.pnMenu.Visible = true;
            this.lblNewGame.Visible = true;
            this.lblHelp.Visible = true;
            this.lblSettings.Visible = true;
            this.lblAbout.Visible = true;
            this.lblExit.Visible = true;
            this.pnEndGame.Visible = false;
            this.pnSetting.Visible = false;
            Music.Play();
            
        }

        private void initStartGame()
        {
            
            this.pipeBottom.Visible = true;
            this.pipeTop.Visible = true;
            this.flappyBird.Visible = true;
            this.ground.Visible = true;
            this.scoreText.Visible = true;
            this.cloudy.Visible = true;
            this.picPause.Visible = true;
            this.pnMenu.Visible = false;
            
            Music.Stop();
            Music.DuringPlayGame();
           
        }
        
        private void initEndgame()
        {
            this.pipeBottom.Visible = false;
            this.pipeTop.Visible = false;
            this.flappyBird.Visible = false;
            this.ground.Visible = false;
            this.scoreText.Visible = false;
            this.cloudy.Visible = false;
            this.picPause.Visible = false;
            this.pnMenu.Visible = false;

            this.pnEndGame.Visible = true;
            this.pnEndGame.BringToFront();
            this.picHome.Visible = true;
            this.picRestart.Visible = true;

            Music.Stop();
            Music.PlayEndGame();
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
            //if (e.KeyCode == Keys.Enter)
         //   {
            //    gameOver = true;
            //    overGameText.Visible = false;
             //   RestartGame();

            //}
        }

        private void endGame()
        {
            gameOver = true;
            

        }

        public int setPipeSpeed()
        {
            if (Hardcore.Checked)
            {
                return pipeSpeed=25;
            }
            if (Mediumcore.Checked)
            {
               return this.pipeSpeed = 15;
            }
            if (EasyCore.Checked)
            {
               return this.pipeSpeed = 5;
            }
            return this.pipeSpeed = 5;
        }

        private void RestartGame()
        {
            gameOver = false;
            flappyBird.Location = new Point(69, 200);
            pipeTop.Left = 800;
            pipeBottom.Left = 1200;

            score = 0;
            pipeSpeed = 8;
            scoreText.Text = "Score :";
            gameTimer.Start();

        }

        

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity;
            pipeBottom.Left -= setPipeSpeed();
            pipeTop.Left -= setPipeSpeed();
            cloudy.Left -= setPipeSpeed();
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
            if (score > 15)
            {
                pipeSpeed = 30;
            }
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) ||
                flappyBird.Top < -25
                )
            {
                gameTimer.Stop();
                
                gameOver = true;
                initEndgame();
                lblScore.Text = scoreText.Text;
                lblScore.Visible = true; 
            }


        }

        private void lblNewGame_Click(object sender, EventArgs e)
        {
            initStartGame();
            RestartGame();
            this.scoreText.Visible = true;
        }

        private void lblResume_Click(object sender, EventArgs e)
        {
            initStartGame();
            gameTimerEvent(sender, e);
            gameTimer.Start();
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1) Nhấn Space để điều khiển chim để tránh các chướng ngại vật \n" +
                "2) Nhấn esc để thoát ");
        }

        private void lblAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giới thiệu\n" +
                "Made By : Nguyễn Văn Cường ft Trần Trọng Lương\n" +
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
            pnMenu.BringToFront();
            initMenu();
            gameTimer.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSetting_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = true;
            pnMenu.Visible = false;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            initMenu();
            
        }

        private void pnEndGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picRestart_Click(object sender, EventArgs e)
        {
            initStartGame();
            RestartGame();
            pnEndGame.Visible = false;
        }

        private void pnMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picCancel_Click(object sender, EventArgs e)
        {
            pnSetting.Visible = false;
            pnMenu.Visible = true;
        }
    }
}
