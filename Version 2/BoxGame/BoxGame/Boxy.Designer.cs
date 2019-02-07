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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.ExitConfirmation = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.YesBtn = new System.Windows.Forms.Button();
            this.QuitBtn = new System.Windows.Forms.Button();
            this.LearnBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
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
            this.LearnPnl.BackgroundImage = global::BoxGame.Properties.Resources.LearnPanelPic;
            this.LearnPnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnPnl.Controls.Add(this.BackBtn);
            this.LearnPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LearnPnl.ForeColor = System.Drawing.SystemColors.Control;
            this.LearnPnl.Location = new System.Drawing.Point(0, 0);
            this.LearnPnl.Name = "LearnPnl";
            this.LearnPnl.Size = new System.Drawing.Size(1059, 599);
            this.LearnPnl.TabIndex = 11;
            this.LearnPnl.Visible = false;
            // 
            // BackBtn
            // 
            this.BackBtn.BackgroundImage = global::BoxGame.Properties.Resources.BackBtn;
            this.BackBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BackBtn.Location = new System.Drawing.Point(53, 463);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(174, 93);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(0, 709);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(767, 89);
            this.panel1.TabIndex = 10;
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImage = global::BoxGame.Properties.Resources.MainMenuPic;
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.ExitConfirmation);
            this.MainMenuPanel.Controls.Add(this.QuitBtn);
            this.MainMenuPanel.Controls.Add(this.LearnBtn);
            this.MainMenuPanel.Controls.Add(this.PlayBtn);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(1060, 600);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainMenuPanel_Paint);
            // 
            // ExitConfirmation
            // 
            this.ExitConfirmation.BackgroundImage = global::BoxGame.Properties.Resources.exitbox;
            this.ExitConfirmation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitConfirmation.Controls.Add(this.CancelBtn);
            this.ExitConfirmation.Controls.Add(this.YesBtn);
            this.ExitConfirmation.Location = new System.Drawing.Point(317, 95);
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
            this.QuitBtn.Location = new System.Drawing.Point(493, 439);
            this.QuitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.QuitBtn.Name = "QuitBtn";
            this.QuitBtn.Size = new System.Drawing.Size(200, 100);
            this.QuitBtn.TabIndex = 8;
            this.QuitBtn.UseVisualStyleBackColor = true;
            this.QuitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // LearnBtn
            // 
            this.LearnBtn.BackgroundImage = global::BoxGame.Properties.Resources.learnbutton;
            this.LearnBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnBtn.Location = new System.Drawing.Point(285, 439);
            this.LearnBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LearnBtn.Name = "LearnBtn";
            this.LearnBtn.Size = new System.Drawing.Size(200, 100);
            this.LearnBtn.TabIndex = 7;
            this.LearnBtn.UseVisualStyleBackColor = true;
            this.LearnBtn.Click += new System.EventHandler(this.LearnBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.BackgroundImage = global::BoxGame.Properties.Resources.playbutton;
            this.PlayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayBtn.Location = new System.Drawing.Point(77, 439);
            this.PlayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(200, 100);
            this.PlayBtn.TabIndex = 6;
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 599);
            this.Controls.Add(this.LearnPnl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MainMenuPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "Boxy The Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.LearnPnl.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel LearnPnl;
        private System.Windows.Forms.Button BackBtn;
    }
}

