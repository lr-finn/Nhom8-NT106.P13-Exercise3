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
            rtbBookDetails = new RichTextBox();
            btnAddToShelf = new Button();
            progressBar = new ProgressBar();
            dgvBookShelves = new DataGridView();
            Column3 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvBookShelves).BeginInit();
            SuspendLayout();
            // 
            // rtbBookDetails
            // 
            rtbBookDetails.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rtbBookDetails.Location = new Point(12, 15);
            rtbBookDetails.Margin = new Padding(3, 4, 3, 4);
            rtbBookDetails.Name = "rtbBookDetails";
            rtbBookDetails.Size = new Size(975, 443);
            rtbBookDetails.TabIndex = 0;
            rtbBookDetails.Text = "";
            // 
            // btnAddToShelf
            // 
            btnAddToShelf.BackColor = Color.FromArgb(255, 224, 192);
            btnAddToShelf.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToShelf.Location = new Point(12, 479);
            btnAddToShelf.Margin = new Padding(3, 4, 3, 4);
            btnAddToShelf.Name = "btnAddToShelf";
            btnAddToShelf.Size = new Size(163, 70);
            btnAddToShelf.TabIndex = 1;
            btnAddToShelf.Text = "Thêm vào kệ sách";
            btnAddToShelf.UseVisualStyleBackColor = false;
            btnAddToShelf.Click += btnAddToShelf_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(607, 501);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(380, 34);
            progressBar.TabIndex = 3;
            // 
            // dgvBookShelves
            // 
            dgvBookShelves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookShelves.Columns.AddRange(new DataGridViewColumn[] { Column3, Column1, Column2 });
            dgvBookShelves.Location = new Point(12, 571);
            dgvBookShelves.Margin = new Padding(3, 4, 3, 4);
            dgvBookShelves.Name = "dgvBookShelves";
            dgvBookShelves.RowHeadersWidth = 51;
            dgvBookShelves.RowTemplate.Height = 24;
            dgvBookShelves.Size = new Size(975, 332);
            dgvBookShelves.TabIndex = 4;
            dgvBookShelves.CellDoubleClick += dgvBookShelves_CellDoubleClick;
            // 
            // Column3
            // 
            Column3.HeaderText = "ID";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column1
            // 
            Column1.HeaderText = "tên kệ sách";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mô tả";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 700;
            // 
            // InfoSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(998, 919);
            Controls.Add(dgvBookShelves);
            Controls.Add(progressBar);
            Controls.Add(btnAddToShelf);
            Controls.Add(rtbBookDetails);
            Margin = new Padding(3, 4, 3, 4);
            Name = "InfoSach";
            Text = "Thông tin sách";
            ((System.ComponentModel.ISupportInitialize)dgvBookShelves).EndInit();
            ResumeLayout(false);
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