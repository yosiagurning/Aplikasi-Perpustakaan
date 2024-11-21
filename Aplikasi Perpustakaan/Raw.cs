using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    internal class Raw
    {
        public List<Buku> buku;
        public List<Peminjaman> peminjaman;
        public string path { get; set; }

        public static Raw getRecord(string path)
        {
            Raw raw = new Raw();

            string raw_text = File.ReadAllText(path);

            raw = JsonConvert.DeserializeObject<Raw>(raw_text, new JsonSerializerSettings
            {
                DateFormatString = "dd/MM/yyyy"
            });
            raw.path = path;
            return raw;
        }
    }
}
