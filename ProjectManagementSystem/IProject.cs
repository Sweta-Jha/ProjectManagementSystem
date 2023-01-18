using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public interface IProject
    {
        string GetProjectDescription();
        string GetProjectStatus();
        string GetProjectMemberName();
        string GetProjectsCategoryName();
    }
}
