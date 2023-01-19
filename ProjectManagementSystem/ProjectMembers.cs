using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ProjectMembers
    {
        private int _projectMemeberID;
        public int ProjectMemberId
        {
            get { return _projectMemeberID; }
            set { _projectMemeberID = value; }
        }
        private string _memberName;
        public string MemberName
        {
            get { return _memberName; }
            set { _memberName = value; }
        }
        private string _contactDetails;
        public string ContactDetails
        {
            get { return _contactDetails; }
            set { _contactDetails = value; }
        }
        private int _empCode;
        public int EmpCode
        {
            get { return _empCode; }
            set { _empCode = value; }
        }
        private int _allocation;
        public int Allocation
        {
            get { return _allocation; }
            set { _allocation = value; }
        }
        public ProjectMembers(string memberName, int allocation)
        {
            MemberName = memberName;
            Allocation = allocation;
        }
        public static void Main()
        {
            ProjectMembers projectMembers = new ProjectMembers("Ramesh", 40);
        }
    }
}
