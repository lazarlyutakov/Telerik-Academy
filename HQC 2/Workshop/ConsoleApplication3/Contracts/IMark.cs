using SchoolSystem.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Contracts
{
    public interface IMark
    {
        Subject Subject { get; set; }
        float Value { get; set; }
    }
}
