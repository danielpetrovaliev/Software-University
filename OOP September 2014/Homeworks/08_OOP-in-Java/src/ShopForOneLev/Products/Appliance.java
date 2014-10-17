package ShopForOneLev.Products;

import ShopForOneLev.AgeRestriction;

public class Appliance extends ElectronicsProduct{

	public Appliance(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 6);
	}

	@Override
	public double getPrice() {
		if (this.getQuantity() < 50) {
			this.price *= 1.05;
		}
		return this.price;
	}
	
	

}
