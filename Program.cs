using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WhiteBoardAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.  Declare and initialize variables. One of type int, one of type string, and one of type DateTime.
            int firstNumber = 5;
            string firstname = "Peyton";
            DateTime today = DateTime.Now;


            //2. Create a method that subtracts two numbers and returns the value.
            Subtract number = new Subtract();
            number.NumOne = 10;
            number.NumTwo = 2;

            Console.WriteLine(number.FindProduct());



            //3. Create a method that takes two strings from the user and outputs a string.
            Person person = new Person();
            person.FirstName = "Peyton";
            person.LastName = "Cooper";

            Console.WriteLine(person.GetFullName());


            //4. Write a switch case that asks the user if they are wearing clothes.
            Console.WriteLine("Are you wearing any clothes, Yes or No?");
            string answer = (Console.ReadLine());
            switch (answer)
            {
                case "Yes":
                    {
                        Console.WriteLine("Good, I am happy to hear that.");
                        break;
                    }
                case "No":
                    {
                        Console.WriteLine("Oh... maybe you should put some on.");
                        break;
                    }
                    Console.ReadLine();
            }


            //5. Write an if else statement that uses a boolean to check if the user is happy. You can start off with something like: bool happy = true;
            bool happy = true;
            Console.WriteLine("Are you happy?");
            string glad = Console.ReadLine();
            if (glad == "yes")
            {
                happy = true;
            }
            else if (glad == "no")
            {
                happy = false;
            }
            Console.WriteLine(happy == true ? "Yay!" : "Sorry, how can I help?");




            //6. Write an if, else if, else that asks the user how much 
            //money they make a year. Check ranges between 1,000-10,000,  
            //11,000-50,000, and 51,000-100,000. Output to the test runner based 
            //on each salary range. Have a else statement to prepare for the 
            //user not giving their salary range or out of the ranges we are checking.

            Console.WriteLine("How much money do you make in a year?");
            string moneyInput = Console.ReadLine();
            int salary = int.Parse(moneyInput);

            if (salary <= 10000 && salary >= 1000)
            {
                Console.WriteLine("Cool");
            }
            else if (salary <= 50000 && salary >= 11000)
            {
                Console.WriteLine("Nice");
            }
            else if (salary <= 100000 && salary >= 51000)
            {
                Console.WriteLine("Wow!");
            }
            else
            {
                Console.WriteLine("Sorry, I'm not sure what you mean.");
            }













        }
    }
}
