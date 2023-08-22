using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace SeleniumConcepts
{
    public class Demo5Tabs
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            driver.FindElement(By.PartialLinkText("phpMyAdmi")).Click();


            var windows= driver.WindowHandles;

            foreach(string win in windows)
            {
                Console.WriteLine(win);
                driver.SwitchTo().Window(win);
                Console.WriteLine(driver.Title);
                if(driver.Title.Equals("phpMyAdmin"))
                {
                    break;
                }
                Console.WriteLine("----------------------------");
            }


            //driver will be pointing to the tab with title phpMyAdmin
            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            //enter password as welcome123
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            //click on login 
            driver.FindElement(By.Id("input_go")).Click();

            //get the entire text of "Access denied for user." and print it 
            Console.WriteLine(driver.FindElement(By.Id("pma_errors")).Text);
        }

    }
}
