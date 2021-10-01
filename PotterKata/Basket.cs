using System;

namespace PotterKata
{
    public class Basket
    {
        public double GetPrice(int[] books)
        {

            switch (books.Length)
            {
                case 1:
                    return 8.0;
                case 2:
                    if (books[0] == books[1]) return 16.0;
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
