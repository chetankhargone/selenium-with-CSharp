﻿using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium.auto.contract;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using selenium.auto.pom.Pages;
using selenium.auto.pom;

namespace selenium.auto
{
    /// <summary>
    /// Summary description for TestApplication
    /// </summary>
    [TestClass]
    public class TestHomePage : Base
    {
        private readonly IApplicationPOM<HomePageOM> _homepage;
        public TestHomePage()
        {
            _homepage = new HomePageOM(_driver);
        }
        [TestMethod]
        public void LoginTest()
        {
            var url =Setup();
            HomePageOM home = new HomePageOM(_driver);
            home.SubmitLoginForm();
            Assert.AreEqual(1, 1);
            TearDown();
        }
        
       

    }
}
