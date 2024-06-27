using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Price
    {
        int PriceID {  get; set; } 
        Currency CurrencyID {  get; set; }
        Insurence InsurenceID {  get; set; }
        Tests TestID {  get; set; }
        int Prices {  get; set; }
        public Price (int PriceID , Currency CurrencyID ,Insurence  InsurenceID,Tests TestID , int Prices )
        {
            this.PriceID = PriceID;
            this.CurrencyID = CurrencyID;
            this.InsurenceID = InsurenceID;
            this.TestID = TestID;
            this.Prices = Prices;
        }
    }
}
