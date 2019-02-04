namespace Boxy
{
    partial class Boxy
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
            this.MainMenuPanel = new System.Windows.Forms.Panel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.LearnButton = new System.Windows.Forms.Button();
            this.QuitButton = new System.Windows.Forms.Button();
            this.GamePanel = new System.Windows.Forms.Panel();
            this.GameBackground = new System.Windows.Forms.PictureBox();
            this.MenuBackground = new System.Windows.Forms.PictureBox();
            this.MainMenuPanel.SuspendLayout();
            this.GamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenuPanel
            // 
            this.MainMenuPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainMenuPanel.Controls.Add(this.GamePanel);
            this.MainMenuPanel.Controls.Add(this.PlayButton);
            this.MainMenuPanel.Controls.Add(this.LearnButton);
            this.MainMenuPanel.Controls.Add(this.QuitButton);
            this.MainMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MainMenuPanel.Name = "MainMenuPanel";
            this.MainMenuPanel.Size = new System.Drawing.Size(352, 606);
            this.MainMenuPanel.TabIndex = 0;
            this.MainMenuPanel.UseWaitCursor = true;
            // 
            // PlayButton
            // 
            this.PlayButton.BackgroundImage = global::Boxy.Properties.Resources.playbutton;
            this.PlayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlayButton.Location = new System.Drawing.Point(90, 177);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(180, 90);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.UseWaitCursor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // LearnButton
            // 
            this.LearnButton.BackgroundImage = global::Boxy.Properties.Resources.learnbutton;
            this.LearnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LearnButton.Location = new System.Drawing.Point(90, 273);
            this.LearnButton.Name = "LearnButton";
            this.LearnButton.Size = new System.Drawing.Size(180, 90);
            this.LearnButton.TabIndex = 1;
            this.LearnButton.UseVisualStyleBackColor = true;
            this.LearnButton.UseWaitCursor = true;
            this.LearnButton.Click += new System.EventHandler(this.LearnButton_Click);
            // 
            // QuitButton
            // 
            this.QuitButton.BackgroundImage = global::Boxy.Properties.Resources.quitbutton;
            this.QuitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuitButton.Location = new System.Drawing.Point(90, 369);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(180, 90);
            this.QuitButton.TabIndex = 2;
            this.QuitButton.UseVisualStyleBackColor = true;
            this.QuitButton.UseWaitCursor = true;
            this.QuitButton.Click += new System.EventHandler(this.QuitButton_Click);
            // 
            // GamePanel
            // 
            this.GamePanel.Controls.Add(this.MenuBackground);
            this.GamePanel.Controls.Add(this.GameBackground);
            this.GamePanel.Location = new System.Drawing.Point(0, 0);
            this.GamePanel.Name = "GamePanel";
            this.GamePanel.Size = new System.Drawing.Size(352, 606);
            this.GamePanel.TabIndex = 3;
            this.GamePanel.UseWaitCursor = true;
            this.GamePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GamePanel_Paint);
            // 
            // GameBackground
            // 
            this.GameBackground.Image = global::Boxy.Properties.Resources.setsizewarehouse;
            this.GameBackground.Location = new System.Drawing.Point(0, 0);
            this.GameBackground.Name = "GameBackground";
            this.GameBackground.Size = new System.Drawing.Size(352, 609);
            this.GameBackground.TabIndex = 0;
            this.GameBackground.TabStop = false;
            this.GameBackground.UseWaitCursor = true;
            // 
            // MenuBackground
            // 
            this.MenuBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MenuBackground.Image = global::Boxy.Properties.Resources.setsizemenu;
            this.MenuBackground.Location = new System.Drawing.Point(0, 0);
            this.MenuBackground.Name = "MenuBackground";
            this.MenuBackground.Size = new System.Drawing.Size(352, 606);
            this.MenuBackground.TabIndex = 4;
            this.MenuBackground.TabStop = false;
            this.MenuBackground.UseWaitCursor = true;
            this.MenuBackground.Click += new System.EventHandler(this.MenuBackground_Click);
            // 
            // Boxy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 607);
            this.Controls.Add(this.MainMenuPanel);
            this.Name = "Boxy";
            this.Text = "Boxy";
            this.UseWaitCursor = true;
            this.MainMenuPanel.ResumeLayout(false);
            this.GamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GameBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBackground)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel MainMenuPanel;
        private System.Windows.Forms.Panel GamePanel;
        private System.Windows.Forms.Button LearnButton;
        private System.Windows.Forms.Button QuitButton;
        private System.Windows.Forms.PictureBox MenuBackground;
        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.PictureBox GameBackground;
    }
}

