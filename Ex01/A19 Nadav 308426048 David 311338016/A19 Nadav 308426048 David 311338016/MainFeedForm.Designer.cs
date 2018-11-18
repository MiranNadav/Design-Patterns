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
            System.Windows.Forms.PictureBox FacebookLogoPictureBox;
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
            this.showAllLikesButton = new System.Windows.Forms.Button();
            this.pickMonthComboBox = new System.Windows.Forms.ComboBox();
            this.albumPhotosListBox = new System.Windows.Forms.ListBox();
            this.fetchAllPhotosButton = new System.Windows.Forms.Button();
            this.openBirthdayGameButton = new System.Windows.Forms.Button();
            FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FacebookLogoPictureBox
            // 
            FacebookLogoPictureBox.Image = global::A19_Nadav_308426048_David_311338016.Properties.Resources.facebook;
            FacebookLogoPictureBox.Location = new System.Drawing.Point(26, 205);
            FacebookLogoPictureBox.Name = "FacebookLogoPictureBox";
            FacebookLogoPictureBox.Size = new System.Drawing.Size(165, 156);
            FacebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            FacebookLogoPictureBox.TabIndex = 15;
            FacebookLogoPictureBox.TabStop = false;
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(46, 54);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(112, 95);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            this.ProfilePictureBox.Click += new System.EventHandler(this.ProfilePictureBox_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WelcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(88, 13);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Welcome Text";
            this.WelcomeLabel.Click += new System.EventHandler(this.WelcomeLabel_Click);
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(214, 54);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 95);
            this.listBoxPosts.TabIndex = 2;
            // 
            // fetchPosts
            // 
            this.fetchPosts.BackColor = System.Drawing.Color.Transparent;
            this.fetchPosts.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fetchPosts.Location = new System.Drawing.Point(214, 25);
            this.fetchPosts.Name = "fetchPosts";
            this.fetchPosts.Size = new System.Drawing.Size(120, 23);
            this.fetchPosts.TabIndex = 3;
            this.fetchPosts.Text = "Posts";
            this.fetchPosts.UseVisualStyleBackColor = false;
            this.fetchPosts.Click += new System.EventHandler(this.fetchPosts_Click);
            // 
            // listViewFriends
            // 
            this.listViewFriends.Location = new System.Drawing.Point(360, 54);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(121, 95);
            this.listViewFriends.TabIndex = 4;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // fetchFriendsButton
            // 
            this.fetchFriendsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fetchFriendsButton.Location = new System.Drawing.Point(360, 25);
            this.fetchFriendsButton.Name = "fetchFriendsButton";
            this.fetchFriendsButton.Size = new System.Drawing.Size(121, 23);
            this.fetchFriendsButton.TabIndex = 5;
            this.fetchFriendsButton.Text = "Friends";
            this.fetchFriendsButton.UseVisualStyleBackColor = true;
            this.fetchFriendsButton.Click += new System.EventHandler(this.fetchFriendsButton_Click);
            // 
            // uploadPostButton
            // 
            this.uploadPostButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.uploadPostButton.Location = new System.Drawing.Point(505, 25);
            this.uploadPostButton.Name = "uploadPostButton";
            this.uploadPostButton.Size = new System.Drawing.Size(120, 23);
            this.uploadPostButton.TabIndex = 6;
            this.uploadPostButton.Text = "Upload a Post";
            this.uploadPostButton.UseVisualStyleBackColor = true;
            this.uploadPostButton.Click += new System.EventHandler(this.uploadPostButton_Click);
            // 
            // textBoxPostDetails
            // 
            this.textBoxPostDetails.Location = new System.Drawing.Point(505, 54);
            this.textBoxPostDetails.Name = "textBoxPostDetails";
            this.textBoxPostDetails.Size = new System.Drawing.Size(120, 20);
            this.textBoxPostDetails.TabIndex = 7;
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(505, 136);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(120, 95);
            this.listBoxLikes.TabIndex = 8;
            // 
            // myLikesButton
            // 
            this.myLikesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.myLikesButton.Location = new System.Drawing.Point(505, 107);
            this.myLikesButton.Name = "myLikesButton";
            this.myLikesButton.Size = new System.Drawing.Size(120, 23);
            this.myLikesButton.TabIndex = 9;
            this.myLikesButton.Text = "My Pages";
            this.myLikesButton.UseVisualStyleBackColor = true;
            this.myLikesButton.Click += new System.EventHandler(this.myLikesButton_Click);
            // 
            // fetchBestPostsButton
            // 
            this.fetchBestPostsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fetchBestPostsButton.Location = new System.Drawing.Point(214, 161);
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
            this.listBoxBestPosts.Location = new System.Drawing.Point(214, 217);
            this.listBoxBestPosts.Name = "listBoxBestPosts";
            this.listBoxBestPosts.Size = new System.Drawing.Size(120, 95);
            this.listBoxBestPosts.TabIndex = 11;
            // 
            // textBoxLikesLimit
            // 
            this.textBoxLikesLimit.Location = new System.Drawing.Point(214, 191);
            this.textBoxLikesLimit.Name = "textBoxLikesLimit";
            this.textBoxLikesLimit.Size = new System.Drawing.Size(120, 20);
            this.textBoxLikesLimit.TabIndex = 12;
            this.textBoxLikesLimit.Text = "Likes limit";
            // 
            // fetchSameMonthFriendsButton
            // 
            this.fetchSameMonthFriendsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fetchSameMonthFriendsButton.Location = new System.Drawing.Point(359, 161);
            this.fetchSameMonthFriendsButton.Name = "fetchSameMonthFriendsButton";
            this.fetchSameMonthFriendsButton.Size = new System.Drawing.Size(121, 23);
            this.fetchSameMonthFriendsButton.TabIndex = 13;
            this.fetchSameMonthFriendsButton.Text = "Friends by Month";
            this.fetchSameMonthFriendsButton.UseVisualStyleBackColor = true;
            this.fetchSameMonthFriendsButton.Click += new System.EventHandler(this.fetchSameMonthFriendsButton_Click);
            // 
            // listBoxSameMonthFriends
            // 
            this.listBoxSameMonthFriends.FormattingEnabled = true;
            this.listBoxSameMonthFriends.Location = new System.Drawing.Point(360, 217);
            this.listBoxSameMonthFriends.Name = "listBoxSameMonthFriends";
            this.listBoxSameMonthFriends.Size = new System.Drawing.Size(120, 95);
            this.listBoxSameMonthFriends.TabIndex = 14;
            // 
            // showAllLikesButton
            // 
            this.showAllLikesButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showAllLikesButton.Location = new System.Drawing.Point(214, 321);
            this.showAllLikesButton.Name = "showAllLikesButton";
            this.showAllLikesButton.Size = new System.Drawing.Size(120, 40);
            this.showAllLikesButton.TabIndex = 16;
            this.showAllLikesButton.Text = "Show All Likes";
            this.showAllLikesButton.UseVisualStyleBackColor = true;
            this.showAllLikesButton.Click += new System.EventHandler(this.showAllLikesButton_Click);
            // 
            // pickMonthComboBox
            // 
            this.pickMonthComboBox.FormattingEnabled = true;
            this.pickMonthComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.pickMonthComboBox.Location = new System.Drawing.Point(359, 190);
            this.pickMonthComboBox.Name = "pickMonthComboBox";
            this.pickMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.pickMonthComboBox.TabIndex = 17;
            // 
            // albumPhotosListBox
            // 
            this.albumPhotosListBox.FormattingEnabled = true;
            this.albumPhotosListBox.Location = new System.Drawing.Point(505, 267);
            this.albumPhotosListBox.Name = "albumPhotosListBox";
            this.albumPhotosListBox.Size = new System.Drawing.Size(120, 95);
            this.albumPhotosListBox.TabIndex = 18;
            this.albumPhotosListBox.SelectedIndexChanged += new System.EventHandler(this.albumPhotosListBox_SelectedIndexChanged);
            // 
            // fetchAllPhotosButton
            // 
            this.fetchAllPhotosButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.fetchAllPhotosButton.Location = new System.Drawing.Point(505, 238);
            this.fetchAllPhotosButton.Name = "fetchAllPhotosButton";
            this.fetchAllPhotosButton.Size = new System.Drawing.Size(120, 23);
            this.fetchAllPhotosButton.TabIndex = 19;
            this.fetchAllPhotosButton.Text = "All Pics";
            this.fetchAllPhotosButton.UseVisualStyleBackColor = true;
            this.fetchAllPhotosButton.Click += new System.EventHandler(this.fetchAllPhotosButton_Click);
            // 
            // openBirthdayGameButton
            // 
            this.openBirthdayGameButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openBirthdayGameButton.Location = new System.Drawing.Point(359, 321);
            this.openBirthdayGameButton.Name = "openBirthdayGameButton";
            this.openBirthdayGameButton.Size = new System.Drawing.Size(120, 40);
            this.openBirthdayGameButton.TabIndex = 20;
            this.openBirthdayGameButton.Text = "Open Birthday Game";
            this.openBirthdayGameButton.UseVisualStyleBackColor = true;
            this.openBirthdayGameButton.Click += new System.EventHandler(this.openBirthdayGameButton_Click);
            // 
            // MainFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(711, 386);
            this.Controls.Add(this.openBirthdayGameButton);
            this.Controls.Add(this.fetchAllPhotosButton);
            this.Controls.Add(this.albumPhotosListBox);
            this.Controls.Add(this.pickMonthComboBox);
            this.Controls.Add(this.showAllLikesButton);
            this.Controls.Add(FacebookLogoPictureBox);
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
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "MainFeedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.MainFeedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(FacebookLogoPictureBox)).EndInit();
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
        private System.Windows.Forms.Button showAllLikesButton;
        private System.Windows.Forms.ComboBox pickMonthComboBox;
        private System.Windows.Forms.ListBox albumPhotosListBox;
        private System.Windows.Forms.Button fetchAllPhotosButton;
        private System.Windows.Forms.Button openBirthdayGameButton;
    }
}