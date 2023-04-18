namespace Flappy_Bird_Windows_Form
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.cloudy = new System.Windows.Forms.PictureBox();
            this.overGameText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudy)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            this.scoreText.BackColor = System.Drawing.Color.PapayaWhip;
            this.scoreText.Location = new System.Drawing.Point(12, 655);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(125, 34);
            this.scoreText.TabIndex = 7;
            this.scoreText.Text = "SCORE: ";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblNewGame
            // 
            this.lblNewGame.Location = new System.Drawing.Point(224, 226);
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Size = new System.Drawing.Size(100, 23);
            this.lblNewGame.TabIndex = 5;
            this.lblNewGame.Text = "NEW GAME";
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            // 
            // lblHelp
            // 
            this.lblHelp.Location = new System.Drawing.Point(224, 270);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(100, 23);
            this.lblHelp.TabIndex = 4;
            this.lblHelp.Text = "HELP";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.Location = new System.Drawing.Point(224, 312);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(100, 23);
            this.lblAbout.TabIndex = 3;
            this.lblAbout.Text = "ABOUT";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(224, 352);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(100, 23);
            this.lblExit.TabIndex = 2;
            this.lblExit.Text = "Exit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picPause
            // 
            this.picPause.BackColor = System.Drawing.Color.Aqua;
            this.picPause.Location = new System.Drawing.Point(12, 0);
            this.picPause.Name = "picPause";
            this.picPause.Size = new System.Drawing.Size(43, 41);
            this.picPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPause.TabIndex = 1;
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            this.ground.Location = new System.Drawing.Point(-6, 614);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(591, 99);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 8;
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            this.pipeBottom.Location = new System.Drawing.Point(300, 451);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 262);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 9;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            this.pipeTop.Location = new System.Drawing.Point(406, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 235);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 10;
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Aqua;
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.flappyBird;
            this.flappyBird.Location = new System.Drawing.Point(30, 255);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(114, 98);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 11;
            this.flappyBird.TabStop = false;
            // 
            // cloudy
            // 
            this.cloudy.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.clouds;
            this.cloudy.Location = new System.Drawing.Point(45, 45);
            this.cloudy.Name = "cloudy";
            this.cloudy.Size = new System.Drawing.Size(228, 139);
            this.cloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cloudy.TabIndex = 12;
            this.cloudy.TabStop = false;
            // 
            // overGameText
            // 
            this.overGameText.Location = new System.Drawing.Point(173, 387);
            this.overGameText.Name = "overGameText";
            this.overGameText.Size = new System.Drawing.Size(100, 23);
            this.overGameText.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(584, 707);
            this.Controls.Add(this.overGameText);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.flappyBird);
            this.Controls.Add(this.cloudy);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox cloudy;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Label overGameText;
    }
}

