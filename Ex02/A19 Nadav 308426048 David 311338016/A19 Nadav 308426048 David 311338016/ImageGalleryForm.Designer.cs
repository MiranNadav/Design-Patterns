namespace A19_Nadav_308426048_David_311338016
{
    public partial class ImageGalleryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // albumsListComboBox
            // 
            this.albumsListComboBox.FormattingEnabled = true;
            this.albumsListComboBox.Location = new System.Drawing.Point(192, 66);
            this.albumsListComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.albumsListComboBox.Name = "albumsListComboBox";
            this.albumsListComboBox.Size = new System.Drawing.Size(355, 28);
            this.albumsListComboBox.TabIndex = 0;
            this.albumsListComboBox.SelectedIndexChanged += new System.EventHandler(this.albumsListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pick an Album";
            // 
            // ImageGalleryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(776, 514);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumsListComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ImageGalleryForm";
            this.Text = "ImageGallery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox albumsListComboBox;
        private System.Windows.Forms.Label label1;
    }
}