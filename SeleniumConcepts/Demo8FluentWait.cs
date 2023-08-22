using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcepts
{
    internal class Demo8FluentWait
    {
        public static void Main1(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();


            driver.Url = "https://www.facebook.com/";  //wait for page load to complete

            ////click on Create New Account
            //driver.FindElement(By.LinkText("Create new account")).Click(); //it checks for present of element in 0.5s

            ////enter firstname as john
            //driver.FindElement(By.Name("firstname")).SendKeys("john");

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);
            wait.Timeout=TimeSpan.FromSeconds(50);
            wait.IgnoreExceptionTypes(typeof(Exception));
            //wait.PollingInterval=TimeSpan.FromSeconds(1);

            wait.Until(x=>x.FindElement(By.LinkText("Create new account"))).Click();

            wait.Until(x => x.FindElement(By.Name("firstname"))).SendKeys("john");

            string actualAlertText=wait.Until(x => x.SwitchTo().Alert()).Text;


        }
    }
}
