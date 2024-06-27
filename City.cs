namespace finito.Pages
{
    public class City
    {
        public int CityID { get; set; }
        public int PatientID { get; set; }
        public int StateID { get; set; }
        string CityName { get; set; }
        public City(int CityID , int StateID, string CityName)
        { 
            this.CityID = CityID;

            this.StateID = StateID;
            this.CityName = CityName;

        }
    }
}
