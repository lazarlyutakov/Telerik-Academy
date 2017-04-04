using PackageManager.Models;
using PackageManager.Models.Contracts;
using PackageManager.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.Mocks
{
    internal class MockProject : Project
    {
        public MockProject(string name, string location, IRepository<IPackage> packages = null) : base(name, location, packages)
        {

        }

        public string Location { get; set; }

        public string Name { get; set; }

        public IRepository<IPackage> PackageRepository { get; protected set; }
    }
}
