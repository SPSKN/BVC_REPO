package com.company;
import java.util.Random;

public class Passenger {
    private final int passengerId;
    private final int processingTime;
    private final int arrivalTime;
    private final int maxProcessingTime =0;
    private static int idNum =0;
    private static Random random = new Random();

    // Create a new Passenger

    public Passenger(int arrivalTime){
        this.arrivalTime = arrivalTime;
        processingTime = 1 + random.nextInt(maxProcessingTime);
        passengerId = idNum++;
    }

    // Create a passenger with specific processing time

    public Passenger(int arrivalTime,int processingTime){
        this.arrivalTime = arrivalTime;
        this.processingTime = processingTime;
        passengerId = idNum++;
    }

    // Get the arrival time

    public int getArrivalTime(){

        return arrivalTime;
    }

    // Get processing time

    public int getProcessingTime(){
        return processingTime;
    }

    // Set max processing time

    public static void setMaxProcessingTime(int maxProcessingTime){
        maxProcessingTime=maxProcessingTime;
    }

    // get max processing time

    public static int getMaxProcessingTime(){
        return maxProcessingTime;
    }

    //Passenger ID
    public int getPassengerId(){
        return passengerId;
    }

    // yeah boiiiiii

}
