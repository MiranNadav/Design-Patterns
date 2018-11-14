namespace A19_Nadav_308426048_David_311338016
{
    partial class MainFeedForm
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
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.fetchPosts = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(12, 25);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(194, 162);
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.Click += new System.EventHandler(this.ProfilePictureBox_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(76, 13);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome Text";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(234, 49);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 95);
            this.listBoxPosts.TabIndex = 2;
            // 
            // fetchPosts
            // 
            this.fetchPosts.Location = new System.Drawing.Point(234, 20);
            this.fetchPosts.Name = "fetchPosts";
            this.fetchPosts.Size = new System.Drawing.Size(120, 23);
            this.fetchPosts.TabIndex = 3;
            this.fetchPosts.Text = "Posts";
            this.fetchPosts.UseVisualStyleBackColor = true;
            this.fetchPosts.Click += new System.EventHandler(this.fetchPosts_Click);
            // 
            // MainFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fetchPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Name = "MainFeedForm";
            this.Text = "MainFeedForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button fetchPosts;
    }
}