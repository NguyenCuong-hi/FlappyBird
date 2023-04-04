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
            this.lblNewGame = new System.Windows.Forms.Label();
            this.lblHelp = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.overGameText = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblResume = new System.Windows.Forms.Label();
            this.pnEndGame = new System.Windows.Forms.Panel();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.picRestart = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.picPause = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.cloudy = new System.Windows.Forms.PictureBox();
            this.pnSetting = new System.Windows.Forms.Panel();
            this.picCancel = new System.Windows.Forms.PictureBox();
            this.EasyCore = new System.Windows.Forms.RadioButton();
            this.Mediumcore = new System.Windows.Forms.RadioButton();
            this.Hardcore = new System.Windows.Forms.RadioButton();
            this.pnMenu.SuspendLayout();
            this.pnEndGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudy)).BeginInit();
            this.pnSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreText
            // 
            resources.ApplyResources(this.scoreText, "scoreText");
            this.scoreText.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.scoreText.Name = "scoreText";
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 30;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
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
            // overGameText
            // 
            resources.ApplyResources(this.overGameText, "overGameText");
            this.overGameText.Name = "overGameText";
            // 
            // lblSettings
            // 
            resources.ApplyResources(this.lblSettings, "lblSettings");
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Click += new System.EventHandler(this.lblSetting_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.lblResume);
            this.pnMenu.Controls.Add(this.lblNewGame);
            this.pnMenu.Controls.Add(this.lblHelp);
            this.pnMenu.Controls.Add(this.lblSettings);
            this.pnMenu.Controls.Add(this.lblExit);
            this.pnMenu.Controls.Add(this.lblAbout);
            resources.ApplyResources(this.pnMenu, "pnMenu");
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // lblResume
            // 
            resources.ApplyResources(this.lblResume, "lblResume");
            this.lblResume.Name = "lblResume";
            this.lblResume.Click += new System.EventHandler(this.lblResume_Click);
            // 
            // pnEndGame
            // 
            this.pnEndGame.Controls.Add(this.picHome);
            this.pnEndGame.Controls.Add(this.picRestart);
            this.pnEndGame.Controls.Add(this.lblScore);
            resources.ApplyResources(this.pnEndGame, "pnEndGame");
            this.pnEndGame.Name = "pnEndGame";
            this.pnEndGame.Paint += new System.Windows.Forms.PaintEventHandler(this.pnEndGame_Paint);
            // 
            // picHome
            // 
            resources.ApplyResources(this.picHome, "picHome");
            this.picHome.Name = "picHome";
            this.picHome.TabStop = false;
            this.picHome.Click += new System.EventHandler(this.picHome_Click);
            // 
            // picRestart
            // 
            resources.ApplyResources(this.picRestart, "picRestart");
            this.picRestart.Name = "picRestart";
            this.picRestart.TabStop = false;
            this.picRestart.Click += new System.EventHandler(this.picRestart_Click);
            // 
            // lblScore
            // 
            resources.ApplyResources(this.lblScore, "lblScore");
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblScore.Name = "lblScore";
            // 
            // picPause
            // 
            this.picPause.BackColor = System.Drawing.Color.Aqua;
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
            // pnSetting
            // 
            this.pnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.pnSetting.Controls.Add(this.picCancel);
            this.pnSetting.Controls.Add(this.EasyCore);
            this.pnSetting.Controls.Add(this.Mediumcore);
            this.pnSetting.Controls.Add(this.Hardcore);
            resources.ApplyResources(this.pnSetting, "pnSetting");
            this.pnSetting.Name = "pnSetting";
            // 
            // picCancel
            // 
            this.picCancel.Image = global::Flappy_Bird_Windows_Form.Properties.Resources.cancel;
            resources.ApplyResources(this.picCancel, "picCancel");
            this.picCancel.Name = "picCancel";
            this.picCancel.TabStop = false;
            this.picCancel.Click += new System.EventHandler(this.picCancel_Click);
            // 
            // EasyCore
            // 
            resources.ApplyResources(this.EasyCore, "EasyCore");
            this.EasyCore.Name = "EasyCore";
            this.EasyCore.TabStop = true;
            this.EasyCore.UseVisualStyleBackColor = true;
            // 
            // Mediumcore
            // 
            resources.ApplyResources(this.Mediumcore, "Mediumcore");
            this.Mediumcore.Name = "Mediumcore";
            this.Mediumcore.TabStop = true;
            this.Mediumcore.UseVisualStyleBackColor = true;
            // 
            // Hardcore
            // 
            resources.ApplyResources(this.Hardcore, "Hardcore");
            this.Hardcore.Name = "Hardcore";
            this.Hardcore.TabStop = true;
            this.Hardcore.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.Controls.Add(this.pnSetting);
            this.Controls.Add(this.pnEndGame);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.overGameText);
            this.Controls.Add(this.picPause);
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
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.pnEndGame.ResumeLayout(false);
            this.pnEndGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRestart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cloudy)).EndInit();
            this.pnSetting.ResumeLayout(false);
            this.pnSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCancel)).EndInit();
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
        private System.Windows.Forms.PictureBox cloudy;
        private System.Windows.Forms.Label lblNewGame;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.PictureBox picPause;
        private System.Windows.Forms.Label overGameText;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnEndGame;
        private System.Windows.Forms.PictureBox picRestart;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblResume;
        private System.Windows.Forms.Panel pnSetting;
        private System.Windows.Forms.RadioButton EasyCore;
        private System.Windows.Forms.RadioButton Mediumcore;
        private System.Windows.Forms.RadioButton Hardcore;
        private System.Windows.Forms.PictureBox picCancel;
    }
}

