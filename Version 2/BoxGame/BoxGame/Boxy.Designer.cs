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
            this.QuitBtn = new System.Windows.Forms.Button();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitConfirmation = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.QuitJobBtn = new System.Windows.Forms.Button();
            this.StartOverBtn = new System.Windows.Forms.Button();
            this.TotalScoreLabel = new System.Windows.Forms.Label();
            this.AverageDispatchSize = new System.Windows.Forms.Label();
            this.TotalDispatch = new System.Windows.Forms.Label();
            this.LearnPnl.SuspendLayout();
            this.MainMenuPanel.SuspendLayout();
            this.ExitConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryTimer
            // 
            this.PrimaryTimer.Interval = 200;
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
            this.LearnPnl.Margin = new System.Windows.Forms.Padding(2);
            this.LearnPnl.Name = "LearnPnl";
            this.LearnPnl.Size = new System.Drawing.Size(1044, 561);
            this.LearnPnl.TabIndex = 11;
            this.LearnPnl.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::BoxGame.Properties.Resources.BackBtn;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(58, 459);
            this.BackBtn.Margin = new System.Windows.Forms.Padding(2);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(134, 79);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::BoxGame.Properties.Resources.MainMenuPic;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.ExitConfirmation);
            this.MainMenuPanel.Controls.Add(this.QuitBtn);
            this.MainMenuPanel.Controls.Add(this.LearnBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn);
            this.MainMenuPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1044, 561);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackgroundImage = global::BoxGame.Properties.Resources.quitbutton;
            this.QuitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitBtn.Location = new System.Drawing.Point(370, 457);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(150, 81);
            this.QuitBtn.TabIndex = 8;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // LearnBtn
            // 
            this.LearnBtn.BackgroundImage = global::BoxGame.Properties.Resources.learnbutton;
            this.LearnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnBtn.Location = new System.Drawing.Point(214, 457);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(150, 81);
            this.LearnBtn.TabIndex = 7;
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::BoxGame.Properties.Resources.playbutton;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Location = new System.Drawing.Point(58, 457);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(150, 81);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // ExitConfirmation
            // 
            this.ExitConfirmation.BackgroundImage = global::BoxGame.Properties.Resources.exitbox;
            this.ExitConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitConfirmation.Controls.Add(this.CancelBtn);
            this.ExitConfirmation.Controls.Add(this.YesBtn);
            this.ExitConfirmation.Location = new System.Drawing.Point(370, 82);
            this.ExitConfirmation.Margin = new System.Windows.Forms.Padding(2);
            this.ExitConfirmation.Name = "ExitConfirmation";
            this.ExitConfirmation.Size = new System.Drawing.Size(331, 310);
            this.ExitConfirmation.TabIndex = 9;
            this.ExitConfirmation.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = global::BoxGame.Properties.Resources.cancelbuttonwhite;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Location = new System.Drawing.Point(178, 137);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(117, 59);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // YesBtn
            // 
            this.YesBtn.BackgroundImage = global::BoxGame.Properties.Resources.yesbuttonwhite;
            this.YesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YesBtn.Location = new System.Drawing.Point(21, 137);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(117, 59);
            this.YesBtn.TabIndex = 2;
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // QuitJobBtn
            // 
            this.QuitJobBtn.BackgroundImage = global::BoxGame.Properties.Resources.QuitJobBtn;
            this.QuitJobBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitJobBtn.Location = new System.Drawing.Point(676, 332);
            this.QuitJobBtn.Margin = new System.Windows.Forms.Padding(2);
            this.QuitJobBtn.Name = "QuitJobBtn";
            this.QuitJobBtn.Size = new System.Drawing.Size(100, 50);
            this.QuitJobBtn.TabIndex = 12;
            this.QuitJobBtn.UseVisualStyleBackColor = true;
            this.QuitJobBtn.Click += new System.EventHandler(this.QuitJobBtn_Click);
            // 
            // StartOverBtn
            // 
            this.StartOverBtn.BackgroundImage = global::BoxGame.Properties.Resources.StartOverBtn;
            this.StartOverBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartOverBtn.Location = new System.Drawing.Point(780, 332);
            this.StartOverBtn.Margin = new System.Windows.Forms.Padding(2);
            this.StartOverBtn.Name = "StartOverBtn";
            this.StartOverBtn.Size = new System.Drawing.Size(109, 50);
            this.StartOverBtn.TabIndex = 13;
            this.StartOverBtn.UseVisualStyleBackColor = true;
            this.StartOverBtn.Click += new System.EventHandler(this.StartOverBtn_Click);
            // 
            // TotalScoreLabel
            // 
            this.TotalScoreLabel.AutoSize = true;
            this.TotalScoreLabel.Location = new System.Drawing.Point(898, 220);
            this.TotalScoreLabel.Name = "TotalScoreLabel";
            this.TotalScoreLabel.Size = new System.Drawing.Size(13, 13);
            this.TotalScoreLabel.TabIndex = 14;
            this.TotalScoreLabel.Text = "0";
            // 
            // AverageDispatchSize
            // 
            this.AverageDispatchSize.AutoSize = true;
            this.AverageDispatchSize.Location = new System.Drawing.Point(898, 290);
            this.AverageDispatchSize.Name = "AverageDispatchSize";
            this.AverageDispatchSize.Size = new System.Drawing.Size(13, 13);
            this.AverageDispatchSize.TabIndex = 15;
            this.AverageDispatchSize.Text = "0";
            // 
            // TotalDispatch
            // 
            this.TotalDispatch.AutoSize = true;
            this.TotalDispatch.Location = new System.Drawing.Point(898, 256);
            this.TotalDispatch.Name = "TotalDispatch";
            this.TotalDispatch.Size = new System.Drawing.Size(13, 13);
            this.TotalDispatch.TabIndex = 16;
            this.TotalDispatch.Text = "0";
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::BoxGame.Properties.Resources.GameBoard;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 561);
            this.Controls.Add(this.MainMenuPanel);
            this.Controls.Add(this.LearnPnl);
            this.Controls.Add(this.QuitJobBtn);
            this.Controls.Add(this.StartOverBtn);
            this.Controls.Add(this.AverageDispatchSize);
            this.Controls.Add(this.TotalDispatch);
            this.Controls.Add(this.TotalScoreLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GameForm";
            this.Text = "Boxy The Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.LearnPnl.ResumeLayout(false);
            this.MainMenuPanel.ResumeLayout(false);
            this.ExitConfirmation.ResumeLayout(false);
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
    }
}

