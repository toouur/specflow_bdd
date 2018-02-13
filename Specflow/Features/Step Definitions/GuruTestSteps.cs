using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using OpenQA.Selenium.Support.UI;

namespace Specflow.Tests.Guru
{
   
    

    public static class WebDriverExtensions
    {
        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            if (timeoutInSeconds > 0)
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
                return wait.Until(drv => drv.FindElement(by));
            }
            return driver.FindElement(by);
        }
    }

    [Binding]

    class GuruTestSteps
    {
        IWebDriver webDriver = new ChromeDriver();

        [Given(@"I am on the Guru(.*) homepage")]
        public void GivenIAmOnTheGuruHomepage(int p0)

        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://demo.guru99.com");
        }

        [When(@"enter blank details for register")]
        public void WhenEnterBlankDetailsForRegister()
        {
            var input = webDriver.FindElement(By.CssSelector("input[type='text']"));
            input.SendKeys("fhbehrfbsd");
            var btn = webDriver.FindElement(By.Name("btnLogin"));
            btn.Click();
        }

        [Then(@"error email shown")]
        public void ThenErrorEmailShown()
        {
            Console.WriteLine("Email is Required!");
            System.Threading.Thread.Sleep(500);
            webDriver.Close();
        }

        [When(@"enter details for Register")]
        public void WhenEnterDetailsForRegister()
        {
            webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("http://demo.guru99.com");
            webDriver.FindElement(By.CssSelector("input[type='text']")).SendKeys("andrei.patsiomkin@gmail.com");
            webDriver.FindElement(By.Name("btnLogin")).Click();
        }

        [Then(@"login details shown")]
        public void ThenLoginDetailsShown()
        {
            Console.WriteLine("Successfully registered");
            System.Threading.Thread.Sleep(500);
            webDriver.Close();
        }


    }
}
