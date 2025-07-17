using System;

namespace TestApplication
{
       class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, .NET 8!");
            byte number = 22;
            Console.WriteLine($"The number is: {number}");
            //by default real number is double , so add f to make it float
            float price = 22.08f;
            Console.WriteLine($"The price is: {price}");
            bool isWorking = true;
            Console.WriteLine($"Is it working? {isWorking}");
            char letter = 'V';
            Console.WriteLine($"The letter is: {letter}");
            string name = "Vignan";
            Console.WriteLine($"my name is {name}");

            //we can use .net var aswell that will automatically detect the type of variable
            var numberTwo = 23;
            var priceTwo = 23.08f;
            var c = 'c';
            Console.WriteLine($"The second number is: {numberTwo}");
            Console.WriteLine($"The second price is: {priceTwo}");
         
            Console.WriteLine("{0}{1}",2,44);
            
            //cw shortcut for Console.WriteLine by vs
            Console.WriteLine();
        }
    }
}