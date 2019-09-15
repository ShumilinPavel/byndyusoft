using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ByndyusoftTask.Tests
{
    [TestClass]
    public class ByndyusoftTaskTests
    {
        private void TestGetSumOfTwoMins(long[] inputNumbers, long expectedResult)
        {
            long actualResult = ByndyusoftTask.GetSumOfTwoMins(inputNumbers);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void EmptyArray()
        {
            TestGetSumOfTwoMins(new long[] { }, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void OneNumberInArray()
        {
            TestGetSumOfTwoMins(new long[] { 1 }, 0);
        }

        [TestMethod]
        public void TwoNumbersInArray()
        {
            TestGetSumOfTwoMins(new long[] { 5, 3 }, 8);
        }

        [TestMethod]
        public void OrdinaryTest()
        {
            TestGetSumOfTwoMins(new long[] { 4, 0, 3, 19, 492, -10, 1 }, -10);
        }

        [TestMethod]
        public void LargeArray()
        {
            var numbers = new long[100000000];
            for (var i = 0; i < 100000000; i++)
                numbers[i] = i;
            TestGetSumOfTwoMins(numbers, 1);
        }
    }
}
