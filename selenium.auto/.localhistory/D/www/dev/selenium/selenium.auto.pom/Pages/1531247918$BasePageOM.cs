using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.pom.Pages
{
    public abstract class BasePageOM<T> : IApplicationPOM<T>
        where T : class
    {
        protected readonly IWebDriver _driver;
        protected readonly string _url;

        public BasePageOM(IWebDriver driver, string url)
        {
            _url = url;
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
