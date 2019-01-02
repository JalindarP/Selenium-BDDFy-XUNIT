using System;
using System.IO;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(Directory.GetCurrentDirectory());

            driver.Navigate().GoToUrl("https://www.linkedin.com/");
            IWebElement element = driver.FindElement(By.Id("login-email"));
            element.SendKeys("mymail@gmail.com");

            element = driver.FindElement(By.Id("login-password"));
            element.SendKeys("password");

            element = driver.FindElement(By.Id("login-submit"));
            element.Submit();

            driver.Dispose(); 

        }
    }
}
