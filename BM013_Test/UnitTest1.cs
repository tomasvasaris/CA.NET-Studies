namespace BM013_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDNR_1()
        {
            var fake1 = 1;
            var fake2 = 0.5;
            var fake3 = "/";
            var expected = 2;
            var actual = BM013.Program.Skaiciuotuvas(fake1, fake2, fake3);
            Assert.AreEqual(expected, actual);
        }
    }
}