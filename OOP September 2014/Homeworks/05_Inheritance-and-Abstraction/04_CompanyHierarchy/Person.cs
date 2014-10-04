using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;

namespace _04_CompanyHierarchy
{
    public abstract class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private string id;

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null");
                }
                this.firstName = value;
            }
        }
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null");
                }
                this.lastName = value;
            }
        }
        public string Id
        {
            get
            {
                return this.id;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID cannot be null");
                }
                this.id = value;
            }
        }
        
        protected Person(string firstName, string lastName, string id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }

        public override string ToString()
        {
            string result = String.Format("{0} {1}, ID: {2}", 
                this.FirstName, this.LastName, this.Id);
            
            return result;
        }
    }
}
