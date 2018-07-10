using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using selenium.auto.contract;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using selenium.auto.pom.Pages;
using selenium.auto.pom;
using selenium.auto.pom.Contract;

namespace selenium.auto
{
    /// <summary>
    /// Summary description for TestApplication
    /// </summary>
    [TestClass]
    public class TestHomePage : Base
    {
        #region Private
        private readonly IHomePageOM _homepage;
        private const string _homePageUrl = "https://selenium-kgn.azurewebsites.net";
        #endregion

        #region Ctor
        public TestHomePage()
        {
            _homepage = new HomePageOM(_driver, _homePageUrl);
        }
        #endregion

        #region TestMethod(s)
        [TestMethod]
        public void TestLogin()
        {
            Setup();
            _homepage.SubmitLoginForm();
            Assert.AreEqual(1, 1);
            TearDown();
        }

        #endregion

    }
}
