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

            if (books.Distinct().Count() != books.Length)
            {

                var booksList = books.ToList();
                var totalDiscountedPrice = 0.0;
                var distinctBooks = booksList.Distinct().ToList();

                while (distinctBooks.Any())
                {
                    totalDiscountedPrice += distinctBooks.Count() * _discountFactorPerNumberOfDistinctBooks[distinctBooks.Count()] * UnitPrice;
                    foreach (var book in distinctBooks)
                    {
                        booksList.Remove(book);
                    }
                    distinctBooks = booksList.Distinct().ToList();
                }

                /*
                totalDiscountedPrice += booksList.Count * UnitPrice;
                */
                return totalDiscountedPrice;

            }

            var totalBasePrice = books.Length * UnitPrice;
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
