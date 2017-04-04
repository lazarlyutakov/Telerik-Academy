using PackageManager.Commands;
using PackageManager.Core.Contracts;
using PackageManager.Enums;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Commands.Mocks
{
    internal class MockInstallCommand : InstallCommand
    {

        public MockInstallCommand(IInstaller<IPackage> installer, IPackage package) : base(installer, package)
        {

        }

        public IInstaller<IPackage> MyInstaller
        {
            get
            {
                return this.Installer;
            }
        }

        public IPackage MyPackage
        {
            get
            {
                return this.Package;
            }
        }

    }
}


