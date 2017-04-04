﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlsHierarchy
{
    public class Surface : Control
    {
        private readonly IEnumerable<IControl> controls;

        public Surface(IEnumerable<IControl> controls)
        {
            this.controls = controls;
        }

        public IEnumerable<IControl> Controls
        {
            get
            {
                return this.controls;
            }
        }

        public override double Size
        {
            get
            {
                double size = 0;
                foreach (IControl control in this.Controls)
                {
                    size += control.Size;

                }
                return size;
            }
        }
    }
}
