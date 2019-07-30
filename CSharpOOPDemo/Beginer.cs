using System;

namespace CSharpOOPDemo
{
    class Beginer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Trainer alex = new Trainer();
            alex.age = 24;
            alex.name = "Alex";
            Trainer sam = new Trainer();
            sam.name = "Alex";
            sam.age = 24;
            Console.WriteLine(sam.Equals(alex));
            Console.Write(sam == alex);

            Console.ReadKey();
        }
    }

    class Trainer
    {
       
        public string name;
        public int age;

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Trainer objTrainer = (Trainer)obj;

            if (objTrainer.name.Equals(this.name) && objTrainer.age.Equals(this.age))
                return true;
            else return false;
            
        }
    }
}
