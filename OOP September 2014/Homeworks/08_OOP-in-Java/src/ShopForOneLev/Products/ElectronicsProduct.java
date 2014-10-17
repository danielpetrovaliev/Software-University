package ShopForOneLev.Products;

import java.security.InvalidParameterException;

import ShopForOneLev.AgeRestriction;

public abstract class ElectronicsProduct extends Product {
	private int guaranteePeriod;
	
	public ElectronicsProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, int guaranteePeriod) {
		super(name, price, quantity, ageRestriction);
		this.setGuaranteePeriod(guaranteePeriod);
	}

	public int getGuaranteePeriod() {
		return guaranteePeriod;
	}

	public void setGuaranteePeriod(int guaranteePeriod) {
		if (guaranteePeriod < 1) {
			throw new InvalidParameterException("Invalid guarantee period.");
		}
		this.guaranteePeriod = guaranteePeriod;
	}

	
}
