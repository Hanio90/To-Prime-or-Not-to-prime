using System;


namespace isAPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var message = Numbers.isAPrimeNumber(150) == true ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(2) == true ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(53) == true ? "Is a prime number!" : "Is not a prime number!";
            Console.WriteLine(message);

            message = Numbers.isAPrimeNumber(23123) == true ? "Is a prime number!" : "Is not a prime number!";
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
