using PackageManager.Models;
using PackageManager.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.Mocks
{
    internal class MockPackage : Package
    {
        public MockPackage(string name, IVersion version, ICollection<IPackage> dependencies = null) : base(name, version, dependencies)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }

            if (version == null)
            {
                throw new ArgumentNullException();
            }

            if (dependencies == null)
            {
                this.Dependencies = new HashSet<IPackage>();
            }
            else
            {
                this.Dependencies = dependencies;
            }

            this.Name = name;
            this.Version = version;
            this.Url = string.Format("{0}.{1}.{2}-{3}", this.Version.Major, this.Version.Minor, this.Version.Patch, this.Version.VersionType);
        }

        public ICollection<IPackage> Dependencies { get; set; }

        public string Name { get; set; }

        public string Url { get; set; }

        public IVersion Version { get; set; }
    }
}
