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
    public class Demo16
    {
        public static void Main(string[] args)
        {

            ChromeOptions options = new ChromeOptions();
            options.AddUserProfilePreference("download.default_directory", "C:\\mine");
            options.AcceptInsecureCertificates = true;
            options.AddArgument("--headless");
        //https://username:password@www.selenium.dev/downloads/

            IWebDriver driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://www.selenium.dev/downloads/";

            Cookie c = new Cookie("username", "bala");

            driver.Manage().Cookies.AddCookie(c);

            var cookies = driver.Manage().Cookies.AllCookies;
            foreach (var cookie in cookies)
            {
                Console.WriteLine(cookie.Name);
                Console.WriteLine(cookie.Value);
            }

            driver.Manage().Cookies.DeleteAllCookies();


          //driver.FindElement(By.PartialLinkText("32")).Click();
          //  driver.SwitchTo().NewWindow(WindowType.Tab);
          //  driver.Url = "chrome://downloads/";

          //string actualText=  driver.FindElement(By.Id("show")).Text;
          //  Console.WriteLine(actualText);

          // string res= driver.ExecuteJavaScript<string>("return document.title");
          //  Console.WriteLine(res);

          //  res = driver.ExecuteJavaScript<string>("return document.querySelector(\"body > downloads-manager\").shadowRoot.querySelector(\"#frb0\").shadowRoot.querySelector(\"#show\").textContent");
          //  Console.WriteLine(res);

            ITakesScreenshot ts = (ITakesScreenshot)driver;
            Screenshot screenshot = ts.GetScreenshot();
            screenshot.SaveAsFile("error.png");

        }
    }
}
