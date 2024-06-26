﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trpo_test_2.models
{
    public class CylindricalContainer : Container
    {
        public int Height { get; set; }
        public int Diameter { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", {Height}, {Diameter}";
        }
    }
}
