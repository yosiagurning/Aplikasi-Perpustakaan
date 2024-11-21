using Aplikasi_Perpustakaan;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Runtime.CompilerServices;

[assembly:InternalsVisibleTo("CariBukuTest.Caribuku")]
namespace CaribukuTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            CariBuku Testing1 = new CariBuku();

            //Assert
            Assert.AreEqual(Testing1.BukuTersedia("AA"), true);


        }
    }
}