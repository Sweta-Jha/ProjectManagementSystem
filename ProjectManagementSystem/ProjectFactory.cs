using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public  class ProjectFactory
    {
        public static IProject GetProject(string prj)
        {
            IProject project = null;
            if(prj == "HealthCareProject") 
            {
                project = new HealthCareProject();
            }
            else if(prj== "WebDevelopment")
            {
                project = new WebDevelopmentProject();
            }
            return project;
        }
    }
}
