namespace BasicTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SmallestArrayNo()
        {
            int[] test = new int[] { 1, -2, 3 };
            int expected = -2;
            var actual = BM019.Program.SmallestArrayNo(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestArrayNo()
        {
            int[] test = new int[] { 1, 12, 3 };
            int expected = 12;
            var actual = BM019.Program.LargestArrayNo(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortArrayFromLargest()
        {
            int[] test = new int[] { 1, 12, 3, -5 };
            int[] expected = { 12, 3, 1, -5 };
            var actual = BM019.Program.sortArrayFromLargest(test);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SortArrayABC()
        {
            char[] test =     new char[] { 'z', 'A', 's' };
            char[] expected = new char[] { 'A', 's', 'z' };
            var actual = BM019.Program.sortArrayABC(test);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargestInList()
        {
            List<int> test = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = BM020.Program.largestInList(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void LargerThanLargest()
        {
            List<int> test     = new List<int> { 5, 1, 6, 8, 7 };
            List<int> expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            List<int> actual = BM020.Program.largerThanLargest(test);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListAverage()
        {
            List<int> test = new List<int> { 5, 1, 6, 8, 7 };
            int expected = (5+1+6+8+7)/5;
            int actual = BM022.Program.ListAverage(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ListPositivity()
        {
            var tested = new List<int> { 5, -1, 0 };
            var expect = new List<string> { "Pos", "Neg", "Pos" };
            var actual = BM022.Program.ListPositivity(tested);
            CollectionAssert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void GetNumbersInText()
        {
            var tested = "as5d1af16f";
            var expect = "5116";
            var actual = BM022.Program.GetNumbersInText(tested);
            Assert.AreEqual(expect, actual);
        }

        [TestMethod]
        public void SortNumbersFromText()
        {
            var tested = "5116";
            var expect = new List<int> { 1, 1, 5, 6 };
            var actual = BM022.Program.SortNumbersFromText(tested);
            CollectionAssert.AreEqual(expect, actual);
        }
    }
}