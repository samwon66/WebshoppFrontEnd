using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebbshopFrontEnd.Controllers.AdminControllers;

namespace WebbshopFrontEnd.Views
{
    public static class AdminViews
    {
        public static WebbShopAPI api = new WebbShopAPI();

        public static void AdminMenu(int adminId)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*   Adminstratörsmeny  *");
                Console.WriteLine("************************\n");
                Console.WriteLine("Du har följande val");
                Console.WriteLine("[1]  Hantera böcker");
                Console.WriteLine("[2]  Hantera kategorier");
                Console.WriteLine("[3]  Hantera användare");
                Console.WriteLine("[4]  Logga ut");
                
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    if (choice == 4)
                    {
                        Console.WriteLine("Du loggar ut nu.");
                        api.LogOut(adminId);
                        loop = false;
                    }
                    else { AdminChoiceController.AdminMenuChoice(adminId, choice); }
                }
                catch { Message.ErrorInput();}
            }
        }
    }
}
