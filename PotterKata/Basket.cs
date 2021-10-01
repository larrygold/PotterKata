using System;
using System.Collections.Generic;
using System.Linq;

namespace PotterKata
{
    public class Basket
    {
        private Dictionary<int, double> _discountFactorPerNumberOfDistinctBooks;

        public Basket()
        {
            _discountFactorPerNumberOfDistinctBooks = new Dictionary<int, double>()
            {
                { 1, 1.0 },
                { 2, 0.95 },
                { 3, 0.90 },
                { 4, 0.80 },
                { 5, 0.75 }
            };
        }

        private const double UnitPrice = 8.0;

        public double GetPrice(int[] books)
        {
            if (books.All(book => book == books[0]))
                return books.Length * UnitPrice;

            var totalBasePrice = books.Length * UnitPrice;

            if ((books.Distinct().Count() == 2) && (books.Length == 5))
                return 4 * _discountFactorPerNumberOfDistinctBooks[4] * UnitPrice + 1 * UnitPrice;

            if ((books.Distinct().Count() == 2) && (books.Length == 4))
                return 3 * _discountFactorPerNumberOfDistinctBooks[3] * UnitPrice + 1 * UnitPrice;

            if ((books.Distinct().Count() == 2) && (books.Length == 3))
            {
                var numberDistinctBooks = 2;
                return numberDistinctBooks * _discountFactorPerNumberOfDistinctBooks[numberDistinctBooks] * UnitPrice + 1 * UnitPrice;
            }

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
