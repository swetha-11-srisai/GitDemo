using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareProblem
{
    class Square
    {
        int a1=10;
        int a2=10;
        //public void Values()
        //{
          //  a1 = 4;
            //a2 = 4;
            
        //}
        public int GetArea()
        {
            return a1 * a2;
        }
        public void Display()
        {
            Console.WriteLine("side1:{0}", a1);
            Console.WriteLine("side2:{0}", a2);
            Console.WriteLine("Area of Square:{0}", GetArea());
        }

        static void Main(string[] args)
        {
            Square s = new Square();
            Class1 c = new Class1();
            //Assign a = new Assign(); 
            //s.Values();
            s.GetArea();
            s.Display();
            c.Check();
           // a.Check();
            Console.ReadLine();
        }
    }
}
