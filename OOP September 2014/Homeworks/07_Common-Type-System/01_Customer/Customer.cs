using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Customer
{
    public class Customer : ICloneable, IComparable<Customer>
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string id;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        private IList<Payment> payments;
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, string id,
            string permanentAddress, string mobilePhone, string email, 
            IList<Payment> payments, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = payments;
            this.CustomerType = customerType;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("First name cannot be null or empty.");
                }
                this.firstName = value;
            }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Middle name cannot be null or empty.");
                }
                this.middleName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Last name cannot be null or empty.");
                }
                this.lastName = value;
            }
        }

        public string Id
        {
            get { return this.id; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("ID cannot be null or empty.");
                }
                this.id = value;
            }
        }

        public string PermanentAddress
        {
            get { return this.permanentAddress; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Permanent Address cannot be null or empty.");
                }
                this.permanentAddress = value;
            }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Mobile phone cannot be null or empty.");
                }
                this.mobilePhone = value;
            }
        }

        public string Email
        {
            get { return this.email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Email cannot be null or empty.");
                }
                this.email = value;
            }
        }

        public IList<Payment> Payments
        {
            get { return this.payments; }
            set { this.payments = value; }
        }

        public CustomerType CustomerType
        {
            get { return this.customerType; }
            set { this.customerType = value; }
        }

        public static bool operator ==(Customer firstCustomer, Customer secondCustomer)
        {
            return Equals(firstCustomer, secondCustomer);
        }

        public static bool operator !=(Customer firstCustomer, Customer secondCustomer)
        {
            return !(Equals(firstCustomer, secondCustomer));
        }

        public int CompareTo(Customer other)
        {
            if (this.firstName != other.LastName)
            {
                return this.FirstName.CompareTo(other.FirstName);
            }
            if (this.MiddleName != other.MiddleName)
            {
                return this.MiddleName.CompareTo(other.MiddleName);
            }
            if (this.LastName != other.LastName)
            {
                return this.LastName.CompareTo(other.LastName);
            }
            if (this.Id != other.Id)
            {
                return other.Id.CompareTo(this.Id);
            }
            return 0;
        }

        public override bool Equals(object param)
        {
            Customer other = param as Customer;

            if (other == null)
            {
                return false;
            }

            return string.Equals(this.FirstName, other.FirstName) &&
                   string.Equals(this.MiddleName, other.MiddleName) &&
                   string.Equals(this.LastName, other.LastName) &&
                   string.Equals(this.CustomerType, other.CustomerType) &&
                   string.Equals(this.Email, other.Email) &&
                   string.Equals(this.PermanentAddress, other.PermanentAddress) &&
                   string.Equals(this.Id, other.Id) &&
                   string.Equals(this.MobilePhone, other.MobilePhone) &&
                   string.Equals(this.Payments, other.Payments);
        }

        public override string ToString()
        {
            string paymentsToString = "";
            int counter = 1;
            foreach (var payment in this.Payments)
            {
                paymentsToString += string.Format("{0}. {1}\n", counter, payment);
                counter++;
            }

            string result =
                string.Format(
                    "{0} {1} {2} ID: {3}, Adress: {4}, Phone: {5}, E-mail: {6}, Customer type: {7}, Payments: \n{8}",
                    this.FirstName, this.MiddleName, this.LastName, this.Id, this.PermanentAddress, 
                    this.MobilePhone,this.Email, this.CustomerType, paymentsToString);
            return result;
        }

        public object Clone()
        {
            var clonedPayments = new List<Payment>(this.Payments);

            return new Customer(this.FirstName, this.MiddleName,
                this.LastName, this.Id, this.PermanentAddress,
                this.MobilePhone, this.Email, clonedPayments,
                this.CustomerType);
        }

        public override int GetHashCode()
        {
            return 
                this.FirstName.GetHashCode() ^ this.MiddleName.GetHashCode() 
                   ^ this.LastName.GetHashCode() ^ this.CustomerType.GetHashCode()
                   ^ this.Email.GetHashCode() ^ this.PermanentAddress.GetHashCode()
                   ^ this.Id.GetHashCode() ^ this.MobilePhone.GetHashCode() ^ this.Payments.GetHashCode();
        }
    }
}
