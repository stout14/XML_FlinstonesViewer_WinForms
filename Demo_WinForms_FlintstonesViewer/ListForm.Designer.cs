namespace Demo_WinForms_FlintstonesViewer
{
    partial class ListForm
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
            this.dataGridView_Characters = new System.Windows.Forms.DataGridView();
            this.btn_DeleteSelected = new System.Windows.Forms.Button();
            this.btn_DetailView = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Characters
            // 
            this.dataGridView_Characters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Characters.Location = new System.Drawing.Point(33, 51);
            this.dataGridView_Characters.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_Characters.Name = "dataGridView_Characters";
            this.dataGridView_Characters.RowTemplate.Height = 24;
            this.dataGridView_Characters.Size = new System.Drawing.Size(971, 328);
            this.dataGridView_Characters.TabIndex = 0;
            // 
            // btn_DeleteSelected
            // 
            this.btn_DeleteSelected.Location = new System.Drawing.Point(33, 385);
            this.btn_DeleteSelected.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DeleteSelected.Name = "btn_DeleteSelected";
            this.btn_DeleteSelected.Size = new System.Drawing.Size(85, 37);
            this.btn_DeleteSelected.TabIndex = 1;
            this.btn_DeleteSelected.Text = "Delete Selected";
            this.btn_DeleteSelected.UseVisualStyleBackColor = true;
            this.btn_DeleteSelected.Click += new System.EventHandler(this.btn_CheckList_Click);
            // 
            // btn_DetailView
            // 
            this.btn_DetailView.Location = new System.Drawing.Point(122, 384);
            this.btn_DetailView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_DetailView.Name = "btn_DetailView";
            this.btn_DetailView.Size = new System.Drawing.Size(81, 39);
            this.btn_DetailView.TabIndex = 2;
            this.btn_DetailView.Text = "View Detail";
            this.btn_DetailView.UseVisualStyleBackColor = true;
            this.btn_DetailView.Click += new System.EventHandler(this.btn_DetailView_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(101, 7);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(355, 29);
            this.lbl_Title.TabIndex = 3;
            this.lbl_Title.Text = "Characters from The Flintstones";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(923, 383);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(81, 39);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // ListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 440);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.btn_DetailView);
            this.Controls.Add(this.btn_DeleteSelected);
            this.Controls.Add(this.dataGridView_Characters);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListForm";
            this.Text = "Cartoon Characters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Characters)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Characters;
        private System.Windows.Forms.Button btn_DeleteSelected;
        private System.Windows.Forms.Button btn_DetailView;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_exit;
    }
}

