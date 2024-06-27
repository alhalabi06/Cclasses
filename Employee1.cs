using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string PhoneNumber { get; set; }
        string Gender { get; set; }
        int CityID { get; set; }
        int ReletivesID { get; set; }
        BloodType BloodTypeID { get; set; }
        DateTime DateOfBirth { get; set; } // didn't find the dateOnly

        public Employee(int Employee, string FirstName, string LastName, string PhoneNumber, string Gender, DateTime DateOfBirth, int CityID, int ReletivesID, BloodType BloodTypeID)
        {
            this.EmployeeID = EmployeeID;
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