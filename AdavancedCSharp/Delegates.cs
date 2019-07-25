using System;

namespace AdavancedCSharp
{
    public class Delegates
    {

        public delegate int MathOperation(int a, int b);

        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            MathOperation addOperation = new MathOperation(Sum);
            MathOperation subOperation = new MathOperation(Subtract);
            Console.WriteLine($"a + b = {addOperation(a, b)}");
            Console.WriteLine($"a - b = {subOperation(a, b)}");

            Console.ReadKey();
        }
    }

    public class MultiCastDelegates
    {

        public delegate int MathOperation(int a);
        private int _counter = 0;
        public int Increment(int count)
        {
            return _counter + count;
        }

        public int Decrement(int counter)
        {
            return _counter - counter;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = Convert.ToInt32(Console.ReadLine());

            MultiCastDelegates multicastDelegate = new MultiCastDelegates();
            MathOperation mathOperation = new MathOperation(multicastDelegate.Increment);
            mathOperation += multicastDelegate.Decrement;
            Console.WriteLine("Final Count "+ mathOperation(count));
            Console.ReadKey();
        }
    }
}
