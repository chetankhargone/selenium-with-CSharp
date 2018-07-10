using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using selenium.auto.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.chrome
{
    public class IE : IBrowser
    {

        #region 
        private IWebDriver _driver;
        #endregion


        public IWebDriver Launch()
        {
            _driver = new InternetExplorerDriver();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

    }
}
