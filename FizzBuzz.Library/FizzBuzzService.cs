using System;
using System.Collections.Generic;

namespace FizzBuzz.Library{

    public class FizzBuzzService
    {
        public String Print(int number)
        {
            
            if (IsDivisibleBy3(number) && IsDivisibleBy5(number))
            {
                return "FizzBuzz";
            }

            else if (IsDivisibleBy5(number))
            {
                return "Buzz";
            }

            else if (IsDivisibleBy3(number))
            {
                return "Fizz";
            }


            return number.ToString();
        }

        private Boolean IsDivisibleBy3(int number) => number % 3 == 0;
        private Boolean IsDivisibleBy5(int number) => number % 5 == 0;
    }
}

