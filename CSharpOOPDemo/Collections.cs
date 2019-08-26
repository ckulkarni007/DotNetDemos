using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPDemo
{
    public class Collections
    {
        static void Main(string[] args)
        {

            HashSet<string> vs = new HashSet<string>();

            Console.WriteLine("Hello World!");
            int[] array = new int[3]; // 3 size array
            array[0] = 1;
            array[1] = 1;
            array[2] = 1;
            array[3] = 1;

            Console.WriteLine(array[2]);
        }
    }
}
