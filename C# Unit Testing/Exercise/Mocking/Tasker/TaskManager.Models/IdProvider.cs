﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.Models
{
   public class IdProvider : IIdProvider
    {
        private static int id;

        public int Id
        {
            get
            {
                return ++id;
            }
        }
    }
}
