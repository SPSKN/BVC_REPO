package com.company;

public class Main {

    public static void main(String[] args) {
	// write your code here

        public int countNode(Node root){

            //base case
            if(root==null)
                return 0;

            //recursive call to left child and right child and
            // add the result of these with 1 ( 1 for counting the root)
            return 1 + countNode(root.left) + countNode(root.right);
        }
    }
}
