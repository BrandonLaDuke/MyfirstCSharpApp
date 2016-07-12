using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialze Varribles
            String userName = "";
            String emailAddress = "";
            String phoneNumber = "";
<<<<<<< HEAD
            String age = "";
            Boolean confirm = false;
=======
            int age = 0;
            boolean confirm = false; //Set boolean to confirm.
>>>>>>> origin/master

            Console.WriteLine("Hello World!");
            // Ask for users name
            Console.WriteLine("What's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ", it's nice to meet you!");
            // Ask for users age
            Console.WriteLine("How old are you " + userName + "?");
            age = Console.ReadLine();
            // Ask for users phone number
            Console.WriteLine("What is your Phone Number?");
            phoneNumber = Console.ReadLine();
            // Ask for users email
            Console.WriteLine("What is your eamil address?");
            emailAddress = Console.ReadLine();
            // Confirm We got it correct
            //Console.WriteLine("\nSo your " + userName + " and you are " + age + " years old. \nYour email address is: " + emailAddress + "\nand your phone number is: " + phoneNumber + ". Correct? \n\n(Y) Yes, (N) No");
            
            // Create String Array called lines
            string[] lines = { "Name: " + userName + ",", "Age: " + age + ",", "Phone Number: " + phoneNumber + ",", "Email: " + emailAddress };
            // Write to File
            System.IO.File.WriteAllLines(@"C:\Users\bladuk8617\Documents\Visual Studio 2012\Projects\MyfirstCSharpApp\WriteLines.txt", lines);
            // Tell user that their file has been created
            Console.WriteLine(userName + ", your info has been saved to WriteLines.txt\n\nPress Enter to Quit");
            Console.ReadLine();
        }
    }
}
