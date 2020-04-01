package com.company;
import java.util.Scanner;


public class Main {

    public static void main(String[] args) {
	// write your code here

        Scanner in = new Scanner(System.in);
        System.out.println("Enter a number for the base:  ");
        double number = in.nextDouble();
        int x = in.nextInt();
        System.out.println(power(number,x));

//System.out.println(fact(5));

    }

    /**
     *
     * @param y a number
     * @param n the power of
     * @return y^n
     */
    private static double power(double y, int n)
    {
        double z;
        if(n == 0)
        {
            return 1.0;
        }else {
            z = power(y, n / 2);
            z = z*z;
            if(n%2==0)
                return z;
            return y *z;
        }
    }


    /**
     *
     * @param n
     * @return
     */
    public static int fact(int n){
       /*
        if(n==0)
        {
            return 1;
        }else{
            return n * fact(n-1);
        }
        */
       int sum =1;
      for(int i = 1;i < n;i++){
           sum = n * sum;

      }
      return sum;

    }








}
