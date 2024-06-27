namespace finito.Pages
{
    public class Currency
    {

        public int CurrencyID { get; set; }
        string currency { get; set; }
        string UserCreate { get; set; }
        DateTime CreateDate { get; set; }
        string UserMod { get; set; }
        DateTime ModDate { get; set; }
        public Currency( string currency, string UserCreate, string UserMod, DateTime CreateDate, DateTime ModDate)
        {
            Currency.CurrencyID +=1;
            this.currency = currency;
            this.UserCreate = UserCreate;
            this.UserMod = UserMod;
            this.CreateDate = CreateDate;
            this.ModDate = ModDate;
        }
    }
}
