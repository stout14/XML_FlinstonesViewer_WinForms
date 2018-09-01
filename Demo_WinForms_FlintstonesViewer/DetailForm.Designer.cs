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
            this.txtBox_FirstName = new System.Windows.Forms.TextBox();
            this.txtBox_LastName = new System.Windows.Forms.TextBox();
            this.txtBox_Age = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_FirstName
            // 
            this.txtBox_FirstName.Location = new System.Drawing.Point(32, 36);
            this.txtBox_FirstName.Name = "txtBox_FirstName";
            this.txtBox_FirstName.Size = new System.Drawing.Size(100, 22);
            this.txtBox_FirstName.TabIndex = 0;
            // 
            // txtBox_LastName
            // 
            this.txtBox_LastName.Location = new System.Drawing.Point(32, 64);
            this.txtBox_LastName.Name = "txtBox_LastName";
            this.txtBox_LastName.Size = new System.Drawing.Size(100, 22);
            this.txtBox_LastName.TabIndex = 1;
            // 
            // txtBox_Age
            // 
            this.txtBox_Age.Location = new System.Drawing.Point(32, 93);
            this.txtBox_Age.Name = "txtBox_Age";
            this.txtBox_Age.Size = new System.Drawing.Size(100, 22);
            this.txtBox_Age.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(76, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // DetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtBox_Age);
            this.Controls.Add(this.txtBox_LastName);
            this.Controls.Add(this.txtBox_FirstName);
            this.Name = "DetailForm";
            this.Text = "DetailForm";
            this.Load += new System.EventHandler(this.DetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox_FirstName;
        private System.Windows.Forms.TextBox txtBox_LastName;
        private System.Windows.Forms.TextBox txtBox_Age;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}