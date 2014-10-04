using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Humans
{
    public class Student : Human
    {
        private string factualyNumber;

        public string FactualyNumber 
        {
            get { return this.factualyNumber;} 
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Factualy number can not be null!");
                }
                else if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Factualy number length must be between 5 and 10 digits.");
                }
                this.factualyNumber = value;
            }
        }

        public Student(string firstName, string lastName, string factyalyNumber) 
            : base(firstName, lastName)
        {
            this.FactualyNumber = factyalyNumber;
        }

        public override string ToString()
        {
            return String.Format("Student: {0} {1}, Factualy number: {2}",
                this.FirstName, this.LastName, this.FactualyNumber);
        }
    }
}
