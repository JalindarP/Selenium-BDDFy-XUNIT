using System;
using Xunit;
using TestStack.BDDfy;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.IO;
using Shouldly;

namespace XUnitTestProject1
{
    public class LoginTest
    {
        //Given When Then
        IWebDriver driver = null;
        void GivenSetup()
        {
            driver = new ChromeDriver(Directory.GetCurrentDirectory());
            driver.Navigate().GoToUrl("https://www.linkedin.com/");
        }

        void WhenLogin()
        {
            IWebElement element = driver.FindElement(By.Id("login-email"));
            element.SendKeys("mymail@gmail.com");

            element = driver.FindElement(By.Id("login-password"));
            element.SendKeys("password");

            element = driver.FindElement(By.Id("login-submit"));
            element.Submit();
            driver.Url.ShouldNotBeEmpty();
        }

        void ThenILoadPage()
        {
            driver.Dispose();
        }

        [Fact]
        public void Login()
        {
            this.BDDfy();
        }
    }
}
