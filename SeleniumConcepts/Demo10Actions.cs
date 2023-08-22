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
    public class Demo10Actions
    {
        public static void Mainss(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://nasscom.in/about-us/contact-us";

            Actions actions = new Actions(driver);
            actions.MoveToElement(driver.FindElement(By.XPath("//a[text()='Membership']"))).Perform();

            driver.FindElement(By.XPath("//a[text()='Members Listing']")).Click();

        }
    }
}





