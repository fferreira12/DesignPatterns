﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Prototype
{
    interface IClonableMonster
    {

        IClonableMonster clone();
        string ToString();

    }
}
