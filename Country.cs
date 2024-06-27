namespace finito.Pages
{
    Country myc = new Country(); 
    class Country
    {
        public int CountryID { get; set; }
        public int StateID { get; set; }
        string CountryName { get; set; }
        string UserCreate { get; set; }
        DateTime CreateDate { get; set; }
        string UserMod { get; set; }
        DateTime ModDate { get; set; }

        public Country( int StateID, string CountryName, string UserCreate, string UserMod, DateTime CreateDate, DateTime ModDate)
        {
            // the constructoe is the first thing called while execution    
            Country.CountryID +=1 ;
            this.StateID = StateID;
            this.CountryName = CountryName;
            this.UserCreate = UserCreate;
            this.UserMod = UserMod;
            this.CreateDate = CreateDate;
            this.ModDate = ModDate;
        }

    }
}
