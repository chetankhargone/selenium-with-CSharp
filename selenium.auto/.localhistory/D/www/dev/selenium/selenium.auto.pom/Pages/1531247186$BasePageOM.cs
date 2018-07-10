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
        protected readonly string url;

        public BasePageOM()
        {

        }
        public void Load(string url)
        {
            var bUrl = _driver.Url;
            if (bUrl == url)
            {
                //skip
            }
            else
            {
                _driver.Navigate().GoToUrl(url);
            }
        }
    }
}
