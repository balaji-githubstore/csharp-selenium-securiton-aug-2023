using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo4Tabs
    {
        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            driver.FindElement(By.PartialLinkText("phpMyAdmi")).Click();

            Console.WriteLine(driver.WindowHandles[0]);
            Console.WriteLine(driver.WindowHandles[1]);

            //switch to second tab 
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Id("input_username")).SendKeys("admin");
            //enter password as welcome123
            driver.FindElement(By.Id("input_password")).SendKeys("admin");
            //click on login 
            driver.FindElement(By.Id("input_go")).Click();

            //get the entire text of "Access denied for user." and print it 
            Console.WriteLine(driver.FindElement(By.Id("pma_errors")).Text);

            driver.Close(); //check what is happening 

            //switch to 1st tab
            driver.SwitchTo().Window(driver.WindowHandles[0]);

            Console.WriteLine(driver.Title); //check whether title is printing or not
        }

    }
}
