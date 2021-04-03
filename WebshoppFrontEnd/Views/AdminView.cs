using Inlämning2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("DU har följande val");
                Console.WriteLine("[1]  Lägg till en bok");
                Console.WriteLine("[2]  Lägg till antal böcker i lagret.");
                Console.WriteLine("[3]  Uppdatera information om en bok.");
                Console.WriteLine("[4]  Ta bort en bok.");
                Console.WriteLine("[5]  Lägg till en kategori.");
                Console.WriteLine("[6]  Lägg till kategori på en bok.");
                Console.WriteLine("[7]  Uppdatera kategori.");
                Console.WriteLine("[8]  Ta bort en kategori utan böcker.");
                Console.WriteLine("[9]  Lista alla användare.");
                Console.WriteLine("[10] Söka en användare.");
                Console.WriteLine("[11] Lägg till en användare.");
                Console.WriteLine("[12] Logga ut.");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    if (input == 12)
                    {
                        Console.WriteLine("Du loggar ut nu.");
                        api.LogOut(adminId);
                        loop = false;
                    }
                    else { }
                }
                catch { Message.ErrorInput(); }
            }
        }
    }
}
