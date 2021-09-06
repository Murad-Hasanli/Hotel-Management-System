using Hotel_Management_System.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.systems
{
    class LoginSystem
    {
        public static void Start()
        {
            UserService userService = new UserService();

            Console.Clear();

            if(Database.users.Count > 0)
            {
                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Password: ");
                string password = Console.ReadLine();


                bool success = userService.Login(email, password);

                if (success)
                {
                    Console.Clear();
                    Console.WriteLine("Logged in successfully!");
                    Console.WriteLine("Press any key to go main menu...");
                    Console.ReadKey();
                    MainMenu.Start();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong email or password!");

                    Console.WriteLine("\nPress any key to try again...\n");
                    Console.ReadKey();
                    Start();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("No user to login!");
                Console.WriteLine("\nPress any key to register...\n");
                Console.ReadKey();
            }
        }
    }
}
