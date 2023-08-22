using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo2FbSignup
    {
        public static void Main3(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
           

            driver.Url = "https://www.facebook.com/";  //wait for page load to complete

            //click on Create New Account
            driver.FindElement(By.LinkText("Create new account")).Click(); //it checks for present of element in 0.5s

            //enter firstname as john
            driver.FindElement(By.Name("firstname")).SendKeys("john");

            //enter lastname as wick
            driver.FindElement(By.Name("lastname")).SendKeys("wick");

            //enter password as welcome122
            driver.FindElement(By.Id("password_step_input")).SendKeys("jack2233");

            //Click on radio button - custom 
            driver.FindElement(By.XPath("//input[@value='-1']")).Click();


            //String color=driver.FindElement(By.Name("websubmit")).GetCssValue("background-color");
            //Console.WriteLine(color);

            
        }
    }
}



