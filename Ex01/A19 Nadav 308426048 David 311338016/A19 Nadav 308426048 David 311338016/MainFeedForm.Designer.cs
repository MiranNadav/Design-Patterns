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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.listViewFriends = new System.Windows.Forms.ListView();
            this.uploadPostButton = new System.Windows.Forms.Button();
            this.textBoxPostDetails = new System.Windows.Forms.TextBox();
            this.listBoxLikes = new System.Windows.Forms.ListBox();
            this.fetchBestPostsButton = new System.Windows.Forms.Button();
            this.listBoxBestPosts = new System.Windows.Forms.ListBox();
            this.textBoxLikesLimit = new System.Windows.Forms.TextBox();
            this.fetchSameMonthFriendsButton = new System.Windows.Forms.Button();
            this.listBoxSameMonthFriends = new System.Windows.Forms.ListBox();
            this.showAllLikesButton = new System.Windows.Forms.Button();
            this.pickMonthComboBox = new System.Windows.Forms.ComboBox();
            this.albumPhotosListBox = new System.Windows.Forms.ListBox();
            this.openBirthdayGameButton = new System.Windows.Forms.Button();
            this.searchInAllFacebook = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.ProfilePictureBox = new System.Windows.Forms.PictureBox();
            FacebookLogoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(FacebookLogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FacebookLogoPictureBox
            // 
            FacebookLogoPictureBox.Image = global::A19_Nadav_308426048_David_311338016.Properties.Resources.facebook1;
            FacebookLogoPictureBox.Location = new System.Drawing.Point(534, 231);
            FacebookLogoPictureBox.Name = "FacebookLogoPictureBox";
            FacebookLogoPictureBox.Size = new System.Drawing.Size(209, 187);
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
            this.listBoxPosts.Location = new System.Drawing.Point(214, 54);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(120, 147);
            this.listBoxPosts.TabIndex = 2;
            // 
            // listViewFriends
            // 
            this.listViewFriends.Location = new System.Drawing.Point(360, 54);
            this.listViewFriends.Name = "listViewFriends";
            this.listViewFriends.Size = new System.Drawing.Size(121, 147);
            this.listViewFriends.TabIndex = 4;
            this.listViewFriends.UseCompatibleStateImageBehavior = false;
            // 
            // uploadPostButton
            // 
            this.uploadPostButton.BackColor = System.Drawing.Color.DimGray;
            this.uploadPostButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadPostButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPostButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.uploadPostButton.Location = new System.Drawing.Point(35, 161);
            this.uploadPostButton.Name = "uploadPostButton";
            this.uploadPostButton.Size = new System.Drawing.Size(146, 23);
            this.uploadPostButton.TabIndex = 6;
            this.uploadPostButton.Text = "Upload a Post";
            this.uploadPostButton.UseVisualStyleBackColor = false;
            this.uploadPostButton.Click += new System.EventHandler(this.uploadPostButton_Click);
            // 
            // textBoxPostDetails
            // 
            this.textBoxPostDetails.Location = new System.Drawing.Point(35, 190);
            this.textBoxPostDetails.Multiline = true;
            this.textBoxPostDetails.Name = "textBoxPostDetails";
            this.textBoxPostDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPostDetails.Size = new System.Drawing.Size(146, 109);
            this.textBoxPostDetails.TabIndex = 7;
            // 
            // listBoxLikes
            // 
            this.listBoxLikes.FormattingEnabled = true;
            this.listBoxLikes.Location = new System.Drawing.Point(505, 54);
            this.listBoxLikes.Name = "listBoxLikes";
            this.listBoxLikes.Size = new System.Drawing.Size(120, 147);
            this.listBoxLikes.TabIndex = 8;
            // 
            // fetchBestPostsButton
            // 
            this.fetchBestPostsButton.BackColor = System.Drawing.Color.DimGray;
            this.fetchBestPostsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fetchBestPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fetchBestPostsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fetchBestPostsButton.Location = new System.Drawing.Point(214, 215);
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
            this.listBoxBestPosts.Location = new System.Drawing.Point(214, 271);
            this.listBoxBestPosts.Name = "listBoxBestPosts";
            this.listBoxBestPosts.Size = new System.Drawing.Size(120, 147);
            this.listBoxBestPosts.TabIndex = 11;
            // 
            // textBoxLikesLimit
            // 
            this.textBoxLikesLimit.Location = new System.Drawing.Point(214, 245);
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
            this.fetchSameMonthFriendsButton.Location = new System.Drawing.Point(359, 215);
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
            this.listBoxSameMonthFriends.Location = new System.Drawing.Point(360, 271);
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
            this.showAllLikesButton.Location = new System.Drawing.Point(35, 386);
            this.showAllLikesButton.Name = "showAllLikesButton";
            this.showAllLikesButton.Size = new System.Drawing.Size(146, 34);
            this.showAllLikesButton.TabIndex = 16;
            this.showAllLikesButton.Text = "Show All Likes";
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
            this.pickMonthComboBox.Location = new System.Drawing.Point(359, 244);
            this.pickMonthComboBox.Name = "pickMonthComboBox";
            this.pickMonthComboBox.Size = new System.Drawing.Size(121, 21);
            this.pickMonthComboBox.TabIndex = 17;
            // 
            // albumPhotosListBox
            // 
            this.albumPhotosListBox.FormattingEnabled = true;
            this.albumPhotosListBox.Location = new System.Drawing.Point(647, 54);
            this.albumPhotosListBox.Name = "albumPhotosListBox";
            this.albumPhotosListBox.Size = new System.Drawing.Size(120, 147);
            this.albumPhotosListBox.TabIndex = 18;
            // 
            // openBirthdayGameButton
            // 
            this.openBirthdayGameButton.BackColor = System.Drawing.Color.DimGray;
            this.openBirthdayGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openBirthdayGameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openBirthdayGameButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.openBirthdayGameButton.Location = new System.Drawing.Point(35, 345);
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
            this.searchInAllFacebook.Location = new System.Drawing.Point(35, 305);
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
            this.label1.Location = new System.Drawing.Point(211, 30);
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
            this.label2.Location = new System.Drawing.Point(356, 30);
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
            this.label3.Location = new System.Drawing.Point(502, 30);
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
            this.label4.Location = new System.Drawing.Point(644, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "My Pics";
            // 
            // ProfilePictureBox
            // 
            this.ProfilePictureBox.Location = new System.Drawing.Point(45, 35);
            this.ProfilePictureBox.Name = "ProfilePictureBox";
            this.ProfilePictureBox.Size = new System.Drawing.Size(112, 95);
            this.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePictureBox.TabIndex = 0;
            this.ProfilePictureBox.TabStop = false;
            // 
            // MainFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(786, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchInAllFacebook);
            this.Controls.Add(this.openBirthdayGameButton);
            this.Controls.Add(this.albumPhotosListBox);
            this.Controls.Add(this.pickMonthComboBox);
            this.Controls.Add(this.showAllLikesButton);
            this.Controls.Add(FacebookLogoPictureBox);
            this.Controls.Add(this.listBoxSameMonthFriends);
            this.Controls.Add(this.fetchSameMonthFriendsButton);
            this.Controls.Add(this.textBoxLikesLimit);
            this.Controls.Add(this.listBoxBestPosts);
            this.Controls.Add(this.fetchBestPostsButton);
            this.Controls.Add(this.listBoxLikes);
            this.Controls.Add(this.textBoxPostDetails);
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
        private System.Windows.Forms.TextBox textBoxPostDetails;
        private System.Windows.Forms.ListBox listBoxLikes;
        private System.Windows.Forms.Button fetchBestPostsButton;
        private System.Windows.Forms.ListBox listBoxBestPosts;
        private System.Windows.Forms.TextBox textBoxLikesLimit;
        private System.Windows.Forms.Button fetchSameMonthFriendsButton;
        private System.Windows.Forms.ListBox listBoxSameMonthFriends;
        private System.Windows.Forms.Button showAllLikesButton;
        private System.Windows.Forms.ComboBox pickMonthComboBox;
        private System.Windows.Forms.ListBox albumPhotosListBox;
        private System.Windows.Forms.Button openBirthdayGameButton;
        private System.Windows.Forms.Button searchInAllFacebook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}