using System;
using System.Windows.Forms;

namespace Aplikasi_Perpustakaan
{
    public class CariBuku
    {
        public T SearchBuku<T>(T searchBuku)
        {
            if (typeof(T) == typeof(string))
            {
                dynamic title = searchBuku;
                return (T)title;
            }
            else
            {
                return default(T);
            }
        }

        public bool BukuTersedia<T>(T cari)
        {
            dynamic temp = SearchBuku(cari);

            string convertTemp = Convert.ToString(temp);

            //string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\databuku.json";

            //List<Buku> list_buku = new List<Buku>();

            //Raw raw = Raw.getRecord(path);

            //list_buku = raw.buku;

            dynamic list_buku = Buku.GetDataBuku();

            for (int i = 0; i < list_buku.Count; i++)
            {
                Buku dataBuku = list_buku[i];
                if (dataBuku.judulBuku == convertTemp)
                {
                    return true;
                }
            }
            return false;
        }

        public enum status_buku { disimpan, dipinjam, hilang };
        public void TampilDataBuku(bool hasil, dynamic cari)
        {
            cari = Convert.ToString(cari);
            string[] message = { "Buku Tersedia dan dapat dipinjam", "Buku Sedang dipinjam, mohon bersabar :)", "Mohon maaf, buku yang anda cari hilang" };

            dynamic list_buku = Buku.GetDataBuku();

            if (hasil == true)
            {
                for (int i = 0; i < list_buku.Count; i++)
                {
                    Buku dataBuku = list_buku[i];
                    if (cari == dataBuku.judulBuku)
                    {
                        for (int j = 0; j < Enum.GetNames(typeof(status_buku)).Length; j++)
                        {
                            status_buku getstats = (status_buku)j;
                            string statsinstring = getstats.ToString();
                            if (dataBuku.status == statsinstring)
                            {
                                MessageBox.Show(message[(int)getstats]);
                                MessageBox.Show("judul: " + dataBuku.judulBuku + "\n" + "id: " + dataBuku.idBuku + "\n" + "jumlah halaman: " + dataBuku.jumlahHalaman + "\n" + "peulis: " + dataBuku.penulis + "\n" + "status peminjaman: " + dataBuku.status);
                                break;
                            }
                        }
                    }
                    //if (cari == dataBuku.judulBuku)
                    //{
                    //    if (dataBuku.status == status_buku.disimpan.ToString())
                    //    {
                    //        status_buku stats_disimpan = status_buku.disimpan;
                    //        int indexjawaban = (int)stats_disimpan;
                    //        MessageBox.Show(message[indexjawaban]);
                    //        MessageBox.Show("judul: " + dataBuku.judulBuku + "\n" + "id: " + dataBuku.idBuku + "\n" + "jumlah halaman: " + dataBuku.jumlahHalaman + "\n" + "peulis: " + dataBuku.penulis + "\n" + "status peminjaman: " + dataBuku.status);
                    //        break;
                    //    }
                    //    else if (dataBuku.status == status_buku.dipinjam.ToString())
                    //    {
                    //        status_buku stats_dipinjam = status_buku.dipinjam;
                    //        int indexjawaban = (int)stats_dipinjam;
                    //        MessageBox.Show(message[indexjawaban]);
                    //        MessageBox.Show("judul: " + dataBuku.judulBuku + "\n" + "id: " + dataBuku.idBuku + "\n" + "jumlah halaman: " + dataBuku.jumlahHalaman + "\n" + "peulis: " + dataBuku.penulis + "\n" + "status peminjaman: " + dataBuku.status);
                    //        break;
                    //    }
                    //    else if (dataBuku.status == status_buku.hilang.ToString())
                    //    {
                    //        status_buku stats_hilang = status_buku.hilang;
                    //        int indexjawaban = (int)stats_hilang;
                    //        MessageBox.Show(message[indexjawaban]);
                    //        MessageBox.Show("judul: " + dataBuku.judulBuku + "\n" + "id: " + dataBuku.idBuku + "\n" + "jumlah halaman: " + dataBuku.jumlahHalaman + "\n" + "peulis: " + dataBuku.penulis + "\n" + "status peminjaman: " + dataBuku.status);
                    //        break;
                    //    }
                    //}
                }
            }
            else
            {
                MessageBox.Show("Buku Tidak Ditemukan !");
            }
        }
    }
}
