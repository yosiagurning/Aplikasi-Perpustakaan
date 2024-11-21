using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public partial class PageSearchBook : Form
    {
        public PageSearchBook()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            CariBuku book = new CariBuku();
            dynamic availableBook = book.BukuTersedia(Text);
            book.TampilDataBuku(availableBook, Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PageDashboard dashboard = new PageDashboard();
            dashboard.Closed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            ProgramConfig config = new ProgramConfig();
            dynamic conf = config.ReadConfigFile();
            this.Size = new Size(conf.width, conf.height);
            if (LanguageCounter.identifier == "en")
            {
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                label1.Text = "Search a book in MyLibrary";
                button2.Text = conf_bahasa.BahasaPageBook.ButtonKembali.En;
            }
            else if (LanguageCounter.identifier == "id")
            {
                ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
                dynamic conf_bahasa = config_bahasa.ReadConfigFile();
                label1.Text = "Cari Buku MyLibrary";
                button2.Text = conf_bahasa.BahasaPageBook.ButtonKembali.Id;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
