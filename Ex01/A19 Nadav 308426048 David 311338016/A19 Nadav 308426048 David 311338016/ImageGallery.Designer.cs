namespace A19_Nadav_308426048_David_311338016
{
    partial class ImageGallery
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
            this.albumsListComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // albumsListComboBox
            // 
            this.albumsListComboBox.FormattingEnabled = true;
            this.albumsListComboBox.Location = new System.Drawing.Point(25, 31);
            this.albumsListComboBox.Name = "albumsListComboBox";
            this.albumsListComboBox.Size = new System.Drawing.Size(238, 21);
            this.albumsListComboBox.TabIndex = 0;
            this.albumsListComboBox.SelectedIndexChanged += new System.EventHandler(this.albumsListComboBox_SelectedIndexChanged);
            // 
            // ImageGallery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 450);
            this.Controls.Add(this.albumsListComboBox);
            this.Name = "ImageGallery";
            this.Text = "ImageGallery";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox albumsListComboBox;
    }
}