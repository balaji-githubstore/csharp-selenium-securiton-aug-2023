using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo1FBLogin
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver=new ChromeDriver();

            driver.Url = "https://www.facebook.com/";


            //  driver.FindElement(By.Id("email")).SendKeys("john123455@gmail.com");

            //By locator= By.Id("email");
            //IWebElement ele= driver.FindElement(locator);
            //ele.SendKeys("john");

            IWebElement ele = driver.FindElement(By.Id("email"));
            ele.SendKeys("john");

            //driver.FindElement(By.Id("email")).SendKeys("john123455@gmail.com");


            driver.FindElement(By.Id("pass")).SendKeys("welcome123");

            //click on login 
            driver.FindElement(By.Name("login")).Click();

        }

    }
}
