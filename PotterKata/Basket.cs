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
            var booksList = books.ToList();
            var totalDiscountedPrice = 0.0;
            var distinctBooks = UpdateDistinctBooks(booksList);

            while (distinctBooks.Any())
            {
                totalDiscountedPrice += GetDiscountedPriceForDistinctBooks(distinctBooks);
                UpdateBooksList(distinctBooks, booksList);
                distinctBooks = UpdateDistinctBooks(booksList);
            }

            return totalDiscountedPrice;
        }

        private static List<int> UpdateDistinctBooks(List<int> booksList)
        {
            return booksList.Distinct().ToList();
        }

        private double GetDiscountedPriceForDistinctBooks(List<int> distinctBooks)
        {
            return distinctBooks.Count() * _discountFactorPerNumberOfDistinctBooks[distinctBooks.Count()] * UnitPrice;
        }

        private static void UpdateBooksList(List<int> distinctBooks, List<int> booksList)
        {
            foreach (var book in distinctBooks)
            {
                booksList.Remove(book);
            }
        }
    }
}
