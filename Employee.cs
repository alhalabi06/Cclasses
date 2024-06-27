namespace finito.Pages
{
    Employee E = new Employee()
    public class Employee
    {
        public int EmployeeID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Gender { get; set; }
        DateOnly DateOfBirth { get; set; }
        int CityID { get; set; }
        int ReletivesID { get; set; }
        BloodType BloodTypeID { get; set; }
        public Employee(string Employee, string FirstName, string LastName, string PhoneNumber, string Gender, DateOnly DateOfBirth, int CityID, inr ReletivesID, BloodType BloodTypeID)
        {
            Employee.EmployeeID +=1;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.Gender = Gender;
            this.DateOfBirth = DateOfBirth;
            this.CityID = CityID;
            this.ReletivesID = ReletivesID;
            this.BloodTypeID = BloodTypeID;



        }
    }
}
