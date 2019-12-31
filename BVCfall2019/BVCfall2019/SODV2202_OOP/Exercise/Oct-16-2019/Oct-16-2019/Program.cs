using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oct_16_2019
{
    class Program
    {

        
        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            while(userInput != "exit")
            {
                Hashtable PhoneList = new Hashtable();
                userInput = Console.ReadLine();
                if (userInput.StartsWith("add"))
                {
                   string theInput = userInput.Substring(4);
                   string pNumber= "";
                   string contact = "";
                    foreach(char c in theInput)
                    {
                        if(Char.IsDigit(c) != false ) // if c is a Char
                        {
                            contact.Append(c);
                        }
                        else
                        {
                            pNumber.Append(c);
                        }
                        Console.WriteLine("Contact Name: " + contact);

                        Console.WriteLine("Phone Number: " + pNumber);
                    }
                    Console.WriteLine("Contact Name: " + contact);
                    
                   Console.WriteLine("Phone Number: " + pNumber);
                   PhoneList.Add(contact, pNumber);
                    
                }
                else if(userInput.StartsWith("find"))
                {

                }
                else
                {
                    
                    
                }

            }

        }
    }
}
