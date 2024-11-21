using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikasi_Perpustakaan
{
    public class AutomataStatusBuku
    {
        public enum StatusBuku{disimpan, dipinjam, hilang};
        public enum Aksi { dipinjam, dikembalikan, hilang};
       
        public class Transisi
        {
            public StatusBuku state_sebelum;
            public StatusBuku state_setelah;
            public Aksi aksi_peminjam;

            public Transisi(StatusBuku StateSebelum, StatusBuku StateSetelah, Aksi AksiPeminjam)
            {
                this.state_sebelum = StateSebelum;
                this.state_setelah = StateSetelah;
                this.aksi_peminjam = AksiPeminjam;
            }
        }

        Transisi[] daftarTransisi =
        {
            new Transisi(StatusBuku.dipinjam, StatusBuku.disimpan, Aksi.dikembalikan),
            new Transisi(StatusBuku.disimpan, StatusBuku.dipinjam, Aksi.dipinjam),
            new Transisi(StatusBuku.dipinjam, StatusBuku.hilang, Aksi.hilang),
            new Transisi(StatusBuku.disimpan, StatusBuku.hilang, Aksi.hilang)
        };

        public StatusBuku StatusBukuSaatIni = StatusBuku.disimpan;

        public StatusBuku changeStatus(StatusBuku status_buku, Aksi aksi)
        {
            StatusBuku next_status = status_buku;
            for(int i = 0; i < daftarTransisi.Length; i++)
            {
                if(daftarTransisi[i].state_sebelum == status_buku && daftarTransisi[i].aksi_peminjam == aksi)
                {
                    next_status = daftarTransisi[i].state_setelah;
                }
            }
            return next_status;
        }

        public void TriggerAksi(Aksi aksi)
        {
            StatusBuku sekarang = changeStatus(this.StatusBukuSaatIni, aksi);
            StatusBukuSaatIni = sekarang;
        }

        public AutomataStatusBuku() { }

    }
}
