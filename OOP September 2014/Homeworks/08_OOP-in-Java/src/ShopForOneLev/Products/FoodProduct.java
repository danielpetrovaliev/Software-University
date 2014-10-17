package ShopForOneLev.Products;

import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.concurrent.TimeUnit;
import ShopForOneLev.AgeRestriction;
import ShopForOneLev.Interfaces.Expirable;

public class FoodProduct extends Product implements Expirable{
	private Date expirationDate;
	private long daysUntilExpiry;
	private boolean hasExpiried;

	/**
	 * 
	 * @param name
	 * @param price
	 * @param quantity
	 * @param ageRestriction
	 * @param expirationDate in format dd-MM-yyyy in string
	 */
	public FoodProduct(String name, double price, int quantity,
			AgeRestriction ageRestriction, String expirationDate) {
		super(name, price, quantity, ageRestriction);
		
		SimpleDateFormat simpleFormat = (SimpleDateFormat) DateFormat.getDateInstance();
	    simpleFormat.applyPattern("dd-MM-yyyy");
		
		try {
			this.expirationDate = simpleFormat.parse(expirationDate);
		} catch (ParseException e) {
			throw new IllegalArgumentException("not a valid date");
		}
		
		checkIfExpired();
	}

	public boolean isHasExpiried() {
		return hasExpiried;
	}
	
	public long getDaysUntilExpiry() {
		return daysUntilExpiry;
	}

	public void setDaysUntilExpiry(long daysUntilExpiry) {
		this.daysUntilExpiry = daysUntilExpiry;
	}

	@Override
	public double getPrice() {
		if (this.daysUntilExpiry <= 15) {
			this.price *= 0.70;
		}
		return this.price;
	}

	@Override
	public Date getExpirationDate() {
		return this.expirationDate;
	}
	
	private void checkIfExpired() {	
		Date now = new Date();
		long diff = this.expirationDate.getTime() - now.getTime();
		long days = TimeUnit.DAYS.convert(diff, TimeUnit.MILLISECONDS);
		
		if (days < 1) {
			this.hasExpiried = true;
		} else {
			this.hasExpiried = false;
		}
		
		this.daysUntilExpiry = days;
	}
	
}
