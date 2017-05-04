﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Models.Contracts
{
    public interface IUser
    {
        string UserName { get; }

        string Email { get; }

        string ToString();
    }
}
