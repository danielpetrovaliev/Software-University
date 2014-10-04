using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy.Interfaces
{
    public interface IProject
    {
        string ProjectName { get; set; }
        DateTime ProjectStartDate { get; set; }
        string Details { get; set; }
        State State { get; set; }
        void CloseProject(State state);
    }
}
