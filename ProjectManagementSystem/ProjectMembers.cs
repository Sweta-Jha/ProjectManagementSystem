using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ProjectMembers
    {
        private int _ProjectMemeberID;
        public int ProjectMemberId
        {
            get { return _ProjectMemeberID; }
            set { _ProjectMemeberID = value; }
        }
        private string _MemberName;
        public string MemberName
        {
            get { return _MemberName; }
            set { _MemberName = value; }
        }
        private string _ContactDetails;
        public string ContactDetails
        {
            get { return _ContactDetails; }
            set { _ContactDetails = value; }
        }
        private int _EmpCode;
        public int EmpCode
        {
            get { return _EmpCode; }
            set { _EmpCode = value; }
        }
        private int _Allocation;
        public int Allocation
        {
            get { return _Allocation; }
            set { _Allocation = value; }
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
