package ShopForOneLev;

public class Customer {
	private String name;
	private int age;
	private double balance;
	
	public Customer(String name, int age, int balance) {
		this.setName(name);
		this.setAge(age);
		this.setBalance(balance);
	}
	
	public String getName() {
		return name;
	}
	public void setName(String name) {
		if (name == null || name == "") {
			throw new IllegalArgumentException("Name cannot be null or empty.");
		}
		this.name = name;
	}
	
	public int getAge() {
		return age;
	}
	public void setAge(int age) {
		if (age < 1) {
			throw new IllegalArgumentException("Invalid age.");
		}
		this.age = age;
	}
	
	public double getBalance() {
		return balance;
	}
	public void setBalance(double balance) {
		if (balance <= 0) {
			throw new IllegalArgumentException("Invalid balance.");
		}
		this.balance = balance;
	}
	
}
