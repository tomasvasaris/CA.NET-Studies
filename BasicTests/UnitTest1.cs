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
    }
}