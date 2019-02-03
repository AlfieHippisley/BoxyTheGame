namespace Boxy
{
    partial class quitConfirmation
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
            this.YesBtn = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // YesBtn
            // 
            this.YesBtn.BackgroundImage = global::Boxy.Properties.Resources.yesbuttonwhite;
            this.YesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.YesBtn.Location = new System.Drawing.Point(30, 151);
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Size = new System.Drawing.Size(156, 73);
            this.YesBtn.TabIndex = 0;
            this.YesBtn.UseVisualStyleBackColor = true;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackgroundImage = global::Boxy.Properties.Resources.cancelbuttonwhite;
            this.CancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelBtn.Location = new System.Drawing.Point(277, 151);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(156, 73);
            this.CancelBtn.TabIndex = 1;
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // quitConfirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Boxy.Properties.Resources.exitbox;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(482, 371);
            this.ControlBox = false;
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.YesBtn);
            this.Name = "quitConfirmation";
            this.Text = "quitConfirmation";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button YesBtn;
        private System.Windows.Forms.Button CancelBtn;
    }
}