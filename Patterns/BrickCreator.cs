﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public class BrickCreator : MaterialCreator
    {
        public override IMaterial CreateMaterial()
        {
            return new Brick();
        }
    }
}
