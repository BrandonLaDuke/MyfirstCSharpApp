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
            String userName = "";
            String emailAddress = "";
            String phoneNumber = "";
            int age = 0;
            Char confirm = 'x';

            Console.WriteLine("Hello World!");
            Console.WriteLine("What's your name?");
            userName = Console.ReadLine();
            Console.WriteLine("Hello " + userName + ", it's nice to meet you!");
            Console.WriteLine("How old are you " + userName + "?");
            age = Console.Read();
            Console.ReadLine();
            Console.WriteLine("What is your Phone Number?");
            phoneNumber = Console.ReadLine();
            Console.WriteLine("What is your eamil address?");
            emailAddress = Console.ReadLine();
            Console.WriteLine("\nSo your " + userName + " and you are " + age + " years old. \nYour email address is: " + emailAddress + "\nand your phone number is: " + phoneNumber + ". Correct? \n\n(Y) Yes, (N) No");
            Console.Read();
        }
    }
}
