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
        public void sortArrayFromLargest()
        {
            int[] test = new int[] { 1, 12, 3, -5 };
            int[] expected = { 12, 3, 1, -5 };
            var actual = BM019.Program.sortArrayFromLargest(test);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void sortArrayABC()
        {
            char[] test =     new char[] { 'z', 'A', 's' };
            char[] expected = new char[] { 'A', 's', 'z' };
            var actual = BM019.Program.sortArrayABC(test);
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void largestInList()
        {
            List<int> test = new List<int> { 5, 1, 6, 8, 7 };
            int expected = 8;
            var actual = BM020.Program.largestInList(test);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void largerThanLargest()
        {
            List<int> test     = new List<int> { 5, 1, 6, 8, 7 };
            List<int> expected = new List<int> { 5, 1, 6, 8, 7, 9 };
            List<int> actual = BM020.Program.largerThanLargest(test);
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}