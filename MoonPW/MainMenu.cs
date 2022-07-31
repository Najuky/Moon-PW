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
                GeneratePassword.Gen();
                Console.WriteLine("Web-Address: " + GeneratePassword.Web());
                Console.WriteLine("Username: " + GeneratePassword.Username());
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