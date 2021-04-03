using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebbshopFrontEnd.Views
{
    public static class UserView
    {
        public static WebbShopAPI api = new WebbShopAPI();

        public static void RegisterUser(string username, string password)
        {
            Console.WriteLine("Du är inte kund hos oss, var vänligen och registera dig.");
            Console.Write("Var god och angett ett användarnamn: ");
            Console.Write("Skriv lösenord igen: ");
            string pwVerify = Console.ReadLine();
            api.Register(username, password, pwVerify);
        }

        public static void UserMenu(int userId)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*    Användarmeny      *");
                Console.WriteLine("************************\n");
                Console.WriteLine("Du har följande val ");
                Console.WriteLine("[1] Lista alla kategorier");
                Console.WriteLine("[2] Söka efter kategori med sökord");
                Console.WriteLine("[3] Lista alla böcker i en kategori");
                Console.WriteLine("[4] Söka efter en bok");
                Console.WriteLine("[5] Söka efter böcker av en författare");
                Console.WriteLine("[6] Logga ut");

                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 6)
                    {
                        Console.WriteLine("Du loggar ut nu.");
                        api.LogOut(userId);
                        loop = false;
                    }
                    else { }
                }
                catch { Message.ErrorInput(); }

            }
        }
    }
}
