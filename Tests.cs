using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Tests
    {
        int TestID { get; set; }
        string TestName { get; set; }
        int UnitID { get; set; }
        int UserID { get; set; }
        string TestTypeID { get; set; }
        public Tests(int testID, string testName, int unitID, int userID, string testTypeID)
        {
            this.TestID = testID;
            this.TestName = testName;
            this.UnitID = unitID;
            this.UserID = userID;
            this.TestTypeID = testTypeID;
        }
    }

}