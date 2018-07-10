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
    public abstract class Base<T>
    {
        protected  IWebDriver _driver;
        
        const string _appUrl = "https://selenium-kgn.azurewebsites.net/";

        public Base(T t)
        {
           // _browser = new Chrome();
            _driver = new ChromeDriver();
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
