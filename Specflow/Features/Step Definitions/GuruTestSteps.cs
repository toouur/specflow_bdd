using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Specflow.Tests.Guru
{
   
    [Binding]

    class GuruTestSteps
    {
        IWebDriver webDriver = new ChromeDriver();
        [Given(@"I am on the Guru(.*) homepage")]
        public void GivenIAmOnTheGuruHomepage(int p0)

        {

            webDriver.Navigate().GoToUrl("http://demo.guru99.com");
            webDriver.FindElement(By.CssSelector("input[type='text']")).SendKeys("andrei.patsiomkin@gmail.com");
            webDriver.FindElement(By.Name("btnLogin")).Click();

            //webDriver.Navigate().GoToUrl("https://mail.google.com");
            // webDriver.FindElement(By.Id("Email")).SendKeys("andrei.patsiomkin@gmail.com");
            //webDriver.FindElement(By.Id("Passwd")).SendKeys("jedemdasseine");
            //webDriver.FindElement(By.Id("signIn")).Click();
        }

        [When(@"enter blank details for register")]
        public void WhenEnterBlankDetailsForRegister()
        {
            //webDriver.Navigate().GoToUrl("https://mail.google.com");
           // webDriver.FindElement(By.Id("Email")).SendKeys("yourEmailId");
            //webDriver.FindElement(By.Id("Passwd")).SendKeys("yourPassword");
            //webDriver.FindElement(By.Id("signIn")).Click();
            //IWebDriver EmailInput = webDriver.FindElement(By.Name("emailid"));
            //EmailInput.SendKeys("andrei.patsiomkin@gmail.com");
            //IWebDriver Button = webDriver.FindElement(By.Name("btnLogin")).Click();

            //webDriver.FindElement(By.CssSelector("input[type='text']")).SendKeys("andrei.patsiomkin@gmail.com");
        }

        [Then(@"error email shown")]
        public void ThenErrorEmailShown()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"enter details for Register")]
        public void WhenEnterDetailsForRegister()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"login details shown")]
        public void ThenLoginDetailsShown()
        {
            ScenarioContext.Current.Pending();
        }


    }
}
