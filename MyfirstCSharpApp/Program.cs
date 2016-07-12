using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyfirstCSharpApp
{
    public class User
    {
        // Initialze Varribles as user_object.
        public String userName = "";
        public String emailAddress = "";
        public String phoneNumber = "";
        public String age = "";
    }

    class Program
    {
        static void Main(string[] args)
        {
            User user_object = new User();

            // Initialze Varribles
            //String userName = "";
            //String emailAddress = "";
            //String phoneNumber = "";
            //String age = "";
            //Boolean confirm = false;

            Console.WriteLine("Hello World!");
            // Ask for users name
            Console.WriteLine("What's your name?");
            user_object.userName = Console.ReadLine();
            Console.WriteLine("Hello " + user_object.userName + ", it's nice to meet you!");
            // Ask for users age
            Console.WriteLine("How old are you " + user_object.userName + "?");
            user_object.age = Console.ReadLine();
            // Ask for users phone number
            Console.WriteLine("What is your Phone Number?");
            user_object.phoneNumber = Console.ReadLine();
            // Ask for users email
            Console.WriteLine("What is your eamil address?");
            user_object.emailAddress = Console.ReadLine();
            // Confirm We got it correct
            Console.WriteLine("\nSo your " + user_object.userName + " and you are " + user_object.age + " years old. \nYour email address is: " + user_object.emailAddress + "\nand your phone number is: " + user_object.phoneNumber + ". Correct? \n\n(Y) Yes, (N) No");
            
            // Create String Array called lines
            string[] lines = { "Name: " + user_object.userName + ",", "Age: " + user_object.age + ",", "Phone Number: " + user_object.phoneNumber + ",", "Email: " + user_object.emailAddress };
            
            // Write to File
            //System.IO.File.WriteAllLines(@"C:\Users\bladuk8617\Documents\Visual Studio 2012\Projects\MyfirstCSharpApp\WriteLines.txt", lines);
            
            // Tell user that their file has been created
            Console.WriteLine(user_object.userName + ", your info has been saved to WriteLines.txt\n\nPress any key to Quit");
            Console.ReadKey();
        }
    }
}
