using System;

namespace SelectTheStudentsFromGroup2
{
    public class Group
    {
        // constructors
        public Group(int groupNumber, string departmentName)
            : this(groupNumber)
        {
            this.DepartmentName = departmentName;
        }

        public Group (int groupNumber)
        {
            this.GroupNumber = groupNumber;
        }

        // properties
        public int GroupNumber { get; set; }

        public string DepartmentName { get; set; }
    }
}
