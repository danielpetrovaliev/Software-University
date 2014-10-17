package ShopForOneLev.Products;

import java.security.InvalidParameterException;
import ShopForOneLev.AgeRestriction;
import ShopForOneLev.Interfaces.Buyable;

public abstract class Product implements Buyable {
	private String name;
	protected double price;
	private int quantity;
	private AgeRestriction ageRestriction;
	
	public Product(String name, double price, int quantity,
			AgeRestriction ageRestriction) {
		this.setName(name);
		this.setPrice(price);
		this.setQuantity(quantity);
		this.setAgeRestriction(ageRestriction);
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		if (name == null || name == "") {
			throw new NullPointerException("Name cannot be null or empty.");
		}
		this.name = name;
	}
	public double getPrice() {
		return price;
	}
	public void setPrice(double price) {
		if (price < 1) {
			throw new InvalidParameterException("Invalid price.");
		}
		this.price = price;
	}
	public int getQuantity() {
		return quantity;
	}
	public void setQuantity(int quantity) {
		if (quantity < 1) {
			throw new InvalidParameterException("Invalid quantity.");
		}
		this.quantity = quantity;
	}
	public AgeRestriction getAgeRestriction() {
		return ageRestriction;
	}
	public void setAgeRestriction(AgeRestriction ageRestriction) {
		this.ageRestriction = ageRestriction;
	}

	@Override
	public String toString() {
		return "Name: " + this.getName() +
				"\nPrice: " + this.getPrice() +
				"\nQuantity: " + this.getQuantity() +
				"\nAge Restriction Level: " + this.getAgeRestriction() + "\n";
	}
	
}
