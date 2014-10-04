using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_CompanyHierarchy.Interfaces
{
    public interface IDeveloper
    {
        IList<Project> Projects { get; set; }
    }
}
