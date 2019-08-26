using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdavancedCSharp
{
    class MyClass
    {
        public const string NameConstant = "Chaitnaya";
        public readonly double pie;
        public MyClass()
        {
            pie = 3.142;
        }
        public void test()
        {
            Console.WriteLine(NameConstant);
        }

    }
}
