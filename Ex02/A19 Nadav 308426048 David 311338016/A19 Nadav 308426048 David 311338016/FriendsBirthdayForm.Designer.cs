namespace A19_Nadav_308426048_David_311338016
{
    public partial class FriendsBirthdayForm
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
            this.FriendNameTextBox = new System.Windows.Forms.TextBox();
            this.checkIfCorrectBirthdayButton = new System.Windows.Forms.Button();
            this.friendRandomGeneratorButton = new System.Windows.Forms.Button();
            this.birthDatePickTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FriendNameTextBox
            // 
            this.FriendNameTextBox.Location = new System.Drawing.Point(18, 118);
            this.FriendNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FriendNameTextBox.Name = "FriendNameTextBox";
            this.FriendNameTextBox.Size = new System.Drawing.Size(379, 26);
            this.FriendNameTextBox.TabIndex = 27;
            // 
            // checkIfCorrectBirthdayButton
            // 
            this.checkIfCorrectBirthdayButton.Location = new System.Drawing.Point(18, 229);
            this.checkIfCorrectBirthdayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkIfCorrectBirthdayButton.Name = "checkIfCorrectBirthdayButton";
            this.checkIfCorrectBirthdayButton.Size = new System.Drawing.Size(381, 35);
            this.checkIfCorrectBirthdayButton.TabIndex = 26;
            this.checkIfCorrectBirthdayButton.Text = "Check if you are right!";
            this.checkIfCorrectBirthdayButton.UseVisualStyleBackColor = true;
            this.checkIfCorrectBirthdayButton.Click += new System.EventHandler(this.checkIfCorrectBirthdayButton_Click);
            // 
            // friendRandomGeneratorButton
            // 
            this.friendRandomGeneratorButton.Location = new System.Drawing.Point(18, 74);
            this.friendRandomGeneratorButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.friendRandomGeneratorButton.Name = "friendRandomGeneratorButton";
            this.friendRandomGeneratorButton.Size = new System.Drawing.Size(381, 35);
            this.friendRandomGeneratorButton.TabIndex = 25;
            this.friendRandomGeneratorButton.Text = "Generate a friend";
            this.friendRandomGeneratorButton.UseVisualStyleBackColor = true;
            this.friendRandomGeneratorButton.Click += new System.EventHandler(this.friendRandomGeneratorButton_Click);
            // 
            // birthDatePickTime
            // 
            this.birthDatePickTime.Location = new System.Drawing.Point(18, 189);
            this.birthDatePickTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.birthDatePickTime.Name = "birthDatePickTime";
            this.birthDatePickTime.Size = new System.Drawing.Size(379, 26);
            this.birthDatePickTime.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "Please Enter your friends birthday:";
            // 
            // FriendsBirthdayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 282);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FriendNameTextBox);
            this.Controls.Add(this.checkIfCorrectBirthdayButton);
            this.Controls.Add(this.friendRandomGeneratorButton);
            this.Controls.Add(this.birthDatePickTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FriendsBirthdayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FriendsBirthdayForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FriendNameTextBox;
        private System.Windows.Forms.Button checkIfCorrectBirthdayButton;
        private System.Windows.Forms.Button friendRandomGeneratorButton;
        private System.Windows.Forms.DateTimePicker birthDatePickTime;
        private System.Windows.Forms.Label label1;
    }
}