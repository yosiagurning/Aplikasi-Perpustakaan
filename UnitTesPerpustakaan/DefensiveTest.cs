using Aplikasi_Perpustakaan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesPerpustakaan
{
    [TestClass]
    public class DefensiveTest
    {
        [TestMethod]
        public void CekValidasiInputBuku()
        {

            string excected = "berhasil";
            string hasil = ValidasiInput.CekValidasi("", "buku ainun", "100", "yuna", "gramedia", "2002", "dipinjam");
            Assert.AreEqual(excected, hasil);

        }
    }
}

