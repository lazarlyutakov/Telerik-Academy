using Academy.Models.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Tests.Fakes
{
    public class UserFake : User
    {
        public UserFake(string username) : base(username)
        {

        }
    }
}
