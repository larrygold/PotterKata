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
        public void NoIdenticalBook(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }

        [TestCase(new int[] { 0, 0 }, 16, TestName = "2 identical books")]
        [TestCase(new int[] { 2, 2 }, 16, TestName = "2 identical books")]
        [TestCase(new int[] { 0, 0, 0 }, 24, TestName = "3 identical books")]
        [TestCase(new int[] { 0, 0, 0, 0 }, 32, TestName = "4 identical books")]
        [TestCase(new int[] { 0, 0, 0, 0, 0 }, 40, TestName = "5 identical books")]
        public void OnlyIdenticalBooks(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }

        [TestCase(new int[] { 0, 0, 1 }, 23.2, TestName = "2 identical + 1 non identical")]
        [TestCase(new int[] { 0, 0, 0, 1 }, 29.6, TestName = "3 identical + 1 non identical")]
        [TestCase(new int[] { 1, 0, 0, 0 }, 29.6, TestName = "3 identical + 1 non identical (other order)")]
        [TestCase(new int[] { 0, 0, 0, 0, 1 }, 33.6, TestName = "4 identical + 1 non identical")]
        public void TwoDistinctWithSeveralIdenticalBooks(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }

        [TestCase(new int[] { 0, 0, 1, 1, 2 }, 37.6, TestName = "3 distinct incl. 2 books with repetition")]
        [TestCase(new int[] { 0, 0, 1, 1, 2, 3 }, 37.6, TestName = "4 distinct incl. 2 books with repetition")]
        public void MoreThanTwoDistinctWithSeveralIdenticalBooks(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }


    }
}