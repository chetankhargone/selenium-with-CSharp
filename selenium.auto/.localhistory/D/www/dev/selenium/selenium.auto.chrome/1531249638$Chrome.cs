﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using selenium.auto.contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.chrome
{
    public class Chrome : IBrowser
    {
        #region 
        private  IWebDriver _driver;
        #endregion

       
        #endregion

        #region Public
        public IWebDriver Launch(string url)
        {
            _driver = new ChromeDriver();
            _driver.Navigate().GoToUrl(url.ToLower().Trim());
        }

        public void Close()
        {
            _driver.Close();
        }
        #endregion
    }
}
