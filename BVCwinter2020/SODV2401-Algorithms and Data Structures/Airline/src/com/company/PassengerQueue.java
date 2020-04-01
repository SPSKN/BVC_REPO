package com.company;
import java.util.ArrayDeque;
import java.util.Queue;

/**
 *
 */
public class PassengerQueue {
    private Queue<Passenger> passengerQueue;
    private int numberServed;
    private int totalWait;
    private String queueName;
    private Queue<int[]> arrivalTimes = null;
    private double arrivalRate;

    /**
     * Construct a passenger queue with given name
     */
    /**
     *
     * @param queueName
     */
    public PassengerQueue(String queueName){
        numberServed = 0;
        totalWait=0;
        this.queueName = queueName;
        passengerQueue = new ArrayDeque<>();
    }
    /**
     * Construct a passenger queue with given name and predefined sequence of arrival times
     */
    /**
     *
     * @param queueName
     * @param arrivalTime
     */
    public PassengerQueue(String queueName, Queue<int[]> arrivalTime){
        this(queueName);
        this.arrivalTimes = arrivalTime;
    }

    /**
     * Returning the number of passenger served
     */

    public int getNumberServed(){
        return numberServed;
    }

    /**
     * Return total wait time
     */

    public int getTotalWait(){
        return totalWait;
    }
    /**
     * Return Queue Name
     */
    public String getQueueName(){
        return queueName;
    }
    /**
     * Set arrivalRate
     */
    public double setArrivalRate(){
        return arrivalRate;
    }

    /**
     * Get Arrival rates
     * @return
     */
    public double getArrivalRate() {
        return arrivalRate;
    }
    /// is the queue empty

    /**
     *
     * @return
     */
    public boolean isEmpty(){
        return passengerQueue.isEmpty();
    }
    /// the size of the queue

    /**
     *
     * @return
     */
    public int size(){
        return passengerQueue.size();
    }

    /**
     *
     * @param clock
     * @param showAll
     */

    // check if new arrival has occurred
    public void checkNewArrival(int clock,boolean showAll){
        if(arrivalTimes != null && !arrivalTimes.isEmpty()){
            int[] nextArrivalTime = arrivalTimes.peek();
            if(clock == nextArrivalTime[0]){
                passengerQueue.add(new Passenger(clock,nextArrivalTime[1]));
                if(showAll){
                    System.out.println("Time is "+ clock + queueName + " Arrival, new queue size is " + passengerQueue.size());
                }
                arrivalTimes.poll();
            }else{
                if(Math.random() < arrivalRate){
                    passengerQueue.add(new Passenger(clock));
                    if(showAll){
                        System.out.println("Time is "+ clock + queueName + " Arrival, new queue size is " + passengerQueue.size());
                    }
                }

            }
        }


    }//end of checkNewArrival

    /**
     * Update status
     */
    public int update(int clock,boolean showAll){
        Passenger nextPassenger = passengerQueue.remove();
        int timeStamp = nextPassenger.getArrivalTime();
        int wait = clock - timeStamp;
        totalWait += wait;
        numberServed++;
        if(showAll){
            System.out.println("Time is "+ clock + queueName + " Arrival, new queue size is " + passengerQueue.size());
        }
        return clock + nextPassenger.getProcessingTime();
    }

}
