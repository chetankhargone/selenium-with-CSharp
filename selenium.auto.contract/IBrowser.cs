using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.contract
{
    public interface IBrowser<T> 
    {
        IWebDriver Launch();
        void Close();
    }
}
