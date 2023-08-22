using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo13Table
    {
        public static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://datatables.net/extensions/select/examples/initialisation/checkbox.html";


            for (int i = 1; i <= 10; i++)
            {
                string name1 = driver.FindElement(By.XPath("//table[@id='example']/tbody/tr["+i+"]/td[2]")).Text;
                Console.WriteLine(name1);

                //click on checkbox when name is matching with Brenden Wagner
                if(name1.Equals("Thor Walton"))
                {
                    driver.FindElement(By.XPath("//table[@id='example']/tbody/tr[" + i + "]/td[1]")).Click();
                    break;
                }
            }
        }
    }
}


