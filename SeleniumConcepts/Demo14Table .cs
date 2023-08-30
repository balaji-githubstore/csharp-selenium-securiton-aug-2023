using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Working on table
namespace SeleniumConcepts
{
    public class Demo14Table
    {
        //new comment1
        public static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";


            for (int p = 1; p <= 6; p++)
            {
                int rowCount = driver.FindElements(By.XPath("//table[@id='example']/tbody/tr")).Count;
                Console.WriteLine(rowCount);

                for (int i = 1; i <= rowCount; i++)
                {
                    string name1 = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[2]")).Text;
                    Console.WriteLine(name1);
                }

                if (driver.FindElement(By.Id("example_next")).Enabled)
                {
                    driver.FindElement(By.Id("example_next")).Click();
                    
                }
            }
        }
    }
}


