package com.company;
public class Main {

    public static void main(String[] args) {

        /**
         * Factory method to create a game using the .cyoa format.
         *
         * Note: This method MUST remain static! Implement a separate constructor method of your own design.
         *
         * @param fileName: The name of a file located in the root program directory
         *                  that contains the CYOA adventure in the .cyoa format.
         **/
        public static CYOAGame createGame(String fileName)

/**
 * Return the title of the current node.
 **/
        public String getTitle()

/**
 * Return the description of the current node
 *
 * @return
 */
        public String getDescription()

/**
 * Return the description of one action for the current node. E.g. "Swim through the river"
 * Return null if that action does not exist.
 *
 * @param choice the choice direction in the binary tree
 **/
        public String getOptionDescription(ChoiceType choice)

/**
 * Choose an option of the current node and move through the story.
 *
 * @param option: The option that the user chooses
 **/
        public void chooseOption(ChoiceType option)

/**
 * Find and return the depth of a given node title. You may assume that the title is
 * unique.
 *
 * @param title title of the story node to find
 * @return depth of the node with a given title, or -1 if the node does not exist
 **/
        public int getDepth(String title)

/**
 * Returns the titles of each node in the CYOAGame, separated by spaces, using an
 * in-order traversal of the root node.
 *
 * @return a String of each title, separated by spaces, of an in-order traversal of
 * the book.
 **/
        public String getInOrderTitles()

                
    }
}

class Node{

    private String title;
    private String description;
    private Node nRight;
    private Node nLeft;


}
