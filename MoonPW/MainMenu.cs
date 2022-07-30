using System;
using System.Globalization;

namespace MoonPW
{
    public class MainMenu
    {

        public static void Menu()
        {
            Console.Clear();
            WriteLogo();
            string menu = @"[1] Generate Password           Password List [2]" + Environment.NewLine + "[3] Fake IT                     Custom Password [4]";
            Console.WriteLine(menu);
            Console.WriteLine("Please input your choice: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    functions.Generate();
                    break;
                case "2":
                    functions.List();
                    break;
                case "3":
                    functions.Fake();
                    break;
                case "4":
                    functions.Custom();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
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