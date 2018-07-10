using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace selenium.auto
{
    [TestClass]
    public class GoogleSearchTest
    {
        [TestMethod]
        public void Should_Search_Using_Chrome()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            IWebElement searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Hello Selenium");
            var searchButton = driver.FindElement(By.Name("btnK"));
            searchButton.Submit();
            var searchResults = driver.FindElement(By.Name("resultStats"));
        }
    }
}
