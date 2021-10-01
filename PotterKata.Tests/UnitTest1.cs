using NUnit.Framework;

namespace PotterKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 0 })]
        public void NoBookDuplicate(int[] books)
        {
            Assert.AreEqual(8, new Basket().GetPrice(books));
        }


    }
}