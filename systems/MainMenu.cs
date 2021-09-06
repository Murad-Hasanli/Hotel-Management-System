using Hotel_Management_System.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System.systems
{
    class MainMenu
    {
        public static void Start()
        {
            while(true)
            {
                Console.Clear();
                
                Console.WriteLine(
                "1: List Users"
            );

                Console.Write("enter mode: ");
                int.TryParse(Console.ReadLine(), out int mode);

                if (mode == 1)
                {
                    foreach(User user in Database.users)
                    {
                        Console.WriteLine($"{user.Name} {user.Surname}");
                    }

                    Console.WriteLine("\n\nPress any key to go back main menu...");
                    Console.ReadKey();
                    MainMenu.Start();
                }
                else
                {
                    Console.WriteLine("Wrong mode number!");
                    continue;
                }
            }
        }
    }
}
