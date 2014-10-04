using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    public class Developer : RegularEmployee, IDeveloper
    {
        private IList<Project> projects;

        public IList<Project> Projects
        {
            get
            {
                return this.projects;
            }
            set
            {
                if (value.Count < 1)
                {
                    throw new ArgumentException("Developer must holds a set of projects.");
                }
                this.projects = value;
            }
        }

        public Developer(string firstName, string lastName, string id, decimal salary,
            Department department, IList<Project> projects)
            : base(firstName, lastName, id, salary, department)
        {
            this.Projects = projects;
        }

        public override string ToString()
        {
            string result = String.Format("{0}: {1}, Projects: \n",
                this.GetType().Name, base.ToString());

            int counter = 1;
            foreach (var project in this.Projects)
            {
                result += "\n\t" + counter + ". " + project;

                counter++;
            }

            return result;
        }
    }
}
