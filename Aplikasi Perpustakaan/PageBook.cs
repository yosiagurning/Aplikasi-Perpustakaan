using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class PageBook : Form
    {

        public PageBook()
        {
            InitializeComponent();
        }

        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

        private void BookPage_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new System.Drawing.Size(conf.width, conf.height);

            if (LanguageCounter.identifier == "en")
            {
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                labelJudul.Text = conf_bahasa.BahasaPageBook.LabelJudulBuku.En;
                labelPenulis.Text = conf_bahasa.BahasaPageBook.LabelPenulis.En;
                labelPenerbit.Text = conf_bahasa.BahasaPageBook.LabelPenerbit.En;
                labelTahun.Text = conf_bahasa.BahasaPageBook.LabelTahunPenerbit.En;
                labelJmlHal.Text = conf_bahasa.BahasaPageBook.LabelJumlahHalaman.En;
                backButton.Text = conf_bahasa.BahasaPageBook.ButtonKembali.En;
                buttonDelete.Text = conf_bahasa.BahasaPageBook.ButtonHapus.En;
                juduldatabuku.Text = "MyLibrary Book Data";
            }
            else if(LanguageCounter.identifier == "id")
            {
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                labelJudul.Text = conf_bahasa.BahasaPageBook.LabelJudulBuku.Id;
                labelPenulis.Text = conf_bahasa.BahasaPageBook.LabelPenulis.Id;
                labelPenerbit.Text = conf_bahasa.BahasaPageBook.LabelPenerbit.Id;
                labelTahun.Text = conf_bahasa.BahasaPageBook.LabelTahunPenerbit.Id;
                labelJmlHal.Text = conf_bahasa.BahasaPageBook.LabelJumlahHalaman.Id;
                backButton.Text = conf_bahasa.BahasaPageBook.ButtonKembali.Id;
                buttonDelete.Text = conf_bahasa.BahasaPageBook.ButtonHapus.Id;
                juduldatabuku.Text = "Data Buku MyLibrary";
            }

            List<Buku> result = Buku.GetDataBuku();

            dgvDataBuku.DataSource = this.ToDataTable(result);

            inputStatus.SelectedItem = "disimpan";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageDashboard dashboard = new PageDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void dgvDataBuku_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labelJudul_Click(object sender, EventArgs e)

        {

        }

        private void labelPenerbit_Click(object sender, EventArgs e)
        {

        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string id_buku = null;
            string judul = this.inputJudul.Text;
            string jumlahHalaman = this.inputJmlHal.Text;
            string penulis = this.inputPenulis.Text;
            string penerbit = this.inputPenerbit.Text;
            string tahun = this.inputTahun.Text;
            string status = null;

            string result = ValidasiInput.CekValidasi(id_buku, judul, jumlahHalaman, penulis, penerbit, tahun, status);

            if (result == "berhasil")
            {
                Buku buku = new Buku(id_buku, judul, int.Parse(jumlahHalaman), penulis, penerbit, int.Parse(tahun), status);

                bool hasil = Buku.TambahBuku(buku);

                if (hasil)
                {
                    MessageBox.Show("Buku berhasil ditambahkan");
                    dynamic resBuku = Buku.GetDataBuku();
                    dgvDataBuku.DataSource = this.ToDataTable(resBuku);
                    resetInput();
                }
                else
                {
                    MessageBox.Show("Buku gagal ditambahkan");
                    resetInput();
                }
            }
            else if(result == "judul")
            {
                MessageBox.Show("Judul Buku Terlalu Panjang");
            }
            else if(result == "kosong")
            {
                MessageBox.Show("Input tidak boleh kosong!");
            }
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labelJmlHal_Click(object sender, EventArgs e)
        {

        }

        private void dgvDataBuku_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dgvDataBuku.Rows[index];

            labelIdBuku.Text = selectedRow.Cells[0].Value.ToString();
            inputJudul.Text = selectedRow.Cells[1].Value.ToString();
            inputJmlHal.Text = selectedRow.Cells[2].Value.ToString();
            inputPenulis.Text = selectedRow.Cells[3].Value.ToString();
            inputPenerbit.Text = selectedRow.Cells[4].Value.ToString();
            inputTahun.Text = selectedRow.Cells[5].Value.ToString();
            inputStatus.SelectedItem = selectedRow.Cells[6].Value.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            dynamic result = Buku.DeleteDataBuku(labelIdBuku.Text);

            if (result != null)
            {
                MessageBox.Show("Hapus Data Berhasil", "Berhasil");
                dynamic buku = Buku.GetDataBuku();
                dgvDataBuku.DataSource = this.ToDataTable(buku);
                resetInput();
            } 
            else
            {
                MessageBox.Show("Hapus Data Gagal", "Gagal");
                resetInput();
            }
        }

        private void resetInput()
        {
            inputJmlHal.Text = "";
            inputJudul.Text = "";
            inputPenerbit.Text = "";
            inputPenulis.Text = "";
            inputTahun.Text = "";
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            resetInput();
        }

        private void inputJudul_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataBuku_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
