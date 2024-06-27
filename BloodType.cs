namespace finito.Pages
{
    public class BloodType
    {
        public int BloodID { get; set; }
        string BloodName { get; set; }
        // declare as nullable => ?
    }         
    public BloodType(int BloodID, String BloodName)
        {
            this.BloodID = BloodID;
            this.BloodName = BloodName;
        }
}
