﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca5
{
    public class Espresso : Coffee
    {

        public double GetCost()
        {
            return 1.99;
        }

        public string GetDescription()
        {
            return "Espresso";
        }
    }

}
