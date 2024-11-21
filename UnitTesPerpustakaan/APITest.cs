using Aplikasi_Perpustakaan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTesPerpustakaan
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void GetJudulBukuTest()
        {
            string expected = "Bebas";
            List<Buku> result = Buku.GetDataBuku();
            Assert.AreEqual(expected, result[0].judulBuku);
        }

        [TestMethod]
        public void GetNamaPeminjam()
        {
            string expected = "Doni";
            List<ResponsePeminjaman> list_peminjaman = Peminjaman.GetDataPeminjaman();
            Assert.AreEqual(expected, list_peminjaman[0].namaPeminjam);
        }
    }
}   