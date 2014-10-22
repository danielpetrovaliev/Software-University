using FurnitureManufacturer.Interfaces;

namespace FurnitureManufacturer.Models
{
    public class ConvertibleChair : Chair, IConvertibleChair
    {
        private bool isConverted;
        private decimal normalHeight;

        public ConvertibleChair(string model, MaterialType material, decimal price, decimal height, int numberOfLegs)
            : base(model, material, price, height, numberOfLegs)
        {
            this.isConverted = false;
            this.normalHeight = this.Height;
        }

        public bool IsConverted
        {
            get { return this.isConverted; }
        }

        public void Convert()
        {
            
            if (this.IsConverted)
            {
                this.isConverted = false;
                this.Height = this.normalHeight;
            }
            else
            {
                this.isConverted = true;
                this.Height = 0.10m;
            }
        }

        public override string ToString()
        {
            string result = base.ToString() + string.Format(", State: {0}",
                this.IsConverted ? "Converted" : "Normal");
            return result;
        }
    }
}