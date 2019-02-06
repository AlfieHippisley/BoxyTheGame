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
            this.PrimaryTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.ExitConfirmation = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.MainMenuPanel.SuspendLayout();
            this.ExitConfirmation.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrimaryTimer
            // 
            this.PrimaryTimer.Interval = 200;
            this.PrimaryTimer.Tick += new System.EventHandler(this.PrimaryTimer_Tick);
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::BoxGame.Properties.Resources.mainmenubackground;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.QuitBtn);
            this.MainMenuPanel.Controls.Add(this.LearnBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(440, 712);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            // 
            // QuitBtn
            // 
            this.QuitBtn.BackgroundImage = global::BoxGame.Properties.Resources.quitbutton;
            this.QuitBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitBtn.Location = new System.Drawing.Point(100, 419);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(240, 111);
            this.QuitBtn.TabIndex = 8;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // LearnBtn
            // 
            this.LearnBtn.BackgroundImage = global::BoxGame.Properties.Resources.learnbutton;
            this.LearnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnBtn.Location = new System.Drawing.Point(100, 300);
            this.LearnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(240, 111);
            this.LearnBtn.TabIndex = 7;
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::BoxGame.Properties.Resources.playbutton;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Location = new System.Drawing.Point(100, 182);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(240, 111);
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
            this.ExitConfirmation.Location = new System.Drawing.Point(-1, 209);
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 703);
            this.Controls.Add(this.ExitConfirmation);
            this.Controls.Add(this.MainMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Boxy The Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.MainMenuPanel.ResumeLayout(false);
            this.ExitConfirmation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer PrimaryTimer;
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Button QuitBtn;
        private System.Windows.Forms.Button LearnBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Panel ExitConfirmation;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button YesBtn;
    }
}

