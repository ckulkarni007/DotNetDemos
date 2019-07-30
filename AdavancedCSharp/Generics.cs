using System;
using System.Collections.Generic;

namespace AdavancedCSharp
{
    class Generics
    {
        public static void Main()
        {
            #region Generic Abstraction
            Console.WriteLine("Hello World!!");
            //Employee<int> employee = new Employee<int>(new SimpleCalc());
            //int totalSalry = employee.GetTotalSalary(10000, 2000);
            //Console.WriteLine("Total Salary" + totalSalry);
            //bool areEqual = employee.AreEqual(1000, 2000);

            //Employee<double> newEmp = new Employee<double>(new SimpleDoubleCalc());
            //double netSalary = newEmp.GetTotalSalary(12569.5541, 2685.2125);
            BookStore bookStore = new BookStore();
            bookStore.Add(new Book() { Name = "Demo on C#" });
            bookStore.Add(new Book() { Name = "test on C#" });
            bookStore.Add(new Book() { Name = "Demo on sacsa#" });
            bookStore.Add(new Book() { Name = "Demo on casc#" });
            Console.WriteLine(bookStore[2].Name);

            Store<Book> bookStoreNew = new Store<Book>();
            Console.ReadLine();
            #endregion


        }

    }

   


    #region  Generic Collection
    class Store<T>
    {
        private T[] _itemCollection = new T[20];
        private int _counter = 0;

        public void Add(T item)
        {
            _itemCollection[_counter] = item;
            _counter++;
        }

        public T this[int index]
        {
            get
            {
                return _itemCollection[index];
            }
        }
         
    }


    class BookStore
    {
        private Book[] _books = new Book[20];
        private int _counter = 0;
        public void Add(Book book)
        {
            _books[_counter] = book;
            _counter++;
        }

        public Book this[int index]
        {
            get
            {
                return _books[index];
            }
        }
    }
    class Book
    {
        public string Name { get; set; }
    } 
    #endregion


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

        public T Add<T>(T a, T b) where T : Addition, new()
        {
            return new T();
        }
    } 
    #endregion

    #region Generic Abstraction

    class Employee<T> where T : struct
    {
        Calculator<T> _calculator;
        public Employee(Calculator<T> calculator)
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

    abstract class Calculator<T> where T : struct
    {
        public abstract T Add(T a, T b);

        public abstract bool Equals(T a, T b);
    }

    class SimpleCalc : Calculator<int>
    {
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public override bool Equals(int a, int b)
        {
            return a == b ? true : false;
        }
    }

    class SimpleDoubleCalc : Calculator<double>
    {
        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override bool Equals(double a, double b)
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
