﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selenium.auto.contract
{
    public interface IBrowser
    {
        void Launch(string url);

        void Close();
    }
}
