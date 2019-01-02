using System;
using System.Collections.Generic;
using System.Text;
using Shouldly;
using Xunit;
using TestStack.BDDfy;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace SeleniumFirst
{
    public class SeleniumTests
    {
        void GivenIHaveNotUsedBDDfyBefore()
        {
        }

        void WhenIAmIntroducedToTheFramework()
        {
        }

        void ThenILikeItAndStartUsingIt()
        {
        }

        [Test]
        public void ShouldBeAbleToBDDfyMyTestsVeryEasily()
        {
            this.BDDfy();
        }

        //Given When Then
        //IWebDriver driver = null;
        //void GivenSetup()
        //{
        //    driver = new ChromeDriver(Directory.GetCurrentDirectory());
        //    driver.Navigate().GoToUrl("https://www.linkedin.com/");
        //}

        //void WhenLogin()
        //{
        //    IWebElement element = driver.FindElement(By.Id("login-email"));
        //    element.SendKeys("mymail@gmail.com");

        //    element = driver.FindElement(By.Id("login-password"));
        //    element.SendKeys("password");

        //    element = driver.FindElement(By.Id("login-submit"));
        //    element.Submit();
        //}

        //void ThenILoadPage()
        //{
        //    driver.Dispose();
        //}

        //[Fact]
        //public void Login()
        //{
        //    this.BDDfy();
        //}

    }
}
