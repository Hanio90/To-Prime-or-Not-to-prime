using System;


namespace isAPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Numbers.isAPrimeNumber(150) ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(2) ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(53) ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(23123) ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            Console.ReadKey();

            /*
            OUTPUT:
            
            Is not a prime number!
            Is a prime number!
            Is a prime number!
            Is not a prime number!

            */
        }
    }
}
