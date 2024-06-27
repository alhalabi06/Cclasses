using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    class Country
    {
        public int CountryID { get; set; }
        public int StateID { get; set; }
        string CountryName { get; set; }

        public Country(int StateID, string CountryName, string UserCreate, string UserMod, DateTime CreateDate, DateTime ModDate)
        {
            // the constructoe is the first thing called while execution    
            this.CountryID += 1;
            this.StateID = StateID;
            this.CountryName = CountryName;
        }

    }
}
