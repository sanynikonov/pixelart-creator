﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace PixelartCreator.Domain
{
    public class PixelizingOptions
    {
        public IEnumerable<System.Drawing.Color> AvailibleColors { get; set; }
        public Size Size { get; set; }
    }
}
