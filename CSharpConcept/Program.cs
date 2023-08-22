

using MathFormulae;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securiton.CSharpConcept
{
    public class Program
    {
        public static void Main2(string[] args)
        {
            //Console.WriteLine("Balaji Dinakaran ");

            //char letter = '#'; //16 bits 

            //String name = "Balaji"; //16*6 

            //int radius = 10; //32 bits

            ////double result = 3.14 * radius * radius;
            ////Console.WriteLine(result);

            ////radius = 20;


            ////result = 3.14 * radius * radius;
            ////Console.WriteLine(result);


            //Area obj1=  new Area();

            //double res = obj1.AreaOfCircle(10);
            //Console.WriteLine(res);

            //Console.WriteLine(obj1.AreaOfCircle(20));

            //Console.WriteLine(Area.AreaOfSquare(4));

            //string authorName= obj1.GetAuthorName();
            //Console.WriteLine(authorName);

            //obj1.Quit();

            Area.aS = 100;

            Console.WriteLine(Area.aS);
            Console.WriteLine(Area.bS);

            Area obj1 = new Area(10);

            Area obj2=new Area(101);


            obj1.aNS = 1000;

            Console.WriteLine(obj1.aNS);
            Console.WriteLine(obj1.bNS);


            obj1.PrintValue();

            Console.ReadLine();
        }

    }
}
