namespace A19_Nadav_308426048_David_311338016
{
    partial class ReturnableForm
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
            this.components = new System.ComponentModel.Container();
            this.fadeTimer = new System.Windows.Forms.Timer(this.components);
            this.generalReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // 
            // generalReturnButton
            // 
            this.generalReturnButton.Location = new System.Drawing.Point(8, 8);
            this.generalReturnButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.generalReturnButton.Name = "generalReturnButton";
            this.generalReturnButton.Size = new System.Drawing.Size(66, 31);
            this.generalReturnButton.TabIndex = 0;
            this.generalReturnButton.Text = "<-- Back";
            this.generalReturnButton.UseVisualStyleBackColor = true;
            this.generalReturnButton.Click += new System.EventHandler(this.generalReturnButton_Click);
            // 
            // ReturnableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.generalReturnButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReturnableForm";
            this.Text = "ReturnableForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer fadeTimer;
        private System.Windows.Forms.Button generalReturnButton;
    }
}