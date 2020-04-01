package com.company;

import java.util.Scanner;

public class FibRecur {
    private static int fibonacci(int n){
        if(n == 1 || n == 2){
            return 1;
        }
        return fibonacci(n-1) + fibonacci(n-2);
    }
    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        System.out.println("Enter a number: ");
        int input = in.nextInt();
        for(int i = 1;i<= input;i++){
            System.out.println("The fibonacci is : " + fibonacci(i));
        }

    }


}
