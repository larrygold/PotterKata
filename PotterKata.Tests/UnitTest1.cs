using NUnit.Framework;

namespace PotterKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 0 }, 8)]
        /*
        [TestCase(new int[] {0, 1}, 15.2)]
        */
        public void NoBookDuplicate(int[] books, double expected)
        {
            Assert.AreEqual(expected, new Basket().GetPrice(books));
        }


    }
}