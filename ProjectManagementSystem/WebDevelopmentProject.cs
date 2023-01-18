using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    class WebDevelopmentProject : IProject
    {
        public string GetProjectDescription()
        {
            return "WebDevelopmentProject";
        }
        public string GetProjectStatus()
        {
            return "InProgress";
        }
        public string GetProjectMemberName()
        {
            return "Suresh";
        }
        public string GetProjectsCategoryName()
        {
            return "Technology";
        }
    }
}
