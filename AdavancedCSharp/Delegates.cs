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

        public static int ProcessNumbers(int a, int b, MathOperation mathOperation)
        {

            //int store
            // int validation
            // int datye, business check

            return mathOperation(a, b);
        }

        static void Main(string[] args)
        {
            //MathOperation mathOperation = new MathOperation(Sum);
            ProcessNumbers(10, 20, Sum);

            Console.ReadKey();
        }
    }


    public class MultiCastDelegates
    {
        // Declare a delegate
        public delegate void Display(string name);
        public void DisplayOnlyName(string name)
        {
            Console.WriteLine(name);
        }
        // Define methods matching to delegate
        public void DisplayNameWithDetails(string name)
        {
            Console.WriteLine("The full name is "+ name);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the count");
            int count = Convert.ToInt32(Console.ReadLine());
            MultiCastDelegates multicastDelegate = new MultiCastDelegates();

            // Initialize a delegate
            Display mathOperation = new Display(multicastDelegate.DisplayOnlyName);
            mathOperation += multicastDelegate.DisplayNameWithDetails;
            // invoke a delegate
            mathOperation("Chaitanya");
            Console.ReadKey();
        }
    }


    public class AbstractGenericDelegates
    {
        public delegate T Sum<T>(T a, T b);

        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public double AddDoubles(double a, double b)
        {
            return a + b;
        }
        public string ConcateStrings(string a, string b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AbstractGenericDelegates abstractGenericDelegates = new AbstractGenericDelegates();


            Sum<int> sum = new Sum<int>(abstractGenericDelegates.AddNumbers);
            Console.WriteLine(sum(5,10));

            Console.ReadKey();
        }
    }
}
