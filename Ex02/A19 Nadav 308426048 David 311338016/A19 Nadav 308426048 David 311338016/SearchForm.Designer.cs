namespace A19_Nadav_308426048_David_311338016
{
    public partial class SearchForm
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
            this.eventsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.pageFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.groupsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.friendsFindingsIncludeCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textToFindTextBox
            // 
            this.textToFindTextBox.Location = new System.Drawing.Point(210, 75);
            this.textToFindTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textToFindTextBox.Name = "textToFindTextBox";
            this.textToFindTextBox.Size = new System.Drawing.Size(336, 26);
            this.textToFindTextBox.TabIndex = 0;
            this.textToFindTextBox.TextChanged += new System.EventHandler(this.textToFindTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter free text to search";
            // 
            // listBoxGroupsPostsFindings
            // 
            this.listBoxGroupsPostsFindings.FormattingEnabled = true;
            this.listBoxGroupsPostsFindings.ItemHeight = 20;
            this.listBoxGroupsPostsFindings.Location = new System.Drawing.Point(42, 206);
            this.listBoxGroupsPostsFindings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxGroupsPostsFindings.Name = "listBoxGroupsPostsFindings";
            this.listBoxGroupsPostsFindings.Size = new System.Drawing.Size(337, 264);
            this.listBoxGroupsPostsFindings.TabIndex = 2;
            // 
            // listBoxEventsFindings
            // 
            this.listBoxEventsFindings.FormattingEnabled = true;
            this.listBoxEventsFindings.ItemHeight = 20;
            this.listBoxEventsFindings.Location = new System.Drawing.Point(408, 206);
            this.listBoxEventsFindings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxEventsFindings.Name = "listBoxEventsFindings";
            this.listBoxEventsFindings.Size = new System.Drawing.Size(337, 264);
            this.listBoxEventsFindings.TabIndex = 3;
            // 
            // findRelevantSearchesButton
            // 
            this.findRelevantSearchesButton.Location = new System.Drawing.Point(210, 117);
            this.findRelevantSearchesButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.findRelevantSearchesButton.Name = "findRelevantSearchesButton";
            this.findRelevantSearchesButton.Size = new System.Drawing.Size(338, 35);
            this.findRelevantSearchesButton.TabIndex = 4;
            this.findRelevantSearchesButton.Text = "Find All !!";
            this.findRelevantSearchesButton.UseVisualStyleBackColor = true;
            this.findRelevantSearchesButton.Click += new System.EventHandler(this.findRelevantSearchesButton_Click);
            // 
            // listBoxPagesFindings
            // 
            this.listBoxPagesFindings.FormattingEnabled = true;
            this.listBoxPagesFindings.ItemHeight = 20;
            this.listBoxPagesFindings.Location = new System.Drawing.Point(408, 540);
            this.listBoxPagesFindings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxPagesFindings.Name = "listBoxPagesFindings";
            this.listBoxPagesFindings.Size = new System.Drawing.Size(337, 264);
            this.listBoxPagesFindings.TabIndex = 5;
            // 
            // listBoxFriendsPostsFindings
            // 
            this.listBoxFriendsPostsFindings.FormattingEnabled = true;
            this.listBoxFriendsPostsFindings.ItemHeight = 20;
            this.listBoxFriendsPostsFindings.Location = new System.Drawing.Point(42, 540);
            this.listBoxFriendsPostsFindings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxFriendsPostsFindings.Name = "listBoxFriendsPostsFindings";
            this.listBoxFriendsPostsFindings.Size = new System.Drawing.Size(337, 264);
            this.listBoxFriendsPostsFindings.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Friends Posts Findings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(440, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Events Findings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 514);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Groups Findings";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(440, 514);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pages Findings";
            // 
            // eventsFindingsIncludeCheckBox
            // 
            this.eventsFindingsIncludeCheckBox.AutoSize = true;
            this.eventsFindingsIncludeCheckBox.Checked = true;
            this.eventsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.eventsFindingsIncludeCheckBox.Location = new System.Drawing.Point(408, 180);
            this.eventsFindingsIncludeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.eventsFindingsIncludeCheckBox.Name = "eventsFindingsIncludeCheckBox";
            this.eventsFindingsIncludeCheckBox.Size = new System.Drawing.Size(22, 21);
            this.eventsFindingsIncludeCheckBox.TabIndex = 31;
            this.eventsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // pageFindingsIncludeCheckBox
            // 
            this.pageFindingsIncludeCheckBox.AutoSize = true;
            this.pageFindingsIncludeCheckBox.Checked = true;
            this.pageFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pageFindingsIncludeCheckBox.Location = new System.Drawing.Point(408, 515);
            this.pageFindingsIncludeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pageFindingsIncludeCheckBox.Name = "pageFindingsIncludeCheckBox";
            this.pageFindingsIncludeCheckBox.Size = new System.Drawing.Size(22, 21);
            this.pageFindingsIncludeCheckBox.TabIndex = 32;
            this.pageFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupsFindingsIncludeCheckBox
            // 
            this.groupsFindingsIncludeCheckBox.AutoSize = true;
            this.groupsFindingsIncludeCheckBox.Checked = true;
            this.groupsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.groupsFindingsIncludeCheckBox.Location = new System.Drawing.Point(42, 515);
            this.groupsFindingsIncludeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupsFindingsIncludeCheckBox.Name = "groupsFindingsIncludeCheckBox";
            this.groupsFindingsIncludeCheckBox.Size = new System.Drawing.Size(22, 21);
            this.groupsFindingsIncludeCheckBox.TabIndex = 33;
            this.groupsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // friendsFindingsIncludeCheckBox
            // 
            this.friendsFindingsIncludeCheckBox.AutoSize = true;
            this.friendsFindingsIncludeCheckBox.Checked = true;
            this.friendsFindingsIncludeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.friendsFindingsIncludeCheckBox.Location = new System.Drawing.Point(42, 180);
            this.friendsFindingsIncludeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendsFindingsIncludeCheckBox.Name = "friendsFindingsIncludeCheckBox";
            this.friendsFindingsIncludeCheckBox.Size = new System.Drawing.Size(22, 21);
            this.friendsFindingsIncludeCheckBox.TabIndex = 34;
            this.friendsFindingsIncludeCheckBox.UseVisualStyleBackColor = true;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 834);
            this.Controls.Add(this.friendsFindingsIncludeCheckBox);
            this.Controls.Add(this.groupsFindingsIncludeCheckBox);
            this.Controls.Add(this.pageFindingsIncludeCheckBox);
            this.Controls.Add(this.eventsFindingsIncludeCheckBox);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchForm";
            this.Text = "SearchForm";
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
        private System.Windows.Forms.CheckBox eventsFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox pageFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox groupsFindingsIncludeCheckBox;
        private System.Windows.Forms.CheckBox friendsFindingsIncludeCheckBox;
    }
}