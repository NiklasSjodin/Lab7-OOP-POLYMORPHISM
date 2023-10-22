﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Rektangel : Geometri
    {
        public double Lenght { get; set; }
        public double Width { get; set; }

        public Rektangel()
        {
            Lenght = 5.5; Width = 10;
        }

        public override double Area() { return Lenght * Width; }
    }
}
