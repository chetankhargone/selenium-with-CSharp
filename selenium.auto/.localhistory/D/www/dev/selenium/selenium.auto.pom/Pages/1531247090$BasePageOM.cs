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
        protected string url;


    }
}
