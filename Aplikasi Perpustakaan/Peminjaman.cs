using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    public class Peminjaman
    {
        public string idPeminjaman { get; set; }
        public string namaPeminjam { get; set; }
        public string idBuku { get; set; }
        public DateTime tanggalPinjam { get; set; }
        public string statusPeminjaman { get; set; }

        public Peminjaman(string id_peminjaman, string nama_peminjam, string id_buku, DateTime tanggal_pinjam, string status_peminjaman)
        {
            this.idPeminjaman = id_peminjaman;
            this.namaPeminjam = nama_peminjam;
            this.idBuku = id_buku;
            this.tanggalPinjam = tanggal_pinjam;
            this.statusPeminjaman = status_peminjaman;
        }

        public static dynamic GetDataPeminjaman()
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkPeminjamanGet;
            dynamic result = LibrariesAPI.API.Get<ResponsePeminjaman>(url);
            
            return result;
        }

        public static dynamic GetDataPeminjaman(string idPeminjaman)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkPeminjamanGet + "?idPeminjaman=" + idPeminjaman;
            dynamic result = LibrariesAPI.API.GetById<Peminjaman>(url);

            return result;
        }

        public static dynamic TambahPeminjaman(Peminjaman peminjaman)
        {
            Console.WriteLine(peminjaman.idBuku);
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkPeminjamanPost;
            dynamic result = LibrariesAPI.API.Post<Peminjaman>(url, peminjaman);
            
            return result;
        }

        public static dynamic DeleteDataPeminjaman(string id)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();

            string url = conf_bahasa.LinkAPI.LinkPeminjamanDelete + "?idPeminjaman=" + id;
            dynamic result = LibrariesAPI.API.Delete(url);

            return result;
        }

    }

    public class ResponsePeminjaman
    {
        public string idPeminjaman { get; set; }
        public string namaPeminjam { get; set; }
        public string judulBuku { get; set; }
        public string tanggalPinjam { get; set; }
        public string statusPeminjaman { get; set; }

        public ResponsePeminjaman(string id_peminjaman, string nama_peminjam, string buku, string tanggal_pinjam, string status_peminjaman)
        {
            this.idPeminjaman = id_peminjaman;
            this.namaPeminjam = nama_peminjam;
            this.judulBuku = buku;
            this.tanggalPinjam = tanggal_pinjam;
            this.statusPeminjaman = status_peminjaman;
        }
    }

}
