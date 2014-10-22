using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public abstract class Furniture : IFurniture
    {
        private string model;
        private MaterialType material;
        private decimal price;
        private decimal height;

        protected  Furniture(string model, MaterialType material, decimal price, decimal height)
        {
            this.Model = model;
            this.material = material;
            this.Price = price;
            this.Height = height;
        }

        public string Model
        {
            get { return this.model; }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentException("Model cannot be null, empty or less than 3 symbols.");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get { return this.material.ToString(); }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value <= 0)
                {
                    throw new 
                        ArgumentOutOfRangeException("Price cannot be less or equal to $0.00.");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get { return this.height; }
            protected set
            {
                if (value <= 0)
                {
                    throw new 
                        ArgumentOutOfRangeException("Height cannot be less or equal to 0.00 m.");
                }
                this.height = value;
            }
        }
    }
}
