using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikasi_Perpustakaan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTesPerpustakaan
{
    [TestClass]
    public class AutomataTest
    {
        [TestMethod]
        public void ObjectInitializingDefaultValueValidation()
        {
            //Arrange
            AutomataStatusBuku StateTest = new AutomataStatusBuku();

            //Assert
            Assert.AreEqual(StateTest.StatusBukuSaatIni, AutomataStatusBuku.StatusBuku.disimpan);
        }

        [TestMethod]
        public void ObjectValueChangeValidationFromDisimpanToDipinjam()
        {
            //Arrange
            AutomataStatusBuku StateTest = new AutomataStatusBuku();

            //Act
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.dipinjam);

            //Assert
            Assert.AreEqual(StateTest.StatusBukuSaatIni, AutomataStatusBuku.StatusBuku.dipinjam);
        }

        [TestMethod]
        public void ObjectValueChangeValidationFromDipinjamToDisimpan()
        {
            //Arrange
            AutomataStatusBuku StateTest = new AutomataStatusBuku();

            //Act
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.dipinjam);
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.dikembalikan);

            //Assert
            Assert.AreEqual(StateTest.StatusBukuSaatIni, AutomataStatusBuku.StatusBuku.disimpan);
        }

        [TestMethod]
        public void ObjectValueChangeValidationFromDisimpanToHilang()
        {
            //Arrange
            AutomataStatusBuku StateTest = new AutomataStatusBuku();

            //Act
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.hilang);

            //Assert
            Assert.AreEqual(StateTest.StatusBukuSaatIni, AutomataStatusBuku.StatusBuku.hilang);
        }

        [TestMethod]
        public void ObjectValueChangeValidationFromDipinjamToHilang()
        {
            //Arrange
            AutomataStatusBuku StateTest = new AutomataStatusBuku();

            //Act
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.dipinjam);
            StateTest.TriggerAksi(AutomataStatusBuku.Aksi.hilang);

            //Assert
            Assert.AreEqual(StateTest.StatusBukuSaatIni, AutomataStatusBuku.StatusBuku.hilang);
        }

    }
}
