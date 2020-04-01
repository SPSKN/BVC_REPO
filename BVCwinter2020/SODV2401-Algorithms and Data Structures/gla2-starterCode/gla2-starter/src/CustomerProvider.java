import java.util.ArrayList;
import java.util.List;

/**
 * Provides arrays of incoming customers for the simulation
 */
public class CustomerProvider {

    private List<List<Customer>> customers;

    public CustomerProvider(List<List<Customer>> upcomingCustomers) {
        this.customers = upcomingCustomers;
    }

    /**
     * Gets next array of arriving return customers, in order.
     * @return
     */
    public Customer[] getIncomingCustomers() {
        List<Customer> toReturn = customers.isEmpty() ? new ArrayList() : customers.remove(0);

        return toReturn.toArray(new Customer[0]);
    }

}
