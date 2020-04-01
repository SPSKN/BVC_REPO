package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here

        String s = "Scott";
        int size = ToNumber.toNumber(s);

    }
}


class ToNumber{
    public static int toNumber(String s){
        if(s== null || s.length()==0 ){
            return 0;
        }else{
            char next = s.charAt(0);
            if(Character.isDigit(next)){
                return Character.digit(next, 10) + toNumber(s.substring(1));
            }else{
                return toNumber(s.substring(1));
            }
        }

    }
}