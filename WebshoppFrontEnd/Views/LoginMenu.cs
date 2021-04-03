using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views
{
    public static class LoginMenu
    {
        public static void ShowLogInMenu()
        {
            Console.Clear();
            Console.WriteLine("********************");
            Console.WriteLine("*     Inloggning   *");
            Console.WriteLine("********************\n");
            Console.Write("Ditt användarnamn: ");
            var username = Console.ReadLine();
            Console.Write("Ditt lösenord: ");
            var password = Console.ReadLine();

        }
    }
}
