namespace A19_Nadav_308426048_David_311338016
{
    partial class SearchForm
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
            this.textToFindTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxGroupsPostsFindings = new System.Windows.Forms.ListBox();
            this.listBoxEventsFindings = new System.Windows.Forms.ListBox();
            this.findRelevantSearchesButton = new System.Windows.Forms.Button();
            this.listBoxPagesFindings = new System.Windows.Forms.ListBox();
            this.listBoxFriendsPostsFindings = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.eventsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.pageFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.friendsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textToFindTextBox
            // 
            this.textToFindTextBox.Location = new System.Drawing.Point(140, 49);
            this.textToFindTextBox.Name = "textToFindTextBox";
            this.textToFindTextBox.Size = new System.Drawing.Size(225, 20);
            this.textToFindTextBox.TabIndex = 0;
            this.textToFindTextBox.TextChanged += new System.EventHandler(this.textToFindTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter free text to search";
            // 
            // listBoxGroupsPostsFindings
            // 
            this.listBoxGroupsPostsFindings.FormattingEnabled = true;
            this.listBoxGroupsPostsFindings.Location = new System.Drawing.Point(28, 134);
            this.listBoxGroupsPostsFindings.Name = "listBoxGroupsPostsFindings";
            this.listBoxGroupsPostsFindings.Size = new System.Drawing.Size(226, 173);
            this.listBoxGroupsPostsFindings.TabIndex = 2;
            // 
            // listBoxEventsFindings
            // 
            this.listBoxEventsFindings.FormattingEnabled = true;
            this.listBoxEventsFindings.Location = new System.Drawing.Point(272, 134);
            this.listBoxEventsFindings.Name = "listBoxEventsFindings";
            this.listBoxEventsFindings.Size = new System.Drawing.Size(226, 173);
            this.listBoxEventsFindings.TabIndex = 3;
            // 
            // findRelevantSearchesButton
            // 
            this.findRelevantSearchesButton.Location = new System.Drawing.Point(140, 76);
            this.findRelevantSearchesButton.Name = "findRelevantSearchesButton";
            this.findRelevantSearchesButton.Size = new System.Drawing.Size(225, 23);
            this.findRelevantSearchesButton.TabIndex = 4;
            this.findRelevantSearchesButton.Text = "Find All !!";
            this.findRelevantSearchesButton.UseVisualStyleBackColor = true;
            this.findRelevantSearchesButton.Click += new System.EventHandler(this.findRelevantSearchesButton_Click);
            // 
            // listBoxPagesFindings
            // 
            this.listBoxPagesFindings.FormattingEnabled = true;
            this.listBoxPagesFindings.Location = new System.Drawing.Point(272, 351);
            this.listBoxPagesFindings.Name = "listBoxPagesFindings";
            this.listBoxPagesFindings.Size = new System.Drawing.Size(226, 173);
            this.listBoxPagesFindings.TabIndex = 5;
            // 
            // listBoxFriendsPostsFindings
            // 
            this.listBoxFriendsPostsFindings.FormattingEnabled = true;
            this.listBoxFriendsPostsFindings.Location = new System.Drawing.Point(28, 351);
            this.listBoxFriendsPostsFindings.Name = "listBoxFriendsPostsFindings";
            this.listBoxFriendsPostsFindings.Size = new System.Drawing.Size(226, 173);
            this.listBoxFriendsPostsFindings.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Friends Posts Findings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Events Findings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 334);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Groups Findings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(293, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pages Findings";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(12, 12);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 30;
            this.backButton.Text = "<--  Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // eventsFindingsIncludeCheckBox
            // 
            this.eventsFindingsIncludeCheckBox.AutoSize = true;
            this.eventsFindingsIncludeCheckBox.Checked = true;
            this.eventsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventsFindingsIncludeCheckBox.Location = new System.Drawing.Point(272, 117);
            this.eventsFindingsIncludeCheckBox.Name = "eventsFindingsIncludeCheckBox";
            this.eventsFindingsIncludeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.eventsFindingsIncludeCheckBox.TabIndex = 31;
            this.eventsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // pageFindingsIncludeCheckBox
            // 
            this.pageFindingsIncludeCheckBox.AutoSize = true;
            this.pageFindingsIncludeCheckBox.Checked = true;
            this.pageFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pageFindingsIncludeCheckBox.Location = new System.Drawing.Point(272, 335);
            this.pageFindingsIncludeCheckBox.Name = "pageFindingsIncludeCheckBox";
            this.pageFindingsIncludeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.pageFindingsIncludeCheckBox.TabIndex = 32;
            this.pageFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupsFindingsIncludeCheckBox
            // 
            this.groupsFindingsIncludeCheckBox.AutoSize = true;
            this.groupsFindingsIncludeCheckBox.Checked = true;
            this.groupsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupsFindingsIncludeCheckBox.Location = new System.Drawing.Point(28, 335);
            this.groupsFindingsIncludeCheckBox.Name = "groupsFindingsIncludeCheckBox";
            this.groupsFindingsIncludeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.groupsFindingsIncludeCheckBox.TabIndex = 33;
            this.groupsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // friendsFindingsIncludeCheckBox
            // 
            this.friendsFindingsIncludeCheckBox.AutoSize = true;
            this.friendsFindingsIncludeCheckBox.Checked = true;
            this.friendsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.friendsFindingsIncludeCheckBox.Location = new System.Drawing.Point(28, 117);
            this.friendsFindingsIncludeCheckBox.Name = "friendsFindingsIncludeCheckBox";
            this.friendsFindingsIncludeCheckBox.Size = new System.Drawing.Size(15, 14);
            this.friendsFindingsIncludeCheckBox.TabIndex = 34;
            this.friendsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 542);
            this.Controls.Add(this.friendsFindingsIncludeCheckBox);
            this.Controls.Add(this.groupsFindingsIncludeCheckBox);
            this.Controls.Add(this.pageFindingsIncludeCheckBox);
            this.Controls.Add(this.eventsFindingsIncludeCheckBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxFriendsPostsFindings);
            this.Controls.Add(this.listBoxPagesFindings);
            this.Controls.Add(this.findRelevantSearchesButton);
            this.Controls.Add(this.listBoxEventsFindings);
            this.Controls.Add(this.listBoxGroupsPostsFindings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textToFindTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textToFindTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxGroupsPostsFindings;
        private System.Windows.Forms.ListBox listBoxEventsFindings;
        private System.Windows.Forms.Button findRelevantSearchesButton;
        private System.Windows.Forms.ListBox listBoxPagesFindings;
        private System.Windows.Forms.ListBox listBoxFriendsPostsFindings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.CheckBox eventsFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox pageFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox groupsFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox friendsFindingsIncludeCheckBox;
    }
}