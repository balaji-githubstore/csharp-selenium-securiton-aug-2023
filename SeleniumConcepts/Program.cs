using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Securiton.SeleniumConcepts
{
    public class Program
    {
        public static void Main8(string[] args)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("--disable-notifications");

            IWebDriver driver = new ChromeDriver(options);

            //driver.Manage().Cookies
            
          //  driver = new EdgeDriver();

            //ChromeDriver driver1 = new ChromeDriver();

            driver.Url = "https://www.irctc.co.in/nget/train-search";

            //driver1.Url = "http://facebook.com";

            string actualTitle = driver.Title;
            Console.WriteLine(actualTitle);

            //PageSource

            //Console.WriteLine(driver.PageSource);

            //driver.Quit();

            //driver1.Quit();
        }
    }
}
