﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WypozyczalniaDLL
{
    public abstract class PointsCalculatingStrategy
    {
        public abstract int CalcualtePoints(Rental rental);
        public abstract string GetNameOfStrategy();
    }
}
