using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class Chair : Furniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs) 
            : base(model, material, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return this.numberOfLegs; }
            private set { this.numberOfLegs = value; }
        }

        public override string ToString()
        {
            string result = 
                String.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}, Legs: {5}",
                this.GetType().Name, this.Model, this.Material, this.Price, this.Height, this.NumberOfLegs);
            return result;
        }
    }
}
