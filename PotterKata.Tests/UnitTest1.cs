using NUnit.Framework;

namespace PotterKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [TestCase(new int[] { 0 }, 8, TestName = "1 book")]
        [TestCase(new int[] {0, 1}, 15.2, TestName = "2 books")]
        [TestCase(new int[] {0, 1, 2}, 21.6, TestName = "3 books")]
        [TestCase(new int[] {0, 1, 2, 3}, 25.6, TestName = "4 books")]
        [TestCase(new int[] {0, 1, 2, 3, 4}, 30, TestName = "5 books")]
        public void NoBookDuplicate(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }

        [Ignore("")]
        [TestCase(new int[] { 0, 0 }, 16, TestName = "2 identical books")]
        public void BookDuplicates(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }



    }
}