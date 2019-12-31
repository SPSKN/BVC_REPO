using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_1___Calculator
{
    class Program
    {
        

        public class Calculator
        {
            string equ = ""; // this will hold all my number and stuff
            //double answer;
            public void getAnswer() // get the console line and parse into string.
            {
                equ = Console.ReadLine();                
                //this.equ = Console.ReadLine();
               
                int counter = 0;
                bool left = true;
           

                EquBranch nodeBranch = new EquBranch();
                nodeBranch.A = "";
                nodeBranch.B = "";
                foreach (char c in equ )
                {
                    if(Char.IsDigit(c)==true) // checks c if is a digit
                    {
                        c.ToString();
                        if (left == true)
                        {
                            
                           // Console.WriteLine(c + " Number in Index: " + counter); // it is a digit     
                            //push to Left
                            //Console.WriteLine(left);
                            nodeBranch.A =nodeBranch.A + c;
                            //Console.WriteLine(aLeft);
                        }
                        else
                        {
                           
                            //push to right
                            //Console.WriteLine(c + " Number in Index: " + counter); // it is a digit
                            //Console.WriteLine(left);
                            nodeBranch.B = nodeBranch.B + c;
                            // Console.WriteLine(bLeft);
                        }
                    }
                    else
                    {
                        left = false;
                        // it is a operator
                        switch (c)
                        {   
                            case '/': nodeBranch.Oper = "/"; break;
                            case '*': nodeBranch.Oper = "*"; break;
                            case '+': nodeBranch.Oper = "+"; break;
                            case '-': nodeBranch.Oper = "-"; break;
                            default:Console.WriteLine("Brackets"+ counter); break;
                        }                       
                    }
                    counter++;   // counter or index number
                    nodeBranch.ShowMe();
                    nodeBranch.nodeAnswer();
                }                
            }
        }
        public class EquBranch // for each Branch in the Equation, (x+y) or /,*,-,+
        {
            public string A;
            public string B;
            public string Oper;
            public void ShowMe()
            {
                Console.WriteLine(this.A);
                Console.WriteLine(this.B);
                Console.WriteLine(this.Oper);
            }
            public void nodeAnswer()
            {
                /*
                 * This takes the left side and the right side of the operators
                 * Parse the value
                 * Will return the nodeAnswer
                 
                   */
                //string A = a.ToString();
                //string B = b.ToString();
                double leftSide = Double.Parse(this.A);
                double rightSide = Double.Parse(this.B); //this is not working for some reason...
                string oper = this.Oper;
                switch (oper)
                {
                    case "*": Console.WriteLine(leftSide * rightSide); break;
                    case "/": Console.WriteLine(leftSide / rightSide); break;
                    case "+": Console.WriteLine(leftSide + rightSide); break;
                    case "-": Console.WriteLine(leftSide - rightSide); break;
                    default: break;
                        //return answer;
                }            
                
            }
        }
        /*
         * Scott Patterson
         * 2019 - Sept - 30
         * 
         * 
            Your program should be able to:
            1.	Handle addition, subtraction, multiplication, and division.
            2.	Evaluate expressions with a single operation (ie: 1+2).
            3.	Evaluate larger expressions with multiple operations (ie: 1*2-3+4).
            4.	Perform operations in the correct order of operations (ie 2+3*4 is 14 not20).
            5.	Ignore whitespace in the expression.
            6.	Handle negative numbers.
            7.	Handle numbers with a decimal.
            8.	Handle brackets (ie: (2+3)*4 is 20).
            9.	Handle nested brackets.
         * 
         * */
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator ON");
            bool calON = true;
            while (calON == true)
            { 
                Calculator C1 = new Calculator();
                C1.getAnswer();
                
                
            }
        }
    }
}
