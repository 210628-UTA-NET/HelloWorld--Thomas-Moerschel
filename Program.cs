using System;
using HouseFunction;


namespace HelloWord
{
    class Program
    {
        private static string _first = "Hello";
        private static string _last = "World!";

        static void Main(string[] args)
        {
            
            Console.WriteLine("This can be whatever I want!");

            Test obj = new Test();
            obj.SomeMethod();

            Console.WriteLine(_first + " " + _last);
            Console.WriteLine(obj.SomeMethod());
            

            House objHouse = new House();
            Console.WriteLine(objHouse.getColor());
            objHouse.setColor("Blue");
            Console.WriteLine(objHouse.getColor());
            objHouse.Price = 800000;
            Console.WriteLine("Thomas' house was bought for $" + objHouse.Price);
            objHouse.Name = "Thomas' very Expensive House";
            Console.WriteLine(objHouse.Name);
        }
    }
    class Test
    {
        public string SomeMethod()
        {
            return "Hello World SomeMethod";
        }
    }
}
