using System;
using System.Data;

namespace MoonPW
{
    public class GeneratePassword
    {
        
        public static string Web()
        {
            Console.WriteLine("Web-Address: ");
            string web = Console.ReadLine();
            Console.Clear();
            MainMenu.WriteLogo();

            return web;
        }
        
        public static string Username()
        {
            Console.WriteLine("Username: ");
            string user = Console.ReadLine();
            Console.Clear();
            MainMenu.WriteLogo();

            return user;
        }
        
        public static string Gen()
        {
            Console.Clear();
            MainMenu.WriteLogo();
            PasswordGenerator.PasswordGenerator pwdGen1 = new PasswordGenerator.PasswordGenerator(32);
            string password1 = pwdGen1.Next(); ;
            return password1;
        }
    }
}