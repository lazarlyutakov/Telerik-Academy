namespace QualityMethods
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Class, which provides some additional information on the student object.
    /// </summary>
    public class OtherInformation
    {
        public OtherInformation(DateTime birthDate, string homeCity)
        {
            this.BirthDate = birthDate;
            this.HomeCity = homeCity;
        }

        public DateTime BirthDate { get; }

        public string HomeCity { get; }
    }
}
