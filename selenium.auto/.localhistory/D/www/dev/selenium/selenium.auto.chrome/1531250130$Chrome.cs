using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium.auto.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.chrome
{
    public class Chrome  : IBrowser
    {
        #region 
        private  IWebDriver _driver;
        #endregion

       

        #region Public
        public void Launch()
        {
            _driver = new ChromeDriver();
        }

        public void Close()
        {
            _driver.Close();
        }
        #endregion
    }
}
