package com.company;
import java.util.*;
public class Fibi {
    private static final List<Long> fibValues = new ArrayList<>();

    static {
        fibValues.add(0L);
        fibValues.add(1L);
    }
    public static long fibo(int n){
        if(n<0){
            throw new IllegalArgumentException(n + " <= 0 for Fibonacci");
        }
        if(n <= fibValues.size()-1){
            return  fibValues.get(n);
        }
        int i = fibValues.size();
        long fibim1 = fibValues.get(i-1);
        long fibim2 = fibValues.get(i-2);
        long fibi =0;
        while(i<=n){
            fibi = fibim1 + fibim2;
            fibValues.add(fibi);
            i++;
            fibim2 = fibim1;
            fibim1 = fibi;
        }
        return fibi;


    }

    public static void main(String[] args){
        Scanner in = new Scanner(System.in);
        System.out.println("Enter a number: ");
        while(in.hasNextInt()){
            int n = in.nextInt();
            System.out.println("Fib ("+n+")"+fibo(n));
            System.out.println("");
            System.out.println("Enter a number: ");


        }
    }


    /**
     *
     */


}
