using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Humans
{
    public abstract class Human
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get { return this.firstName ;}
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name can not be null or empty!");
                }
                this.firstName = value;
            } 
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name can not be null or empty!");
                }
                this.lastName = value;
            }
        }

        protected Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

    }
}
