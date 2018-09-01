namespace Demo_WinForms_FlintstonesViewer
{
    partial class Form1
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
            this.dataGridView_People = new System.Windows.Forms.DataGridView();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.btn_DetailView = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_People)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_People
            // 
            this.dataGridView_People.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_People.Location = new System.Drawing.Point(12, 12);
            this.dataGridView_People.Name = "dataGridView_People";
            this.dataGridView_People.RowTemplate.Height = 24;
            this.dataGridView_People.Size = new System.Drawing.Size(449, 229);
            this.dataGridView_People.TabIndex = 0;
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.Location = new System.Drawing.Point(499, 12);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(113, 45);
            this.btn_DeleteSelected.TabIndex = 1;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = true;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_CheckList_Click);
            // 
            // btn_DetailView
            // 
            this.btn_DetailView.Location = new System.Drawing.Point(503, 75);
            this.btn_DetailView.Name = "btn_DetailView";
            this.btn_DetailView.Size = new System.Drawing.Size(108, 48);
            this.btn_DetailView.TabIndex = 2;
            this.btn_DetailView.Text = "View Detail";
            this.btn_DetailView.UseVisualStyleBackColor = true;
            this.btn_DetailView.Click += new System.EventHandler(this.btn_DetailView_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 253);
            this.Controls.Add(this.btn_DetailView);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.dataGridView_People);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_People)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_People;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Button btn_DetailView;
    }
}

