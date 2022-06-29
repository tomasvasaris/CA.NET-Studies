namespace BM012_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mokausi_test0()
        {
            var fake = " sgmokausissg  ";
            var expected = "Ne";
            var actual = BM012.Program.MokausiDar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mokausi_test1()
        {
            var fake = " a6 mokausi labai  ";
            var expected = "Taip";
            var actual = BM012.Program.MokausiDar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mokausi_test2()
        {
            var fake = "";
            var expected = "Ne";
            var actual = BM012.Program.MokausiDar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Mokausi_test3()
        {
            var fake = "a6 MOKAUSI labai";
            var expected = "Taip";
            var actual = BM012.Program.MokausiDar(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARaide_test0()
        {
            var fake = " sgssg  ";
            var expected = 0;
            var actual = BM012.Program.ARaide(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARaide_test1()
        {
            var fake = " a6 mokausi labai  ";
            var expected = 2;
            var actual = BM012.Program.ARaide(fake);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ARaide_test2()
        {
            var fake = "";
            var expected = 0;
            var actual = BM012.Program.ARaide(fake);
            Assert.AreEqual(expected, actual);
        }
    }
}