using System;
using System.Data;
using System.Net;

namespace MoonPW
{
    public class GeneratePassword
    {
        public static string Gen()
        {
            PasswordGenerator.PasswordGenerator pwdGen1 = new PasswordGenerator.PasswordGenerator(32);
            string password1 = pwdGen1.Next();
            return password1;
        }
    }
}