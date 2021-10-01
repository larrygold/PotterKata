using System;
using System.Linq;

namespace PotterKata
{
    public class Basket
    {
        private const double UnitPrice = 8.0;

        public double GetPrice(int[] books)
        {
            if (books.All(book => book == books[0]))
                return books.Length * UnitPrice;

            var totalBasePrice = books.Length * UnitPrice;

            if ((books.Distinct().Count() == 2) && (books.Length == 4))
                return 3 * 0.90 * UnitPrice + 1 * UnitPrice;

            if ((books.Distinct().Count() == 2) && (books.Length == 3))
                return 2 * 0.95 * UnitPrice + 1 * UnitPrice;


            switch (books.Length)
            {
                case 1:
                    return totalBasePrice;
                case 2:
                    return totalBasePrice * 0.95;
                case 3:
                    return totalBasePrice * 0.90;
                case 4:
                    return totalBasePrice * 0.80;
                case 5:
                    return totalBasePrice * 0.75;
                default:
                    throw new Exception();
            }
        }
    }
}
