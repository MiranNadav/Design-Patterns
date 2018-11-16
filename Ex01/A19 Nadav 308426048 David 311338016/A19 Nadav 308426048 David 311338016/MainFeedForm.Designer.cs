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
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.fetchFriendsButton = new System.Windows.Forms.Button();
            this.uploadPostButton = new System.Windows.Forms.Button();
            this.textBoxPostDetails = new System.Windows.Forms.TextBox();
            this.listBoxLikes = new System.Windows.Forms.ListBox();
            this.myLikesButton = new System.Windows.Forms.Button();
            this.fetchBestPostsButton = new System.Windows.Forms.Button();
            this.listBoxBestPosts = new System.Windows.Forms.ListBox();
            this.textBoxLikesLimit = new System.Windows.Forms.TextBox();
            this.fetchSameMonthFriendsButton = new System.Windows.Forms.Button();
            this.listBoxSameMonthFriends = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(12, 25);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(148, 119);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.listBoxPosts.Location = new System.Drawing.Point(183, 49);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 95);
            this.listBoxPosts.TabIndex = 2;
            // 
            // fetchPosts
            // 
            this.fetchPosts.Location = new System.Drawing.Point(183, 20);
            this.fetchPosts.Name = "fetchPosts";
            this.fetchPosts.Size = new System.Drawing.Size(120, 23);
            this.fetchPosts.TabIndex = 3;
            this.fetchPosts.Text = "Posts";
            this.fetchPosts.UseVisualStyleBackColor = true;
            this.fetchPosts.Click += new System.EventHandler(this.fetchPosts_Click);
            // 
            // listViewFriends
            // 
            this.listViewFriends.Location = new System.Drawing.Point(332, 49);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(121, 95);
            this.listViewFriends.TabIndex = 4;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.Location = new System.Drawing.Point(332, 20);
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.Size = new System.Drawing.Size(121, 23);
            this.fetchFriendsButton.TabIndex = 5;
            this.fetchFriendsButton.Text = "Friends";
            this.fetchFriendsButton.UseVisualStyleBackColor = true;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // uploadPostButton
            // 
            this.uploadPostButton.Location = new System.Drawing.Point(479, 151);
            this.uploadPostButton.Name = "uploadPostButton";
            this.uploadPostButton.Size = new System.Drawing.Size(120, 23);
            this.uploadPostButton.TabIndex = 6;
            this.uploadPostButton.Text = "Upload a Post";
            this.uploadPostButton.UseVisualStyleBackColor = true;
            this.uploadPostButton.Click += new System.EventHandler(this.uploadPostButton_Click);
            // 
            // textBoxPostDetails
            // 
            this.textBoxPostDetails.Location = new System.Drawing.Point(479, 180);
            this.textBoxPostDetails.Name = "textBoxPostDetails";
            this.textBoxPostDetails.Size = new System.Drawing.Size(120, 20);
            this.textBoxPostDetails.TabIndex = 7;
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(479, 49);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(120, 95);
            this.listBoxLikes.TabIndex = 8;
            // 
            // myLikesButton
            // 
            this.myLikesButton.Location = new System.Drawing.Point(479, 20);
            this.myLikesButton.Name = "myLikesButton";
            this.myLikesButton.Size = new System.Drawing.Size(120, 23);
            this.myLikesButton.TabIndex = 9;
            this.myLikesButton.Text = "My Likes";
            this.myLikesButton.UseVisualStyleBackColor = true;
            this.myLikesButton.Click += new System.EventHandler(this.myLikesButton_Click);
            // 
            // fetchBestPostsButton
            // 
            this.fetchBestPostsButton.Location = new System.Drawing.Point(183, 150);
            this.fetchBestPostsButton.Name = "fetchBestPostsButton";
            this.fetchBestPostsButton.Size = new System.Drawing.Size(120, 23);
            this.fetchBestPostsButton.TabIndex = 10;
            this.fetchBestPostsButton.Text = "Show best Posts";
            this.fetchBestPostsButton.UseVisualStyleBackColor = true;
            this.fetchBestPostsButton.Click += new System.EventHandler(this.fetchBestPostsButton_Click);
            // 
            // listBoxBestPosts
            // 
            this.listBoxBestPosts.FormattingEnabled = true;
            this.listBoxBestPosts.Location = new System.Drawing.Point(183, 206);
            this.listBoxBestPosts.Name = "listBoxBestPosts";
            this.listBoxBestPosts.Size = new System.Drawing.Size(120, 95);
            this.listBoxBestPosts.TabIndex = 11;
            // 
            // textBoxLikesLimit
            // 
            this.textBoxLikesLimit.Location = new System.Drawing.Point(183, 180);
            this.textBoxLikesLimit.Name = "textBoxLikesLimit";
            this.textBoxLikesLimit.Size = new System.Drawing.Size(120, 20);
            this.textBoxLikesLimit.TabIndex = 12;
            this.textBoxLikesLimit.Text = "Likes limit";
            // 
            // fetchSameMonthFriendsButton
            // 
            this.fetchSameMonthFriendsButton.Location = new System.Drawing.Point(332, 151);
            this.fetchSameMonthFriendsButton.Name = "fetchSameMonthFriendsButton";
            this.fetchSameMonthFriendsButton.Size = new System.Drawing.Size(121, 23);
            this.fetchSameMonthFriendsButton.TabIndex = 13;
            this.fetchSameMonthFriendsButton.Text = "Same month friends";
            this.fetchSameMonthFriendsButton.UseVisualStyleBackColor = true;
            this.fetchSameMonthFriendsButton.Click += new System.EventHandler(this.fetchSameMonthFriendsButton_Click);
            // 
            // listBoxSameMonthFriends
            // 
            this.listBoxSameMonthFriends.FormattingEnabled = true;
            this.listBoxSameMonthFriends.Location = new System.Drawing.Point(332, 180);
            this.listBoxSameMonthFriends.Name = "listBoxSameMonthFriends";
            this.listBoxSameMonthFriends.Size = new System.Drawing.Size(120, 95);
            this.listBoxSameMonthFriends.TabIndex = 14;
            // 
            // MainFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.listBoxSameMonthFriends);
            this.Controls.Add(this.fetchSameMonthFriendsButton);
            this.Controls.Add(this.textBoxLikesLimit);
            this.Controls.Add(this.listBoxBestPosts);
            this.Controls.Add(this.fetchBestPostsButton);
            this.Controls.Add(this.myLikesButton);
            this.Controls.Add(this.listBoxLikes);
            this.Controls.Add(this.textBoxPostDetails);
            this.Controls.Add(this.uploadPostButton);
            this.Controls.Add(this.fetchFriendsButton);
            this.Controls.Add(this.listViewFriends);
            this.Controls.Add(this.fetchPosts);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.Name = "MainFeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainFeedForm";
            this.Load += new System.EventHandler(this.MainFeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ProfilePictureBox;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.ListBox listBoxPosts;
        private System.Windows.Forms.Button fetchPosts;
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.Button fetchFriendsButton;
        private System.Windows.Forms.Button uploadPostButton;
        private System.Windows.Forms.TextBox textBoxPostDetails;
        private System.Windows.Forms.ListBox listBoxLikes;
        private System.Windows.Forms.Button myLikesButton;
        private System.Windows.Forms.Button fetchBestPostsButton;
        private System.Windows.Forms.ListBox listBoxBestPosts;
        private System.Windows.Forms.TextBox textBoxLikesLimit;
        private System.Windows.Forms.Button fetchSameMonthFriendsButton;
        private System.Windows.Forms.ListBox listBoxSameMonthFriends;
    }
}