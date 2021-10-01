using System;
using System.Linq;

namespace PotterKata
{
    public class Basket
    {
        public double GetPrice(int[] books)
        {
            if (books.All(book => book == books[0]))
                return books.Length * 8.0;

            switch (books.Length)
            {
                case 1:
                    return 8.0;
                case 2:
                    return 15.2;
                case 3:
                    return 21.6;
                case 4:
                    return 25.6;
                case 5:
                    return 30.0;
                default:
                    throw new Exception();
            }
        }
    }
}
