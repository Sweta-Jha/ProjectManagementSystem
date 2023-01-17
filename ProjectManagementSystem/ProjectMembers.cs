using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class ProjectMembers
    {
        private int ProjectMemeberID;
        public int projectMemberId
        {
            get { return ProjectMemeberID; }
            set
            {
                ProjectMemeberID = value;
            }
        }
        private string MemberName;
        public string memberName
        {
            get { return MemberName; }
            set
            {
                MemberName = value;
            }
        }
        private string ContactDetails;
        public string contactDetails
        {
            get { return contactDetails; }
            set
            {
                contactDetails = value;
            }
        }
        private int EmpCode;
        public int empCode
        {
            get { return EmpCode; }
            set
            {
                EmpCode = value;
            }
        }
        private int Allocation;
        public int allocation
        {
            get { return Allocation; }
            set
            {
                Allocation = value;
            }
        }
        private Project Project;
        public Project project
        {
            get
            {
                return Project;
            }
            set { Project = value; }
        }
        public ProjectMembers(string memberName,string ProjectName,int allocation)
        {
            MemberName = memberName;
            Project.projectName = ProjectName;
            Allocation = allocation;
        }
        public static void Main()
        {
            ProjectMembers projectMembers = new ProjectMembers("Ramesh","Web development",40);
        }
    }
}
