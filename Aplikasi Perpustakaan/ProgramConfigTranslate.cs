using Newtonsoft.Json;
using System;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    internal class ProgramConfigTranslate
    {
        public dynamic conf;
        public ConfigTranslate defaultConfigBahasa;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string configFileName = "configTranslate.json";

        public ProgramConfigTranslate()
        {
            try
            {
                ReadConfigFile();
            }
            catch
            {
                SetDefault();
                WriteNewConfigFile();
            }
        }

        private void SetDefault()
        {
            LabelIdBuku labelIdBuku = new LabelIdBuku("ID Buku","Book ID");
            LabelNamaPeminjam labelNamaPeminjam = new LabelNamaPeminjam("Nama Peminjam","Borrower's name");
            BahasaPagePeminjaman bahasaPagePeminjaman = new BahasaPagePeminjaman(labelIdBuku, labelNamaPeminjam);

            LabelJudulBuku labelJudulBuku = new LabelJudulBuku("Judul Buku","Book's Title");
            LabelPenulis labelPenulis = new LabelPenulis("Penulis","Writer");
            LabelPenerbit labelPenerbit = new LabelPenerbit("Penerbit", "Publisher");
            LabelTahunPenerbit labelTahunPenerbit = new LabelTahunPenerbit("Tahun Terbit", "Publication Year");
            LabelJumlahHalaman labelJumlahHalaman = new LabelJumlahHalaman("Jumlah Halaman", "Number of Pages");
            ButtonHapus buttonHapus = new ButtonHapus("Hapus", "Delete");
            ButtonKembali buttonKembali = new ButtonKembali("Kembali", "Back");
            BahasaPageBook bahasaPageBook = new BahasaPageBook(labelJudulBuku, labelPenulis,
                labelPenerbit, labelTahunPenerbit, labelJumlahHalaman, buttonHapus, buttonKembali);

            string linkBukuGet = "https://w5bzmo.deta.dev/buku/get";
            string linkBukuPost = "https://w5bzmo.deta.dev/buku/post";
            string linkBukuPatch = "https://w5bzmo.deta.dev/buku/patch";
            string linkBukuDelete = "https://w5bzmo.deta.dev/buku/delete";
            string linkPeminjamanGet = "https://w5bzmo.deta.dev/peminjaman/get";
            string linkPeminjamanPost = "https://w5bzmo.deta.dev/peminjaman/post";
            string linkPeminjamanPatch = "https://w5bzmo.deta.dev/peminjaman/patch";
            string linkPeminjamanDelete = "https://w5bzmo.deta.dev/peminjaman/delete";
            LinkAPI linkAPI = new LinkAPI(linkBukuGet, linkBukuPost, linkBukuPatch,
                linkBukuDelete, linkPeminjamanGet, linkPeminjamanPost, linkPeminjamanPatch,
                linkPeminjamanDelete);
            defaultConfigBahasa = new ConfigTranslate(bahasaPagePeminjaman, bahasaPageBook, linkAPI);
        }

        public dynamic ReadConfigFile()
        {
            string jsonFromFilee = File.ReadAllText(path + '/' + configFileName);
            conf = JsonConvert.DeserializeObject<ConfigTranslate>(jsonFromFilee);
            return conf;
        }

        private void WriteNewConfigFile()
        {

            String jsonStringg = JsonConvert.SerializeObject(defaultConfigBahasa);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonStringg);
        }
    }
}
