using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium.auto.chrome;
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
        protected  readonly IWebDriver _driver;
        protected readonly IBrowser<Chrome> _browser;
        const string _appUrl = "https://selenium-kgn.azurewebsites.net/";

        public Base()
        {
            _browser = new IE();
            _driver = _browser.Launch();
        }
        protected string Setup()
        {
            _driver.Navigate().GoToUrl(_appUrl);
            return _appUrl;
        }

        protected void TearDown()
        {
            _driver.Close();
        }
    }
}
