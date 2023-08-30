using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.Extensions;

namespace SeleniumConcepts
{
    public class Demo15JS
    {
        public static void Mainw(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.citibank.co.in/ssjsps/forgetuserid.jsp";

            driver.FindElement(By.LinkText("select your product type")).Click();
            driver.FindElement(By.LinkText("Credit Card")).Click();

            //approach 1
            //driver.FindElement(By.Id("bill-date-long")).SendKeys("14/12/2000");

            //approach 2
            //driver.FindElement(By.Id("bill-date-long")).Click();

            //new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectYear']"))).SelectByText("2000");
            //new SelectElement(driver.FindElement(By.XPath("//select[@data-handler='selectMonth']"))).SelectByText("Dec");

            //driver.FindElement(By.LinkText("14")).Click();


            //approach 3
            //driver.ExecuteJavaScript("document.querySelector('#bill-date-long').value='14/12/2000'");

            //approach 4
            IWebElement ele1= driver.FindElement(By.XPath("//input[@id='bill-date-long']"));

            driver.ExecuteJavaScript("arguments[0].value='14/12/2000'", ele1);


            //IWebElement ele2 = driver.FindElement(By.XPath("//input[@id='bill-date-long']"));
            //driver.ExecuteJavaScript("arguments[0].value='14/12/2000';arguments[1].click()", ele1,ele2);
        }
    }
}
