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
    public class Demo7Alert
    {
        public static void Main9(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


            driver.Url = "https://netbanking.hdfcbank.com/netbanking/IpinResetUsingOTP.htm";

            //click on go
            driver.FindElement(By.XPath("//img[@alt='Go']")).Click();

            //alert should be present
            //wait for alert to be present

            DefaultWait<IWebDriver> wait = new DefaultWait<IWebDriver>(driver);

            wait.Timeout=TimeSpan.FromSeconds(200);
            //wait.PollingInterval = TimeSpan.FromSeconds(30);
            wait.IgnoreExceptionTypes(typeof(NoAlertPresentException),typeof(NoSuchElementException));

            wait.Until(x => x.SwitchTo().Alert());
            
            string actualAlertText= driver.SwitchTo().Alert().Text;
            Console.WriteLine(actualAlertText);

            driver.SwitchTo().Alert().Accept();


            //IAlert alert = driver.SwitchTo().Alert();

            //string actualAlertText = alert.Text;
            //Console.WriteLine(actualAlertText);

            //alert.Accept();
        }
    }
}
