using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;
using System.Drawing;
using OpenQA.Selenium.Interactions;

namespace SeleniumConcepts
{
    public class Demo17
    {
        public static void Main(string[] args)
        {
 
            IWebDriver driver = new ChromeDriver();
            //driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Size s = new Size(1000, 600);
            driver.Manage().Window.Size = s;

            driver.Url = "https://www.google.com";

            Size wSize= driver.Manage().Window.Size;
            Console.WriteLine(wSize.Width);
            Console.WriteLine(wSize.Height);

            Size size= driver.FindElement(By.LinkText("Gmail")).Size;
            Console.WriteLine(size.Width);
            Console.WriteLine(size.Height);

            Point p= driver.FindElement(By.LinkText("Gmail")).Location;
            Console.WriteLine(p.X);
            Console.WriteLine(p.Y);

            Actions actions = new Actions(driver);
            actions.MoveByOffset(p.X, p.Y).Perform();



            //var elements=  driver.FindElements(By.TagName("a"));

            //Console.WriteLine(elements.Count);

            //for(int i = 0; i < elements.Count; i++)
            //{
            //    Console.WriteLine(elements[i].GetAttribute("href"));
            //    Console.WriteLine(elements[i].Text);
            //}

            //foreach (IWebElement element in elements)
            //{
            //    Console.WriteLine(element.Text);
            //    Console.WriteLine(element.GetAttribute("href"));


            //}




            ////check the presence
            //if(driver.FindElements(By.XPath("abc")).Count>0)
            //{
            //    //visiblity 
            //    if(driver.FindElement(By.XPath("abc")).Displayed)
            //    {
            //        //click
            //    }
            //}



        }
    }
}
