using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VersionAttribute
{
    [Version("3.14")]
    class SampleClass
    {

        static void Main()
        {
            Type obj = typeof(SampleClass);
            var attributeType = obj.GetCustomAttributes(false);
            foreach (VersionAttribute item in attributeType)
            {
                Console.WriteLine(item.Version);
            }
        }
    }
}
