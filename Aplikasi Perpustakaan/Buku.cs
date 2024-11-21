using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Aplikasi_Perpustakaan
{
    public class Buku
    {
        public string idBuku { get; set; }
        public string judulBuku { get; set; }
        public int jumlahHalaman { get; set; }
        public string penulis { get; set; }
        public string penerbit { get; set; }
        public int tahunTerbit { get; set; }
        public string status { get; set; }

        public Buku(string idBuku, string judulBuku, int jumlahHalaman, string penulis, string penerbit, int tahunTerbit, string status)
        {
            this.idBuku = idBuku;
            this.judulBuku = judulBuku;
            this.jumlahHalaman = jumlahHalaman;
            this.penulis = penulis;
            this.penerbit = penerbit;
            this.tahunTerbit = tahunTerbit;
            this.status = status;
        }

        public static List<Buku> GetDataBuku()
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkBukuGet;
            List<Buku> result = LibrariesAPI.API.Get<Buku>(url);

            return result;
        }

        public static dynamic GetDataBuku(string idBuku)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkBukuGet + "?idBuku=" + idBuku;
            dynamic result = LibrariesAPI.API.GetById<Buku>(url);

            return result;
        }

        public static dynamic TambahBuku(Buku buku)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkBukuPost;
            dynamic result = LibrariesAPI.API.Post<Buku>(url, buku);

            return result;
        }

        public static dynamic DeleteDataBuku(string id)
        {
            ProgramConfigTranslate config_bahasa = new ProgramConfigTranslate();
            dynamic conf_bahasa = config_bahasa.ReadConfigFile();
            string url = conf_bahasa.LinkAPI.LinkBukuDelete + "?idBuku=" + id;
            dynamic result = LibrariesAPI.API.Delete(url);

            return result;
        }

        //public static Buku search(Raw data, string id_buku)
        //{
        //    foreach (Buku item in data.buku)
        //    {
        //        if (item.idBuku == id_buku)
        //        {
        //            return item;
        //        }
        //    }
        //    return null;
        //}

        //public Raw update(Raw data)
        //{
        //    bool changed = false;

        //    foreach (Buku item in data.buku)
        //    {
        //        if (item.idBuku == this.idBuku)
        //        {
        //            changed = true;
        //            item.status = status;
        //            item.judulBuku = this.judulBuku;
        //            item.jumlahHalaman = this.jumlahHalaman;
        //            item.penulis = this.penulis;
        //            item.penerbit = this.penerbit;
        //            item.tahunTerbit = this.tahunTerbit;
        //            break;
        //        }
        //    }

        //    string json = JsonConvert.SerializeObject(data, Formatting.Indented);
        //    File.WriteAllText(data.path, json);

        //    if (changed)
        //    {
        //        return data;
        //    } else
        //    {
        //        return null;
        //    }
        //}

    }
}
