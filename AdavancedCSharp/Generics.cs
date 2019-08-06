using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace AdavancedCSharp
{

    class Generics
    {
        public static void Main()
        {
            Store<string> strStore = new Store<string>();
            strStore.Add("test");
            foreach (var item in strStore)
            {
                Console.WriteLine(item);
            }
            Addition addition = new Addition(10);
            ICalculator<int> simpleCalc = new SimpleCalc();

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(string Name)
        {

        }
       
    }

    class Store<T>// : IEnumerable<T>
    {
        T[] ts = new T[20];
        int index = 0;

        public void Add(T item)
        {
            ts[index] = item;
            index++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return ts.Cast<T>().GetEnumerator();
        }

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    return this.GetEnumerator();
        //}
    }


    #region Operators In Generic

    class Addition
    {
        public Addition(int num)
        {
            Number = num;
        }
        public int Number { get; set; }

        public static Addition operator +(Addition a, Addition b)
        {
            return new Addition(a.Number + b.Number);
        }

        public T Add<T>(T a, T b) where T : Addition
        {
            return (T)(a + b);
        }
    }
    #endregion

    #region Generic Abstraction

    class Employee<T> where T : struct
    {
        ICalculator<T> _calculator;
        public Employee(ICalculator<T> calculator)
        {
            _calculator = calculator;
        }
        public T GetTotalSalary(T baseSalary, T bonus)
        {
            return _calculator.Add(baseSalary, bonus);
        }

        public bool AreEqual(T baseSalary, T bonus)
        {
            return _calculator.Equals(baseSalary, bonus);
        }
    }

    interface ICalculator<T> where T : struct
    {
         T Add(T a, T b);

         bool Equals(T a, T b);
    }

    class SimpleCalc : ICalculator<int>
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool Equals(int a, int b)
        {
            return a == b ? true : false;
        }
    }

    class SimpleDoubleCalc : ICalculator<double>
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public bool Equals(double a, double b)
        {
            return a == b ? true : false;
        }
    }
    #endregion

    #region Generic Class Constraints
    class Product
    {
        public int Id;
        public string Name;
    }

    class ProductCalculator<TProduct> where TProduct : Product
    {
        public float CalculateProductAmount(TProduct product)
        {
            product.Id = 20;
            return product.Id;
        }
    }
    #endregion

    #region Interface Constraint
    interface ISchool
    {
        string GetName();
    }

    class Test<T> where T : ISchool
    {
        public string GetData()
        {
            return "";
        }
    }

    class GovtSchool : ISchool
    {
        public string GetName()
        {
            throw new NotImplementedException();
        }

        string GetData()
        {
            Test<GovtSchool> test = new Test<GovtSchool>();
            return test.GetData();
        }
    }

    #endregion

}
