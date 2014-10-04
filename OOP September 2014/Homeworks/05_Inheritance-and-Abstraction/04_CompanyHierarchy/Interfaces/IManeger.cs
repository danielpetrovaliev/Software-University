using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04_CompanyHierarchy.Interfaces
{
    public interface IManeger
    {
        IList<Employee> Employees { get; set; }
    }
}
