﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed_v3.Interfaces
{
    public interface IValidator
    {
        bool Validate(ICalculation calculation);
    }
}