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
        void test();
    }

    interface ILandLineDevice
    {
        void Ring();
    }

    public class DeviceRingtone : IMobileDevice, ILandLineDevice
    {
        public void test()
        {
            throw new NotImplementedException();
        }

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

    public class ShapeCalculator
    {
        IShape _shape;
        
        public int GetShape()
        {
            Square rect = new Square();
            int result = _shape.GetArea(10, 20);
            return result;
        }

        public int GetShapeForSquare()
        {
            _shape = new Square();
            int result = _shape.GetArea(10, 20);
            return result;
        }
    }


    interface IShape
    {
        int GetArea(int width, int length);
    }
    interface IShapeNew
    {
        int GetArea(int width, int length);
    }

    public class Rectangle : IShape, IShapeNew
    {
        int IShapeNew.GetArea(int width, int length)
        {
            throw new NotImplementedException();
        }

        int IShape.GetArea(int width, int length)
        {
            throw new NotImplementedException();
        }
    }

    public class Square : IShape
    {
        public int GetArea(int width, int length)
        {
            if (width == length)
                return width * length;
            else return  0;
        }
    }
}

