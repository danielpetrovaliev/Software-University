using System;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Table : Furniture, ITable
    {
        private decimal length;
        private decimal width;
        private decimal area;

        public Table(string model, MaterialType material, decimal price, decimal height, decimal length, decimal width) 
            : base(model, material, price, height)
        {
            this.width = width;
            this.length = length;
            this.Area = this.Length*this.Width;
        }

        public decimal Length
        {
            get { return this.length; }
        }

        public decimal Width
        {
            get { return this.width; }
        }

        public decimal Area
        {
            get { return this.area; }
            private set { this.area = value; }
        }

        public override string ToString()
        {
            string result =
                String.Format(
                    "Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Length: {5}, Width: {6}, Area: {7}",
                    this.GetType().Name,
                    this.Model,
                    this.Material,
                    this.Price,
                    this.Height, 
                    this.Length, 
                    this.Width,
                    this.Area);
            return result;
        }
    }
}
