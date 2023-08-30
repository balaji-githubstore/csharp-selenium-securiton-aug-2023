//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpConcept
//{

//    class Father
//    {
//        public int fAge = 60;

//        public Father(int a) 
//        {
//            fAge = a;
//            Console.WriteLine(  "Father constructor");
//        }

//        public void FatherStyle()
//        {
//            Console.WriteLine("father style");
//        }
//    }

//    class Son : Father
//    {
//        public int sAge = 20;
//        public Son(int f,int s):base(f)
//        {
//            sAge = s;
//            Console.WriteLine("Son constructor");
//        }
//        public void SonStyle()
//        {
//            //FatherStyle();
//            Console.WriteLine("Son style");
//        }
//    }

//    public class Program3
//    {
//        public static void Main(string[] args)
//        {
//            Son son = new Son();
//            son.FatherStyle();
//            son.SonStyle();
//        }
//    }
//}
