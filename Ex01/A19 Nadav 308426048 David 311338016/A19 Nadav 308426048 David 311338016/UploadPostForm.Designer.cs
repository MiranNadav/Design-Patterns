namespace A19_Nadav_308426048_David_311338016
{
    partial class UploadPostForm
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
            this.textBoxPostDetails = new System.Windows.Forms.TextBox();
            this.uploadPostTitleLabel = new System.Windows.Forms.Label();
            this.uploadPostButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxPostDetails
            // 
            this.textBoxPostDetails.Location = new System.Drawing.Point(237, 113);
            this.textBoxPostDetails.Multiline = true;
            this.textBoxPostDetails.Name = "textBoxPostDetails";
            this.textBoxPostDetails.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxPostDetails.Size = new System.Drawing.Size(299, 166);
            this.textBoxPostDetails.TabIndex = 8;
            // 
            // uploadPostTitleLabel
            // 
            this.uploadPostTitleLabel.AutoSize = true;
            this.uploadPostTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uploadPostTitleLabel.Location = new System.Drawing.Point(215, 49);
            this.uploadPostTitleLabel.Name = "uploadPostTitleLabel";
            this.uploadPostTitleLabel.Size = new System.Drawing.Size(365, 31);
            this.uploadPostTitleLabel.TabIndex = 10;
            this.uploadPostTitleLabel.Text = "Upload a new Facebook post";
            this.uploadPostTitleLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // uploadPostButton
            // 
            this.uploadPostButton.Location = new System.Drawing.Point(315, 333);
            this.uploadPostButton.Name = "uploadPostButton";
            this.uploadPostButton.Size = new System.Drawing.Size(156, 49);
            this.uploadPostButton.TabIndex = 11;
            this.uploadPostButton.Text = "Upload";
            this.uploadPostButton.UseVisualStyleBackColor = true;
            this.uploadPostButton.Click += new System.EventHandler(this.uploadPostButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(40, 49);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 31;
            this.backButton.Text = "<--  Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // UploadPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.uploadPostButton);
            this.Controls.Add(this.uploadPostTitleLabel);
            this.Controls.Add(this.textBoxPostDetails);
            this.Name = "UploadPostForm";
            this.Text = "Upload Post";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPostDetails;
        private System.Windows.Forms.Label uploadPostTitleLabel;
        private System.Windows.Forms.Button uploadPostButton;
        private System.Windows.Forms.Button backButton;
    }
}