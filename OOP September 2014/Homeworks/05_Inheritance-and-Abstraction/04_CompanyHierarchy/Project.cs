using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;
using _04_CompanyHierarchy.Enumerations;

namespace _04_CompanyHierarchy
{
    public class Project : IProject
    {
        private string projectName;
        private DateTime projectStartDate;
        private string details;
        private State state;

        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Project name cannot be null.");
                }
                this.projectName = value;
            }
        }
        public DateTime ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                this.projectStartDate = value;
            }
        }
        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Details cannot be null or empty.");
                }
                this.details = value;
            }
        }
        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }

        public Project(string projectName, DateTime projectStartDate, 
            string details, State state)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.Details = details;
            this.State = state;
        }

        public void CloseProject(State state)
        {
            this.State = State.Closed;
        }

        public override string ToString()
        {
            string result = String.Format("Project name: {0}, Start date: {1}, Details: {2}, State: {3}",
                this.ProjectName, this.ProjectStartDate, this.Details, this.State);

            return result;
        }
    }
}
