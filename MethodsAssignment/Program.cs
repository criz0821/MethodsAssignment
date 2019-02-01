/*
    Author: Christopher Mejia
    Date: 1/31/19
    Comments: This assignment demonstrates the use of a method
    On another note... enter my name (Chris Mejia) into the console :)
 */
using System;

namespace MethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you full name");
            string userInput = Console.ReadLine();
                    
            try
            {
                //calling custom method
                Hello(userInput);
                Console.ReadKey(true);
            }// end of try

            catch
            {
                Console.WriteLine("Sorry an error occured");
                Console.ReadKey(true);
            }// end of catch
        }// end of main

        private static void Hello(string name)
        {
            if (name == "Chris Mejia")
            {
                Console.WriteLine("Hello father, thanks for creating me!");
            }// end of if statement

            else
            {
                Console.WriteLine("Hello " + name + "! I hope your day is going well.");
            }// end of else statement
        }// end of custom method Hello

    }// end of class
}// end of namespace
