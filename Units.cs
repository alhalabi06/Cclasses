using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Units
    {
        public int UnitID { get; set; }
        string Unit { get; set; }
        public Units(int UnitID, string Unit)
        {
            this.UnitID = UnitID;
            this.Unit = Unit;
        }
    }
}