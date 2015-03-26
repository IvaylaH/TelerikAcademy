using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractStudentsByGroupName
{
    public class Group
    {
        // constructors
        public Group(int groupNumber, string groupName, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.GroupName = groupName;
            this.DepartmentName = departmentName;
        }

        // properties
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }

        public string GroupName { get; set; }
    }
}
