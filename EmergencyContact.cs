using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public class EmergencyContact
    {
        public int RelativesID { get; set; }
        string RelativesName { get; set; }
        string Date { get; set; }
        string Address { get; set; }


        public EmergencyContact(string relativesName, string date, string address, string userCreate, DateTime createDate, string userMod, DateTime modDate)
        {
            this.RelativesName = relativesName;
            this.Date = date;
            this.Address = address;
        }
    }
}
