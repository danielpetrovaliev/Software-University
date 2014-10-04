using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _04_CompanyHierarchy.Interfaces;

namespace _04_CompanyHierarchy
{
    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public string ProductName
        {
            get
            {
                return this.productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Product name cannot be null or empty.");
                }
                this.productName = value;
            }
        }
        public DateTime Date
        {
            get
            {
                return this.date;
            }
            set
            {
                this.date = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }
                this.price = value;
            }
        }

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            string result = string.Format("Product name: {0}, Date: {1}, Price: {2}", 
                this.ProductName, this.Date, this.Price);

            return result;
        }
    }
}
