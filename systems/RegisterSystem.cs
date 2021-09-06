using Hotel_Management_System.models;
using Hotel_Management_System.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.systems
{
    class RegisterSystem
    {
        public static void Start()
        {
            UserService userService = new UserService();

            Console.Clear();

            Console.Write("Name: ");
            string name = Console.ReadLine();


            Console.Write("Surname: ");
            string surname = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Passport Id: ");
            string passportID = Console.ReadLine();

            User user = new User(name, surname, email, surname, password, passportID);

            bool success = userService.Register(user);

            if (success)
            {
                Console.Clear();
                Console.WriteLine("Registered successfully!");
                Console.WriteLine("Press any key to login...");
                Console.ReadKey();
                LoginSystem.Start();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Unknown error occurred!");

                Console.WriteLine("\nPress any key to try again...\n");
                Console.ReadKey();
                Start();
            }
        }
    }
}
