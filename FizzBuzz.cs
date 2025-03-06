using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0
{
    class FizzBuzz
    {
        int upperRange = 0;

        public FizzBuzz(int number)
        {
            upperRange = number;
        }
        public void show()
        {
            for (int num = 1; num <= upperRange; num++)
            {
                if (num % 3 == 0)
                    Console.Write("Fizz");
                if (num % 5 == 0)
                    Console.Write("Buzz");
                if (!(num % 3 == 0 || num % 5 == 0))
                    Console.Write(num);
                Console.Write("\n");
            }
            
        }
    }
}
