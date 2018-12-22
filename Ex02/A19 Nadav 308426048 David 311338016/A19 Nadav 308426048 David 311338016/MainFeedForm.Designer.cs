namespace A19_Nadav_308426048_David_311338016
{
    public partial class MainFeedForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFeedForm));
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.uploadPostButton = new System.Windows.Forms.Button();
            this.listBoxLikes = new System.Windows.Forms.ListBox();
            this.fetchBestPostsButton = new System.Windows.Forms.Button();
            this.listBoxBestPosts = new System.Windows.Forms.ListBox();
            this.textBoxLikesLimit = new System.Windows.Forms.TextBox();
            this.fetchSameMonthFriendsButton = new System.Windows.Forms.Button();
            this.listBoxSameMonthFriends = new System.Windows.Forms.ListBox();
            this.showAllLikesButton = new System.Windows.Forms.Button();
            this.pickMonthComboBox = new System.Windows.Forms.ComboBox();
            this.openBirthdayGameButton = new System.Windows.Forms.Button();
            this.searchInAllFacebook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            this.openGalleryButton = new System.Windows.Forms.Button();
            this.forgetMeButton = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listBoxFriendsPosts = new System.Windows.Forms.ListBox();
            this.openAboutMeButton = new System.Windows.Forms.Button();
            FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FacebookLogoPictureBox
            // 
            FacebookLogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FacebookLogoPictureBox.Image")));
            FacebookLogoPictureBox.Location = new System.Drawing.Point(-3, 327);
            FacebookLogoPictureBox.Name = "FacebookLogoPictureBox";
            FacebookLogoPictureBox.Size = new System.Drawing.Size(170, 150);
            FacebookLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            FacebookLogoPictureBox.TabIndex = 15;
            FacebookLogoPictureBox.TabStop = false;
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
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.Location = new System.Drawing.Point(225, 54);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(263, 121);
            this.listBoxPosts.TabIndex = 2;
            // 
            // listViewFriends
            // 
            this.listViewFriends.Location = new System.Drawing.Point(792, 54);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(103, 184);
            this.listViewFriends.TabIndex = 4;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // uploadPostButton
            // 
            this.uploadPostButton.BackColor = System.Drawing.Color.DimGray;
            this.uploadPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadPostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPostButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadPostButton.Location = new System.Drawing.Point(226, 190);
            this.uploadPostButton.Name = "uploadPostButton";
            this.uploadPostButton.Size = new System.Drawing.Size(262, 50);
            this.uploadPostButton.TabIndex = 6;
            this.uploadPostButton.Text = "Upload a Post";
            this.uploadPostButton.UseVisualStyleBackColor = false;
            this.uploadPostButton.Click += new System.EventHandler(this.uploadPostButton_Click);
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(651, 54);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(126, 186);
            this.listBoxLikes.TabIndex = 8;
            // 
            // fetchBestPostsButton
            // 
            this.fetchBestPostsButton.BackColor = System.Drawing.Color.DimGray;
            this.fetchBestPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchBestPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchBestPostsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fetchBestPostsButton.Location = new System.Drawing.Point(229, 274);
            this.fetchBestPostsButton.Name = "fetchBestPostsButton";
            this.fetchBestPostsButton.Size = new System.Drawing.Size(120, 23);
            this.fetchBestPostsButton.TabIndex = 10;
            this.fetchBestPostsButton.Text = "Show best Posts";
            this.fetchBestPostsButton.UseVisualStyleBackColor = false;
            this.fetchBestPostsButton.Click += new System.EventHandler(this.fetchBestPostsButton_Click);
            // 
            // listBoxBestPosts
            // 
            this.listBoxBestPosts.FormattingEnabled = true;
            this.listBoxBestPosts.Location = new System.Drawing.Point(229, 330);
            this.listBoxBestPosts.Name = "listBoxBestPosts";
            this.listBoxBestPosts.Size = new System.Drawing.Size(120, 147);
            this.listBoxBestPosts.TabIndex = 11;
            // 
            // textBoxLikesLimit
            // 
            this.textBoxLikesLimit.Location = new System.Drawing.Point(229, 304);
            this.textBoxLikesLimit.Name = "textBoxLikesLimit";
            this.textBoxLikesLimit.Size = new System.Drawing.Size(120, 20);
            this.textBoxLikesLimit.TabIndex = 12;
            this.textBoxLikesLimit.Text = "Likes limit";
            // 
            // fetchSameMonthFriendsButton
            // 
            this.fetchSameMonthFriendsButton.BackColor = System.Drawing.Color.DimGray;
            this.fetchSameMonthFriendsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchSameMonthFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchSameMonthFriendsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fetchSameMonthFriendsButton.Location = new System.Drawing.Point(355, 274);
            this.fetchSameMonthFriendsButton.Name = "fetchSameMonthFriendsButton";
            this.fetchSameMonthFriendsButton.Size = new System.Drawing.Size(121, 23);
            this.fetchSameMonthFriendsButton.TabIndex = 13;
            this.fetchSameMonthFriendsButton.Text = "Friends by Month";
            this.fetchSameMonthFriendsButton.UseVisualStyleBackColor = false;
            this.fetchSameMonthFriendsButton.Click += new System.EventHandler(this.fetchSameMonthFriendsButton_Click);
            // 
            // listBoxSameMonthFriends
            // 
            this.listBoxSameMonthFriends.FormattingEnabled = true;
            this.listBoxSameMonthFriends.Location = new System.Drawing.Point(356, 330);
            this.listBoxSameMonthFriends.Name = "listBoxSameMonthFriends";
            this.listBoxSameMonthFriends.Size = new System.Drawing.Size(120, 147);
            this.listBoxSameMonthFriends.TabIndex = 14;
            // 
            // showAllLikesButton
            // 
            this.showAllLikesButton.BackColor = System.Drawing.Color.DimGray;
            this.showAllLikesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showAllLikesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showAllLikesButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showAllLikesButton.Location = new System.Drawing.Point(33, 270);
            this.showAllLikesButton.Name = "showAllLikesButton";
            this.showAllLikesButton.Size = new System.Drawing.Size(146, 45);
            this.showAllLikesButton.TabIndex = 16;
            this.showAllLikesButton.Text = "Show total amount of Likes";
            this.showAllLikesButton.UseVisualStyleBackColor = false;
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
            this.pickMonthComboBox.Location = new System.Drawing.Point(355, 303);
            this.pickMonthComboBox.Name = "pickMonthComboBox";
            this.pickMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.pickMonthComboBox.TabIndex = 17;
            // 
            // openBirthdayGameButton
            // 
            this.openBirthdayGameButton.BackColor = System.Drawing.Color.DimGray;
            this.openBirthdayGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBirthdayGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBirthdayGameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openBirthdayGameButton.Location = new System.Drawing.Point(33, 190);
            this.openBirthdayGameButton.Name = "openBirthdayGameButton";
            this.openBirthdayGameButton.Size = new System.Drawing.Size(146, 34);
            this.openBirthdayGameButton.TabIndex = 20;
            this.openBirthdayGameButton.Text = "Open Birthday Game";
            this.openBirthdayGameButton.UseVisualStyleBackColor = false;
            this.openBirthdayGameButton.Click += new System.EventHandler(this.openBirthdayGameButton_Click);
            // 
            // searchInAllFacebook
            // 
            this.searchInAllFacebook.BackColor = System.Drawing.Color.DimGray;
            this.searchInAllFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchInAllFacebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInAllFacebook.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.searchInAllFacebook.Location = new System.Drawing.Point(33, 230);
            this.searchInAllFacebook.Name = "searchInAllFacebook";
            this.searchInAllFacebook.Size = new System.Drawing.Size(146, 34);
            this.searchInAllFacebook.TabIndex = 21;
            this.searchInAllFacebook.Text = "Multi Element Search!";
            this.searchInAllFacebook.UseVisualStyleBackColor = false;
            this.searchInAllFacebook.Click += new System.EventHandler(this.searchInAllFacebook_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(222, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "My Posts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(788, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Friends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(648, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Liked Pages";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(789, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "My Pics";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(45, 80);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(112, 95);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // openGalleryButton
            // 
            this.openGalleryButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.openGalleryButton.BackColor = System.Drawing.Color.DimGray;
            this.openGalleryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.openGalleryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.openGalleryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openGalleryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openGalleryButton.Location = new System.Drawing.Point(792, 291);
            this.openGalleryButton.Name = "openGalleryButton";
            this.openGalleryButton.Size = new System.Drawing.Size(96, 69);
            this.openGalleryButton.TabIndex = 26;
            this.openGalleryButton.Text = "Open Gallery";
            this.openGalleryButton.UseVisualStyleBackColor = false;
            this.openGalleryButton.Click += new System.EventHandler(this.openGalleryButton_Click);
            // 
            // forgetMeButton
            // 
            this.forgetMeButton.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.forgetMeButton.BackColor = System.Drawing.Color.DimGray;
            this.forgetMeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.forgetMeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.forgetMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgetMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgetMeButton.Location = new System.Drawing.Point(54, 45);
            this.forgetMeButton.Name = "forgetMeButton";
            this.forgetMeButton.Size = new System.Drawing.Size(95, 23);
            this.forgetMeButton.TabIndex = 27;
            this.forgetMeButton.Text = "Forget Me";
            this.forgetMeButton.UseVisualStyleBackColor = false;
            this.forgetMeButton.Click += new System.EventHandler(this.forgetMeButton_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(511, 54);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(126, 186);
            this.listBoxEvents.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(509, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Events";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(508, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Groups";
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(511, 291);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(126, 186);
            this.listBoxGroups.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(648, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Friends Posts";
            // 
            // listBoxFriendsPosts
            // 
            this.listBoxFriendsPosts.FormattingEnabled = true;
            this.listBoxFriendsPosts.Location = new System.Drawing.Point(651, 291);
            this.listBoxFriendsPosts.Name = "listBoxFriendsPosts";
            this.listBoxFriendsPosts.Size = new System.Drawing.Size(126, 186);
            this.listBoxFriendsPosts.TabIndex = 33;
            // 
            // openAboutMeButton
            // 
            this.openAboutMeButton.BackColor = System.Drawing.Color.DimGray;
            this.openAboutMeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openAboutMeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openAboutMeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openAboutMeButton.Location = new System.Drawing.Point(33, 321);
            this.openAboutMeButton.Name = "openAboutMeButton";
            this.openAboutMeButton.Size = new System.Drawing.Size(146, 34);
            this.openAboutMeButton.TabIndex = 35;
            this.openAboutMeButton.Text = "About ME";
            this.openAboutMeButton.UseVisualStyleBackColor = false;
            this.openAboutMeButton.Click += new System.EventHandler(this.openAboutMeButton_Click);
            // 
            // MainFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(917, 481);
            this.Controls.Add(this.openAboutMeButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBoxFriendsPosts);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listBoxGroups);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.forgetMeButton);
            this.Controls.Add(this.openGalleryButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInAllFacebook);
            this.Controls.Add(this.openBirthdayGameButton);
            this.Controls.Add(this.pickMonthComboBox);
            this.Controls.Add(this.showAllLikesButton);
            this.Controls.Add(FacebookLogoPictureBox);
            this.Controls.Add(this.listBoxSameMonthFriends);
            this.Controls.Add(this.fetchSameMonthFriendsButton);
            this.Controls.Add(this.textBoxLikesLimit);
            this.Controls.Add(this.listBoxBestPosts);
            this.Controls.Add(this.fetchBestPostsButton);
            this.Controls.Add(this.listBoxLikes);
            this.Controls.Add(this.uploadPostButton);
            this.Controls.Add(this.listViewFriends);
            this.Controls.Add(this.listBoxPosts);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.ProfilePictureBox);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.ListView listViewFriends;
        private System.Windows.Forms.Button uploadPostButton;
        private System.Windows.Forms.ListBox listBoxLikes;
        private System.Windows.Forms.Button fetchBestPostsButton;
        private System.Windows.Forms.ListBox listBoxBestPosts;
        private System.Windows.Forms.TextBox textBoxLikesLimit;
        private System.Windows.Forms.Button fetchSameMonthFriendsButton;
        private System.Windows.Forms.ListBox listBoxSameMonthFriends;
        private System.Windows.Forms.Button showAllLikesButton;
        private System.Windows.Forms.ComboBox pickMonthComboBox;
        private System.Windows.Forms.Button openBirthdayGameButton;
        private System.Windows.Forms.Button searchInAllFacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button openGalleryButton;
        private System.Windows.Forms.Button forgetMeButton;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listBoxFriendsPosts;
        private System.Windows.Forms.Button openAboutMeButton;
    }
}