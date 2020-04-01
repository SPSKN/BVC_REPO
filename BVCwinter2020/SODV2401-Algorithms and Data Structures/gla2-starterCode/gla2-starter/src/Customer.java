/**
 * Represents a simple customer.
 *
 * This class should not be modified.
 */
public class Customer {

    private String name;

    // The laptop that the customer has rented, null if no laptop is rented
    private Laptop rentedLaptop;

    public Customer() {
        this("Anonymous", null);
    }

    public Customer(Laptop laptop) {
        this("Anonymous", laptop);
    }

    public Customer(String name) {
        this(name, null);
    }

    public Customer(String name, Laptop rentedLaptop) {
        this.name = name;
        this.rentedLaptop = rentedLaptop;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        this.name = name;
    }

    public Laptop getRentedLaptop() {
        return rentedLaptop;
    }

    public void setRentedLaptop(Laptop rentedLaptop) {
        this.rentedLaptop = rentedLaptop;
    }
}
