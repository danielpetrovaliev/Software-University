package ShopForOneLev.Products;

import ShopForOneLev.AgeRestriction;

public class Computer extends ElectronicsProduct {

	public Computer(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		super(name, price, quantity, ageRestriction, 24);
	}

	@Override
	public double getPrice() {
		if (this.getQuantity() > 1000) {
			this.price *= 0.95;
		}
		return this.price;
	}

	

}
