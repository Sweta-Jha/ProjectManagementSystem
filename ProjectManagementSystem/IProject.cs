using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystem
{
    public interface IProject
    {
        void GetProjectDescription();
        void GetProjectStatus();
        void GetProjectMembersDetail();
        void GetProjectCategory();
    }
}
