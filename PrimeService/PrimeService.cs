using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }

            if (candidate == 2)
            {
                return true;
            }

            if (candidate % 2 == 0)
            {
                return false;
            }

            for (int divisor = 3; divisor <= Math.Sqrt(candidate); divisor += 2)
            {
                if (candidate % divisor == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}