namespace Aplikasi_Perpustakaan
{
    partial class PageBook
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
            this.dgvDataBuku = new System.Windows.Forms.DataGridView();
            this.juduldatabuku = new System.Windows.Forms.Label();
            this.labelJudul = new System.Windows.Forms.Label();
            this.inputJudul = new System.Windows.Forms.TextBox();
            this.inputJmlHal = new System.Windows.Forms.TextBox();
            this.inputPenulis = new System.Windows.Forms.TextBox();
            this.labelJmlHal = new System.Windows.Forms.Label();
            this.labelPenulis = new System.Windows.Forms.Label();
            this.inputPenerbit = new System.Windows.Forms.TextBox();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.inputTahun = new System.Windows.Forms.TextBox();
            this.labelTahun = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.inputStatus = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelIdBuku = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.MintCream;
            this.backButton.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.Location = new System.Drawing.Point(25, 20);
            this.backButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(70, 30);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Kembali";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // dgvDataBuku
            // 
            this.dgvDataBuku.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dgvDataBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataBuku.Location = new System.Drawing.Point(25, 299);
            this.dgvDataBuku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvDataBuku.Name = "dgvDataBuku";
            this.dgvDataBuku.RowHeadersWidth = 51;
            this.dgvDataBuku.RowTemplate.Height = 24;
            this.dgvDataBuku.Size = new System.Drawing.Size(648, 174);
            this.dgvDataBuku.TabIndex = 1;
            this.dgvDataBuku.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellClick);
            this.dgvDataBuku.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataBuku_CellContentClick_1);
            // 
            // juduldatabuku
            // 
            this.juduldatabuku.AutoSize = true;
            this.juduldatabuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.juduldatabuku.Location = new System.Drawing.Point(234, 18);
            this.juduldatabuku.Name = "juduldatabuku";
            this.juduldatabuku.Size = new System.Drawing.Size(306, 33);
            this.juduldatabuku.TabIndex = 2;
            this.juduldatabuku.Text = "Data Buku MyLibrary";
            // 
            // labelJudul
            // 
            this.labelJudul.AutoSize = true;
            this.labelJudul.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelJudul.Location = new System.Drawing.Point(57, 99);
            this.labelJudul.Name = "labelJudul";
            this.labelJudul.Size = new System.Drawing.Size(66, 15);
            this.labelJudul.TabIndex = 2;
            this.labelJudul.Text = "Judul Buku";
            // 
            // inputJudul
            // 
            this.inputJudul.Location = new System.Drawing.Point(60, 127);
            this.inputJudul.Name = "inputJudul";
            this.inputJudul.Size = new System.Drawing.Size(188, 20);
            this.inputJudul.TabIndex = 3;
            this.inputJudul.TextChanged += new System.EventHandler(this.inputJudul_TextChanged);
            // 
            // inputJmlHal
            // 
            this.inputJmlHal.Location = new System.Drawing.Point(299, 232);
            this.inputJmlHal.Name = "inputJmlHal";
            this.inputJmlHal.Size = new System.Drawing.Size(188, 20);
            this.inputJmlHal.TabIndex = 6;
            // 
            // inputPenulis
            // 
            this.inputPenulis.Location = new System.Drawing.Point(60, 182);
            this.inputPenulis.Name = "inputPenulis";
            this.inputPenulis.Size = new System.Drawing.Size(188, 20);
            this.inputPenulis.TabIndex = 7;
            // 
            // labelJmlHal
            // 
            this.labelJmlHal.AutoSize = true;
            this.labelJmlHal.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelJmlHal.Location = new System.Drawing.Point(296, 208);
            this.labelJmlHal.Name = "labelJmlHal";
            this.labelJmlHal.Size = new System.Drawing.Size(97, 15);
            this.labelJmlHal.TabIndex = 10;
            this.labelJmlHal.Text = "Jumlah Halaman";
            this.labelJmlHal.Click += new System.EventHandler(this.labelJmlHal_Click);
            // 
            // labelPenulis
            // 
            this.labelPenulis.AutoSize = true;
            this.labelPenulis.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelPenulis.Location = new System.Drawing.Point(57, 154);
            this.labelPenulis.Name = "labelPenulis";
            this.labelPenulis.Size = new System.Drawing.Size(45, 15);
            this.labelPenulis.TabIndex = 11;
            this.labelPenulis.Text = "Penulis";
            // 
            // inputPenerbit
            // 
            this.inputPenerbit.Location = new System.Drawing.Point(60, 232);
            this.inputPenerbit.Name = "inputPenerbit";
            this.inputPenerbit.Size = new System.Drawing.Size(188, 20);
            this.inputPenerbit.TabIndex = 8;
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenerbit.Location = new System.Drawing.Point(57, 208);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(51, 15);
            this.labelPenerbit.TabIndex = 12;
            this.labelPenerbit.Text = "Penerbit";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.BackColor = System.Drawing.Color.MintCream;
            this.buttonSubmit.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(535, 120);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(105, 30);
            this.buttonSubmit.TabIndex = 13;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.MintCream;
            this.buttonReset.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonReset.Location = new System.Drawing.Point(535, 172);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(105, 30);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // inputTahun
            // 
            this.inputTahun.Location = new System.Drawing.Point(299, 182);
            this.inputTahun.Name = "inputTahun";
            this.inputTahun.Size = new System.Drawing.Size(188, 20);
            this.inputTahun.TabIndex = 15;
            // 
            // labelTahun
            // 
            this.labelTahun.AutoSize = true;
            this.labelTahun.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelTahun.Location = new System.Drawing.Point(296, 154);
            this.labelTahun.Name = "labelTahun";
            this.labelTahun.Size = new System.Drawing.Size(73, 15);
            this.labelTahun.TabIndex = 17;
            this.labelTahun.Text = "Tahun Terbit";
            this.labelTahun.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelStatus.Location = new System.Drawing.Point(296, 99);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(40, 15);
            this.labelStatus.TabIndex = 18;
            this.labelStatus.Text = "Status";
            // 
            // inputStatus
            // 
            this.inputStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inputStatus.FormattingEnabled = true;
            this.inputStatus.Items.AddRange(new object[] {
            "disimpan",
            "dipinjam",
            "hilang"});
            this.inputStatus.Location = new System.Drawing.Point(298, 126);
            this.inputStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inputStatus.Name = "inputStatus";
            this.inputStatus.Size = new System.Drawing.Size(190, 21);
            this.inputStatus.TabIndex = 19;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.MintCream;
            this.buttonDelete.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDelete.Location = new System.Drawing.Point(535, 226);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(105, 30);
            this.buttonDelete.TabIndex = 21;
            this.buttonDelete.Text = "Hapus";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelIdBuku
            // 
            this.labelIdBuku.AutoSize = true;
            this.labelIdBuku.BackColor = System.Drawing.Color.Transparent;
            this.labelIdBuku.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.labelIdBuku.ForeColor = System.Drawing.Color.Transparent;
            this.labelIdBuku.Location = new System.Drawing.Point(182, 99);
            this.labelIdBuku.Name = "labelIdBuku";
            this.labelIdBuku.Size = new System.Drawing.Size(48, 15);
            this.labelIdBuku.TabIndex = 22;
            this.labelIdBuku.Text = "Id Buku";
            this.labelIdBuku.Visible = false;
            // 
            // PageBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(704, 501);
            this.Controls.Add(this.labelIdBuku);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.inputStatus);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelTahun);
            this.Controls.Add(this.inputTahun);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.juduldatabuku);
            this.Controls.Add(this.labelPenerbit);
            this.Controls.Add(this.labelPenulis);
            this.Controls.Add(this.labelJmlHal);
            this.Controls.Add(this.inputPenerbit);
            this.Controls.Add(this.inputPenulis);
            this.Controls.Add(this.inputJmlHal);
            this.Controls.Add(this.inputJudul);
            this.Controls.Add(this.labelJudul);
            this.Controls.Add(this.dgvDataBuku);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PageBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Buku";
            this.Load += new System.EventHandler(this.BookPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataBuku)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView dgvDataBuku;

        private System.Windows.Forms.Label juduldatabuku;

        private System.Windows.Forms.Label labelJudul;
        private System.Windows.Forms.TextBox inputJudul;
        private System.Windows.Forms.TextBox inputJmlHal;
        private System.Windows.Forms.TextBox inputPenulis;
        private System.Windows.Forms.Label labelJmlHal;
        private System.Windows.Forms.Label labelPenulis;
        private System.Windows.Forms.TextBox inputPenerbit;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox inputTahun;
        private System.Windows.Forms.Label labelTahun;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.ComboBox inputStatus;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelIdBuku;
    }
}