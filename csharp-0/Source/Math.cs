using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Math
    {
        public List<int> Fibonacci()
        {
            var fibonacci = new List<int> { 0, 1, 1 };

            while (fibonacci.Count < 14)
            {
                var previous = fibonacci[fibonacci.Count - 1];
                var previous2 = fibonacci[fibonacci.Count - 2];

                fibonacci.Add(previous + previous2);
            }

            return fibonacci;

            throw new NotImplementedException();
            
        }

        public bool IsFibonacci(int numberToTest)
        {
            return Fibonacci().Contains(numberToTest);
            throw new NotImplementedException();
        }
        
    }
}
