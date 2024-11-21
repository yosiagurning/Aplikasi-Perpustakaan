namespace Aplikasi_Perpustakaan
{
    partial class PagePeminjaman
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
            this.backButton = new System.Windows.Forms.Button();
            this.dgvDataPeminjaman = new System.Windows.Forms.DataGridView();
            this.labelIdBuku = new System.Windows.Forms.Label();
            this.inputNama = new System.Windows.Forms.TextBox();
            this.labelPeminjam = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.labeljudulpeminjaman = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.labelIdPeminjaman = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MintCream;
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(22, 11);
            this.backButton.Margin = new System.Windows.Forms.Padding(2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 30);
            this.backButton.TabIndex = 1;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataPeminjaman
            // 
            this.dgvDataPeminjaman.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataPeminjaman.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPeminjaman.Location = new System.Drawing.Point(22, 319);
            this.dgvDataPeminjaman.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataPeminjaman.Name = "dgvDataPeminjaman";
            this.dgvDataPeminjaman.RowHeadersWidth = 51;
            this.dgvDataPeminjaman.RowTemplate.Height = 24;
            this.dgvDataPeminjaman.Size = new System.Drawing.Size(547, 158);
            this.dgvDataPeminjaman.TabIndex = 2;
            this.dgvDataPeminjaman.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataPeminjaman_CellClick);
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdBuku.Location = new System.Drawing.Point(609, 45);
            this.labelIdBuku.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(50, 15);
            this.labelIdBuku.TabIndex = 16;
            this.labelIdBuku.Text = "ID Buku";
            this.labelIdBuku.Visible = false;
            // 
            // inputNama
            // 
            this.inputNama.Location = new System.Drawing.Point(234, 116);
            this.inputNama.Margin = new System.Windows.Forms.Padding(2);
            this.inputNama.Name = "inputNama";
            this.inputNama.Size = new System.Drawing.Size(335, 20);
            this.inputNama.TabIndex = 14;
            this.inputNama.TextChanged += new System.EventHandler(this.inputNama_TextChanged);
            // 
            // labelPeminjam
            // 
            this.labelPeminjam.AutoSize = true;
            this.labelPeminjam.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeminjam.Location = new System.Drawing.Point(20, 118);
            this.labelPeminjam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPeminjam.Name = "labelPeminjam";
            this.labelPeminjam.Size = new System.Drawing.Size(102, 15);
            this.labelPeminjam.TabIndex = 13;
            this.labelPeminjam.Text = "Nama Peminjam :";
            this.labelPeminjam.Click += new System.EventHandler(this.labelPeminjam_Click);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MintCream;
            this.buttonSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(591, 116);
            this.buttonSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(87, 30);
            this.buttonSubmit.TabIndex = 23;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataBuku.ColumnHeadersHeight = 29;
            this.dgvDataBuku.Location = new System.Drawing.Point(234, 160);
            this.dgvDataBuku.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(335, 122);
            this.dgvDataBuku.TabIndex = 25;
            this.dgvDataBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellClick);
            // 
            // labeljudulpeminjaman
            // 
            this.labeljudulpeminjaman.AutoSize = true;
            this.labeljudulpeminjaman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeljudulpeminjaman.Location = new System.Drawing.Point(161, 29);
            this.labeljudulpeminjaman.Name = "labeljudulpeminjaman";
            this.labeljudulpeminjaman.Size = new System.Drawing.Size(379, 31);
            this.labeljudulpeminjaman.TabIndex = 28;
            this.labeljudulpeminjaman.Text = "Data Peminjaman MyLibrary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Pilih buku yang ingin dipinjam :";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.MintCream;
            this.btnReturn.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(589, 319);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(89, 30);
            this.btnReturn.TabIndex = 30;
            this.btnReturn.Text = "Kembalikan";
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MintCream;
            this.btnHapus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(589, 366);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(89, 30);
            this.btnHapus.TabIndex = 31;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // labelIdPeminjaman
            // 
            this.labelIdPeminjaman.AutoSize = true;
            this.labelIdPeminjaman.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIdPeminjaman.Location = new System.Drawing.Point(609, 60);
            this.labelIdPeminjaman.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIdPeminjaman.Name = "labelIdPeminjaman";
            this.labelIdPeminjaman.Size = new System.Drawing.Size(90, 15);
            this.labelIdPeminjaman.TabIndex = 32;
            this.labelIdPeminjaman.Text = "ID Peminjaman";
            this.labelIdPeminjaman.Visible = false;
            // 
            // PagePeminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.labelIdPeminjaman);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labeljudulpeminjaman);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.inputNama);
            this.Controls.Add(this.labelPeminjam);
            this.Controls.Add(this.dgvDataPeminjaman);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PagePeminjaman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.PeminjamanPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPeminjaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dgvDataPeminjaman;
        private System.Windows.Forms.Label labelIdBuku;
        private System.Windows.Forms.TextBox inputNama;
        private System.Windows.Forms.Label labelPeminjam;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.DataGridView dgvDataBuku;
        private System.Windows.Forms.Label labeljudulpeminjaman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Label labelIdPeminjaman;
    }
}