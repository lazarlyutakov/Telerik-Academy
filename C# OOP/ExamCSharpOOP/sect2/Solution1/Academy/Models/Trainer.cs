using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;
using System.Globalization;

namespace Academy.Models
{
   public class Trainer : ITrainer
    {
        private string username;
        IList<string> technologies;

        public string Username
        {
            get
            {
                return this.username;
            }
             set
            {
                if(value.Length < 3 || value.Length > 16)
                {
                    throw new ArgumentOutOfRangeException("User's username should be between 3 and 16 symbols long!");
                }
            }
        }

        public IList<string> Technologies { get;  set; }

        public Trainer(string username, IList<string> technologies)
        {
            this.Username = username;
            this.Technologies = technologies;
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, @"*Trainer:
                                                                 - Userame: {0}
                                                                 - Technologies: {1}",                                                                               
                                                                 this.Username, this.Technologies);
        }
    }
}
