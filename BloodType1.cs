using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public class BloodType
    {
        public int BloodID { get; set; }
        string BloodName { get; set; }

    
    public BloodType(int BloodID, String BloodName)
    {
        this.BloodID = BloodID;
        this.BloodName = BloodName;
    }
}
}