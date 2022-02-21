using System;

namespace BasicClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Toyota";
            myCar.model = "Tundra";
            myCar.year = 2006;
            Console.WriteLine(myCar.year);
            Console.WriteLine(myCar.make);
            Console.WriteLine(myCar.model);           
        }
    }
}
