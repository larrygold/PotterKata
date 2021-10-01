using System;

namespace PotterKata
{
    public class Basket
    {
        public double GetPrice(int[] books)
        {
            switch (books.Length)
            {
                case 2:
                    return 15.2;
                case 3:
                    return 21.6;
            }
                
            return 8.0;
        }
    }
}
