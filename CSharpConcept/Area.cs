using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulae
{
    public class Area 
    {
        public static int aS = 10;  //static variable or class variable
        public static int bS = 20;

        public int aNS = 10; //non-static variable or instance variable 
        public int bNS = 20;

        public Area(int a) 
        {
            Console.WriteLine("Browser launch!!!");
        }

        public Area(double a)
        {
            Console.WriteLine("Browser launch!!!");
        }

        public Area(int a,double b)
        {
            Console.WriteLine(a*b);
            Console.WriteLine("Browser launch!!!");
        }

        public Area(double a, int b):this(b,a)
        {
           
           
        }



        public void PrintValue()
        {
            Console.WriteLine(Area.aS);
            Console.WriteLine(Area.bS);

            Console.WriteLine(aNS);
            Console.WriteLine(bNS);
        }
        public double AreaOfCircle(int r)
        {
            double area= 3.14 * r * r;
            return area;
        }

        public static double AreaOfSquare(int side)
        {
            return side * side;
        }

        public String GetAuthorName()
        {
            return "Balaji";
        }

        public void Quit()
        {

        }
    }
}
