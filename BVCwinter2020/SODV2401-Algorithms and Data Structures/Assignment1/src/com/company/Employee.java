package com.company;

import java.util.*;
import java.math.BigInteger;

/**
 * name, social security number, age, gender, address, and telephone number
 */
public class Employee extends Person {
    /**
     * Constructor
     *
     * @param n
     * @param s
     * @param a
     * @param g
     * @param b
     * @param p
     */
    public Employee(String n, int s, int a, char g, String b, String p) {

        this.name = n;
        this.sin = s;
        this.age = a;
        this.gender = g;
        this.address = b;
        this.phoneNumber = p;


    }

    /**
     * An employee has a department, job title, and year of hire.
     * In addition, there are hourly employees (hourly rate, hours worked, and union dues)
     * and salaried
     * employees (annual salary)
     */
    private String department;
    private String jobTitle;
    private int yearOfHire;
    private boolean hourlyWorker;
    private double wage;
    private double hoursWork;
    private double salary;


    public void addToDepartment() {
        Scanner in = new Scanner(System.in);
        System.out.println("Which deparment? manager,retail,sales ");
        while (in.toString() != "exit") {
            System.out.println("");
            switch (in.toString()) {
                case "manager":
                    this.department = "manager";
                    break;
                case "retail":
                    this.department = "retail";
                    break;
                case "sales":
                    this.department = "sales";
                    break;
                default:
                    System.out.println("Press return to quit  ");
                    break;
            }
        }

    }

    public void quitDepartment() {
        this.department = "";
        this.hourlyWorker = false;
        this.hoursWork = 0.0;
        this.jobTitle = "";
        this.salary = 0.0;
        this.wage = 0.0;

    }

    public void changeDepartment() {
        Scanner in = new Scanner(System.in);
        System.out.println("What the new Department? ");
        switch (in.toString()) {
            case "manager":
                this.department = "manager";
                break;
            case "retail":
                this.department = "retail";
                break;
            case "sales":
                this.department = "sales";
                break;
            default:
                System.out.println("Press return to quit  ");

        }

    }
}