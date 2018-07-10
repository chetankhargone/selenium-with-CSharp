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
        private readonly IWebDriver _driver;
        protected string url;

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
