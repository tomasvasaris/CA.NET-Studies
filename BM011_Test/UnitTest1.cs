namespace BM011_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TarpaiPrieky_Test1()
        {
            var fake = " sgssg  ";
            var expected = 1;
            var actual = BM011.Program.TarpaiPrieky(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiGale_Test1()
        {
            var fake = " sgssg  ";
            var expected = 2;
            var actual = BM011.Program.TarpaiGale(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPriekyIrGale_Test1()
        {
            var fake = " sgssg  ";
            var expected = 1;
            var actual = BM011.Program.TarpaiPriekyIrGale(fake, out int tarpaiGale);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TarpaiPriekyIrGale_Test2()
        {
            var fake = " sgssg  ";
            var expected1 = 1;
            var expected2 = 2;
            var actual1 = BM011.Program.TarpaiPriekyIrGale(fake, out int actual2);
            Assert.AreEqual(expected1, actual1);
            Assert.AreEqual(expected2, actual2);
        }
    }
}