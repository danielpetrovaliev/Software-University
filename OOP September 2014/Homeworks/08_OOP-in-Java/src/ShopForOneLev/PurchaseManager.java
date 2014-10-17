package ShopForOneLev;

import ShopForOneLev.Products.FoodProduct;
import ShopForOneLev.Products.Product;

public final class PurchaseManager {
	static void ProcessPurchase(Product product, Customer customer){
		if ( product.getPrice() > customer.getBalance() ) {
			throw new IllegalArgumentException("You do not have enough money to buy this product!");
		}
		if (product.getQuantity() == 0) {
			throw new IllegalArgumentException("The product is out of stock.");
		}
		if (customer.getAge() < 18 && product.getAgeRestriction() == AgeRestriction.Adult) {
			throw new IllegalArgumentException("You are too young to buy this product!");
		}
		if (product instanceof FoodProduct) {
			if ( ( ( FoodProduct ) product ).isHasExpiried() ) {
				throw new IllegalArgumentException("This product has expired");
			}
		}
		
		product.setQuantity( product.getQuantity() - 1 );
		customer.setBalance( customer.getBalance() - product.getPrice() );
		System.out.println("Purchase completed.");
	}
}
