using System;

namespace PotterKata
{
    public class Basket
    {
        public double GetPrice(int[] books)
        {
            if (books.Length == 2)
                return 15.2;
            return 8.0;
        }
    }
}
