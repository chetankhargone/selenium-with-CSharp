using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium.auto.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto
{
    public abstract class Base
    {
        protected  IWebDriver _driver;
        protected IBrowser _browser;
        const string _appUrl = "https://selenium-kgn.azurewebsites.net/";

        public Base()
        {
            _browser = new selenium.auto.chrome.Chrome();
            _driver = new ChromeDriver();
        }
        protected string Setup()
        {
            _browser.Launch(_appUrl);
            return _appUrl;
        }

        protected void TearDown()
        {
            _browser.Close();
        }
    }
}
