using System;

namespace Aplikasi_Perpustakaan
{
    class Config
    {
        public int height { get; set; }
        public int width { get; set; }
        public String bahasa { get; set; }
        public text text { get; set; }
        public button button { get; set; }

        public Config() { }
        public Config(int height, int width, string bahasa, text text, button button)
        {
            this.height = height;
            this.width = width;
            this.bahasa = bahasa;
            this.text = text;
            this.button = button;
        }
    }

    class button
    {
        public tambah tambah { get; set; }
        public hapus hapus { get; set; }
        public kembali kembali { get; set; }
        public dataBuku dataBuku { get; set; }
        public cariBuku cariBuku { get; set; }
        public dataPeminjaman dataPeminjaman { get; set; }
        public button() { }
        public button(tambah tambah, hapus hapus, kembali kembali, dataBuku dataBuku, cariBuku cariBuku, dataPeminjaman dataPeminjaman)
        {
            this.tambah = tambah;
            this.hapus = hapus;
            this.dataBuku = dataBuku;
            this.kembali = kembali;
            this.cariBuku = cariBuku;
            this.dataPeminjaman = dataPeminjaman;
        }
    }

    class text
    {
        public greeting greeting { get; set; }
        public pilihBahasa pilihBahasa { get; set; }
        public messageLogin messageLogin { get; set; }
        public alertLogin alertLogin { get; set; }
        public formDataBuku formDataBuku { get; set; }
        public text() { }

        public text(greeting greeting, pilihBahasa pilihBahasa, messageLogin messageLogin, alertLogin alertLogin, formDataBuku formDataBuku)
        {
            this.greeting = greeting;
            this.pilihBahasa = pilihBahasa;
            this.messageLogin = messageLogin;
            this.alertLogin = alertLogin;
            this.formDataBuku = formDataBuku;
        }
    }

    class greeting
    {
        public string id { get; set; }
        public string en { get; set; }

        public greeting() { }
        public greeting(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class formDataBuku
    {
        public idBuku idBuku { get; set; }
        public namaPeminjam namaPeminjam { get; set; }

        public formDataBuku() { }
        public formDataBuku(idBuku idBuku, namaPeminjam namaPeminjam)
        {
            this.idBuku = idBuku;
            this.namaPeminjam = namaPeminjam;
        }
    }

    class idBuku
    {
        public string id { get; set; }
        public string en { get; set; }

        public idBuku() { }
        public idBuku(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class namaPeminjam
    {
        public string id { get; set; }
        public string en { get; set; }

        public namaPeminjam() { }
        public namaPeminjam(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class pilihBahasa
    {
        public string id { get; set; }
        public string en { get; set; }

        public pilihBahasa() { }
        public pilihBahasa(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class messageLogin
    {
        public string id { get; set; }
        public string en { get; set; }

        public messageLogin() { }
        public messageLogin(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class alertLogin
    {
        public string id { get; set; }
        public string en { get; set; }

        public alertLogin() { }
        public alertLogin(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class tambah
    {
        public string id { get; set; }
        public string en { get; set; }

        public tambah() { }
        public tambah(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class dataPeminjaman
    {
        public string id { get; set; }
        public string en { get; set; }

        public dataPeminjaman() { }
        public dataPeminjaman(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class hapus
    {
        public string id { get; set; }
        public string en { get; set; }

        public hapus() { }
        public hapus(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class kembali
    {
        public string id { get; set; }
        public string en { get; set; }

        public kembali() { }
        public kembali(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class dataBuku
    {
        public string id { get; set; }
        public string en { get; set; }

        public dataBuku() { }
        public dataBuku(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }

    class cariBuku
    {
        public string id { get; set; }
        public string en { get; set; }

        public cariBuku() { }
        public cariBuku(string id, string en)
        {
            this.id = id;
            this.en = en;
        }
    }
}
