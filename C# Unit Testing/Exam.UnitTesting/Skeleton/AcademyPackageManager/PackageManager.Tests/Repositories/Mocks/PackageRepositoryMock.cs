using PackageManager.Info.Contracts;
using PackageManager.Models.Contracts;
using PackageManager.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PackageManager.Tests.CustomExceptions;

namespace PackageManager.Tests.Repositories.Mocks
{
    internal class PackageRepositoryMock : PackageRepository 
    {
        public PackageRepositoryMock(ILogger logger, ICollection<IPackage> packages = null) : base(logger, packages)
        {

        }

        public override bool Update(IPackage package)
        {
            throw new UpdateMethodCalledException("The update method is called");
        }
    }
}
