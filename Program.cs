using Hotel_Management_System.services;
using Hotel_Management_System.systems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome To Murad's Hotel");

            while (true) {
                Console.Clear();
                Console.WriteLine(
                    "1: Login\n" +
                    "2: Register\n"
                );

                Console.Write("Mode: ");
                int.TryParse(Console.ReadLine(), out int mode);

                if(mode == 1)
                {
                    LoginSystem.Start();
                    break;
                }
                else if(mode == 2)
                {
                    RegisterSystem.Start();
                    break;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong mode number!");
                    Console.WriteLine("\n\nPress any key to try again...");
                    Console.ReadKey();
                    continue;
                }
            }
        }
    }
}
