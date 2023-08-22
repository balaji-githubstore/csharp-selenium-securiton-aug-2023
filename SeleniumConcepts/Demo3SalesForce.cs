using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Edge;

namespace SeleniumConcepts
{
    public class Demo3SalesForce
    {
        public static void Main7(string[] args)
        {
            var options = new EdgeOptions();
            options.AddArgument("--disable-features=msHubApps");
            IWebDriver driver = new EdgeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Url = "https://www.salesforce.com/in/form/signup/freetrial-sales/";

            //enter firstname as john
            //input[contains(@id,'UserFirst')]
            driver.FindElement(By.Name("UserFirstName")).SendKeys("john");

            //select job title as IT Manager
            SelectElement selectJobTitle = new SelectElement(driver.FindElement(By.Name("UserTitle")));
            selectJobTitle.SelectByText("IT Manager");

            //select Country as United Kingdom 
            SelectElement selectCountry = new SelectElement(driver.FindElement(By.Name("CompanyCountry")));
            selectCountry.SelectByValue("GB");

            //select 101-200 employees
            SelectElement selectEmployees = new SelectElement(driver.FindElement(By.Name("CompanyEmployees")));
            selectEmployees.SelectByText("101 - 200 employees");

            //click on checkbox 
            driver.FindElement(By.XPath("//div[@class='checkbox-ui']")).Click();

            driver.FindElement(By.Name("start my free trial")).Click();

            string actualError= driver.FindElement(By.XPath("//span[contains(text(),'valid phone')]")).Text;

            Console.WriteLine(actualError);
        }
    }
}
