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
    public class Demo12Actions
    {

        public static void Main8(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.Url = "https://google.com";

            Actions actions = new Actions(driver);

            actions.KeyDown(Keys.Shift).SendKeys("hello").KeyUp(Keys.Shift).Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown).SendKeys(Keys.ArrowDown)
                .Pause(TimeSpan.FromSeconds(1))
                .SendKeys(Keys.Enter)
                .Build().Perform();

            //open new tab  -->selenium 4
            driver.SwitchTo().NewWindow(WindowType.Tab);
            driver.Url = "https://gmail.com";

            driver.SwitchTo().Window(driver.WindowHandles[0]);


        }

    }
}
