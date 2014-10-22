using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }

        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be null or empty");
                }
                if (value.Length < 5)
                {
                    throw new ArgumentOutOfRangeException("Name cannot be with less than 5 symbols.");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get { return this.registrationNumber; }
            private set
            {
                if (value.Length != 10)
                {
                    throw new ArgumentOutOfRangeException("Registration number must be exactly 10 symbols.");
                }
                if (value.Any(ch => !char.IsDigit(ch)))
                {
                    throw new FormatException("Registration number must contain only digits.");
                }
                this.registrationNumber = value;
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get { return new List<IFurniture>(this.furnitures); }
        }

        public void Add(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Cannot add null to furnitures.");
            }

            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            if (furniture == null)
            {
                throw new ArgumentNullException("Cannot remove null from furnitures.");
            }

            this.furnitures.Remove(furniture);
        }

        public IFurniture Find(string model)
        {
            var result = this.Furnitures.FirstOrDefault(m => m.Model.ToLower() == model.ToLower());
            return result;
        }

        public string Catalog()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format("{0} - {1} - {2} {3}", 
                this.Name, 
                this.RegistrationNumber, 
                this.Furnitures.Count != 0 ? this.Furnitures.Count.ToString() : "no",
                this.Furnitures.Count != 1 ? "furnitures" : "furniture"));

            var sordetFurnitures = this.furnitures
                .OrderBy(f => f.Price).ThenBy(f => f.Model);

            foreach (var sordetFurniture in sordetFurnitures)
            {
                result.AppendLine(sordetFurniture.ToString());
            }

            return result.ToString().Trim();
        }
    }
}
