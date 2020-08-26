using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
{
    public abstract class Shape
    {
        public abstract void   RectangleArea( int lenght, int breadth );
        public abstract void  SquareArea(int side );
        public abstract void   CircleArea(int radius);
    }
    /* class Rectangle: Shape
     {
         public override int RectangleArea(int l, int b)
         {
             int ar = l * b;
             return ar;
         }
         public override int SquareArea(int s)
         {
             int ar = s * s * s;
             return  ar;
         }
         public override float CircleArea(float r)
         {
             float pi = 3.14;
             float ar = pi *(r*r);
            return ar;
         }
     }*/
    class Area : Shape
    {
        public override void  RectangleArea(int l, int b)
        {
            int ar = l * b;
            Console.WriteLine(" area of rect is " + ar);
        }
        public override void  SquareArea(int s)
        {
            int ar = s * s * s;
            Console.WriteLine(" area of square is " + ar);
        }
        public override void  CircleArea(int r)
        {
            int  ar =(int)2*3.14*(r*r);
            Console.WriteLine(" area of circle is " + ar);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Area();
            
            s.RectangleArea(2,4);
            s.SquareArea(5);
            s.CircleArea(3);
            Console.ReadKey();
    }
}
