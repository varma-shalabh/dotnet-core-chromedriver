using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Xunit;

namespace hello_google_with_webdriver
{
    public class OpenGoogle
    {
        [Fact]
        public void openGoogle()
        {
            IWebDriver driver = new ChromeDriver("../netcoreapp2.0/");

            driver.Navigate().GoToUrl("http://www.google.com");
            driver.Close();

            Console.WriteLine("Test complete");

        }
    }
}
