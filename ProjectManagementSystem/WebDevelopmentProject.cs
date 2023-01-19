using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    class WebDevelopmentProject : IProject
    {
        public string ProjectName;
        public string ProjectDescription;
        public string ProjectStatus;
        public ProjectMembers ProjectMembers;
        public string ProjectCategory;
        public WebDevelopmentProject()
        {
            ProjectName = "WebTool";
            ProjectDescription = "WebDevelopmentProject";
            ProjectStatus = "InProgress";
            ProjectCategory = "Technology"; 
        }
        public string GetProjectDescription()
        {
            return ProjectDescription;
        }
        public string GetProjectStatus()
        {
            return ProjectStatus;
        }
        public string GetProjectMemberName()
        {
            return ProjectMembers.MemberName;
        }
        public string GetProjectsCategoryName()
        {
            return ProjectCategory;
        }
    }
}
