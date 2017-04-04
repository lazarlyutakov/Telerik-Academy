using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilePhone
{
    class Call
    {
        private string date;
        private string time;
        private string dialedPhoneNumb;
        private uint duratation;

        public string Date { get { return DateTime.Now.ToString("dd/MMM/yyyy"); } set { value = this.date; } }

        public string Time { get { return DateTime.Now.ToString("HH:mm:ss "); } set { value = this.time; } }

        public string DialedPhoneNumber { get; set; }

        public uint Duratation { get; set; }

        public Call()
        {
        } 

        public Call(string date, string time, string dialedPhoneNumb, uint duratation)
        {
            this.Date = date;
            this.Time = time.ToString();
            this.DialedPhoneNumber = dialedPhoneNumb;
            this.Duratation = duratation;
        }

        public override string ToString()
        {
            return string.Format($"Date of Call : " + Date +
                                "\nTime Of Call : " + Time +
                                "\nDialed Number : " + dialedPhoneNumb +
                                "\nDuratation : " + duratation +
                                "\n");
                               
        }      
    }
}
