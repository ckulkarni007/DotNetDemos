using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPDemo
{
    //Encapsulation/Data hidding
    class Accountant
    {
        //public string Name;
        //public double Salary;
        //public int Age;
        private string _name;
        private double _salary;
        private int _age;

        public string Name { get; set; }

        public int Salary
        {
            get { return this._age; }
            set {
                if(value  < 10000)
                {
                    //throw exception
                }
                this._age = value;
            }
        }

        public void SetSalary(double amount)
        {
            //if (amount > 0)
            //    this._salary = amount;
            //else
            //    throw new Exception("Invalid Salary Amount...Kuch to do bhai");
            this._salary = amount;
        }
        public double GetSalary()
        {
            return this._salary;
        }

        //public static Accountant operator +(Accountant accountant1, Accountant accountant2)
        //{
        //    return new Accountant { _salary = accountant1.GetSalary() + accountant2.GetSalary() };
        //}


        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                //value is a backing field.
                if (value < 30)
                    this._age = value;
                else
                    throw new Exception("I am quite younger that you think.");
            }
        }
    }

    public class Encapsulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Encapsu
            Accountant accountant = new Accountant();
            //accountant.SetSalary(-50);
            accountant.Salary = 152;
            //Operator Overloading

            //Accountant accountant1 = new Accountant();
            //accountant1.SetSalary(50);
            //Accountant accountant2 = new Accountant();
            //accountant2.SetSalary(50);
            //Accountant accountant3 = accountant1 + accountant2;
            //Console.WriteLine($"Total Salary - {accountant3.GetSalary()}");
            //Console.ReadKey();
        }
    }
}
