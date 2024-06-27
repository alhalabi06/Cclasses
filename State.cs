using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class States
    {
        public int StateID { get; set; }
        int CountryID { get; set; }
        string StateName { get; set; }
        public States(int StateID, int countryID, string stateName)
        {
            this.StateID = StateID;
            this.CountryID = countryID;
            this.StateName = stateName;
        }
    }

}