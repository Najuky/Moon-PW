using System;
using System.Globalization;

namespace MoonPW
{
    public class MainMenu
    {

        public static void Menu()
        {
            while (true)
            {
            Console.Clear();
            WriteLogo();
            string menu = @"[1] Generate Password           Password List [2]" + Environment.NewLine + "[3] Fake IT                     Custom Password [4]";
            Console.WriteLine(menu);
            Console.WriteLine("Please input your choice: ");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                WriteLogo();
                Console.WriteLine("Web Address: ");
                string web = Console.ReadLine();
                Console.Clear();
                WriteLogo();
                
                Console.WriteLine("User: ");
                string user = Console.ReadLine();
                Console.Clear();
                WriteLogo();
                
                Console.WriteLine("Web-Address: " + web);
                Console.WriteLine("User: " + user);
                Console.WriteLine("Password: " + GeneratePassword.Gen());
                Console.ReadKey();
            }
            else if (option == "2")
            {
                functions.List();
            }
            else if (option == "3")
            {
                functions.Fake();
            }
            else if (option == "4")
            {
                functions.Custom();
            }
            else
            {
                Console.WriteLine("Invalid input, please try again.");
                Console.ReadLine();
                WriteLogo();
                Menu();
            }
            }
        }

            public static void WriteLogo()
        {
            string title = @"
███╗   ███╗ ██████╗  ██████╗ ███╗   ██╗
████╗ ████║██╔═══██╗██╔═══██╗████╗  ██║
██╔████╔██║██║   ██║██║   ██║██╔██╗ ██║
██║╚██╔╝██║██║   ██║██║   ██║██║╚██╗██║
██║ ╚═╝ ██║╚██████╔╝╚██████╔╝██║ ╚████║
╚═╝     ╚═╝ ╚═════╝  ╚═════╝ ╚═╝  ╚═══╝
";
            Console.WriteLine(title);
            
        }
    }
}