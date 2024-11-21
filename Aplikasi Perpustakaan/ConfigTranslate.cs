using System;


namespace Aplikasi_Perpustakaan
{
    class ConfigTranslate
    {
        public BahasaPagePeminjaman BahasaPagePeminjaman { get; set; }
        public BahasaPageBook BahasaPageBook { get; set; }
        public LinkAPI LinkAPI { get; set; }

        public ConfigTranslate() { }
        public ConfigTranslate(BahasaPagePeminjaman bahasaPagePeminjaman, BahasaPageBook bahasaPageBook, LinkAPI linkAPI)
        {
            this.BahasaPagePeminjaman = bahasaPagePeminjaman;
            this.BahasaPageBook = bahasaPageBook;
            this.LinkAPI = linkAPI;
        }
    }

    class BahasaPagePeminjaman
    {
        public LabelIdBuku LabelIdBuku { get; set; }
        public LabelNamaPeminjam LabelNamaPeminjam { get; set; }

        public BahasaPagePeminjaman() {}
        public BahasaPagePeminjaman(LabelIdBuku labelIdBuku, 
            LabelNamaPeminjam labelNamaPeminjam)
        {
            this.LabelIdBuku = labelIdBuku;
            this.LabelNamaPeminjam = labelNamaPeminjam;
        }

    }

    class LabelIdBuku
    {
        public string Id { get; set; }
        public string En { get; set; }

        public LabelIdBuku() { }
        public LabelIdBuku(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class LabelNamaPeminjam
    {
        public string Id { get; set; }
        public string En { get; set; }

        public LabelNamaPeminjam() { }
        public LabelNamaPeminjam(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class BahasaPageBook
    {
        public LabelJudulBuku LabelJudulBuku { get; set; }
        public LabelPenulis LabelPenulis { get; set; }
        public LabelPenerbit LabelPenerbit { get; set; }
        public LabelTahunPenerbit LabelTahunPenerbit { get; set; }
        public LabelJumlahHalaman LabelJumlahHalaman { get; set; }
        public ButtonHapus ButtonHapus { get; set; }
        public ButtonKembali ButtonKembali { get; set; }

        public BahasaPageBook() {}
        public BahasaPageBook(LabelJudulBuku labelJudulBuku, LabelPenulis labelPenulis,
            LabelPenerbit labelPenerbit, LabelTahunPenerbit labelTahunPenerbit,
            LabelJumlahHalaman labelJumlahHalaman, ButtonHapus buttonHapus, ButtonKembali
            buttonKembali)
        {
            this.LabelJudulBuku = labelJudulBuku;
            this.LabelPenulis = labelPenulis;
            this.LabelPenerbit = labelPenerbit;
            this.LabelTahunPenerbit = labelTahunPenerbit;
            this.LabelJumlahHalaman = labelJumlahHalaman;
            this.ButtonHapus = buttonHapus;
            this.ButtonKembali = buttonKembali;
        }
    }

    class LabelJudulBuku
    {
        public string Id { get; set; }
        public string En { get; set; }
        public LabelJudulBuku() { }
        public LabelJudulBuku(string id, string en)
        {
            this.Id= id;
            this.En= en;
        }
    }

    class LabelPenulis
    {
        public string Id { get; set; }
        public string En { get; set; }
        public LabelPenulis() { }
        public LabelPenulis(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class LabelPenerbit
    {
        public string Id { get; set; }
        public string En { get; set; }
        public LabelPenerbit() { }
        public LabelPenerbit(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class LabelTahunPenerbit
    {
        public string Id { get; set; }
        public string En { get; set; }
        public LabelTahunPenerbit() { }
        public LabelTahunPenerbit(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class LabelJumlahHalaman
    {
        public string Id { get; set; }
        public string En { get; set; }
        public LabelJumlahHalaman() { }
        public LabelJumlahHalaman(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class ButtonHapus
    {
        public string Id { get; set; }
        public string En { get; set; }
        public ButtonHapus() { }
        public ButtonHapus(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class ButtonKembali
    {
        public string Id { get; set; }
        public string En { get; set; }
        public ButtonKembali() { }
        public ButtonKembali(string id, string en)
        {
            this.Id = id;
            this.En = en;
        }
    }

    class LinkAPI
    {
        public string LinkBukuGet { get; set; }
        public string LinkBukuPost { get; set; }
        public string LinkBukuPatch { get; set; }
        public string LinkBukuDelete { get; set; }
        public string LinkPeminjamanGet { get; set; }
        public string LinkPeminjamanPost { get; set; }
        public string LinkPeminjamanPatch { get; set; }
        public string LinkPeminjamanDelete { get; set; }

        public LinkAPI() { }
        public LinkAPI(string linkBukuGet, string linkBukuPost, string linkBukuPatch,
           string linkBukuDelete, string linkPeminjamanGet, string linkPeminjamanPost,
           string linkPeminjamanPatch, string linkPeminjamanDelete)
        {
            this.LinkBukuGet = linkBukuGet;
            this.LinkBukuPost = linkBukuPost;
            this.LinkBukuPatch = linkBukuPatch;
            this.LinkBukuDelete = linkBukuDelete;
            this.LinkPeminjamanGet = linkPeminjamanGet;
            this.LinkPeminjamanPost = linkPeminjamanPost;
            this.LinkPeminjamanPatch = linkPeminjamanPatch;
            this.LinkPeminjamanDelete = linkPeminjamanDelete;
        }
    }





}
