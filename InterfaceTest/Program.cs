using InterfaceABstraction;
using System;
using TestClasss;

namespace InterfaceTest
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IKitchen kitchen = new HotelKitchen();
            kitchen.GetOrderName();
            Console.ReadKey();
        }
    }
}
