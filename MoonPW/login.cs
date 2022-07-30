using System;

namespace MoonPW
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Console Look
            Console.Title = "MoonPW";
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            
            // Important Variables
            const string MPW = "test";

            // Main Function shit
            var Password_Entry = Console.ReadLine();
            {
                if (Password_Entry == MPW)
                {
                    MainMenu.WriteLogo();
                    MainMenu.Menu();
                }
                else
                {
                    Console.WriteLine("Password Denied");
                }
            }
        }
    }
}