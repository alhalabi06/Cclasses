using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Receipt
    {
        public int ReceiptID { get; set; }
        int PatientID { get; set; }
        string Receipts { get; set; }
        Currency CurrencyID { get; set; }
        public Receipt(int ReceiptID, int PatientID, string Receipts , Currency currencyID)
        {
            this.ReceiptID = ReceiptID;
            this.PatientID = PatientID;
            this.Receipts = Receipts;
            CurrencyID = currencyID;
        }
    }

}