using System;
using System.Collections.Generic;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();  //Explicit Typing
            myCar.make = "Toyota";
            myCar.model = "Tundra";
            myCar.year = 2006;

            var subaru = new Car() //inferred typing
            {
                make = "Suburu",
                model = "Impreza",
                year = 2019
            };

            var chevy = new Car("Chevy", "Impala", 2012);

            Console.WriteLine(myCar.year);
            Console.WriteLine(myCar.make);
            Console.WriteLine(myCar.model);
            Console.WriteLine();
            
            Console.WriteLine(subaru.year);
            Console.WriteLine(subaru.make);
            Console.WriteLine(subaru.model);
            Console.WriteLine();

            Console.WriteLine(chevy.year);
            Console.WriteLine(chevy.make);
            Console.WriteLine(chevy.model);

           
        }
    }
}
