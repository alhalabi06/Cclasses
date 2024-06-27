using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Users
    {
        public int UserID { get; set; }
        int PatientID { get; set; }
        string UserName { get; set; }
        int GroupID { get; set; }
        int EmployeeID { get; set; }
        public Users(int UserID, int PatientID, string UserName, int GroupID, int EmployeeID)
        {
            this.UserID = UserID;
            this.PatientID = PatientID;
            this.UserName = UserName;
            this.GroupID = GroupID;
            this.EmployeeID = EmployeeID;
        }
    }
}
