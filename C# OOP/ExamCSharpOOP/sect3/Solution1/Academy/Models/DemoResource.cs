using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Enums;
using Academy.Models.Contracts;
using System.Globalization;

 namespace Academy.Models
{
   public class DemoResource : ILectureResouce
    {
        private string name;
        private string url;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if(value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentOutOfRangeException("Resource name should be between 3 and 15 symbols long!");
                }
                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }
            set
            {
                if(value.Length < 5 || value.Length > 150)
                {
                    throw new ArgumentOutOfRangeException("Resource url should be between 5 and 150 symbols long!");
                }
                this.url = value;
            }
        }

        public DemoResource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, @"*Resource:
                                                                 - Name: {0}
                                                                 - Url: {1}
                                                                 - Type: Demo",
                                                                 this.Name, this.Url);
        }

    }
}
