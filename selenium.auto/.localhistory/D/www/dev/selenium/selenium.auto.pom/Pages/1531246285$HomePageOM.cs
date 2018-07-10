using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.pom.Pages
{
    public class HomePageOM
    {
        private readonly IWebDriver _driver;

        #region Locators
        [FindsBy(How = How.Id,Using = "txtEmail")]
        private IWebElement txtEmail;
        [FindsBy(How = How.Id, Using = "txtPassword")]
        private IWebElement txtPassword;
        [FindsBy(How = How.Id, Using = "btnSubmit")]
        private IWebElement btnSubmit;

        #endregion

       
        

        

        public void SubmitLoginForm()
        {
            try
            {
                txtEmail.SendKeys("chetan@gmail.com");
                txtPassword.SendKeys("Password@123");
                btnSubmit.Submit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }

        
    }
}
