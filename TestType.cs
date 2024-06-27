using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class TestType
    {
        public int TestTypeID { get; set; }
        string TestTypee { get; set; }
        public TestType(int testTypeID, string TestType)
        {
            this.TestTypeID = testTypeID;
            this.TestTypee = TestType;
        }
    }

}