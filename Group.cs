using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final1
{
    internal class Group
    {
        public int GroupID { get; set; }
        string Groups { get; set; }
        public Group(int GroupGroupID, string Groups)
        {
            this.GroupID = GroupGroupID;
            this.Groups = Groups;
        }
    }
}
