import java.util.Queue;
import java.util.Stack;

/**
 * GLA 2
 * Scott Patterson
 * 2020-02-28
 *
 * Stacks and Queues
 *
 */


public class RentalStore {

    private int numEmployees;
    private Laptop[] InitialRentalPool;
    private Laptop[] InitialRepairPool;
    private CustomerProvider provider;
    private Queue<Customer> line;
    private Stack<Laptop> RentalPool;
    private Queue<Laptop> RepairPool;



    public RentalStore(int numEmployees,
                       Laptop[] initialRentalPool,
                       Laptop[] initialRepairPool,
                       CustomerProvider provider) {
        this.InitialRentalPool = initialRentalPool;
        this.InitialRepairPool = initialRepairPool;
        this.provider = provider;
        this.numEmployees = numEmployees;


        for(Laptop laptop : InitialRentalPool)
        {
            if(RentalPool != null) {
                RentalPool.add(laptop);
            }else{
                System.out.println("Ops Rentals");
            }
        }
        for(Laptop laptop : InitialRepairPool)
        {
            if(RepairPool != null) {
                RepairPool.add(laptop);
            }else{
                System.out.println("Ops Repairs");
            }
        }

    }

    /**
     * Ticks the simulation once.
     * Do not change this method.
     */
    public void tick() {
        for (Customer customer : provider.getIncomingCustomers()) {
            addCustomer(customer);
        }
        for (int i = 0; i < numEmployees; i++) {
            employeeAct();
        }
    }

    /**
     * Simulate a customer arriving in the store to rent or return a laptop.
     *
     * If the customer has a laptop, they are returning it. Otherwise, they are renting a new laptop.
     */
    private void addCustomer(Customer newCustomer) {
        line.add(newCustomer);

        for(Customer cus :  line){
            if (cus.getRentedLaptop()==null)
            {
                cus.setRentedLaptop(RentalPool.pop());
                line.remove(cus);
            }
            else if(cus.getRentedLaptop().isBroken() == true)
            {
               cus.getRentedLaptop();

               line.remove(cus);
            }
        }
    }

    /**
     * Have one employee act according to the program requirements
     */
    private void employeeAct() {


    }

    /**
     * @return The customer who is next in line
     */
    public Customer viewNextCustomer() {
        if(line.peek() != null) {
            Customer nextInLine = line.peek(); /// peek and the next customer in line
            if(nextInLine!= null)
            {
                System.out.println("Next in line is"+ nextInLine.getName());
            }
        }

        return null;
    }

    /**
     * @return The laptop that is next to be rented
     */
    public Laptop viewNextRentalLaptop() {

        /**
         * Checking if the RentalPool is null
         */
        if (RentalPool.peek() != null)
        {
            Laptop RL = RentalPool.pop();
            return RL;
        }
        else{
            /**
             * RentalPool is empty
             */
            return null;
        }
    }
    /**
     * @return The laptop that is next to be repaired.
     */
    public Laptop viewNextRepairLaptop() {

        if(RepairPool.peek()!= null)
        {
            Laptop L=RepairPool.peek();
            L.setBroken(false);
            RepairPool.remove();
            RentalPool.add(L);
            return L;

        }
        return null;
    }


}
