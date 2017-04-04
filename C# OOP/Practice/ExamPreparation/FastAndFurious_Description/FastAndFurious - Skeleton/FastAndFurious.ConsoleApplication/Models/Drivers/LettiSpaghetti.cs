﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FastAndFurious.ConsoleApplication.Common.Constants;
using FastAndFurious.ConsoleApplication.Common.Enums;
using FastAndFurious.ConsoleApplication.Common.Utils;
using FastAndFurious.ConsoleApplication.Contracts;
using FastAndFurious.ConsoleApplication.Common;
using FastAndFurious.ConsoleApplication.Models.Common;
using FastAndFurious.ConsoleApplication.Models.Drivers.Abstract;

namespace FastAndFurious.ConsoleApplication.Models.Drivers
{
    public class LettiSpaghetti : Driver
    {
        private const string LetiNameConst = "Leti Spaghetti";

        public LettiSpaghetti() : base(LetiNameConst, GenderType.Female)
        {

        }
    }
}
