using Inlämning2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views
{
    public static class LoginMenu
    {
        public static (string, string) ShowLogInMenu()
        {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("*     Inloggning   *");
            Console.WriteLine("********************\n");
            Console.Write("Ditt användarnamn: ");
            string username = Console.ReadLine();
            Console.Write("Ditt lösenord: ");
            string password = Console.ReadLine();
            var user = (username, password);
            return user;
        }
    }
}
