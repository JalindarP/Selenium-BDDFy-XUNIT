
using Shouldly;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;
using TestStack.BDDfy;

namespace SeleniumFirst
{
    public class SeleniumTests
    {
        public void GivenIHaveNotUsedBDDfyBefore()
        {
        }

        public void WhenIAmIntroducedToTheFramework()
        {
        }

        public void ThenILikeItAndStartUsingIt()
        {
        }

        [Fact]
        public void ShouldBeAbleToBDDfyMyTestsVeryEasily()
        {
            this.Given(x => x.GivenIHaveNotUsedBDDfyBefore()).When(x => x.WhenIAmIntroducedToTheFramework()).Then(x => x.ThenILikeItAndStartUsingIt()).BDDfy();
           
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
