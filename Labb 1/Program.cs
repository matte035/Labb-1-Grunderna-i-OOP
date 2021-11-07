using System;

namespace Labb_1
{
    public class Circle
    {
        public float _pi = 3.141f;
        public int _Radius;

        public Circle(int radius)
        {
            this._Radius = radius;
        }

        public float GetArea()
        {
            Console.WriteLine("The area of the circle is: {0}", _Radius * _Radius * _pi);
            return _Radius *_Radius *_pi;
            
            
        }
    }
    class Program
    
    {
       


        static void Main(string[] args)
        {
            Circle c1 = new Circle(5);
            Circle c2 = new Circle(6);

            c1.GetArea();
            c2.GetArea();
            Console.ReadKey();
               
        }
    }
}
