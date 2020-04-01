package com.company;

import java.util.*;

public class HomeworkTracker {
    private ArrayList<Assignment> listOfAssignments;
    private Queue<Assignment> orderOfDue;
    private int size;

    public void addAssignment(Assignment a){
        orderOfDue.add(a);
    }

}


class Assignment{
    public String name;
    public Date dateAssigned;
    public Date dateDue;

    public Assignment(String n,Date da,Date dd){
        this.name = n;
        this.dateAssigned = da;
        this.dateDue = dd;
    }
}