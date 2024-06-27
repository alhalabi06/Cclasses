using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Insurence
    {
        int InsurenceID {  get; set; } 
        string  InsurenceName {  get; set; }
        public Insurence(int InsurenceID , string InsurenceName) {
            this.InsurenceID = InsurenceID;
            this.InsurenceName = InsurenceName;
        }
    }
}
