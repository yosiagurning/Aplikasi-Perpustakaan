using System;
using System.Diagnostics;

namespace Aplikasi_Perpustakaan
{
    public class ValidasiInput
    {
        public static string CekValidasi(string id_buku, string judul, string jumlahHalaman, string penulis, string penerbit, string tahun, string status)
        {
            String result = null;

            if (judul.Length >= 30)
            {
                result = "judul"; 
            }
            else if (judul == null || judul == "" | jumlahHalaman == "" || penulis == null || penerbit == null || tahun == "")
            {
                result = "kosong"; 
            }
            else if (int.Parse(jumlahHalaman) >= 1000000)
            {
                Debug.Assert(int.Parse(jumlahHalaman) <= int.MaxValue);
                Debug.Assert(int.Parse(jumlahHalaman) <= 1000000, "Input tidak boleh lebih dari 1 juta");
            }
            else
            {
                return "berhasil";
            }

            return result;
        }
    }
}
