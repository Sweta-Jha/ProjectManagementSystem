using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Project projectobj1 = new HealthCareProject();
            projectobj1.display(02);
            projectobj1.display("Project Management system");
            projectobj1.ProjectDetails();
            projectobj1.ProjectInfo();
            projectobj1.ProjectID = 02;
            WebDevelopmentProject projectObj2 = new WebDevelopmentProject();
            var projectType = ProjectFactory.GetProject("WebDevelopment");
        }
    }
}
