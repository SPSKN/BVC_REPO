import java.util.ArrayList;
import java.util.List;

/**
 * Example test code
 */
public class Main {


    public static void main(String... args) {
        List<Customer> tickZeroCustomers = new ArrayList<>();
        List<Customer> tickOneCustomers = new ArrayList<>();
        List<Customer> tickTwoCustomers = new ArrayList<>();

        tickZeroCustomers.add(new Customer("T0C0"));
        tickZeroCustomers.add(new Customer("T0C1", new Laptop(false)));
        tickZeroCustomers.add(new Customer("T0C2"));

        tickTwoCustomers.add(new Customer("T2C0", new Laptop(true)));
        tickTwoCustomers.add(new Customer("T2C1"));

        List<List<Customer>> upcomingCustomers = new ArrayList<>();
        upcomingCustomers.add(tickZeroCustomers);
        upcomingCustomers.add(tickOneCustomers);
        upcomingCustomers.add(tickTwoCustomers);



        List<Laptop> rentalPool = new ArrayList<>();
        List<Laptop> repairPool = new ArrayList<>();

        rentalPool.add(new Laptop());

        repairPool.add(new Laptop(true));
        repairPool.add(new Laptop(true));



        CustomerProvider provider = new CustomerProvider(upcomingCustomers);
        RentalStore testStore = new RentalStore(1,
                rentalPool.toArray(new Laptop[0]),
                repairPool.toArray(new Laptop[0]),
                provider);

        int num_ticks = 4;

        for (int i = 0; i < num_ticks; i++) {
            System.out.println("Tick " + i);
            System.out.println("Next customer: " + testStore.viewNextCustomer());
            System.out.println("Next rental laptop: " + testStore.viewNextRentalLaptop());
            System.out.println("Next repair laptop: " + testStore.viewNextRepairLaptop());
        }

    }

}
