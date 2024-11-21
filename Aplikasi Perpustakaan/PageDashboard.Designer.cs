namespace Aplikasi_Perpustakaan
{
    partial class PageDashboard
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
            this.LabelGreeting = new System.Windows.Forms.Label();
            this.buttonBook = new System.Windows.Forms.Button();
            this.buttonPeminjaman = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelGreeting
            // 
            this.LabelGreeting.AutoSize = true;
            this.LabelGreeting.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGreeting.Location = new System.Drawing.Point(165, 164);
            this.LabelGreeting.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelGreeting.Name = "LabelGreeting";
            this.LabelGreeting.Size = new System.Drawing.Size(612, 52);
            this.LabelGreeting.TabIndex = 0;
            this.LabelGreeting.Text = "Selamat Datang di MyLibrary";
            this.LabelGreeting.Click += new System.EventHandler(this.LabelGreeting_Click);
            // 
            // buttonBook
            // 
            this.buttonBook.BackColor = System.Drawing.Color.MintCream;
            this.buttonBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonBook.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBook.Location = new System.Drawing.Point(143, 318);
            this.buttonBook.Margin = new System.Windows.Forms.Padding(4);
            this.buttonBook.Name = "buttonBook";
            this.buttonBook.Size = new System.Drawing.Size(193, 76);
            this.buttonBook.TabIndex = 7;
            this.buttonBook.Text = "Data Buku";
            this.buttonBook.UseVisualStyleBackColor = false;
            this.buttonBook.Click += new System.EventHandler(this.buttonBook_Click);
            // 
            // buttonPeminjaman
            // 
            this.buttonPeminjaman.BackColor = System.Drawing.Color.MintCream;
            this.buttonPeminjaman.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPeminjaman.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPeminjaman.Location = new System.Drawing.Point(375, 318);
            this.buttonPeminjaman.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPeminjaman.Name = "buttonPeminjaman";
            this.buttonPeminjaman.Size = new System.Drawing.Size(193, 76);
            this.buttonPeminjaman.TabIndex = 8;
            this.buttonPeminjaman.Text = "Data Peminjaman";
            this.buttonPeminjaman.UseVisualStyleBackColor = false;
            this.buttonPeminjaman.Click += new System.EventHandler(this.buttonPeminjaman_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackColor = System.Drawing.Color.MintCream;
            this.buttonSearch.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(603, 318);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(199, 76);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Cari Buku";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 491);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "Language(ID/EN)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // PageDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(939, 617);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonPeminjaman);
            this.Controls.Add(this.buttonBook);
            this.Controls.Add(this.LabelGreeting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "PageDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplikasi Perpustakaan";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelGreeting;
        private System.Windows.Forms.Button buttonPeminjaman;
        private System.Windows.Forms.Button buttonBook;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button button3;
    }
}

