﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToTheChase.Models;

namespace ToTheChase.Data.Interfaces
{
    public interface ILegData
    {
        IEnumerable<Leg> Legs();
    }
}