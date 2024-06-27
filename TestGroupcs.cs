using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class TestGroup
    {
        public int GroupID { get; set; }
        int TestID { get; set; }
        int UserGroupID { get; set; }
        public TestGroup(int groupID, int testID, int userGroupID)
        {
            this.GroupID = groupID;
            this.TestID = testID;
            this.UserGroupID = userGroupID;
        }
    }

}