namespace Demo_WinForms_FlintstonesViewer
{
    partial class DetailForm
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
            this.picBox_Photo = new System.Windows.Forms.PictureBox();
            this.lbl_FullName = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_Photo
            // 
            this.picBox_Photo.Location = new System.Drawing.Point(21, 72);
            this.picBox_Photo.Name = "picBox_Photo";
            this.picBox_Photo.Size = new System.Drawing.Size(137, 110);
            this.picBox_Photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Photo.TabIndex = 3;
            this.picBox_Photo.TabStop = false;
            // 
            // lbl_FullName
            // 
            this.lbl_FullName.AutoSize = true;
            this.lbl_FullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FullName.Location = new System.Drawing.Point(126, 21);
            this.lbl_FullName.Name = "lbl_FullName";
            this.lbl_FullName.Size = new System.Drawing.Size(137, 31);
            this.lbl_FullName.TabIndex = 4;
            this.lbl_FullName.Text = "Full Name";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(195, 95);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(33, 17);
            this.lbl_Age.TabIndex = 5;
            this.lbl_Age.Text = "Age";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(198, 130);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(56, 17);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender";
            // 
            // lbl_Description
            // 
            this.lbl_Description.Location = new System.Drawing.Point(26, 199);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(340, 112);
            this.lbl_Description.TabIndex = 7;
            this.lbl_Description.Text = "Description";
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 347);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Age);
            this.Controls.Add(this.lbl_FullName);
            this.Controls.Add(this.picBox_Photo);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox_Photo;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Description;
    }
}