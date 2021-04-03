using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning2;
using System;

namespace WebbshopFrontEnd.Views.Admin
{
    public static class AdminUserMenu
    {
        public static WebbShopAPI api = new WebbShopAPI();

        /// <summary>
        /// Vyn för hantering av användare.
        /// </summary>
        /// <param name="adminId"></param>
        public static void ShowUserMenu(int adminId)
        {
            bool loop = true;
            while (loop)
            {
                Console.WriteLine("************************");
                Console.WriteLine("*   Adminstratörsmeny  *");
                Console.WriteLine("************************\n");
                Console.WriteLine("Du har följande val");
                Console.WriteLine("[1]  Lista alla användare");
                Console.WriteLine("[2]  Söka efter en användare");
                Console.WriteLine("[3]  Lägga till en användare");
                Console.WriteLine("[4]  Tillbaka till adminstratörmenyn.");
            }
        }
    }
}
