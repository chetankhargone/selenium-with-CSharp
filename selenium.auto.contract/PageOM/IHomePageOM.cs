﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.pom.Contract
{
    public interface IHomePageOM : IApplicationPOM
    {
        string SubmitLoginForm();
    }
}
