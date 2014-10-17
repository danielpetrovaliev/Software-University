package ShopForOneLev;

import java.util.Comparator;
import java.util.List;
import java.util.ArrayList;
import java.util.stream.Collectors;
import ShopForOneLev.Interfaces.Expirable;
import ShopForOneLev.Products.Computer;
import ShopForOneLev.Products.FoodProduct;
import ShopForOneLev.Products.Product;

public class TestShop {

	public static void main(String[] args) {
		
		Product hp = new Computer("Hp pavilion", 1600, 100000, AgeRestriction.None);
		System.out.println(hp.getPrice());
		Customer gosho = new Customer("Georgi", 18, 2000);
		PurchaseManager.ProcessPurchase(hp, gosho);
		System.out.println(gosho.getBalance());
		
		Customer peshko = new Customer("Peshkata", 15, 500);
		Product cigarets = new FoodProduct("Victory", 5, 500, AgeRestriction.Adult, "05-12-2018");
		//PurchaseManager.ProcessPurchase(cigarets, peshko); this must throw exception
		System.out.println();
		
		List<Product> products = new ArrayList<Product>();
		products.add(new FoodProduct("Cola", 2.00, 1000, AgeRestriction.None, "01-01-2015"));
		products.add(new FoodProduct("Fanta", 2.00, 1000, AgeRestriction.None, "01-01-2015"));
		products.add(new FoodProduct("Bread", 1.00, 500, AgeRestriction.None, "01-11-2014"));
		products.add(new FoodProduct("Jonnie Walker", 80.00, 489, AgeRestriction.Adult, "01-01-2018"));
		products.add(new Computer("Asus", 2000, 100, AgeRestriction.None));
		products.add(new Computer("Dell", 1200, 50, AgeRestriction.None));
		
		Comparator<Product> byDateOfExpiry =  (p1, p2) ->Double.compare( 
				((FoodProduct)p1).getDaysUntilExpiry(), ( (FoodProduct)p2 ).getDaysUntilExpiry() );
		
		Comparator<Product> byPrice = (p1, p2) -> Double.compare(p1.getPrice(), (p2.getPrice()));
				
				Product expirableProduct = products.stream()
						.filter(p -> p instanceof Expirable)
						.sorted(byDateOfExpiry)
						.findFirst()
						.get();
				
				System.out.println(expirableProduct);
				System.out.println("\n ----------------");
				
				List<Product> adultAgerestrictionByPrice = products.stream()
						.filter(p -> p.getAgeRestriction() == AgeRestriction.Adult)
						.sorted(byPrice)
						.collect(Collectors.toList());
				
				for (Product product : adultAgerestrictionByPrice) {
					System.out.println(product + "\n");
				}
	}
	
	

}
