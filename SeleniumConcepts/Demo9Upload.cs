using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcepts
{
    public class Demo9Upload
    {

        public static void Main2(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://smallpdf.com/pdf-to-word";

            driver.FindElement(By.XPath("//input[@type='file']")).SendKeys(@"C:\Mine\Balaji-Profile_2023_1.pdf");
        }

    }
}
