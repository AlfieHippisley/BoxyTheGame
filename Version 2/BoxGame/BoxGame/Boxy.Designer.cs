namespace BoxGame
{
    partial class GameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.PrimaryTimer = new System.Windows.Forms.Timer(this.components);
            this.LearnPnl = new System.Windows.Forms.Panel();
            this.BackBtn = new System.Windows.Forms.Button();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HardButton = new System.Windows.Forms.Button();
            this.MedButton = new System.Windows.Forms.Button();
            this.easybutton = new System.Windows.Forms.Button();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.ExitConfirmation = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.QuitJobBtn = new System.Windows.Forms.Button();
            this.StartOverBtn = new System.Windows.Forms.Button();
            this.TotalScoreLabel = new System.Windows.Forms.Label();
            this.AverageDispatchSize = new System.Windows.Forms.Label();
            this.TotalDispatch = new System.Windows.Forms.Label();
            this.pauseButton = new System.Windows.Forms.Button();
            this.FiredPnl = new System.Windows.Forms.Panel();
            this.BackBtn2 = new System.Windows.Forms.Button();
            this.LearnPnl.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ExitConfirmation.SuspendLayout();
            this.FiredPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryTimer
            // 
            this.PrimaryTimer.Tick += new System.EventHandler(this.PrimaryTimer_Tick);
            // 
            // LearnPnl
            // 
            this.LearnPnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LearnPnl.BackgroundImage")));
            this.LearnPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnPnl.Controls.Add(this.BackBtn);
            this.LearnPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LearnPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.LearnPnl.Location = new System.Drawing.Point(0, 0);
            this.LearnPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LearnPnl.Name = "LearnPnl";
            this.LearnPnl.Size = new System.Drawing.Size(1392, 690);
            this.LearnPnl.TabIndex = 11;
            this.LearnPnl.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::BoxGame.Properties.Resources.BackBtn;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(77, 565);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(179, 97);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::BoxGame.Properties.Resources.MainMenuPic;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.pictureBox1);
            this.MainMenuPanel.Controls.Add(this.HardButton);
            this.MainMenuPanel.Controls.Add(this.MedButton);
            this.MainMenuPanel.Controls.Add(this.easybutton);
            this.MainMenuPanel.Controls.Add(this.LearnBtn);
            this.MainMenuPanel.Controls.Add(this.ExitConfirmation);
            this.MainMenuPanel.Controls.Add(this.QuitBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1392, 690);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::BoxGame.Properties.Resources.selecttitile;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(89, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // HardButton
            // 
            this.HardButton.BackgroundImage = global::BoxGame.Properties.Resources.hardbutton;
            this.HardButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HardButton.Location = new System.Drawing.Point(493, 566);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(200, 100);
            this.HardButton.TabIndex = 13;
            this.HardButton.UseVisualStyleBackColor = true;
            this.HardButton.Click += new System.EventHandler(this.HardButton_Click);
            // 
            // MedButton
            // 
            this.MedButton.BackgroundImage = global::BoxGame.Properties.Resources.mediumbutton;
            this.MedButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MedButton.Location = new System.Drawing.Point(285, 565);
            this.MedButton.Margin = new System.Windows.Forms.Padding(4);
            this.MedButton.Name = "MedButton";
            this.MedButton.Size = new System.Drawing.Size(200, 100);
            this.MedButton.TabIndex = 12;
            this.MedButton.UseVisualStyleBackColor = true;
            this.MedButton.Click += new System.EventHandler(this.MedButton_Click);
            // 
            // easybutton
            // 
            this.easybutton.BackgroundImage = global::BoxGame.Properties.Resources.easybutton;
            this.easybutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.easybutton.Location = new System.Drawing.Point(77, 565);
            this.easybutton.Margin = new System.Windows.Forms.Padding(4);
            this.easybutton.Name = "easybutton";
            this.easybutton.Size = new System.Drawing.Size(200, 100);
            this.easybutton.TabIndex = 6;
            this.easybutton.UseVisualStyleBackColor = true;
            this.easybutton.Click += new System.EventHandler(this.easybutton_Click);
            // 
            // LearnBtn
            // 
            this.LearnBtn.BackgroundImage = global::BoxGame.Properties.Resources.learnbutton;
            this.LearnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnBtn.Location = new System.Drawing.Point(285, 383);
            this.LearnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(200, 100);
            this.LearnBtn.TabIndex = 7;
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // ExitConfirmation
            // 
            this.ExitConfirmation.BackgroundImage = global::BoxGame.Properties.Resources.exitbox;
            this.ExitConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitConfirmation.Controls.Add(this.CancelBtn);
            this.ExitConfirmation.Controls.Add(this.YesBtn);
            this.ExitConfirmation.Location = new System.Drawing.Point(493, 101);
            this.ExitConfirmation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ExitConfirmation.Name = "ExitConfirmation";
            this.ExitConfirmation.Size = new System.Drawing.Size(441, 382);
            this.ExitConfirmation.TabIndex = 9;
            this.ExitConfirmation.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = global::BoxGame.Properties.Resources.cancelbuttonwhite;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(237, 169);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(156, 73);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackgroundImage = global::BoxGame.Properties.Resources.yesbuttonwhite;
            this.YesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YesBtn.Location = new System.Drawing.Point(28, 169);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(156, 73);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackgroundImage = global::BoxGame.Properties.Resources.quitbutton;
            this.QuitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitBtn.Location = new System.Drawing.Point(493, 382);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(200, 100);
            this.QuitBtn.TabIndex = 8;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::BoxGame.Properties.Resources.playbutton;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Location = new System.Drawing.Point(78, 383);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(200, 100);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // QuitJobBtn
            // 
            this.QuitJobBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuitJobBtn.BackgroundImage")));
            this.QuitJobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitJobBtn.Location = new System.Drawing.Point(901, 409);
            this.QuitJobBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuitJobBtn.Name = "QuitJobBtn";
            this.QuitJobBtn.Size = new System.Drawing.Size(133, 62);
            this.QuitJobBtn.TabIndex = 12;
            this.QuitJobBtn.UseVisualStyleBackColor = true;
            this.QuitJobBtn.Click += new System.EventHandler(this.QuitJobBtn_Click);
            // 
            // StartOverBtn
            // 
            this.StartOverBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartOverBtn.BackgroundImage")));
            this.StartOverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartOverBtn.Location = new System.Drawing.Point(1040, 409);
            this.StartOverBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartOverBtn.Name = "StartOverBtn";
            this.StartOverBtn.Size = new System.Drawing.Size(145, 62);
            this.StartOverBtn.TabIndex = 13;
            this.StartOverBtn.UseVisualStyleBackColor = true;
            this.StartOverBtn.Click += new System.EventHandler(this.StartOverBtn_Click);
            // 
            // TotalScoreLabel
            // 
            this.TotalScoreLabel.AutoSize = true;
            this.TotalScoreLabel.Location = new System.Drawing.Point(1197, 271);
            this.TotalScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalScoreLabel.Name = "TotalScoreLabel";
            this.TotalScoreLabel.Size = new System.Drawing.Size(16, 17);
            this.TotalScoreLabel.TabIndex = 14;
            this.TotalScoreLabel.Text = "0";
            // 
            // AverageDispatchSize
            // 
            this.AverageDispatchSize.AutoSize = true;
            this.AverageDispatchSize.Location = new System.Drawing.Point(1197, 357);
            this.AverageDispatchSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AverageDispatchSize.Name = "AverageDispatchSize";
            this.AverageDispatchSize.Size = new System.Drawing.Size(16, 17);
            this.AverageDispatchSize.TabIndex = 15;
            this.AverageDispatchSize.Text = "0";
            // 
            // TotalDispatch
            // 
            this.TotalDispatch.AutoSize = true;
            this.TotalDispatch.Location = new System.Drawing.Point(1197, 315);
            this.TotalDispatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalDispatch.Name = "TotalDispatch";
            this.TotalDispatch.Size = new System.Drawing.Size(16, 17);
            this.TotalDispatch.TabIndex = 16;
            this.TotalDispatch.Text = "0";
            // 
            // pauseButton
            // 
            this.pauseButton.BackgroundImage = global::BoxGame.Properties.Resources.pausebutton;
            this.pauseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pauseButton.Location = new System.Drawing.Point(1191, 409);
            this.pauseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(110, 62);
            this.pauseButton.TabIndex = 17;
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FiredPnl
            // 
            this.FiredPnl.BackgroundImage = global::BoxGame.Properties.Resources.gameover;
            this.FiredPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FiredPnl.Controls.Add(this.BackBtn2);
            this.FiredPnl.Location = new System.Drawing.Point(31, 162);
            this.FiredPnl.Name = "FiredPnl";
            this.FiredPnl.Size = new System.Drawing.Size(795, 397);
            this.FiredPnl.TabIndex = 18;
            this.FiredPnl.Visible = false;
            // 
            // BackBtn2
            // 
            this.BackBtn2.BackgroundImage = global::BoxGame.Properties.Resources.BackBtn;
            this.BackBtn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn2.Location = new System.Drawing.Point(576, 28);
            this.BackBtn2.Name = "BackBtn2";
            this.BackBtn2.Size = new System.Drawing.Size(150, 75);
            this.BackBtn2.TabIndex = 0;
            this.BackBtn2.UseVisualStyleBackColor = true;
            this.BackBtn2.Click += new System.EventHandler(this.BackBtn2_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BoxGame.Properties.Resources.GameBoard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1392, 690);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LearnPnl);
            this.Controls.Add(this.QuitJobBtn);
            this.Controls.Add(this.StartOverBtn);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.TotalScoreLabel);
            this.Controls.Add(this.TotalDispatch);
            this.Controls.Add(this.AverageDispatchSize);
            this.Controls.Add(this.FiredPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Boxy The Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.LearnPnl.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ExitConfirmation.ResumeLayout(false);
            this.FiredPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button QuitJobBtn;
        private System.Windows.Forms.Button StartOverBtn;
        private System.Windows.Forms.Timer PrimaryTimer;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button LearnBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel ExitConfirmation;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Panel LearnPnl;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label TotalScoreLabel;
        private System.Windows.Forms.Label AverageDispatchSize;
        private System.Windows.Forms.Label TotalDispatch;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Panel FiredPnl;
        private System.Windows.Forms.Button BackBtn2;
        private System.Windows.Forms.Button easybutton;
        private System.Windows.Forms.Button MedButton;
        private System.Windows.Forms.Button HardButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

