namespace Exercise3
{
    partial class InfoSach
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
            this.rtbBookDetails = new System.Windows.Forms.RichTextBox();
            this.btnAddToShelf = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.dgvBookShelves = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookShelves)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbBookDetails
            // 
            this.rtbBookDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBookDetails.Location = new System.Drawing.Point(12, 12);
            this.rtbBookDetails.Name = "rtbBookDetails";
            this.rtbBookDetails.Size = new System.Drawing.Size(975, 355);
            this.rtbBookDetails.TabIndex = 0;
            this.rtbBookDetails.Text = "";
            // 
            // btnAddToShelf
            // 
            this.btnAddToShelf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnAddToShelf.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToShelf.Location = new System.Drawing.Point(12, 383);
            this.btnAddToShelf.Name = "btnAddToShelf";
            this.btnAddToShelf.Size = new System.Drawing.Size(163, 56);
            this.btnAddToShelf.TabIndex = 1;
            this.btnAddToShelf.Text = "Thêm vào kệ sách";
            this.btnAddToShelf.UseVisualStyleBackColor = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(607, 401);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(380, 27);
            this.progressBar.TabIndex = 3;
            // 
            // dgvBookShelves
            // 
            this.dgvBookShelves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookShelves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2});
            this.dgvBookShelves.Location = new System.Drawing.Point(12, 457);
            this.dgvBookShelves.Name = "dgvBookShelves";
            this.dgvBookShelves.RowHeadersWidth = 51;
            this.dgvBookShelves.RowTemplate.Height = 24;
            this.dgvBookShelves.Size = new System.Drawing.Size(975, 266);
            this.dgvBookShelves.TabIndex = 4;
            this.dgvBookShelves.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookShelves_CellDoubleClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "tên kệ sách";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mô tả";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 700;
            // 
            // InfoSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(998, 735);
            this.Controls.Add(this.dgvBookShelves);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.btnAddToShelf);
            this.Controls.Add(this.rtbBookDetails);
            this.Name = "InfoSach";
            this.Text = "Thông tin sách";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookShelves)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBookDetails;
        private System.Windows.Forms.Button btnAddToShelf;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.DataGridView dgvBookShelves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}