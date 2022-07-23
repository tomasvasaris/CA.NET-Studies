using BM021;

namespace BM021_Test
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SuperSkaiciuotuvasTest1()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "3" };
            var expected = 50d;

            Program.Reset();
            foreach (var move in fake_moves)
            {
                Program.SuperSkaiciuotuvas(move);
            }
            var actual = BM021.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest2()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "3" };
            var expected = 60d;
            BM021.Program.Reset();
            foreach (var move in fake_moves)
            {
                BM021.Program.SuperSkaiciuotuvas(move);
            }
            var actual = BM021.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SuperSkaiciuotuvasTest3()
        {
            var fake_moves = new string[] { "1", "1", "15", "45", "2", "2", "10", "1", "3", "2", "3", "3" };
            var expected = 6d;

            BM021.Program.Reset();
            foreach (var move in fake_moves)
            {
                BM021.Program.SuperSkaiciuotuvas(move);
            }
            var actual = BM021.Program.Rezultatas();

            Assert.AreEqual(expected, actual);
        }
    }
}