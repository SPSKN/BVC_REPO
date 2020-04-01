package com.company;

import java.math.BigInteger;

/**
 * name, social security number, age, gender, address, and telephone number
 */
public class Student extends Person {
    /**
     *  A student has a grade-point average
     * (GPA), major, and year of graduation.
     * Constructor
     * @param n
     * @param s
     * @param a
     * @param g
     * @param b
     * @param p
     */

    private double gpa;
    private String major;
    private int yearOfGrad;
    public Student(String n, int s, int a, char g, String b, String p)
    {
        this.name = n;
        this.sin = s;
        this.age = a;
        this.gender = g;
        this.address = b;
        this.phoneNumber = p;

    }


    public void pickMajor(String s){
        this.major = s;
    }

    public void pickGrad(int y){
        this.yearOfGrad = y;
    }






}
