using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPDemo
{
    interface IMobileDevice
    {
        void Ring();
    }

    interface ILandLineDevice
    {
        void Ring();
    }

    public class DeviceRingtone : IMobileDevice, ILandLineDevice
    {
        void ILandLineDevice.Ring()
        {
            Console.WriteLine("Hehe...I am a classic one");
        }

        void IMobileDevice.Ring()
        {
            Console.WriteLine("hehe....I am a next generation");
        }
    }
    public class Abstraction
    {
        // Objects are different from object reference variables.
        static void Main(string[] args)
        {
            DeviceRingtone deviceRingtone = new DeviceRingtone();
            ((ILandLineDevice)deviceRingtone).Ring();
            ((IMobileDevice)deviceRingtone).Ring();
            Console.ReadLine();
        }
    }
}

