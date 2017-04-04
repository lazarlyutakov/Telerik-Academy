using PackageManager.Enums;
using PackageManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageManager.Tests.Models.Mocks
{
    internal class MockPackageVersion : PackageVersion
    {

        protected int major;
        protected int minor;
        protected int patch;
        protected VersionType versionType;

        public MockPackageVersion(int major, int minor, int patch, VersionType type) : base(major, minor, patch, type)
        {

        }

        public int Major
        {
            get
            {
                return this.major;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.major = value;
            }
        }

        public int Minor
        {
            get
            {
                return this.minor;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.minor = value;
            }
        }
        public int Patch
        {
            get
            {
                return this.patch;
            }
             set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.patch = value;
            }
        }

        public VersionType VersionType
        {
            get
            {
                return this.versionType;
            }
           set
            {
                if (!Enum.IsDefined(typeof(VersionType), value))
                {
                    throw new ArgumentException();
                }

                this.versionType = value;
            }
        }
    }
}
