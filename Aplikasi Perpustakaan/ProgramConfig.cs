using Newtonsoft.Json;
using System;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    internal class ProgramConfig
    {
        public dynamic conf;
        public Config defaultConfig;
        public string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
        public string configFileName = "configApp.json";

        public ProgramConfig()
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
            greeting pesanAwal = new greeting("Selamat Datang", "Welcome");
            pilihBahasa pilihBahasaAwal = new pilihBahasa("Pilih Bahasa", "Choose Language");
            messageLogin messageLoginAwal = new messageLogin("Sukses Login! Selamat Datang di MyLibrary", "Login Success! Welcome to MyLibrary");
            alertLogin alertLoginAwal = new alertLogin("Username atau Password salah!", "Wrong Username or Password!");
            idBuku idBukuAwal = new idBuku("ID Buku", "Book ID");
            namaPeminjam namaPeminjamAwal = new namaPeminjam("Nama Peminjam", "Borrower Name");
            formDataBuku formDataBukuAwal = new formDataBuku(idBukuAwal, namaPeminjamAwal);
            text textAwal = new text(pesanAwal, pilihBahasaAwal, messageLoginAwal, alertLoginAwal, formDataBukuAwal);

            tambah btnTambah = new tambah("Tambah", "Add");
            hapus btnHapus = new hapus("Hapus", "Delete");
            kembali btnKembali = new kembali("Kembali", "Back");
            dataBuku btnDataBuku= new dataBuku("Data Buku", "Book Data");
            dataPeminjaman btnDataPeminjaman = new dataPeminjaman("Data Peminjaman", "Borrower Data");
            cariBuku btnCariBuku = new cariBuku("Cari Buku", "Search Book");

            button btnAwal = new button(btnTambah, btnHapus, btnKembali, btnDataBuku, btnCariBuku, btnDataPeminjaman);
            defaultConfig = new Config(720, 1080, "id", textAwal, btnAwal);
        }

        public dynamic ReadConfigFile()
        {
            string jsonFromFile = File.ReadAllText(path + '/' + configFileName);
            conf = JsonConvert.DeserializeObject<Config>(jsonFromFile);
            return conf;
        }

        private void WriteNewConfigFile()
        {
            String jsonString = JsonConvert.SerializeObject(defaultConfig);
            string fullPath = path + '/' + configFileName;
            File.WriteAllText(fullPath, jsonString);
        }
    }
}
