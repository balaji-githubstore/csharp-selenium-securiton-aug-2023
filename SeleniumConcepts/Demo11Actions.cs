using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;

namespace SeleniumConcepts
{
    public class Demo11Actions
    {

        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);

            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Become a Member']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='Membership Benefits']")).Click();
            
            driver.FindElement(By.XPath("//a[text()='Click to Apply Online']")).Click();
        }

    }
}
