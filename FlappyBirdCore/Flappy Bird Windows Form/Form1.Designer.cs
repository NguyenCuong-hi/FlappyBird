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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblStart = new System.Windows.Forms.Label();
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
            resources.ApplyResources(this.scoreText, "scoreText");
            this.scoreText.BackColor = System.Drawing.Color.Moccasin;
            this.scoreText.Name = "scoreText";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // lblStart
            // 
            resources.ApplyResources(this.lblStart, "lblStart");
            this.lblStart.Name = "lblStart";
            // 
            // lblNewGame
            // 
            resources.ApplyResources(this.lblNewGame, "lblNewGame");
            this.lblNewGame.Name = "lblNewGame";
            this.lblNewGame.Click += new System.EventHandler(this.lblNewGame_Click);
            // 
            // lblHelp
            // 
            resources.ApplyResources(this.lblHelp, "lblHelp");
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Click += new System.EventHandler(this.lblHelp_Click);
            // 
            // lblAbout
            // 
            resources.ApplyResources(this.lblAbout, "lblAbout");
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // lblExit
            // 
            resources.ApplyResources(this.lblExit, "lblExit");
            this.lblExit.Name = "lblExit";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // picPause
            // 
            this.picPause.BackColor = System.Drawing.Color.Aqua;
            this.picPause.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pauseButton_removebg_preview;
            resources.ApplyResources(this.picPause, "picPause");
            this.picPause.Name = "picPause";
            this.picPause.TabStop = false;
            this.picPause.Click += new System.EventHandler(this.picPause_Click);
            // 
            // ground
            // 
            this.ground.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.ground;
            resources.ApplyResources(this.ground, "ground");
            this.ground.Name = "ground";
            this.ground.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipe;
            resources.ApplyResources(this.pipeBottom, "pipeBottom");
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.pipedown;
            resources.ApplyResources(this.pipeTop, "pipeTop");
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.TabStop = false;
            // 
            // flappyBird
            // 
            this.flappyBird.BackColor = System.Drawing.Color.Aqua;
            resources.ApplyResources(this.flappyBird, "flappyBird");
            this.flappyBird.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.flappyBird;
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.TabStop = false;
            // 
            // cloudy
            // 
            resources.ApplyResources(this.cloudy, "cloudy");
            this.cloudy.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.clouds;
            this.cloudy.Name = "cloudy";
            this.cloudy.TabStop = false;
            // 
            // overGameText
            // 
            resources.ApplyResources(this.overGameText, "overGameText");
            this.overGameText.Name = "overGameText";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.overGameText);
            this.Controls.Add(this.picPause);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.lblNewGame);
            this.Controls.Add(this.lblStart);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.PictureBox cloudy;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Label overGameText;
    }
}

