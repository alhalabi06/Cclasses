using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public class State
    {
        public int StateID { get; set; }
        int CityID { get; set; }
        int CountryID { get; set; }
        string StateName { get; set; }

        public State(int CityID, int CountryID, string StateName, DateTime ModDate, string UserCreate, DateTime CreateDate, string UserMod)
        {
            this.CityID = CityID;
            this.CountryID = CountryID;
            this.StateName = StateName;

        }
    }
}
