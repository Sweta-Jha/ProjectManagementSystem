using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class HealthCareProject : Project, IProject
    {
        public string GetProjectDescription()
        {
            return ProjectDescription;
        }
        public string GetProjectMemberName()
        {
            return ProjectMember.MemberName;
        }
        public string GetProjectsCategoryName()
        {
            return CategoryName;
        }
        public string GetProjectStatus()
        {
            return "InProgress";
        }
        public override void ProjectInformation()
        {
            Console.WriteLine("This is Healthcare Project");
        }
    }

}
