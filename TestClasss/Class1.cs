using InterfaceABstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasss
{
   
    public class HotelKitchen : IKitchen
    {
        public string GetOrderName()
        {
            return "This is a time for based hotel kitchen";
        }
    }
}
