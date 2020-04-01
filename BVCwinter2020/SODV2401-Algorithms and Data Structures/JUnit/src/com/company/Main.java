package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here
         int[] x = {5,12,15,4,8,12,7};


findLargestTest(x,99);


    }
   /* @Test
   first element
   last element
   somewhere in the middle

    */
    public static int findLargestTest(int[] c, int target){
        int index =0;
        int lIndex = c.length-1;
        int mIndex = c.length/2;

        if(c[index]==target)// element 0
        {
            return index;
        } else if(c[lIndex]==target)// last element
        {
            return lIndex;
        } else if(c[mIndex]==target)// somewhere in the middle
        {
            return mIndex;
        }else {
            return -1;
        }
    }
}
