﻿using OpenQA.Selenium;
using selenium.auto.pom.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.pom.Pages
{
    public abstract class BasePageOM : IApplicationPOM
    {
        protected readonly IWebDriver _driver;
        protected readonly string _url;

        public BasePageOM(IWebDriver driver, string url)
        {
            _url = url;
            _driver = driver;
        }

        public void Load()
        {
            var bUrl = _driver.Url;
            if (bUrl == _url)
            {
                //skip
            }
            else
            {
                _driver.Navigate().GoToUrl(_url);
            }
        }
    }
}
