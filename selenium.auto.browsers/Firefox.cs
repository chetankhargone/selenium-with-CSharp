using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using selenium.auto.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.chrome
{
    public class Firefox : IBrowser<Firefox>
    {

        private IWebDriver _driver;
        public IWebDriver Launch()
        {
            _driver = new FirefoxDriver();
            return _driver;
        }

        public void Close()
        {
            _driver.Close();
        }
    }
}
